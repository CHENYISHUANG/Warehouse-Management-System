using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseMOD
{
   public class BillMOD
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int goods_id;

        public int Goods_id
        {
            get { return goods_id; }
            set { goods_id = value; }
        }
        private int goods_amount;

        public int Goods_amount
        {
            get { return goods_amount; }
            set { goods_amount = value; }
        }
        private double goods_price;

        public double Goods_price
        {
            get { return goods_price; }
            set { goods_price = value; }
        }
        private string manufacture_date;

        public string Manufacture_date
        {
            get { return manufacture_date; }
            set { manufacture_date = value; }
        }
        private string expiration_date;

        public string Expiration_date
        {
            get { return expiration_date; }
            set { expiration_date = value; }
        }
        private int operation_type_id;

        public int Operation_type_id
        {
            get { return operation_type_id; }
            set { operation_type_id = value; }
        }
        private int warehouse_id;

        public int Warehouse_id
        {
            get { return warehouse_id; }
            set { warehouse_id = value; }
        }
        private string lot_number;

        public string Lot_number
        {
            get { return lot_number; }
            set { lot_number = value; }
        }
        private string operation_time;

        public string Operation_time
        {
            get { return operation_time; }
            set { operation_time = value; }
        }
        private int manager_id;

        public int Manager_id
        {
            get { return manager_id; }
            set { manager_id = value; }
        }
        private string bill_note;

        public string Bill_note
        {
            get { return bill_note; }
            set { bill_note = value; }
        }
        private int client_id;

        public int Client_id
        {
            get { return client_id; }
            set { client_id = value; }
        }
    }
}
