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
        int RoomId;
        int CourseId;
        decimal PaidMoney;
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

            if (appointment.CustomFields["CourseId"] != null)
            {
                CourseId = Convert.ToInt32(appointment.CustomFields["CourseId"]);
                lookUpCourse.EditValue = CourseId;
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

            base.LoadFormData(appointment);
        }
        /// <summary>
        /// Add your code to retrieve a value from the editor and set the custom appointment field.
        /// </summary>
        public override bool SaveFormData(DevExpress.XtraScheduler.Appointment appointment)
        {
            appointment.CustomFields["RoomId"] = lookUpRoom.EditValue;
            appointment.CustomFields["CourseId"] = lookUpCourse.EditValue;
            appointment.CustomFields["PaidMoney"] = TxtPaidMoney.Value;
            appointment.CustomFields["TotalPrice"] = TxtTotalPrice.Value;

            return base.SaveFormData(appointment);
        }
        /// <summary>
        /// Add your code to notify that any custom field is changed. Return true if a custom field is changed, otherwise false.
        /// </summary>
        public override bool IsAppointmentChanged(DevExpress.XtraScheduler.Appointment appointment)
        {
            if (RoomId == Convert.ToInt32(appointment.CustomFields["RoomId"]) &&
                CourseId == Convert.ToInt32(appointment.CustomFields["CourseId"]) &&
                PaidMoney == Convert.ToDecimal(appointment.CustomFields["PaidMoey"]) &&
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
            lookUpCourse.Properties.DataSource = AlexLabBL.MainClass.getCourses();
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
    }
}
