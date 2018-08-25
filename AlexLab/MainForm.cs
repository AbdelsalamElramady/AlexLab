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
        }

        private void outboxItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            new ClientForm().ShowDialog();
        }

        private void draftsItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            new CourseTypeForm().ShowDialog();
        }

        private void trashItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            new CourseForm().ShowDialog();
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
    }
}