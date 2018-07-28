using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexLabBL
{
    public class ClientClass
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientPhone { get; set; }
        public string ClientNationalId { get; set; }
        public string Notes { get; set; }

        public ClientClass()
        {
            MainClass.DbObj = new DataClassesAlexLabDataContext(MainClass.ConectionString);
        }

        public ClientClass(int clientId)
        {
            MainClass.DbObj = new DataClassesAlexLabDataContext(MainClass.ConectionString);

            var client = (from r in MainClass.DbObj.Clients where r.ClientId == clientId select r).First();

            ClientId = client.ClientId;
            ClientName = client.ClientName;
            ClientPhone = client.ClientPhone;
            ClientNationalId = client.ClientNationalId;
            Notes = client.Notes;
        }

        private bool Insert()
        {
            try
            {
                Client client = new Client();

                client.ClientName = ClientName;
                client.ClientPhone = ClientPhone;
                client.ClientNationalId = ClientNationalId;
                client.Notes = Notes;

                MainClass.DbObj.Clients.InsertOnSubmit(client);
                MainClass.DbObj.SubmitChanges();

                ClientId = client.ClientId;

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
                var client = (from c in MainClass.DbObj.Clients where c.ClientId == ClientId select c).First();

                client.ClientName = ClientName;
                client.ClientPhone = ClientPhone;
                client.ClientNationalId = ClientNationalId;
                client.Notes = Notes;

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
