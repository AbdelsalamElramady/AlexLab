using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace AlexLab
{
    public partial class CoursePaymentForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        AlexLabBL.PaymentClass courseObj;
        AlexLabBL.SafeClass safeObj;

        bool isEdit = false;

        bool isSingleAppointment = false;
        int appointmentID;

        public CoursePaymentForm()
        {
            InitializeComponent();

            courseObj = new AlexLabBL.PaymentClass();
            safeObj = new AlexLabBL.SafeClass();

            lookUpCourse.Properties.DataSource = AlexLabBL.MainClass.getCourses();
            lookUpPaymentType.Properties.DataSource = AlexLabBL.MainClass.getPaymentType();
            lookUpPaymentType.EditValue = 1;

            gridControl1.DataSource = AlexLabBL.MainClass.getPaymentByCourse();
        }

        public CoursePaymentForm(int appointmentId)
        {
            InitializeComponent();

            courseObj = new AlexLabBL.PaymentClass();
            safeObj = new AlexLabBL.SafeClass();

            lookUpCourse.Properties.DataSource = AlexLabBL.MainClass.getCourses();
            lookUpPaymentType.Properties.DataSource = AlexLabBL.MainClass.getPaymentType();
            lookUpPaymentType.EditValue = 1;
            lookUpCourse.EditValue = appointmentId;

            lookUpCourse.Enabled = false;
            isSingleAppointment = true;
            appointmentID = appointmentId;
            CustomAppointmentForm.PaidMoney = 0;

            gridControl1.DataSource = AlexLabBL.MainClass.getPaymentByCourse(appointmentId);
        }

        private void CoursePaymentForm_Load(object sender, EventArgs e)
        {
            
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            TxtValue.Value = 0;
            TxtNotes.Text = string.Empty;

            isEdit = false;
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                courseObj.AppointmentId = appointmentID;
                courseObj.PaymentTypeId = Convert.ToInt32(lookUpPaymentType.EditValue);
                courseObj.PaymentDate = DateTime.Now;
                courseObj.ClientWorkSpaceId = null;
                courseObj.PaymentValue = TxtValue.Value;
                courseObj.Notes = TxtNotes.Text;

                safeObj.CurrentValue = TxtValue.Value;

                if (!AlexLabBL.MainClass.CheckSafeIsClose())
                {

                    if (courseObj.Save(isEdit))
                    {
                        safeObj.Save(false);
                        CustomAppointmentForm.PaidMoney += TxtValue.Value;
                        MainForm.MessageSecuseed();
                    }
                    else
                    {
                        MainForm.MessageError();
                    }
                }
                else
                {
                    MainForm.MessageErrorSafe();
                }

                if (isSingleAppointment)
                {
                    gridControl1.DataSource = AlexLabBL.MainClass.getPaymentByCourse(appointmentID);
                }
                else
                {
                    gridControl1.DataSource = AlexLabBL.MainClass.getPaymentByCourse();
                }
            }
        }
    }
}