using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexLabBL
{
    public class ExpencesTypeClass
    {
        public int ExpencesTypeId { get; set; }
        public string ExpencesDesc { get; set; }

        public ExpencesTypeClass()
        {
            MainClass.DbObj = new DataClassesAlexLabDataContext(MainClass.ConectionString);
        }

        public ExpencesTypeClass(int expencesTypeId)
        {
            MainClass.DbObj = new DataClassesAlexLabDataContext(MainClass.ConectionString);

            var type = (from r in MainClass.DbObj.ExpencesTypes where r.ExpencesTypeId == expencesTypeId select r).First();

            ExpencesTypeId = type.ExpencesTypeId;
            ExpencesDesc = type.ExpencesDesc;
        }

        private bool Insert()
        {
            try
            {
                ExpencesType roo = new ExpencesType();

                roo.ExpencesDesc = ExpencesDesc;

                MainClass.DbObj.ExpencesTypes.InsertOnSubmit(roo);
                MainClass.DbObj.SubmitChanges();

                ExpencesTypeId = roo.ExpencesTypeId;

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
                var roo = (from c in MainClass.DbObj.ExpencesTypes where c.ExpencesTypeId == ExpencesTypeId select c).First();

                roo.ExpencesDesc = ExpencesDesc;

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
