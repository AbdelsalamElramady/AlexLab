using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraScheduler;
using System.Data.SqlClient;

namespace AlexLab
{
    public partial class MainForm : RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            InitSkinGallery();
            schedulerControl.Start = System.DateTime.Now;

            AlexLabBL.MainClass.ConectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AlexLab.Properties.Settings.AlexLabConnectionString"].ConnectionString;

            if (!AlexLabBL.MainClass.putPaymentTypes())
            {
                MessageBox.Show("لم يتم اضافة انواع المدفوعات");
            }

        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alexLabDataSet.Resources' table. You can move, or remove it, as needed.
            this.resourcesTableAdapter.Fill(this.alexLabDataSet.Resources);
            // TODO: This line of code loads data into the 'alexLabDataSet.Appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.alexLabDataSet.Appointments);

            lookUpRoom.Properties.DataSource = AlexLabBL.MainClass.getRooms();
            lookUpClient.Properties.DataSource = AlexLabBL.MainClass.getClients();
            lookUpCourse.Properties.DataSource = AlexLabBL.MainClass.getCourses();
        }

        public static void MessageSecuseed()
        {
            MessageBox.Show("تم الحفظ بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void MessageError()
        {
            MessageBox.Show("لم يتم الحفظ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void MessageErrorSafe()
        {
            MessageBox.Show("من فضلك افتح الخزنه اولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void schedulerStorage_AppointmentsChanged(object sender, DevExpress.XtraScheduler.PersistentObjectsEventArgs e)
        {
            appointmentsTableAdapter.Update(alexLabDataSet);
            alexLabDataSet.AcceptChanges();
        }

        private void inboxItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            new RoomsForm().ShowDialog();
            lookUpRoom.Properties.DataSource = AlexLabBL.MainClass.getRooms();
        }

        private void schedulerControl_EditAppointmentFormShowing(object sender, DevExpress.XtraScheduler.AppointmentFormEventArgs e)
        {
            CustomAppointmentForm form = new CustomAppointmentForm(sender as SchedulerControl, e.Appointment, e.OpenRecurrenceForm);
            try
            {
                e.DialogResult = form.ShowDialog();
                e.Handled = true;
            }
            finally
            {
                form.Dispose();
            }
            lookUpCourse.Properties.DataSource = AlexLabBL.MainClass.getCourses();
        }

        private void outboxItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            new ClientForm().ShowDialog();
            lookUpClient.Properties.DataSource = AlexLabBL.MainClass.getClients();
        }

        private void draftsItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            new CourseTypeForm().ShowDialog();
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            new CourseStudentForm().ShowDialog();
        }

        private void calendarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            new SafeForm().ShowDialog();
        }

        private void tasksItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            new ExpencesTypeForm().ShowDialog();
        }

        private void navBarControl_Click(object sender, EventArgs e)
        {
            
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            new ExpencesForm().ShowDialog();
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            new PaymentForm().ShowDialog();
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            new ClientWorkSpaceForm().ShowDialog();
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            new WorkSpaceForm().ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            lookUpRoom.EditValue = null;
            lookUpCourse.EditValue = null;
            lookUpClient.EditValue = null;
            appointmentsTableAdapter.Fill(alexLabDataSet.Appointments);
        }

        private void lookUpRoom_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpClient.EditValue == null && lookUpCourse.EditValue == null)
            {
                appointmentsTableAdapter.FillBy(alexLabDataSet.Appointments, Convert.ToInt32(lookUpRoom.EditValue), null, null);
            }
            else if(lookUpCourse.EditValue != null && lookUpClient.EditValue == null)
            {
                appointmentsTableAdapter.FillBy(alexLabDataSet.Appointments, Convert.ToInt32(lookUpRoom.EditValue), null, Convert.ToInt32(lookUpCourse.EditValue));
            }
            else if (lookUpCourse.EditValue == null && lookUpClient.EditValue != null)
            {
                appointmentsTableAdapter.FillBy(alexLabDataSet.Appointments, Convert.ToInt32(lookUpRoom.EditValue), Convert.ToInt32(lookUpClient.EditValue), null);
            }
            else
            {
                appointmentsTableAdapter.FillBy(alexLabDataSet.Appointments, Convert.ToInt32(lookUpRoom.EditValue), Convert.ToInt32(lookUpClient.EditValue), Convert.ToInt32(lookUpCourse.EditValue));
            }
        }

        private void lookUpClient_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpCourse.EditValue == null && lookUpRoom.EditValue == null)
            {
                appointmentsTableAdapter.FillBy(alexLabDataSet.Appointments, null, Convert.ToInt32(lookUpClient.EditValue), null);
            }
            else if (lookUpCourse.EditValue == null && lookUpRoom.EditValue != null)
            {
                appointmentsTableAdapter.FillBy(alexLabDataSet.Appointments, Convert.ToInt32(lookUpRoom.EditValue), Convert.ToInt32(lookUpClient.EditValue), null);
            }
            else if (lookUpCourse.EditValue != null && lookUpRoom.EditValue == null)
            {
                appointmentsTableAdapter.FillBy(alexLabDataSet.Appointments, null, Convert.ToInt32(lookUpClient.EditValue), Convert.ToInt32(lookUpCourse.EditValue));
            }
            else
            {
                appointmentsTableAdapter.FillBy(alexLabDataSet.Appointments, Convert.ToInt32(lookUpRoom.EditValue), Convert.ToInt32(lookUpClient.EditValue), Convert.ToInt32(lookUpCourse.EditValue));
            }
        }

        private void lookUpCourse_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpClient.EditValue == null && lookUpRoom.EditValue == null)
            {
                appointmentsTableAdapter.FillBy(alexLabDataSet.Appointments, null, null, Convert.ToInt32(lookUpCourse.EditValue));
            }
            else if (lookUpClient.EditValue == null && lookUpRoom.EditValue != null)
            {
                appointmentsTableAdapter.FillBy(alexLabDataSet.Appointments, Convert.ToInt32(lookUpRoom.EditValue), null, Convert.ToInt32(lookUpCourse.EditValue));
            }
            else if (lookUpClient.EditValue == null && lookUpRoom.EditValue != null)
            {
                appointmentsTableAdapter.FillBy(alexLabDataSet.Appointments, null, Convert.ToInt32(lookUpClient.EditValue), Convert.ToInt32(lookUpCourse.EditValue));
            }
            else
            {
                appointmentsTableAdapter.FillBy(alexLabDataSet.Appointments, Convert.ToInt32(lookUpRoom.EditValue), Convert.ToInt32(lookUpClient.EditValue), Convert.ToInt32(lookUpCourse.EditValue));
            }
        }

        private void schedulerControl_StorageChanged(object sender, EventArgs e)
        {
            lookUpCourse.Properties.DataSource = AlexLabBL.MainClass.getCourses();
        }

        private void schedulerControl_AllowAppointmentDelete(object sender, AppointmentOperationEventArgs e)
        {
            
        }

        private void schedulerControl_AppointmentDrop(object sender, AppointmentDragEventArgs e)
        {
            
        }

        private void schedulerControl_DeleteRecurrentAppointmentFormShowing(object sender, DeleteRecurrentAppointmentFormEventArgs e)
        {
            
        }
        
        SqlConnection con;
        SqlCommand cmd;

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            con = new SqlConnection(AlexLabBL.MainClass.ConectionString);
            try
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                               string query = "BACKUP DATABASE AlexLab TO DISK = '" 
                               + folderBrowserDialog1.SelectedPath + "\\AlexLabDatabase" 
                               + "(" + DateTime.Now.ToShortDateString().Replace('/', '-') + ")"
                               + "(" + DateTime.Now.ToShortTimeString().Replace(':', '-') + ")" + ".bak'";

                    cmd = new SqlCommand(query, con);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                
                    MessageBox.Show("تم الحفظ");
                }
            }
            catch
            {
                MessageBox.Show("المسار الذى ادخلته خطأ او ان الملف موجود مسبقا");
            }
        }

        private void schedulerControl_ControlRemoved(object sender, ControlEventArgs e)
        {
            
        }

        private void schedulerStorage_AppointmentDeleting_1(object sender, PersistentObjectCancelEventArgs e)
        {
            DialogResult result = MessageBox.Show("هل انت متاكد من الغاء الكورس", "الغاء الكورس", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}