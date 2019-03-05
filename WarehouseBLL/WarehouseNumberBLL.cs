using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseDAL;
using WarehouseMOD;

namespace WarehouseBLL
{
    public class WarehouseNumberBLL
    {
        WarehouseNumberDAL wmd = new WarehouseNumberDAL();
        public List<WarehouseNumberMOD> FindAll() 
        {
            return wmd.FindAll();
        }
        public List<WarehouseNumberMOD> FindById(int id) 
        {
            return wmd.FindById(id);
        }
        public int Update(WarehouseNumberMOD wm) 
        {
           return wmd.Update(wm);
        }

        public void Insert(WarehouseNumberMOD wm) 
        {
            wmd.Insert(wm);
        }
        public List<WarehouseNumberMOD> FindName(string name) 
        {
            return wmd.FindName(name);
        }

        public void Delete(int warehouse_id) 
        {
             wmd.Delete(warehouse_id);
        }
    }
}
