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
    public partial class PaymentForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        AlexLabBL.PaymentClass courseObj;
        AlexLabBL.SafeClass safeObj;

        bool isEdit = false;

        public PaymentForm()
        {
            InitializeComponent();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            courseObj = new AlexLabBL.PaymentClass();
            safeObj = new AlexLabBL.SafeClass();

            gridControl1.DataSource = AlexLabBL.MainClass.getPayment();
            lookUpPaymentType.Properties.DataSource = AlexLabBL.MainClass.getPaymentType();
            lookUpPaymentType.EditValue = 3;
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            TxtPaymentValue.Value = decimal.Zero;
            TxtNotes.Text = string.Empty;

            isEdit = false;
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                courseObj.PaymentTypeId = Convert.ToInt32(lookUpPaymentType.EditValue);
                courseObj.PaymentDate = DateTime.Now;
                courseObj.AppointmentId = null;
                courseObj.ClientWorkSpaceId = null;
                courseObj.PaymentValue = TxtPaymentValue.Value;
                courseObj.Notes = TxtNotes.Text;

                safeObj.CurrentValue = TxtPaymentValue.Value;

                if (!AlexLabBL.MainClass.CheckSafeIsClose())
                {

                    if (courseObj.Save(isEdit))
                    {
                        safeObj.Save(false);
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

                gridControl1.DataSource = AlexLabBL.MainClass.getPayment();
            }
        }
    }
}