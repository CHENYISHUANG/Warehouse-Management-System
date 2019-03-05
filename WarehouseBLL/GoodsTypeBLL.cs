using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseDAL;
using WarehouseMOD;

namespace WarehouseBLL
{
   public class GoodsTypeBLL
    {
       GoodsTypeDAL gtd = new GoodsTypeDAL();
       /// <summary>
       /// 查询全部
       /// </summary>
       /// <returns></returns>
       public List<GoodsTypeMOD> FindAll() 
       {
           return gtd.FindAll();
       }
       /// <summary>
       /// 根据ID查询
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
       public GoodsTypeMOD FindID(int id) 
       {
           return gtd.FindID(id);
       }
       /// <summary>
       /// 修改
       /// </summary>
       /// <param name="gtm"></param>
       public void Update(GoodsTypeMOD gtm) 
       {
           gtd.Update(gtm);
       }
       /// <summary>
       /// 修改
       /// </summary>
       /// <param name="gtm"></param>
       public void Update(int id,string goods_type)
       {
           gtd.Update(id,goods_type);
       }
       /// <summary>
       /// 插入
       /// </summary>
       /// <param name="gtm"></param>
       public void Insert(GoodsTypeMOD gtm) 
       {
           gtd.Insert(gtm);
       }
       /// <summary>
       /// 删除当前和所有子节点
       /// </summary>
       public void DeleteAll(int id)
       {
           gtd.DeleteAll(id);
       }
       /// <summary>
       /// 删除当前子节点
       /// </summary>
       public void Delete(int id)
       {
           gtd.Delete(id);
       }
    }
}
