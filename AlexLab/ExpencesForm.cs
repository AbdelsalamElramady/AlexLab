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
    public partial class ExpencesForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        AlexLabBL.ExpencesClass expencesObj;
        AlexLabBL.SafeClass safeObj;

        bool isEdit = false;

        public ExpencesForm()
        {
            InitializeComponent();
        }

        private void ExpencesForm_Load(object sender, EventArgs e)
        {
            expencesObj = new AlexLabBL.ExpencesClass();
            safeObj = new AlexLabBL.SafeClass();

            gridControl1.DataSource = AlexLabBL.MainClass.getExpences();
            lookUpExpencesType.Properties.DataSource = AlexLabBL.MainClass.getExpencesType();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            //expencesObj = new AlexLabBL.ExpencesClass(Convert.ToInt32(gridView1.GetFocusedRowCellValue("ExpencesId")));

            //lookUpExpencesType.EditValue = expencesObj.ExpencesTypeId;
            //TxtExpencesValue.Value = expencesObj.ExpencesValue;
            //TxtNotes.Text = expencesObj.Notes;

            //isEdit = true;
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            lookUpExpencesType.EditValue = null;
            TxtExpencesValue.Text = string.Empty;
            TxtNotes.Text = string.Empty;

            isEdit = false;
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                expencesObj.ExpencesTypeId = Convert.ToInt32(lookUpExpencesType.EditValue);
                expencesObj.ExpencesValue = TxtExpencesValue.Value;
                expencesObj.ExpencesDate = DateTime.Now;
                expencesObj.Notes = TxtNotes.Text;

                safeObj.CurrentValue = TxtExpencesValue.Value;

                if (!AlexLabBL.MainClass.CheckSafeIsClose())
                {
                    if (expencesObj.Save(isEdit))
                    {
                        safeObj.Save(true);
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

                gridControl1.DataSource = AlexLabBL.MainClass.getExpences();
            }
        }
    }
}