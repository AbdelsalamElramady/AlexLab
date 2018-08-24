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
    public partial class ClientWorkSpaceForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        AlexLabBL.ClientWorkSpaceClass clientObj;

        bool isEdit = false;

        public ClientWorkSpaceForm()
        {
            InitializeComponent();
        }

        private void ClientWorkSpaceForm_Load(object sender, EventArgs e)
        {
            clientObj = new AlexLabBL.ClientWorkSpaceClass();

            gridControl1.DataSource = AlexLabBL.MainClass.getClientsWorkSpace();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            TxtClientWorkSpaceName.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("ClientWorkSpaceName"));
            TxtClientWorkSpacePhone.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("ClientWorkSpacePhone"));
            TxtClientWorkSpaceNationalId.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("ClientWorkSpaceNationalId"));
            TxtNotes.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("Notes"));

            clientObj.ClientWorkSpaceId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ClientWorkSpaceId"));

            isEdit = true;
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            TxtClientWorkSpaceName.Text = string.Empty;
            TxtClientWorkSpaceNationalId.Text = string.Empty;
            TxtClientWorkSpacePhone.Text = string.Empty;
            TxtNotes.Text = string.Empty;

            isEdit = false;
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                clientObj.ClientWorkSpaceName = TxtClientWorkSpaceName.Text;
                clientObj.ClientWorkSpaceNationalId = TxtClientWorkSpaceNationalId.Text;
                clientObj.ClientWorkSpacePhone = TxtClientWorkSpacePhone.Text;
                clientObj.Notes = TxtNotes.Text;

                if (clientObj.Save(isEdit))
                {
                    MainForm.MessageSecuseed();
                }
                else
                {
                    MainForm.MessageError();
                }

                gridControl1.DataSource = AlexLabBL.MainClass.getClientsWorkSpace();
            }
        }
    }
}