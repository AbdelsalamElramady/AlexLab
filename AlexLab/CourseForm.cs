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
    public partial class CourseForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        AlexLabBL.CourseClass courseObj;

        bool isEdit = false;

        public CourseForm()
        {
            InitializeComponent();
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            courseObj = new AlexLabBL.CourseClass();

            gridControl1.DataSource = AlexLabBL.MainClass.getCourses();
            LookUpClient.Properties.DataSource = AlexLabBL.MainClass.getClients();
            LookUpCourseType.Properties.DataSource = AlexLabBL.MainClass.getCourseTypes();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            courseObj = new AlexLabBL.CourseClass(Convert.ToInt32(gridView1.GetFocusedRowCellValue("CourseId")));

            LookUpClient.EditValue = courseObj.ClientId;
            LookUpCourseType.EditValue = courseObj.CourseTypeId;
            TxtCourseName.Text = courseObj.CourseName;
            TxtStudentBookMoney.Value = courseObj.StudentBookMoney;
            TxtNotes.Text = courseObj.Notes;

            isEdit = true;
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            LookUpClient.EditValue = null;
            LookUpCourseType.EditValue = null;
            TxtCourseName.Text = string.Empty;
            TxtStudentBookMoney.Value = decimal.Zero;
            TxtNotes.Text = string.Empty;

            isEdit = false;
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                courseObj.ClientId = Convert.ToInt32(LookUpClient.EditValue);
                courseObj.CourseTypeId = Convert.ToInt32(LookUpCourseType.EditValue);
                courseObj.CourseName = TxtCourseName.Text;
                courseObj.StudentBookMoney = TxtStudentBookMoney.Value;
                courseObj.Notes = TxtNotes.Text;

                if (courseObj.Save(isEdit))
                {
                    MainForm.MessageSecuseed();
                }
                else
                {
                    MainForm.MessageError();
                }

                gridControl1.DataSource = AlexLabBL.MainClass.getCourses();
            }
        }
    }
}