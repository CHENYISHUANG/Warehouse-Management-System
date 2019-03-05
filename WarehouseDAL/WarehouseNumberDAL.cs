using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using WarehouseMOD;

namespace WarehouseDAL
{
    public class WarehouseNumberDAL
    {
        private string sql;
        private DataSet ds;
        private List<WarehouseNumberMOD> list = new List<WarehouseNumberMOD>();
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <returns></returns>
        public List<WarehouseNumberMOD> FindAll() 
        {
            sql = "SELECT * FROM WarehouseNumber";
            return GetList(sql);
        }
        /// <summary>
        /// 根据ID查询
        /// </summary>
        /// <returns></returns>
        public List<WarehouseNumberMOD> FindById(int id)
        {
            sql = "SELECT * FROM WarehouseNumber where id="+id;
            return GetList(sql);
        }
        /// <summary>
        /// 根据名称查找
        /// </summary>
        /// <returns></returns>
        public List<WarehouseNumberMOD> FindName(string name) 
        {
            sql = "SELECT * FROM WarehouseNumber WHERE warehouse_name=@name";
            SqlParameter sp = new SqlParameter("@name",name);
            return GetList(sql,sp);
        }
        /// <summary>
        /// 插入
        /// </summary>
        public void Insert(WarehouseNumberMOD wm) 
        {
            sql = "INSERT INTO WarehouseNumber VALUES(@warehouse_name,@warehouse_position,@warehouse_note)";
            SqlParameter[] sp = {
                                    new SqlParameter("@warehouse_name",wm.Warehouse_name),
                                    new SqlParameter("@warehouse_position",wm.Warehouse_position),
                                    new SqlParameter("@warehouse_note",wm.Warehouse_note),
                                };
            DBHelper.ExecuteNonQuery(sql,sp);
        }
         /// <summary>
         /// 删除
         /// </summary>
         /// <param name="warehouse_id"></param>
        public void Delete(int warehouse_id) 
        {
            sql = "DELETE FROM WarehouseNumber WHERE id="+warehouse_id;
            DBHelper.ExecuteNonQuery(sql);
        }
        
         /// <summary>
         /// 修改
         /// </summary>
         /// <param name="wm"></param>
         /// <returns></returns>
        public int Update(WarehouseNumberMOD wm) 
        {
            sql = "UPDATE WarehouseNumber SET warehouse_name=@warehouse_name,warehouse_position=@warehouse_position,warehouse_note=@warehouse_note WHERE id=@id";
            SqlParameter[] sp = {
                                    new SqlParameter("@id",wm.Id),
                                    new SqlParameter("@warehouse_name",wm.Warehouse_name),
                                    new SqlParameter("@warehouse_note",wm.Warehouse_note),
                                    new SqlParameter("@warehouse_position",wm.Warehouse_position)
                                };
           return DBHelper.ExecuteNonQuery(sql,sp);
        } 
        
        /// <summary>
        /// 获取list集合
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="sp"></param>
        /// <returns></returns>
        private List<WarehouseNumberMOD> GetList(string sql, params SqlParameter[] sp)    //Dataset赋值给实体类集合
        {
            list.Clear();
            ds = DBHelper.GetDataset(sql, sp);
            foreach (DataRow rows in ds.Tables[0].Rows)
            {
                WarehouseNumberMOD wnm = new WarehouseNumberMOD();
                wnm.Id = Int32.Parse(rows[0].ToString());
                wnm.Warehouse_name = rows[1].ToString();
                wnm.Warehouse_position = rows[2].ToString();
                wnm.Warehouse_note = rows[3].ToString();
                list.Add(wnm);
            }
            return list;
        }
    }
}
