using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseMOD;
using System.Data;
using System.Data.SqlClient;

namespace WarehouseDAL
{
   public class OperationTypeDAL
    {
       string sql = "";
       List<OperationTypeMOD> list = new List<OperationTypeMOD>();
       public List<OperationTypeMOD> FindAll()       //查询所有入库
       {
           sql = "SELECT * FROM OperationType";
           return GetList(sql);
       }
       /// <summary>
       /// 根据ID查询
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
       public List<OperationTypeMOD> FindById(int id)
       {
           sql = "SELECT * FROM OperationType where id="+id;
           return GetList(sql); 
       }
       public List<OperationTypeMOD> FindPutAll()       //查询所有入库
       {
           sql = "SELECT * FROM OperationType where operation_type LIKE('%入库')";
           return GetList(sql);
       }
       public List<OperationTypeMOD> FindOutAll()       //查询所有出库
       {
           sql = "SELECT * FROM OperationType where operation_type LIKE('%出库')";
           return GetList(sql);
       }
       private List<OperationTypeMOD> GetList(string sql,params SqlParameter[] sp)    //实体类赋值循环
       {
           list.Clear();
           DataSet ds = DBHelper.GetDataset(sql,sp);
           foreach(DataRow rows in ds.Tables[0].Rows)
           {
               OperationTypeMOD om = new OperationTypeMOD();
               om.Id= Int32.Parse(rows[0].ToString());
               om.Operation_type = rows[1].ToString();
               list.Add(om);
           }
           return list;
       }
    }
}
