#region Note
/*
{**************************************************************************************************************}
{  This file is automatically created when you open the Scheduler Control smart tag                            }
{  *and click Create Customizable Appointment Dialog.                                                          }
{  It contains a a descendant of the default appointment editing form created by visual inheritance.           }
{  In Visual Studio Designer add an editor that is required to edit your appointment custom field.             }
{  Modify the LoadFormData method to get data from a custom field and fill your editor with data.              }
{  Modify the SaveFormData method to retrieve data from the editor and set the appointment custom field value. }
{  The code that displays this form is automatically inserted                                                  }
{  *in the EditAppointmentFormShowing event handler of the SchedulerControl.                                   }
{                                                                                                              }
{**************************************************************************************************************}
*/
#endregion Note

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler;

namespace AlexLab
{
    public partial class CustomAppointmentForm : DevExpress.XtraScheduler.UI.AppointmentForm
    {
        int appointmentId;

        int RoomId;
        int ClientId;
        int CourseTypeId;
        decimal StudentBookMoney;
        decimal CoursePrice;
        public static decimal PaidMoney = 0;
        decimal TotalPrice;
        bool IsClose;

        public CustomAppointmentForm()
        {
            InitializeComponent();
        }
        public CustomAppointmentForm(DevExpress.XtraScheduler.SchedulerControl control, DevExpress.XtraScheduler.Appointment apt)
            : base(control, apt)
        {
            InitializeComponent();
        }
        public CustomAppointmentForm(DevExpress.XtraScheduler.SchedulerControl control, DevExpress.XtraScheduler.Appointment apt, bool openRecurrenceForm)
            : base(control, apt, openRecurrenceForm)
        {
            InitializeComponent();
        }
        /// <summary>
        /// Add your code to obtain a custom field value and fill the editor with data.
        /// </summary>
        public override void LoadFormData(DevExpress.XtraScheduler.Appointment appointment)
        {
            if (appointment.CustomFields["RoomId"] != null)
            {
                RoomId = Convert.ToInt32(appointment.CustomFields["RoomId"]);
                lookUpRoom.EditValue = RoomId;
            }

            if (appointment.CustomFields["ClientId"] != null)
            {
                ClientId = Convert.ToInt32(appointment.CustomFields["ClientId"]);
                lookUpClient.EditValue = ClientId;
            }

            if (appointment.CustomFields["CourseTypeId"] != null)
            {
                CourseTypeId = Convert.ToInt32(appointment.CustomFields["CourseTypeId"]);
                lookUpCourseType.EditValue = CourseTypeId;
            }

            if (appointment.CustomFields["PaidMoney"] != null)
            {
                PaidMoney = Convert.ToDecimal(appointment.CustomFields["PaidMoney"]);
                TxtPaidMoney.Value = PaidMoney;
            }

            if (appointment.CustomFields["TotalPrice"] != null)
            {
                TotalPrice = Convert.ToDecimal(appointment.CustomFields["TotalPrice"]);
                TxtTotalPrice.Value = TotalPrice;
            }

            if (appointment.CustomFields["StudentBookMoney"] != null)
            {
                StudentBookMoney = Convert.ToDecimal(appointment.CustomFields["StudentBookMoney"]);
                TxtStudentBookMoney.Value = StudentBookMoney;
            }

            if (appointment.CustomFields["CoursePrice"] != null)
            {
                CoursePrice = Convert.ToDecimal(appointment.CustomFields["CoursePrice"]);
                TxtCoursePrice.Value = CoursePrice;
            }

            if (appointment.CustomFields["UniqueID"] != null)
            {
                appointmentId = Convert.ToInt32(appointment.CustomFields["UniqueID"]);
            }

            base.LoadFormData(appointment);
        }
        /// <summary>
        /// Add your code to retrieve a value from the editor and set the custom appointment field.
        /// </summary>
        public override bool SaveFormData(DevExpress.XtraScheduler.Appointment appointment)
        {
            if (dxValidationProvider1.Validate())
            {
                appointment.CustomFields["RoomId"] = lookUpRoom.EditValue;
                appointment.CustomFields["ClientId"] = lookUpClient.EditValue;
                appointment.CustomFields["CourseTypeId"] = lookUpCourseType.EditValue;
                appointment.CustomFields["PaidMoney"] = TxtPaidMoney.Value;
                appointment.CustomFields["TotalPrice"] = TxtTotalPrice.Value;
                appointment.CustomFields["StudentBookMoney"] = TxtStudentBookMoney.Value;
                appointment.CustomFields["CoursePrice"] = TxtCoursePrice.Value;

                appointment.Location = lookUpRoom.Text;
                appointment.LabelId = Convert.ToInt32(lookUpRoom.EditValue);

                return base.SaveFormData(appointment);
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Add your code to notify that any custom field is changed. Return true if a custom field is changed, otherwise false.
        /// </summary>
        public override bool IsAppointmentChanged(DevExpress.XtraScheduler.Appointment appointment)
        {
            if (dxValidationProvider1.Validate() && RoomId == Convert.ToInt32(appointment.CustomFields["RoomId"]) &&
                ClientId == Convert.ToInt32(appointment.CustomFields["ClientId"]) &&
                CourseTypeId == Convert.ToInt32(appointment.CustomFields["CourseTypeId"]) &&
                PaidMoney == Convert.ToDecimal(appointment.CustomFields["PaidMoey"]) &&
                StudentBookMoney == Convert.ToDecimal(appointment.CustomFields["StudentBookMoney"]) &&
                CoursePrice == Convert.ToDecimal(appointment.CustomFields["CoursePrice"]) &&
                TotalPrice == Convert.ToInt32(appointment.CustomFields["TotalMoney"]))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void CustomAppointmentForm_Load(object sender, EventArgs e)
        {
            lookUpRoom.Properties.DataSource = AlexLabBL.MainClass.getRooms();
            lookUpClient.Properties.DataSource = AlexLabBL.MainClass.getClients();
            lookUpCourseType.Properties.DataSource = AlexLabBL.MainClass.getCourseTypes();
        }

        private void edtStartDate_EditValueChanged(object sender, EventArgs e)
        {
            //if (lookUpRoom.EditValue != null)
            //{
            //    AlexLabBL.RoomClass RoomObj = new AlexLabBL.RoomClass(Convert.ToInt32(lookUpRoom.EditValue));

            //    int days = (edtEndDate.DateTime - edtStartDate.DateTime).Days;

            //    TxtTotalPrice.Value = ((edtEndTime.Time - edtStartTime.Time).Hours + (days * 24)) * RoomObj.HourPrice;
            //}
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            new CoursePaymentForm(appointmentId).ShowDialog();
            TxtPaidMoney.Value += PaidMoney;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void TxtPaidMoney_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }
    }
}
