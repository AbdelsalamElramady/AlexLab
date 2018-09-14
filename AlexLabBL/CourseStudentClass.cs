using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexLabBL
{
    public class CourseStudentClass
    {
        public int CourseStudentId { get; set; }
        public string CourseStudentName { get; set; }
        public string CourseStudentNationalId { get; set; }
        public int UniqueID { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal PaidMoney { get; set; }
        public string Notes { get; set; }

        public CourseStudentClass()
        {
            MainClass.DbObj = new DataClassesAlexLabDataContext(MainClass.ConectionString);
        }

        public CourseStudentClass(int courseStudentId)
        {
            MainClass.DbObj = new DataClassesAlexLabDataContext(MainClass.ConectionString);

            var courseStudent = (from r in MainClass.DbObj.CourseStudents where r.CourseStudentId == courseStudentId select r).First();

            CourseStudentId = courseStudent.CourseStudentId;
            CourseStudentName = courseStudent.CourseStudentName;
            CourseStudentNationalId = courseStudent.CourseStudentNationalId;
            UniqueID = courseStudent.UniqueID.Value;
            TotalPrice = courseStudent.TotalPrice.Value;
            PaidMoney = courseStudent.PaidMoney.Value;
            Notes = courseStudent.Notes;
        }

        private bool Insert()
        {
            try
            {
                CourseStudent courseStudent = new CourseStudent();

                courseStudent.CourseStudentName = CourseStudentName;
                courseStudent.CourseStudentNationalId = CourseStudentNationalId;
                courseStudent.UniqueID = UniqueID;
                courseStudent.TotalPrice = TotalPrice;
                courseStudent.PaidMoney = PaidMoney;
                courseStudent.Notes = Notes;

                MainClass.DbObj.CourseStudents.InsertOnSubmit(courseStudent);
                MainClass.DbObj.SubmitChanges();

                CourseStudentId = courseStudent.CourseStudentId;

                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool Update()
        {
            try
            {
                var courseStudent = (from c in MainClass.DbObj.CourseStudents where c.CourseStudentId == CourseStudentId select c).First();

                courseStudent.CourseStudentName = CourseStudentName;
                courseStudent.CourseStudentNationalId = CourseStudentNationalId;
                courseStudent.UniqueID = UniqueID;
                courseStudent.TotalPrice = TotalPrice;
                courseStudent.PaidMoney = PaidMoney;
                courseStudent.Notes = Notes;

                MainClass.DbObj.SubmitChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Save(bool isEdit)
        {
            if (isEdit == true)
            {
                return Update();
            }
            else
            {
                return Insert();
            }
        }
    }
}
