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
    public partial class RoomsForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        AlexLabBL.RoomClass RoomObj;

        bool isEdit = false;

        public RoomsForm()
        {
            InitializeComponent();
        }

        private void RoomsForm_Load(object sender, EventArgs e)
        {
            RoomObj = new AlexLabBL.RoomClass();

            gridControl1.DataSource = AlexLabBL.MainClass.getRooms();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            TxtRoomName.Text = string.Empty;
            TxtNotes.Text = string.Empty;
            TxtHourPrice.Text = string.Empty;

            isEdit = false;
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            TxtRoomName.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("RoomDesc"));
            TxtHourPrice.Value = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("HourPrice"));
            TxtNotes.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("Notes"));

            RoomObj.RoomId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("RoomId"));

            isEdit = true;
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                RoomObj.RoomDesc = TxtRoomName.Text;
                RoomObj.HourPrice = TxtHourPrice.Value;
                RoomObj.Notes = TxtNotes.Text;

                if (RoomObj.Save(isEdit))
                {
                    MainForm.MessageSecuseed();
                }
                else
                {
                    MainForm.MessageError();
                }

                gridControl1.DataSource = AlexLabBL.MainClass.getRooms();
            }
        }
    }
}