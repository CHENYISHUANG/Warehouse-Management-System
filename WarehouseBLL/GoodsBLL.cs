using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseDAL;
using WarehouseMOD;

namespace WarehouseBLL
{
    public class GoodsBLL
    {
        GoodsDAL gd = new GoodsDAL();
        public List<GoodsMOD> FindLike(string text) 
        {
            return gd.FindLike(text);
        }
        public List<GoodsMOD> FindAll() 
        {
            return gd.FindAll();
        }
        public List<GoodsMOD> ById(int id) 
        {
            return gd.ById(id);
        }
        public int Insert(GoodsMOD gm) 
        {
           gd.Insert(gm);
           return gd.GetId(gm);
        }
        public List<GoodsMOD> FindAllCondition(GoodsMOD gm) 
        {
            return gd.FindAllCondition(gm);
        }
    }
}
