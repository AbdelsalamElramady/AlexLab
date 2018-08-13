using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexLabBL
{
    public class ExpencesClass
    {
        public int ExpencesId { get; set; }
        public string ExpencesDesc { get; set; }

        public ExpencesClass()
        {
            MainClass.DbObj = new DataClassesAlexLabDataContext(MainClass.ConectionString);
        }

        public ExpencesClass(int expencesId)
        {
            MainClass.DbObj = new DataClassesAlexLabDataContext(MainClass.ConectionString);

            var type = (from r in MainClass.DbObj.Expences where r.ExpencesId == expencesId select r).First();

            ExpencesId = type.ExpencesId;
            ExpencesDesc = type.ExpencesDesc;
        }

        private bool Insert()
        {
            try
            {
                Expence roo = new Expence();

                roo.ExpencesDesc = ExpencesDesc;

                MainClass.DbObj.Expences.InsertOnSubmit(roo);
                MainClass.DbObj.SubmitChanges();

                ExpencesId = roo.ExpencesId;

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
                var roo = (from c in MainClass.DbObj.Expences where c.ExpencesId == ExpencesId select c).First();

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
