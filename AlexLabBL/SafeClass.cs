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
                var roo = from sa in MainClass.DbObj.Safes orderby sa.SafeId descending select sa;
                
                roo.First().CurrentValue -= CurrentValue;

                if (roo.First().IsClose == true)
                {
                    return false;
                }

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

        public bool Open()
        {
            try
            {
                var safe = from sa in MainClass.DbObj.Safes orderby sa.SafeId descending select sa;

                Safe s = new Safe();

                if (!safe.Any())
                {
                    s.OpenDate = DateTime.Now;
                    s.OpenValue = 0;
                    s.CurrentValue = 0;
                    s.IsClose = false;
                }
                else if (safe.First().IsClose == false)
                {
                    return false;
                }
                else
                {
                    s.OpenDate = DateTime.Now;
                    s.OpenValue = safe.First().CloseValue;
                    s.CurrentValue = safe.First().CloseValue;
                    s.IsClose = false;
                }


                MainClass.DbObj.Safes.InsertOnSubmit(s);
                MainClass.DbObj.SubmitChanges();

                SafeId = s.SafeId;

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Close()
        {
            try
            {
                var safe = from s in MainClass.DbObj.Safes orderby s.SafeId descending select s;

                if (!safe.Any() || safe.First().IsClose == true)
                {
                    return false;
                }
                else
                {
                    safe.First().CloseValue = safe.First().CurrentValue;
                    safe.First().CloseDate = DateTime.Now;
                    safe.First().IsClose = true;
                }

                MainClass.DbObj.SubmitChanges();

                SafeId = safe.First().SafeId;

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
