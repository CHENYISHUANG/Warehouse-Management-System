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
   public class GoodsTypeDAL
   {
       private string sql;
       private DataSet ds;
       private List<GoodsTypeMOD> list = new List<GoodsTypeMOD>();
       /// <summary>
       /// 查询全部
       /// </summary>
       /// <returns></returns>
       public List<GoodsTypeMOD> FindAll()        
       {
           sql = "select * from GoodsType";
           return GetList(sql);
       }
        /// <summary>
        /// 根据ID查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
       public GoodsTypeMOD FindID(int id)   
       {
           sql = "select * from GoodsType where id=@id";
           SqlParameter sp = new SqlParameter("@id",id);
           list = GetList(sql,sp);
           if(list.Count>0)
           {
               return list[0];
           }
           return new GoodsTypeMOD();
       }
       /// <summary>
       /// 修改
       /// </summary>
       /// <param name="gtm"></param>
       public void Update(int id,string goodstype)
       {
           sql = "UPDATE GoodsType SET goods_type=@goods_type where id="+id;
           SqlParameter sp = new SqlParameter("@goods_type",goodstype);
           DBHelper.ExecuteNonQuery(sql,sp);
       }
       /// <summary>
       /// 修改
       /// </summary>
       /// <param name="gtm"></param>
       public void Update(GoodsTypeMOD gtm)
       {
           sql = "UPDATE GoodsType SET goods_type=@goods_type where id=@id";
           SqlParameter[] sp={
                              new SqlParameter("@goods_type",gtm.Goods_type),
                              new SqlParameter("@id",gtm.Id)
                             };
           DBHelper.ExecuteNonQuery(sql,sp);
       }
       /// <summary>
       /// 获取父节点
       /// </summary>
       /// <returns></returns>
       //public int GetParent(int id) 
       //{
       //    sql = "";
       //}
       /// <summary>
       /// 插入
       /// </summary>
       public void Insert(GoodsTypeMOD gtm) 
       {
           sql = "insert into GoodsType values(@goods_type,@node_parent,@node_depth)";
           SqlParameter[] sp = {
                                   new SqlParameter("@goods_type",gtm.Goods_type),
                                   new SqlParameter("@node_parent",gtm.Node_parent),
                                   new SqlParameter("@node_depth",gtm.Node_depth)
                               };
           DBHelper.ExecuteNonQuery(sql,sp);
       }
       /// <summary>
       /// 获取ID
       /// </summary>
       /// <param name="goodstype"></param>
       /// <returns></returns>
       public int GetID(string goodstype) 
       {
           sql = "select * from GoodsType where goods_type=@goodstype";
           SqlParameter sp = new SqlParameter("@goodstype",goodstype);
           list = GetList(sql, sp);
           if(list.Count>0)
           {
               return list[0].Id;
           }
           return -1;
       }
       /// <summary>
       /// 删除当前和所有子节点
       /// </summary>
       public void DeleteAll(int id)
       {
           sql = "with tab as(select id,goods_type,node_parent,node_depth from GoodsType where node_parent="+id+" union all select b.id,b.goods_type,b.node_parent,b.node_depth from tab a,GoodsType b where b.node_parent=a.id) delete from GoodsType where id in (select id from tab)";
           DBHelper.ExecuteNonQuery(sql);
           sql = "DELETE FROM GoodsType WHERE id="+id;
           DBHelper.ExecuteNonQuery(sql);
       }
       /// <summary>
       /// 删除当前子节点
       /// </summary>
       public void Delete(int id)
       {
           sql = "with tab as(select id,goods_type,node_parent,node_depth from GoodsType where node_parent=" + id + " union all select b.id,b.goods_type,b.node_parent,b.node_depth from tab a,GoodsType b where b.node_parent=a.id) UPDATE GoodsType SET node_depth=node_depth-1 where id in (select id from tab)";
           DBHelper.ExecuteNonQuery(sql);
           sql = "UPDATE GoodsType SET node_parent=0 WHERE node_parent=" + id;
           DBHelper.ExecuteNonQuery(sql);
           sql = "DELETE FROM GoodsType WHERE id=" + id;
           DBHelper.ExecuteNonQuery(sql);
       }

       private List<GoodsTypeMOD> GetList(string sql, params SqlParameter[] sp)    //Dataset赋值给实体类集合
       {
           ds = DBHelper.GetDataset(sql, sp);
           list.Clear();
           foreach (DataRow rows in ds.Tables[0].Rows)
           {
               GoodsTypeMOD gtm = new GoodsTypeMOD();
               gtm.Id = Int32.Parse(rows[0].ToString());
               gtm.Goods_type = rows[1].ToString();
               gtm.Node_parent =Int32.Parse(rows[2].ToString());
               gtm.Node_depth = Int32.Parse(rows[3].ToString());
               list.Add(gtm);
           }
           return list;
       }
    }
}
