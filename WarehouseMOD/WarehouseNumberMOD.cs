using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseMOD
{
    public class WarehouseNumberMOD
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string warehouse_name;

        public string Warehouse_name
        {
            get { return warehouse_name; }
            set { warehouse_name = value; }
        }
        private string warehouse_position;

        public string Warehouse_position
        {
            get { return warehouse_position; }
            set { warehouse_position = value; }
        }
        private string warehouse_note;

        public string Warehouse_note
        {
            get { return warehouse_note; }
            set { warehouse_note = value; }
        }
    }
}
