using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexLabBL
{
    public class SafeClass
    {
        public int SafeId { get; set; }
        public DateTime OpenDate { get; set; }
        public decimal OpenValue { get; set; }
        public decimal CurrentValue { get; set; }
        public decimal CloseValue { get; set; }
        public DateTime CloseDate { get; set; }
        public bool IsClose { get; set; }

        public SafeClass()
        {
            MainClass.DbObj = new DataClassesAlexLabDataContext(MainClass.ConectionString);
        }

        public SafeClass(int safeId)
        {
            MainClass.DbObj = new DataClassesAlexLabDataContext(MainClass.ConectionString);

            var safe = (from r in MainClass.DbObj.Safes where r.SafeId == safeId select r).First();

            SafeId = safe.SafeId;
            OpenDate = safe.OpenDate.Value;
            OpenValue = safe.OpenValue.Value;
            CurrentValue = safe.CurrentValue.Value;
            CloseValue = safe.CloseValue.Value;
            CloseDate = safe.CloseDate.Value;
            IsClose = safe.IsClose.Value;
        }

        private bool Insert()
        {
            try
            {
                Safe roo = new Safe();

                roo.OpenValue = OpenValue;
                roo.OpenDate = OpenDate;
                roo.CurrentValue = CurrentValue;
                roo.CloseValue = CloseValue;
                roo.CloseDate = CloseDate;
                roo.IsClose = IsClose;

                MainClass.DbObj.Safes.InsertOnSubmit(roo);
                MainClass.DbObj.SubmitChanges();

                SafeId = roo.SafeId;

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
                var roo = (from c in MainClass.DbObj.Safes where c.SafeId == SafeId select c).First();

                roo.OpenValue = OpenValue;
                roo.OpenDate = OpenDate;
                roo.CurrentValue = CurrentValue;
                roo.CloseValue = CloseValue;
                roo.CloseDate = CloseDate;
                roo.IsClose = IsClose;

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
