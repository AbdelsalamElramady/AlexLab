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
    public partial class SafeForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        AlexLabBL.SafeClass safeObj;

        public SafeForm()
        {
            InitializeComponent();
        }

        private void SafeForm_Load(object sender, EventArgs e)
        {
            safeObj = new AlexLabBL.SafeClass();

            gridControl1.DataSource = AlexLabBL.MainClass.getSafes();

            TxtSaveCurrentValue.Text = AlexLabBL.MainClass.getSafeCurrentValue().ToString();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(safeObj.Open())
            {
                MessageBox.Show("تم فتح الخزنه", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gridControl1.DataSource = AlexLabBL.MainClass.getSafes();

                TxtSaveCurrentValue.Text = AlexLabBL.MainClass.getSafeCurrentValue().ToString();
            }
            else
            {
                MessageBox.Show("يوجد خزنه مفتوحه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (safeObj.Close())
            {
                MessageBox.Show("تم اغلاق الخزنه", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gridControl1.DataSource = AlexLabBL.MainClass.getSafes();

                TxtSaveCurrentValue.Text = AlexLabBL.MainClass.getSafeCurrentValue().ToString();
            }
            else
            {
                MessageBox.Show("الخزنه مغلقه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}