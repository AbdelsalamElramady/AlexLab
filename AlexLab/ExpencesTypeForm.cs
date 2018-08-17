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
    public partial class ExpencesTypeForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        AlexLabBL.ExpencesTypeClass typeObj;

        bool isEdit = false;

        public ExpencesTypeForm()
        {
            InitializeComponent();
        }

        private void ExpencesTypeForm_Load(object sender, EventArgs e)
        {
            typeObj = new AlexLabBL.ExpencesTypeClass();

            gridControl1.DataSource = AlexLabBL.MainClass.getExpencesType();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            typeObj = new AlexLabBL.ExpencesTypeClass(Convert.ToInt32(gridView1.GetFocusedRowCellValue("ExpencesTypeId")));

            TxtExpencesTypeDesc.Text = typeObj.ExpencesDesc;

            isEdit = true;
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            TxtExpencesTypeDesc.Text = string.Empty;

            isEdit = false;
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                typeObj.ExpencesDesc = TxtExpencesTypeDesc.Text;

                if (typeObj.Save(isEdit))
                {
                    MainForm.MessageSecuseed();
                }
                else
                {
                    MainForm.MessageError();
                }

                gridControl1.DataSource = AlexLabBL.MainClass.getExpencesType();
            }
        }
    }
}