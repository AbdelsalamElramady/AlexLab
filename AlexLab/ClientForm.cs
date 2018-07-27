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
    public partial class ClientForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        AlexLabBL.ClientClass clientObj;

        bool isEdit = false;

        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            clientObj = new AlexLabBL.ClientClass();

            gridControl1.DataSource = AlexLabBL.MainClass.getClients();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            TxtClientName.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("ClientName"));
            TxtClientPhone.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("ClientPhone"));
            TxtClientNationalId.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("ClientNationalId"));
            TxtNotes.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("Notes"));

            clientObj.ClientId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ClientId"));

            isEdit = true;
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            TxtClientName.Text = string.Empty;
            TxtClientNationalId.Text = string.Empty;
            TxtClientPhone.Text = string.Empty;
            TxtNotes.Text = string.Empty;

            isEdit = false;
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                clientObj.ClientName = TxtClientName.Text;
                clientObj.ClientNationalId = TxtClientNationalId.Text;
                clientObj.ClientPhone = TxtClientPhone.Text;
                clientObj.Notes = TxtNotes.Text;

                if (clientObj.Save(isEdit))
                {
                    MainForm.MessageSecuseed();
                }
                else
                {
                    MainForm.MessageError();
                }

                gridControl1.DataSource = AlexLabBL.MainClass.getClients();
            }
        }
    }
}