using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cangku_01.entity;
using MySql.Data.MySqlClient;


namespace cangku_01.MysqlConnection
{
    public class DataMysql
    {
        private static string connstr = "Server=localhost;user id=root;password=mysql;database=cangku_01;SslMode=none;charset=utf8";

        public int WriteDB(string sql)
        {
            int ret;
            MySqlConnection connection = new MySqlConnection(connstr);
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;
            try
            {
                connection.Open();
                cmd.CommandText = sql;
                ret = cmd.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                connection.Close();
                throw new Exception(e.Message);
            }
            return ret;  
        }
    }
}
