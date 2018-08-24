using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexLabBL
{
    public class PaymentClass
    {
        public int PaymentId { get; set; }
        public int PaymentTypeId { get; set; }
        public int? ClientWorkSpaceId { get; set; }
        public int? AppointmentId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal PaymentValue { get; set; }
        public string Notes { get; set; }

        public PaymentClass()
        {
            MainClass.DbObj = new DataClassesAlexLabDataContext(MainClass.ConectionString);
        }

        public PaymentClass(int paymentId)
        {
            MainClass.DbObj = new DataClassesAlexLabDataContext(MainClass.ConectionString);

            var payment = (from r in MainClass.DbObj.Payments where r.PaymentId == paymentId select r).First();

            PaymentId = payment.PaymentId;
            PaymentTypeId = payment.PaymentTypeId.Value;
            ClientWorkSpaceId = payment.ClientWorkSpaceId.Value;
            AppointmentId = payment.AppointmentId.Value;
            PaymentDate = payment.PaymentDate.Value;
            PaymentValue = payment.PaymentValue.Value;
            Notes = payment.Notes;
        }

        private bool Insert()
        {
            try
            {
                Payment roo = new Payment();

                roo.ClientWorkSpaceId = ClientWorkSpaceId;
                roo.PaymentTypeId = PaymentTypeId;
                roo.AppointmentId = AppointmentId;
                roo.PaymentDate = PaymentDate;
                roo.PaymentValue = PaymentValue;
                roo.Notes = Notes;

                MainClass.DbObj.Payments.InsertOnSubmit(roo);
                MainClass.DbObj.SubmitChanges();

                PaymentId = roo.PaymentId;

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
                var roo = (from c in MainClass.DbObj.Payments where c.PaymentId == PaymentId select c).First();

                roo.ClientWorkSpaceId = ClientWorkSpaceId;
                roo.PaymentTypeId = PaymentTypeId;
                roo.AppointmentId = AppointmentId;
                roo.PaymentDate = PaymentDate;
                roo.PaymentValue = PaymentValue;
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
