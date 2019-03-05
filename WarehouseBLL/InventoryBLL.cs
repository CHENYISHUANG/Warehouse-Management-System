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
    public class InventoryBLL
    {
        InventoryDAL id = new InventoryDAL();
        InventoryMOD im = new InventoryMOD();
        List<InventoryMOD> listi = new List<InventoryMOD>();
        /// <summary>
        /// 插入库存
        /// </summary>
        /// <param name="im"></param>
        public void Insert(InventoryMOD im)                                            
        {
            id.Insert(im);
        }
        /// <summary>
        /// 查询全部库存
        /// </summary>
        /// <returns></returns>
        public DataSet FindAll()                                                         
        {
            return id.FindAll();
        }
        /// <summary>
        /// 根据物品ID，仓库ID，客户ID查询库存
        /// </summary>
        /// <param name="goods_id"></param>
        /// <param name="warehouse_id"></param>
        /// <param name="client_id"></param>
        /// <returns></returns>
        public List<InventoryMOD> FindId(int goods_id, int warehouse_id,int client_id)  
        {
           return id.FindId(goods_id,warehouse_id,client_id);
        }
        /// <summary>
        /// 根据ID查询库存
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<InventoryMOD> FindId(int inventoryid) 
        {
            return id.FindId(inventoryid);
        }
        /// <summary>
        /// 修改库存
        /// </summary>
        /// <param name="im"></param>
        /// <param name="Goods_amount"></param>
        /// <param name="Goods_total"></param>
        public void Update(InventoryMOD im, int Goods_amount, double Goods_total)   
        {
            id.Update(im,Goods_amount,Goods_total);
        }
        /// <summary>
        /// 修改库存
        /// </summary>
        /// <param name="goods_id"></param>
        /// <param name="Goods_amount"></param>
        /// <param name="Goods_total"></param>
        public void Update(int goods_id, int Goods_amount, double Goods_total)    
        {
            id.Update(goods_id, Goods_amount, Goods_total);
        }
        /// <summary>
        /// 根据仓库ID获取库存信息
        /// </summary>
        /// <param name="warehouse_id"></param>
        /// <returns></returns>
        public DataSet GetAllById(int warehouse_id)                        
        {
            return id.GetAllById(warehouse_id);
        }
        /// <summary>
        /// 根据仓库ID查询
        /// </summary>
        /// <param name="warehouse_id"></param>
        /// <returns></returns>
        public List<InventoryMOD> FindWarehouseId(int warehouse_id) 
        {
            return id.FindWarehouseId(warehouse_id);
        }
        /// <summary>
        /// 根据输入条件查询
        /// </summary>
        /// <param name="find_type"></param>
        /// <param name="find_name"></param>
        /// <returns></returns>
        public DataSet ByCondition(string find_type, string find_name)    
        {
            find_type = " where " + find_type;
            return id.ByCondition(find_type,find_name);
        }
        /// <summary>
        /// 获取单价
        /// </summary>
        /// <param name="goods_id"></param>
        /// <returns></returns>
        public double GetPrice(int goods_id)                    
        {
            return id.GetPrice(goods_id);
        }
        /// <summary>
        /// 删除库存
        /// </summary>
        /// <param name="warehouse_id"></param>
        public void Delete(int warehouse_id)                      
        {
            id.Delete(warehouse_id);
        }
        /// <summary>
        /// 转仓
        /// </summary>
        /// <param name="warehouse_id1"></param>
        /// <param name="warehouse_id2"></param>
        public void Transfer(int warehouse_id1, int warehouse_id2) 
        {
            id.Transfer(warehouse_id1, warehouse_id2);
        }
        /// <summary>
        /// 转仓
        /// </summary>
        /// <param name="warehouse_id1"></param>
        /// <param name="warehouse_id2"></param>
        /// <param name="list"></param>
        /// <param name="goods_amount"></param>
        public bool Transfer(int warehouse_id1, int warehouse_id2,List<string> list,int goods_amount)  
        {   
            double price;
            foreach(string item in list)
            {
                im = id.FindId(Int32.Parse(item))[0];                               //根据ID准确查询
                if (im.Goods_amount < goods_amount)                                 //判断用户输入数量是否超出仓库所有数量
                {
                    return false;
                }
                price = id.GetPrice(Int32.Parse(item));                             //通过ID获取单价
                Update(Int32.Parse(item), goods_amount,goods_amount*price);         //把第一个仓库的数据减少
                listi = id.FindId(im.Goods_id, warehouse_id2, im.Client_id);            //根据查询出来的结果查询第二个仓库
                if (listi.Count > 0)                                                //如果第二个仓库有和第一个仓库一样的物品并且是一个客户
                {
                    im = listi[0];
                    id.Update(im, goods_amount, goods_amount * price);              //把数据添加到第二个仓库
                }
                else 
                {
                    im.Warehouse_id = warehouse_id2;                                //把第二个仓库的ID给im
                    im.Goods_amount = goods_amount;                                 //物品数量给IM
                    im.Goods_total = goods_amount * price;                          //物品总价给im
                    id.Insert(im);                                                  //添加到数据库
                }
            }
            return true;
        }
    }
}
