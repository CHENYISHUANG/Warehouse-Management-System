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
    public class ClientDAL
    {
        private string sql;
        private DataSet ds;
        private List<ClientMOD> list = new List<ClientMOD>();
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <returns></returns>
        public List<ClientMOD> FindAll()
        {
            sql = "SELECT * FROM Client";
            return GetList(sql);
        }
        /// <summary>
        /// 根据ID查询
        /// </summary>
        /// <returns></returns>
        public List<ClientMOD> FindId(int id)
        {
            sql = "SELECT * FROM Client WHERE id="+id;
            return GetList(sql);
        }
        /// <summary>
        /// 更改
        /// </summary>
        /// <param name="cm"></param>
        public void Update(ClientMOD cm)
        {
            sql = "UPDATE Client SET client_name=@client_name,client_address=@client_address,client_contacts=@client_contacts,client_phone=@client_phone,client_note=@client_note where id=@id";
            SqlParameter[] sp = {
                                    new SqlParameter("@id",cm.Id),
                                    new SqlParameter("@client_name",cm.Client_name),
                                    new SqlParameter("@client_address",cm.Client_address),
                                    new SqlParameter("@client_contacts",cm.Client_contacts),
                                    new SqlParameter("@client_phone",cm.Client_phone),
                                    new SqlParameter("@client_note",cm.Client_note)
                                };
            DBHelper.ExecuteNonQuery(sql,sp);
        }
        /// <summary>
        /// 插入
        /// </summary>
        /// <param name="cm"></param>
        public void Insert(ClientMOD cm)
        {
            sql = "INSERT INTO Client VALUES(@client_name,@client_address,@client_contacts,@client_phone,@client_note)"; 
            SqlParameter[] sp = {
                                    new SqlParameter("@client_name",cm.Client_name),
                                    new SqlParameter("@client_address",cm.Client_address),
                                    new SqlParameter("@client_contacts",cm.Client_contacts),
                                    new SqlParameter("@client_phone",cm.Client_phone),
                                    new SqlParameter("@client_note",cm.Client_note)
                                };
            DBHelper.ExecuteNonQuery(sql, sp);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            sql = " DELETE FROM Client WHERE id="+id;
            DBHelper.ExecuteNonQuery(sql);
        }
        private List<ClientMOD> GetList(string sql, params SqlParameter[] sp)    //Dataset赋值给实体类集合
        {
            ds = DBHelper.GetDataset(sql, sp);
            list.Clear();
            foreach (DataRow rows in ds.Tables[0].Rows)
            {
                ClientMOD cm = new ClientMOD();
                cm.Id = Int32.Parse(rows[0].ToString());
                cm.Client_name = rows[1].ToString();
                cm.Client_address = rows[2].ToString();
                cm.Client_contacts = rows[3].ToString();
                cm.Client_phone = rows[4].ToString();
                cm.Client_note = rows[5].ToString();
                list.Add(cm);
            }
            return list;
        }
    }
}
