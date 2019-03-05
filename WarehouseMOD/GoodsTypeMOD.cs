using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseMOD
{
   public class GoodsTypeMOD
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string goods_type;

        public string Goods_type
        {
            get { return goods_type; }
            set { goods_type = value; }
        }
        private int node_parent;

        public int Node_parent
        {
            get { return node_parent; }
            set { node_parent = value; }
        }

        private int node_depth;

        public int Node_depth
        {
            get { return node_depth; }
            set { node_depth = value; }
        }
    }
}
