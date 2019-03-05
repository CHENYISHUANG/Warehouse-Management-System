using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseMOD;
using WarehouseDAL;

namespace WarehouseBLL
{
    public class ClientBLL
    {
        ClientDAL cd = new ClientDAL();
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <returns></returns>
        public List<ClientMOD> FindAll() 
        {
            return cd.FindAll();
        }
        /// <summary>
        /// 根据ID查询
        /// </summary>
        /// <returns></returns>
        public List<ClientMOD> FindId(int id) 
        {
            return cd.FindId(id);
        }
        /// <summary>
        /// 更改
        /// </summary>
        /// <param name="cm"></param>
        public void Update(ClientMOD cm) 
        {
             cd.Update(cm);
        }
        /// <summary>
        /// 插入
        /// </summary>
        /// <param name="cm"></param>
        public void Insert(ClientMOD cm) 
        {
            cd.Insert(cm);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            cd.Delete(id);
        }
    }
}
