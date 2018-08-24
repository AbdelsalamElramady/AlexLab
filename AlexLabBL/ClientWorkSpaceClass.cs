using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexLabBL
{
    public class ClientWorkSpaceClass
    {
        public int ClientWorkSpaceId { get; set; }
        public string ClientWorkSpaceName { get; set; }
        public string ClientWorkSpacePhone { get; set; }
        public string ClientWorkSpaceNationalId { get; set; }
        public string Notes { get; set; }

        public ClientWorkSpaceClass()
        {
            MainClass.DbObj = new DataClassesAlexLabDataContext(MainClass.ConectionString);
        }

        public ClientWorkSpaceClass(int clientWorkSpaceId)
        {
            MainClass.DbObj = new DataClassesAlexLabDataContext(MainClass.ConectionString);

            var client = (from r in MainClass.DbObj.ClientWorkSpaces where r.ClientWorkSpaceId == clientWorkSpaceId select r).First();

            ClientWorkSpaceId = client.ClientWorkSpaceId;
            ClientWorkSpaceName = client.ClientWorkSpaceName;
            ClientWorkSpacePhone = client.ClientWorkSpacePhone;
            ClientWorkSpaceNationalId = client.ClientWorkSpaceNationalId;
            Notes = client.Notes;
        }

        private bool Insert()
        {
            try
            {
                ClientWorkSpace client = new ClientWorkSpace();

                client.ClientWorkSpaceName = ClientWorkSpaceName;
                client.ClientWorkSpacePhone = ClientWorkSpacePhone;
                client.ClientWorkSpaceNationalId = ClientWorkSpaceNationalId;
                client.Notes = Notes;

                MainClass.DbObj.ClientWorkSpaces.InsertOnSubmit(client);
                MainClass.DbObj.SubmitChanges();

                ClientWorkSpaceId = client.ClientWorkSpaceId;

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
                var client = (from c in MainClass.DbObj.ClientWorkSpaces where c.ClientWorkSpaceId == ClientWorkSpaceId select c).First();

                client.ClientWorkSpaceName = ClientWorkSpaceName;
                client.ClientWorkSpacePhone = ClientWorkSpacePhone;
                client.ClientWorkSpaceNationalId = ClientWorkSpaceNationalId;
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
