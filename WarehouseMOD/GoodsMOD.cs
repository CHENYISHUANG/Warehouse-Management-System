using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseMOD
{
    public class GoodsMOD
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string goods_name;

        public string Goods_name
        {
            get { return goods_name; }
            set { goods_name = value; }
        }
        private int goods_type_id;

        public int Goods_type_id
        {
            get { return goods_type_id; }
            set { goods_type_id = value; }
        }
        private string goods_code;

        public string Goods_code
        {
            get { return goods_code; }
            set { goods_code = value; }
        }
        private string specifications;

        public string Specifications
        {
            get { return specifications; }
            set { specifications = value; }
        }
        private string goods_wight;

        public string Goods_wight
        {
            get { return goods_wight; }
            set { goods_wight = value; }
        }
        private string goods_volume;

        public string Goods_volume
        {
            get { return goods_volume; }
            set { goods_volume = value; }
        }
        private string goods_note;

        public string Goods_note
        {
            get { return goods_note; }
            set { goods_note = value; }
        }
    }
}
