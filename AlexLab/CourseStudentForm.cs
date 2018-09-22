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
    public partial class CourseStudentForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        AlexLabBL.CourseStudentClass courseStudentObj;

        bool isEdit = false;

        public CourseStudentForm()
        {
            InitializeComponent();
        }

        private void CourseStudentForm_Load(object sender, EventArgs e)
        {
            courseStudentObj = new AlexLabBL.CourseStudentClass();

            gridControl1.DataSource = AlexLabBL.MainClass.getCourseStudents();

            LookUpCourse.Properties.DataSource = AlexLabBL.MainClass.getCourses();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            courseStudentObj = new AlexLabBL.CourseStudentClass(Convert.ToInt32(gridView1.GetFocusedRowCellValue("CourseStudentId")));

            LookUpCourse.EditValue = courseStudentObj.UniqueID;
            TxtNationalId.Text = courseStudentObj.CourseStudentNationalId;
            TxtNotes.Text = courseStudentObj.Notes;
            TxtPaidMoney.Value = courseStudentObj.PaidMoney;
            TxtStudentName.Text = courseStudentObj.CourseStudentName;
            TxtBookMoney.Value = courseStudentObj.BookMoney;
            TxtCoursePrice.Value = courseStudentObj.CoursePrice;

            isEdit = true;
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            LookUpCourse.EditValue = null;
            TxtNationalId.Text = string.Empty;
            TxtNotes.Text = string.Empty;
            TxtPaidMoney.Value = decimal.Zero;
            TxtStudentName.Text = string.Empty;
            TxtBookMoney.Value = decimal.Zero;
            TxtCoursePrice.Value = decimal.Zero;

            isEdit = false;
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                courseStudentObj.UniqueID = Convert.ToInt32(LookUpCourse.EditValue);
                courseStudentObj.CourseStudentName = TxtStudentName.Text;
                courseStudentObj.CourseStudentNationalId = TxtNationalId.Text;
                courseStudentObj.BookMoney = TxtBookMoney.Value;
                courseStudentObj.CoursePrice = TxtCoursePrice.Value;
                courseStudentObj.PaidMoney = TxtPaidMoney.Value;
                courseStudentObj.Notes = TxtNotes.Text;

                if (courseStudentObj.Save(isEdit))
                {
                    MainForm.MessageSecuseed();
                }
                else
                {
                    MainForm.MessageError();
                }

                gridControl1.DataSource = AlexLabBL.MainClass.getCourseStudents();
            }
        }

        private void LookUpCourse_EditValueChanged(object sender, EventArgs e)
        {
            TxtBookMoney.Value = AlexLabBL.MainClass.getBookMoney(Convert.ToInt32(LookUpCourse.EditValue));
            TxtCoursePrice.Value = AlexLabBL.MainClass.getCoursePrice(Convert.ToInt32(LookUpCourse.EditValue));
        }
    }
}