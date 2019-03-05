using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseDAL;
using WarehouseMOD;

namespace WarehouseBLL
{
   
   public class OperationTypeBLL
    {
       OperationTypeDAL ob = new OperationTypeDAL();
       public List<OperationTypeMOD> FindAll()
       {
           return ob.FindAll();
       }
       public List<OperationTypeMOD> FindById(int id)
       {
           return ob.FindById(id); 
       }
       public List<OperationTypeMOD> FindPutAll() 
       {
           return ob.FindPutAll();
       }
       public List<OperationTypeMOD> FindOutAll()
       {
           return ob.FindOutAll();
       }
    }
}
