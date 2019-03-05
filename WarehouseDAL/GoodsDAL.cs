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
    public class GoodsDAL
    {
        private string sql;
        private DataSet ds;
        private List<GoodsMOD> list = new List<GoodsMOD>();
        /// <summary>
        /// 模糊查询
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public List<GoodsMOD> FindLike(string text)                            //根据text模糊查询
        {
            text += "%";
            sql = "SELECT * FROM Goods WHERE goods_name LIKE(@text)";
            SqlParameter sp = new SqlParameter("@text",text);
            return GetList(sql, sp);
        }

        public List<GoodsMOD> FindAll() 
        {
            sql = "select * from Goods";
            return GetList(sql);
        }
         /// <summary>
         /// 插入
         /// </summary>
         /// <param name="gm"></param>
        public void Insert(GoodsMOD gm) 
        {
            sql = "insert into Goods values(@goods_name,@goods_type_id,@goods_code,@specifications,@goods_wight,@goods_volume,@goods_note)";
            SqlParameter[] sp = {
                                    new SqlParameter("@goods_name",gm.Goods_name),
                                     new SqlParameter("@goods_type_id",gm.Goods_type_id),
                                     new SqlParameter("@goods_code",gm.Goods_code),
                                     new SqlParameter("@specifications",gm.Specifications),
                                     new SqlParameter("@goods_wight",gm.Goods_wight),
                                     new SqlParameter("@goods_volume",gm.Goods_volume),
                                     new SqlParameter("@goods_note",gm.Goods_note),
                                };
            DBHelper.ExecuteNonQuery(sql,sp);
        }
        public int GetId(GoodsMOD gm) 
        {
            sql = "select * from Goods where goods_name=@goods_name and goods_type_id=@goods_type_id and goods_code=@goods_code and specifications=@specifications and goods_wight=@goods_wight and goods_volume=@goods_volume and goods_note=@goods_note";
            SqlParameter[] sp = {
                                     new SqlParameter("@goods_name",gm.Goods_name),
                                     new SqlParameter("@goods_type_id",gm.Goods_type_id),
                                     new SqlParameter("@goods_code",gm.Goods_code),
                                     new SqlParameter("@specifications",gm.Specifications),
                                     new SqlParameter("@goods_wight",gm.Goods_wight),
                                     new SqlParameter("@goods_volume",gm.Goods_volume),
                                     new SqlParameter("@goods_note",gm.Goods_note),
                                };
            list = GetList(sql, sp);
            if (list.Count > 0)
            {
                return list[0].Id;
            }
            return -1;
        }
        public List<GoodsMOD> FindAllCondition(GoodsMOD gm) 
        {
            sql = "select * from Goods where goods_name=@goods_name and goods_type_id=@goods_type_id and goods_code=@goods_code and specifications=@specifications and goods_wight=@goods_wight and goods_volume=@goods_volume and goods_note=@goods_note";
            SqlParameter[] sp = {
                                    new SqlParameter("@goods_name",gm.Goods_name),
                                     new SqlParameter("@goods_type_id",gm.Goods_type_id),
                                     new SqlParameter("@goods_code",gm.Goods_code),
                                     new SqlParameter("@specifications",gm.Specifications),
                                     new SqlParameter("@goods_wight",gm.Goods_wight),
                                     new SqlParameter("@goods_volume",gm.Goods_volume),
                                     new SqlParameter("@goods_note",gm.Goods_note),
                                };
             return GetList(sql, sp);
        }
        /// <summary>
        /// 根据物品ID查找
        /// </summary>
        /// <param name="id">物品ID</param>
        /// <returns></returns>
        public List<GoodsMOD> ById(int id)
        {
            sql = "SELECT * FROM Goods WHERE id="+id;
            return GetList(sql);
        }
        private List<GoodsMOD> GetList(string sql, params SqlParameter[] sp)    //Dataset赋值给实体类集合
        {
            ds = DBHelper.GetDataset(sql, sp);
            list.Clear();
            foreach (DataRow rows in ds.Tables[0].Rows)
            {
                GoodsMOD gm = new GoodsMOD();
                gm.Id = Int32.Parse(rows[0].ToString());
                gm.Goods_name = rows[1].ToString();
                gm.Goods_type_id = Int32.Parse(rows[2].ToString());
                gm.Goods_code = rows[3].ToString();
                gm.Specifications = rows[4].ToString();
                gm.Goods_wight = rows[5].ToString();
                gm.Goods_volume = rows[6].ToString();
                gm.Goods_note = rows[7].ToString();
                list.Add(gm);
            }
            return list;
        }
    }
}
