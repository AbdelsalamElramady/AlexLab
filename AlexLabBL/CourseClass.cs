using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexLabBL
{
    public class CourseClass
    {
        public int CourseId { get; set; }
        public int CourseTypeId { get; set; }
        public int ClientId { get; set; }
        public string CourseName { get; set; }
        public decimal StudentBookMoney { get; set; }
        public string Notes { get; set; }

        public CourseClass()
        {
            MainClass.DbObj = new DataClassesAlexLabDataContext(MainClass.ConectionString);
        }

        public CourseClass(int courseId)
        {
            MainClass.DbObj = new DataClassesAlexLabDataContext(MainClass.ConectionString);

            var course = (from r in MainClass.DbObj.Courses where r.CourseId == courseId select r).First();

            CourseId = course.CourseId;
            CourseTypeId = course.CourseTypeId.Value;
            ClientId = course.ClientId.Value;
            CourseName = course.CourseName;
            StudentBookMoney = course.StudentBookMoney.Value;
            Notes = course.Notes;
        }

        private bool Insert()
        {
            try
            {
                Course roo = new Course();

                roo.ClientId = ClientId;
                roo.CourseTypeId = CourseTypeId;
                roo.CourseName = CourseName;
                roo.StudentBookMoney = StudentBookMoney;
                roo.Notes = Notes;

                MainClass.DbObj.Courses.InsertOnSubmit(roo);
                MainClass.DbObj.SubmitChanges();

                CourseId = roo.CourseId;

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
                var roo = (from c in MainClass.DbObj.Courses where c.CourseId == CourseId select c).First();

                roo.ClientId = ClientId;
                roo.CourseTypeId = CourseTypeId;
                roo.CourseName = CourseName;
                roo.StudentBookMoney = StudentBookMoney;
                roo.Notes = Notes;

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
