using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseMOD
{
    public class InventoryMOD
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int warehouse_id;

        public int Warehouse_id
        {
            get { return warehouse_id; }
            set { warehouse_id = value; }
        }
        private int goods_id;

        public int Goods_id
        {
            get { return goods_id; }
            set { goods_id = value; }
        }
        private int client_id;

        public int Client_id
        {
            get { return client_id; }
            set { client_id = value; }
        }
        private int goods_amount;

        public int Goods_amount
        {
            get { return goods_amount; }
            set { goods_amount = value; }
        }
        private double goods_total;

        public double Goods_total
        {
            get { return goods_total; }
            set { goods_total = value; }
        }
    }
}
