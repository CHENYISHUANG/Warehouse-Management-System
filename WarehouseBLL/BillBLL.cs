using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseDAL;
using WarehouseMOD;
using System.Data;
namespace WarehouseBLL
{
    public class BillBLL
    {
        BillDAL bd = new BillDAL();
        /// <summary>
        /// 插入
        /// </summary>
        /// <param name="bm"></param>
        public void Insert(BillMOD bm) 
        {
            bd.Insert(bm);
        }
        /// <summary>
        /// 查找全部
        /// </summary>
        /// <returns></returns>
        public List<BillMOD> FindAll() 
        {
            return bd.FindAll(); 
        }
        /// <summary>
        /// 根据ID查找
        /// </summary>
        /// <returns></returns>
        public List<BillMOD> FindById(int id) 
        {
            return bd.FindById( id);
        }
        /// <summary>
        /// 获取dataset
        /// </summary>
        /// <param name="operation_type"></param>
        /// <returns></returns>
        public DataSet GetDataset(string operation_type) 
        {
            return bd.GetDataset("",operation_type);
        }
        /// <summary>
        /// 根据输入的条件拼凑SQL
        /// </summary>
        /// <param name="find_type"></param>
        /// <param name="find_text"></param>
        /// <param name="find_sql"></param>
        /// <param name="operation_type"></param>
        /// <returns></returns>
        public DataSet ByCondition(string find_type, string find_text, string find_sql, string operation_type)  
        {
            string sql = "";
            if (find_type == "根据物品名查询")
            {
                sql = " and g.goods_name LIKE('%" + find_text + "%')";
            }
            else if (find_type == "根据客户名查询") 
            {
                sql = " and c.client_name LIKE('%" + find_text + "%')";
            }                                                       
            else if (find_type == "根据仓库名查询")
            {
                sql = " and w.warehouse_name LIKE('%" + find_text + "%')";
            }
            else if (find_type == "根据操作方式查询")
            {
                sql = " and o.operation_type LIKE('%" + find_text + "%')";
            }
            find_sql =find_sql+sql;
            return bd.GetDataset(find_sql,operation_type);
        }
    }
}
