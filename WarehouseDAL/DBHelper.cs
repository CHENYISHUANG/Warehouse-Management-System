using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WarehouseDAL
{
    public class DBHelper
    {
        private static string Connection = "Data Source=.;Initial Catalog=Warehouse;Integrated Security=True";
        public static DataSet GetDataset(string sql,params SqlParameter[] sp)      //获取Dataset
        {
            using (SqlConnection conn = new SqlConnection(Connection)) 
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sql,conn);
                if(sp!=null)
                {
                    sda.SelectCommand.Parameters.AddRange(sp);
                }
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return ds;
            }
        }

        public static int ExecuteNonQuery(string sql, params SqlParameter[] sp)      //执行SQL语句方法
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                if (sp != null)
                {
                    sda.SelectCommand.Parameters.AddRange(sp);
                }
                return sda.SelectCommand.ExecuteNonQuery();
            }
        }
    }
}
