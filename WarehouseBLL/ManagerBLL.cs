using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseDAL;
using WarehouseMOD;

namespace WarehouseBLL
{
   public class ManagerBLL
    {
       ManagerDAL md=new ManagerDAL();
       /// <summary>
       /// 根据名字查询
       /// </summary>
       /// <param name="name"></param>
       /// <returns></returns>
       public List<ManagerMOD> FindName(string name) 
       {
           return md.FindName(name);
       }
       /// <summary>
       /// 查询全部
       /// </summary>
       /// <returns></returns>
       public List<ManagerMOD> FindAll() 
       {
           return md.FindAll();
       }
       /// <summary>
       /// 根据ID查询
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
       public List<ManagerMOD> FindId(int id) 
       {
           return md.FindId(id);
       }
       /// <summary>
       /// 修改
       /// </summary>
       /// <param name="mm"></param>
       public int Update(ManagerMOD mm)
       {
           return md.Update(mm);
       }
       /// <summary>
       /// 删除
       /// </summary>
       /// <param name="mm"></param>
       public int Delete(int id) 
       {
           return md.Delete(id); 
       }
       /// <summary>
       /// 插入数据
       /// </summary>
       public void Insert(ManagerMOD mm) 
       {
           md.Insert(mm);
       }
       /// <summary>
       /// 根据用户名查找
       /// </summary>
       /// <param name="UserName"></param>
       public List<ManagerMOD> FindUserName(string UserName)
       {
           return md.FindUserName(UserName);
       }
    }
}
