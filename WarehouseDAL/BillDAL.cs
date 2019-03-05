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
    public class BillDAL
    {
        string sql;
        List<BillMOD> list=new List<BillMOD>();
        DataSet ds;
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="bm"></param>
        public void Insert(BillMOD bm)              
        {
            sql = "insert into Bill values(@goods_id,@goods_amount,@goods_price,@manufacture_date,@expiration_date,@operation_type_id,@warehouse_id,@lot_number,@client_id,@operation_time,@manager_id,@bill_note)";
            SqlParameter[] sp = {
                                    new SqlParameter("@goods_id",bm.Goods_id),
                                    new SqlParameter("@goods_amount",bm.Goods_amount),
                                    new SqlParameter("@goods_price",bm.Goods_price),
                                    new SqlParameter("@manufacture_date",bm.Manufacture_date),
                                    new SqlParameter("@expiration_date",bm.Expiration_date),
                                    new SqlParameter("@operation_type_id",bm.Operation_type_id),
                                    new SqlParameter("@warehouse_id",bm.Warehouse_id),
                                    new SqlParameter("@lot_number",bm.Lot_number),
                                    new SqlParameter("@client_id",bm.Client_id),
                                    new SqlParameter("@operation_time",bm.Operation_time),
                                    new SqlParameter("@manager_id",bm.Manager_id),
                                    new SqlParameter("@bill_note",bm.Bill_note),
                                };
            DBHelper.ExecuteNonQuery(sql,sp);
        }
        /// <summary>
        /// 根据ID查找
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<BillMOD> FindById(int id) 
        {
            sql = "SELECT * FROM Bill where id=" + id;
            return GetList(sql);
        }
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <returns></returns>
        public List<BillMOD> FindAll() 
        {
            sql = "SELECT * FROM Bill";
            return GetList(sql);
        }
        /// <summary>
        /// 获取dataset
        /// </summary>
        /// <param name="find_sql"></param>
        /// <returns></returns>
        public DataSet GetDataset(string find_sql,string find_type) 
        {
            sql = "select b.id as '编号',g.goods_name as '物品名称',b.goods_amount as '物品数量',b.goods_price as '物品价格',b.manufacture_date as '生产日期',b.expiration_date as '过期日期',o.operation_type as'操作方式',w.warehouse_name as '仓库',b.lot_number as '批号',c.client_name as '客户名称',b.operation_time as'操作时间',m.manager_name as '管理员',b.bill_note as'备注' FROM Bill as b LEFT JOIN Goods as g on b.goods_id=g.id LEFT JOIN OperationType as o ON b.operation_type_id=o.id LEFT JOIN Client AS c ON b.client_id=c.id LEFT JOIN WarehouseNumber as w ON b.warehouse_id=w.id LEFT JOIN Manager as m on b.manager_id=m.id" + find_type + find_sql;
            return DBHelper.GetDataset(sql);
        }
        private List<BillMOD> GetList(string sql, params SqlParameter[] sp)    //Dataset赋值给实体类集合
        {
            ds = DBHelper.GetDataset(sql, sp);
            list.Clear();
            foreach (DataRow rows in ds.Tables[0].Rows)
            {
                BillMOD bm = new BillMOD();
                bm.Id = Int32.Parse(rows[0].ToString());
                bm.Goods_id = Int32.Parse(rows[1].ToString());
                bm.Goods_amount = Int32.Parse(rows[2].ToString());
                bm.Goods_price = double.Parse(rows[3].ToString());
                bm.Manufacture_date = rows[4].ToString();
                bm.Expiration_date = rows[5].ToString();
                bm.Operation_type_id = Int32.Parse(rows[6].ToString());
                bm.Warehouse_id = Int32.Parse(rows[7].ToString());
                bm.Lot_number = rows[8].ToString();
                bm.Client_id = Int32.Parse(rows[9].ToString());
                bm.Operation_time = rows[10].ToString();
                bm.Manager_id = Int32.Parse(rows[11].ToString());
                bm.Bill_note = rows[12].ToString();
                list.Add(bm);
            }
            return list;
        }

       
    }
}
