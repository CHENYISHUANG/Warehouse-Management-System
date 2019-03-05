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
    public class InventoryDAL
    {
        private string sql;
        private DataSet ds;
        private List<InventoryMOD> list = new List<InventoryMOD>();
        /// <summary>
        /// 根据仓库ID获取库存信息
        /// </summary>
        /// <param name="id">仓库ID</param>
        /// <returns></returns>
        public DataSet GetAllById(int id) 
        {
            sql = "SELECT i.id as '编号',w.warehouse_name as '仓库',g.goods_name as '物品名',i.goods_amount as '物品数量',i.goods_total as '物品总价' FROM Inventory as i LEFT JOIN WarehouseNumber as w ON i.warehouse_id=w.id LEFT JOIN Goods AS g ON i.goods_id=g.id LEFT JOIN Client as c ON i.client_id=c.id WHERE i.warehouse_id=" + id;
            return DBHelper.GetDataset(sql);
        }
        /// <summary>
        /// 根据用户选择的条件查询
        /// </summary>
        /// <returns></returns>
        public DataSet ByCondition(string find_type,string find_name) 
        {
            sql = "SELECT i.id as '编号',w.warehouse_name as '仓库',g.goods_name as '物品名',c.client_name as '客户名',i.goods_amount as '物品数量', i.goods_total as '物品总价' FROM Inventory as i LEFT JOIN WarehouseNumber as w ON i.warehouse_id=w.id LEFT JOIN Goods AS g ON i.goods_id=g.id LEFT JOIN Client as c ON i.client_id=c.id"+find_type+find_name;
            return DBHelper.GetDataset(sql);
        }
        public void Delete(int warehouse_id) 
        {
            sql = "DELETE FROM Inventory WHERE warehouse_id=" + warehouse_id;
            DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 根据物品ID，客户ID，仓库ID查找
        /// </summary>
        /// <param name="goods_id">物品ID</param>
        /// <param name="warehouse_id">仓库ID</param>
        /// <returns></returns>
        public List<InventoryMOD> FindId(int goods_id, int warehouse_id,int client_id)
        {
            sql = "SELECT * FROM Inventory where goods_id=@goods_id and warehouse_id=@warehouse_id and client_id=@client_id";
            SqlParameter[] sp = { 
                                new SqlParameter("@goods_id", goods_id) ,
                                new SqlParameter("@warehouse_id",warehouse_id),
                                new SqlParameter("@client_id",client_id)
                                };
            return GetList(sql, sp);
        }
        /// <summary>
        /// 根据ID查找
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<InventoryMOD> FindId(int id)
        {
            sql = "SELECT * FROM Inventory where id=@id";
            SqlParameter sp = new SqlParameter("@id", id); 
            return GetList(sql, sp);
        }
        /// <summary>
        /// 根据仓库ID查询
        /// </summary>
        /// <param name="warehouse_id">仓库ID</param>
        /// <returns></returns>
        public List<InventoryMOD> FindWarehouseId(int warehouse_id) 
        {
            sql = "SELECT * FROM Inventory where warehouse_id="+warehouse_id;
            return GetList(sql);
        } 
        /// <summary>
        /// 插入库存
        /// </summary>
        /// <param name="im"></param>
        public void Insert(InventoryMOD im)
        {
            sql = "INSERT INTO Inventory VALUES(@Warehouse_id,@Goods_id,@Client_id,@Goods_amount,@Goods_total)";
            SqlParameter[] sp = {
                                new SqlParameter("@Warehouse_id",im.Warehouse_id),
                                new SqlParameter("@Goods_id",im.Goods_id),
                                new SqlParameter("@Client_id",im.Client_id),
                                new SqlParameter("@Goods_amount",im.Goods_amount),
                                new SqlParameter("@Goods_total",im.Goods_total),
                                };
            DBHelper.ExecuteNonQuery(sql,sp);
        }

        public DataSet FindAll() 
        {
            sql = "SELECT i.id as '编号',w.warehouse_name as '仓库',g.goods_name as '物品名',c.client_name as '客户名',i.goods_amount as '物品数量', i.goods_total as '物品总价' FROM Inventory as i LEFT JOIN WarehouseNumber as w ON i.warehouse_id=w.id LEFT JOIN Goods AS g ON i.goods_id=g.id LEFT JOIN Client as c ON i.client_id=c.id";
            return DBHelper.GetDataset(sql);
        }
        /// <summary>
        /// 修改库存
        /// </summary>
        /// <param name="im"></param>
        /// <param name="Goods_amount"></param>
        /// <param name="Goods_total"></param>
        public void Update(InventoryMOD im, int Goods_amount, double Goods_total) 
        {
            sql = "UPDATE Inventory SET goods_amount=goods_amount+@Goods_amount ,goods_total=goods_total+@Goods_total where id=@id";
            SqlParameter[] sp = {
                                new SqlParameter("@id",im.Id),
                                new SqlParameter("@Goods_amount",Goods_amount),
                                new SqlParameter("@Goods_total",Goods_total),
                                };
            DBHelper.ExecuteNonQuery(sql, sp);
        }
        /// <summary>
        /// 修改库存重载
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Goods_amount"></param>
        /// <param name="Goods_total"></param>
        public void Update(int id, int Goods_amount, double Goods_total)
        {
            sql = "UPDATE Inventory SET goods_amount=goods_amount-@Goods_amount ,goods_total=goods_total-@Goods_total where id=@id";
            SqlParameter[] sp = {
                                new SqlParameter("@id",id),
                                new SqlParameter("@Goods_amount",Goods_amount),
                                new SqlParameter("@Goods_total",Goods_total),
                                };
            DBHelper.ExecuteNonQuery(sql, sp);
        }
        /// <summary>
        /// 获取单价
        /// </summary>
        /// <param name="goods_id">物品ID</param>
        /// <returns></returns>
        public double GetPrice(int goods_id)
        {
            sql = "SELECT * FROM Inventory WHERE id="+goods_id;
            ds = DBHelper.GetDataset(sql);
            return double.Parse(ds.Tables[0].Rows[0][5].ToString()) / double.Parse(ds.Tables[0].Rows[0][4].ToString());
        }
        /// <summary>
        /// 转仓
        /// </summary>
        /// <param name="warehouse_id1"></param>
        /// <param name="warehouse_id2"></param>
        public void Transfer(int warehouse_id1, int warehouse_id2)
        {
            //查询两个仓库想同的物品和客户
            sql = "SELECT * FROM Inventory WHERE warehouse_id=" + warehouse_id1 + " AND (goods_id in(SELECT Inventory.goods_id FROM Inventory WHERE warehouse_id=" + warehouse_id2 + "))and client_id IN(SELECT client_id from Inventory WHERE warehouse_id=" + warehouse_id2 + ")";
            list = GetList(sql);
            if(list.Count>0)
            {
                //遍历list 并把第一个仓库的数据转移到第二个仓库
                foreach (InventoryMOD im in list)
                {
                    sql = "UPDATE Inventory SET goods_amount=goods_amount+@Goods_amount ,goods_total=goods_total+@Goods_total where warehouse_id=@Warehouse_id and goods_id=@Goods_id and client_id=@Client_id";
                    SqlParameter[] sp = {
                                new SqlParameter("@Warehouse_id",warehouse_id2),
                                new SqlParameter("@Goods_id",im.Goods_id),
                                new SqlParameter("@Client_id",im.Client_id),
                                new SqlParameter("@Goods_amount",im.Goods_amount),
                                new SqlParameter("@Goods_total",im.Goods_total),
                                };
                    DBHelper.ExecuteNonQuery(sql,sp);
                }
                //删除转移后的第一个仓库
                sql = "DELETE FROM Inventory WHERE warehouse_id=" + warehouse_id1 + " AND (goods_id in(SELECT Inventory.goods_id FROM Inventory WHERE warehouse_id=" + warehouse_id2 + "))and client_id IN(SELECT client_id from Inventory WHERE warehouse_id=" + warehouse_id2 + ")";
                DBHelper.ExecuteNonQuery(sql);
            }
            //把第一个仓库改为第二个仓库
            sql = "UPDATE Inventory SET warehouse_id= " + warehouse_id2 + " WHERE warehouse_id=" + warehouse_id1;
            DBHelper.ExecuteNonQuery(sql);
            //删除第一个仓库（再次过滤）
            sql = "DELETE FROM Inventory WHERE warehouse_id=" + warehouse_id1;
            DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 获取list集合
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="sp"></param>
        /// <returns></returns>
        private List<InventoryMOD> GetList(string sql, params SqlParameter[] sp)    //Dataset赋值给实体类集合
        {
            ds = DBHelper.GetDataset(sql, sp);
            list.Clear();
            foreach (DataRow rows in ds.Tables[0].Rows)
            {
                InventoryMOD im = new InventoryMOD();
                im.Id = Int32.Parse(rows[0].ToString());
                im.Warehouse_id = Int32.Parse(rows[1].ToString());
                im.Goods_id = Int32.Parse(rows[2].ToString());
                im.Client_id = Int32.Parse(rows[3].ToString());
                im.Goods_amount = Int32.Parse(rows[4].ToString());
                im.Goods_total = double.Parse(rows[5].ToString());
                list.Add(im);
            }
            return list;
        }
    }
}
