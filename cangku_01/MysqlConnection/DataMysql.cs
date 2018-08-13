using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cangku_01.entity;
using MySql.Data.MySqlClient;

//数据库连接（懒汉模式）

namespace cangku_01.MysqlConnection
{
    public class DataMysql
    {
        private static string connstr = "Server=localhost;user id=root;password=mysql;database=cangku_01;SslMode=none;charset=utf8";

        private DataMysql() { }

        private static DataMysql dbo = null;

        private static readonly object obj = new object();

        public static DataMysql GetDataMysql()
        {
            if (dbo == null)
            {
                lock (obj)
                {
                    if (dbo == null)
                    {
                        dbo = new DataMysql();
                    }
                 }
            }
            return dbo;
        }
        //对数据库进行写入操作
        public int WriteDB(string sql)
        {
            int ret;
            MySqlConnection connection = new MySqlConnection(connstr);
            MySqlCommand cmd = connection.CreateCommand();
            try
            {
                connection.Open();
                cmd.CommandText = sql;
                ret = cmd.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return ret;  
        }

        //对数据库进行读取操作
        public DataSet ReadDB(string sql)
        {
            DataSet ds = new DataSet();
            MySqlConnection connection = new MySqlConnection(connstr);
            try
            {
                connection.Open();
                MySqlDataAdapter ad = new MySqlDataAdapter(sql,connection);
                ad.Fill(ds);
                
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return ds;
        }

        //返回表的第一行第一列的id
        public int FirstValue(string sql)
        {
            int Id = 0;
            MySqlConnection connection = new MySqlConnection(connstr);
            MySqlCommand cmd = connection.CreateCommand();
            try
            {
                connection.Open();
                cmd.CommandText = sql;
                Id = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return Id;
        }

        //返回DataTable
        public DataTable ReadDBDataTable(string sql)
        {
            DataTable dt = new DataTable();
            MySqlConnection connection = new MySqlConnection(connstr);
            MySqlCommand cmd = connection.CreateCommand();
            try
            {
                connection.Open();
                MySqlDataAdapter ad = new MySqlDataAdapter(sql, connection);
                ad.Fill(dt);
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
    }
}
