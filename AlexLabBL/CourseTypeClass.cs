using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexLabBL
{
    public class CourseTypeClass
    {
        public int CourseTypeId { get; set; }
        public string CourseTypeDesc { get; set; }

        public CourseTypeClass()
        {
            MainClass.DbObj = new DataClassesAlexLabDataContext(MainClass.ConectionString);
        }

        public CourseTypeClass(int courseTypeId)
        {
            MainClass.DbObj = new DataClassesAlexLabDataContext(MainClass.ConectionString);

            var type = (from r in MainClass.DbObj.CourseTypes where r.CourseTypeId == courseTypeId select r).First();

            CourseTypeId = type.CourseTypeId;
            CourseTypeDesc = type.CourseTypeDesc;
        }

        private bool Insert()
        {
            try
            {
                CourseType roo = new CourseType();

                roo.CourseTypeDesc = CourseTypeDesc;

                MainClass.DbObj.CourseTypes.InsertOnSubmit(roo);
                MainClass.DbObj.SubmitChanges();

                CourseTypeId = roo.CourseTypeId;

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
                var roo = (from c in MainClass.DbObj.CourseTypes where c.CourseTypeId == CourseTypeId select c).First();

                roo.CourseTypeDesc = CourseTypeDesc;

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
