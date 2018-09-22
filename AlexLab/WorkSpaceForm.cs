using DevExpress.XtraBars;
using System;

namespace AlexLab
{
    public partial class WorkSpaceForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        AlexLabBL.PaymentClass courseObj;
        AlexLabBL.SafeClass safeObj;

        bool isEdit = false;

        public WorkSpaceForm()
        {
            InitializeComponent();
        }

        private void WorkSpaceForm_Load(object sender, EventArgs e)
        {
            courseObj = new AlexLabBL.PaymentClass();
            safeObj = new AlexLabBL.SafeClass();

            LookUpClient.Properties.DataSource = AlexLabBL.MainClass.getClientsWorkSpace();
            lookUpPaymentType.Properties.DataSource = AlexLabBL.MainClass.getPaymentType();
            lookUpPaymentType.EditValue = 2;

            gridControl1.DataSource = AlexLabBL.MainClass.getPaymentByClient();
        }

        private void LookUpClient_EditValueChanged(object sender, EventArgs e)
        {
            //gridControl1.DataSource = AlexLabBL.MainClass.getPaymentByClient(Convert.ToInt32(LookUpClient.EditValue));
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            LookUpClient.EditValue = null;
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
                    courseObj.ClientWorkSpaceId = Convert.ToInt32(LookUpClient.EditValue);
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

                    gridControl1.DataSource = AlexLabBL.MainClass.getPaymentByClient();
                }
            }
    }
}