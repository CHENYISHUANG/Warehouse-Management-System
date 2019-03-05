using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseDAL;
using WarehouseMOD;
using System.Data;
using System.Data.SqlClient;

namespace WarehouseDAL
{
   public class ManagerDAL
    {
        private string sql;                  
        private DataSet ds;                 
        private List<ManagerMOD> list=new List<ManagerMOD>();
       /// <summary>
       /// 根据名字查询
       /// </summary>
       /// <param name="name"></param>
       /// <returns></returns>
        public List<ManagerMOD> FindName(string name)              //根据用户名查询
        {
            sql = "select * from Manager where manager_username=@name";
            SqlParameter sp = new SqlParameter("@name",name);
            return GetList(sql,sp);
        }
       /// <summary>
       /// 查询所有
       /// </summary>
       /// <returns></returns>
        public List<ManagerMOD> FindAll() 
        {
            sql = "select * from Manager";
            return GetList(sql);
        }
       /// <summary>
       /// 根据ID查询
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
        public List<ManagerMOD> FindId(int id)
        {
            sql = "select * from Manager where id="+id;
            return GetList(sql);
        }
        public int Delete(int id) 
        {
            sql = "DELETE FROM Manager WHERE id="+id;
            return DBHelper.ExecuteNonQuery(sql);
        }
       /// <summary>
       /// 根据用户名查找
       /// </summary>
       /// <param name="UserName"></param>
       /// <returns></returns>
        public List<ManagerMOD> FindUserName(string UserName)
        {
            sql = "select * from Manager where manager_username='" + UserName+"'";
            return GetList(sql);
        }
       /// <summary>
       /// 添加数据
       /// </summary>
       /// <param name="mm"></param>
        public void Insert(ManagerMOD mm)
        {
            sql = "insert into Manager values(@manager_username,@manager_password,@manager_name)";
            SqlParameter[] sp = {
                                    new SqlParameter("@manager_username",mm.Manager_username),
                                    new SqlParameter("@manager_password",mm.Manager_password),
                                    new SqlParameter("@manager_name",mm.Manager_name)
                                };
            DBHelper.ExecuteNonQuery(sql,sp);
        }
       /// <summary>
       /// 修改
       /// </summary>
       /// <param name="mm"></param>
        public int Update(ManagerMOD mm) 
        {
            sql = " UPDATE Manager SET manager_username=@manager_username,manager_password=@manager_password,manager_name=@manager_name where id=@id";
            SqlParameter[] sp = {
                                    new SqlParameter("@id",mm.Id),
                                    new SqlParameter("@manager_name",mm.Manager_name),
                                    new SqlParameter("@manager_password",mm.Manager_password),
                                    new SqlParameter("@manager_username",mm.Manager_username)
                                };
           return DBHelper.ExecuteNonQuery(sql,sp);
        }
       /// <summary>
       /// 获取List集合
       /// </summary>
       /// <param name="sql"></param>
       /// <param name="sp"></param>
       /// <returns></returns>
        private List<ManagerMOD> GetList(string sql,params SqlParameter[] sp)    //Dataset赋值给实体类集合
        {
            ds = DBHelper.GetDataset(sql,sp);
            list.Clear();
            foreach(DataRow rows in ds.Tables[0].Rows)
            {
                ManagerMOD mm = new ManagerMOD();
                mm.Id =Int32.Parse(rows[0].ToString());            
                mm.Manager_username = rows[1].ToString();         
                mm.Manager_password = rows[2].ToString();
                mm.Manager_name = rows[3].ToString();
                list.Add(mm);
            }
            return list;
        }
    }
}
