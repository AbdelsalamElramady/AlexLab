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
    public partial class CourseTypeForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        AlexLabBL.CourseTypeClass typeObj;

        bool isEdit = false;

        public CourseTypeForm()
        {
            InitializeComponent();
        }

        private void CourseTypeForm_Load(object sender, EventArgs e)
        {
            typeObj = new AlexLabBL.CourseTypeClass();

            gridControl1.DataSource = AlexLabBL.MainClass.getCourseType();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            typeObj = new AlexLabBL.CourseTypeClass(Convert.ToInt32(gridView1.GetFocusedRowCellValue("CourseTypeId")));

            TxtCourseTypeDesc.Text = typeObj.CourseTypeDesc;

            isEdit = true;
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            TxtCourseTypeDesc.Text = string.Empty;

            isEdit = false;
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                typeObj.CourseTypeDesc = TxtCourseTypeDesc.Text;

                if (typeObj.Save(isEdit))
                {
                    MainForm.MessageSecuseed();
                }
                else
                {
                    MainForm.MessageError();
                }

                gridControl1.DataSource = AlexLabBL.MainClass.getCourseType();
            }
        }
    }
}