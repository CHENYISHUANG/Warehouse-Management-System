using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseMOD
{
    public class ClientMOD
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string client_name;

        public string Client_name
        {
            get { return client_name; }
            set { client_name = value; }
        }
        private string client_address;

        public string Client_address
        {
            get { return client_address; }
            set { client_address = value; }
        }
        private string client_contacts;

        public string Client_contacts
        {
            get { return client_contacts; }
            set { client_contacts = value; }
        }
        private string client_phone;

        public string Client_phone
        {
            get { return client_phone; }
            set { client_phone = value; }
        }
        private string client_note;

        public string Client_note
        {
            get { return client_note; }
            set { client_note = value; }
        }
    }
}
