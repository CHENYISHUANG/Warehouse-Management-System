using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseMOD
{
    public class ManagerMOD
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string manager_username;

        public string Manager_username
        {
            get { return manager_username; }
            set { manager_username = value; }
        }
        private string manager_password;

        public string Manager_password
        {
            get { return manager_password; }
            set { manager_password = value; }
        }

        private string manager_name;

        public string Manager_name
        {
            get { return manager_name; }
            set { manager_name = value; }
        }
    }
}
