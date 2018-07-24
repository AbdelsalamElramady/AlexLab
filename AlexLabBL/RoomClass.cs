using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexLabBL
{
    class RoomClass
    {
        public int RoomId { get; set; }
        public string RoomDesc { get; set; }
        public decimal HourPrice { get; set; }
        public string Notes { get; set; }

        public RoomClass()
        {
            MainClass.DbObj = new DataClassesAlexLabDataContext(MainClass.ConectionString);
        }

        public RoomClass(int RoomId)
        {
            MainClass.DbObj = new DataClassesAlexLabDataContext(MainClass.ConectionString);

            var Room = (from r in MainClass.DbObj.Rooms where r.RoomId == RoomId select r).First();

            RoomId = Room.RoomId;
            RoomDesc = Room.RoomDesc;
            HourPrice = Room.HourPrice.Value;
            Notes = Room.Notes;
        }

        private bool Insert()
        {
            try
            {
                Room roo = new Room();

                roo.RoomDesc = RoomDesc;
                roo.HourPrice = HourPrice;
                roo.Notes = Notes;

                MainClass.DbObj.Rooms.InsertOnSubmit(roo);
                MainClass.DbObj.SubmitChanges();

                RoomId = roo.RoomId;

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
                var roo = (from c in MainClass.DbObj.Rooms where c.RoomId == RoomId select c).First();

                roo.RoomDesc = RoomDesc;
                roo.HourPrice = HourPrice;
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
