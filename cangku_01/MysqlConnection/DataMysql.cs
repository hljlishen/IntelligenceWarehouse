using MySql.Data.MySqlClient;
using System;
using System.Data;

//数据库连接（懒汉模式）

namespace cangku_01.MysqlConnection
{
    public class DataMysql:IDisposable
    {
        public static string mysqldefaultconnection = "Server=localhost;user id=root;password=mysql;database=cangku_01;SslMode=none;charset=utf8";
        MySqlConnection connection;

        private DataMysql(string databasedefaultconnection)
        {
            connection = new MySqlConnection(databasedefaultconnection);
            connection.Open();
        }

        private static DataMysql dbo = null;

        private static readonly object obj = new object();

        //判断是否实例
        public static DataMysql GetDataMysqlGreateInstance(string databasedefaultconnection)
        {
            if (dbo == null)
            {
                lock (obj)
                {
                    if (dbo == null)
                    {
                        dbo = new DataMysql(databasedefaultconnection);
                    }
                 }
            }
            return dbo;
        }

        //对数据库进行写入操作
        public void WriteDB(string sql)
        {
            int ret;
            MySqlCommand cmd = dbo.connection.CreateCommand();
            cmd.CommandText = sql;
            ret = cmd.ExecuteNonQuery();
            if(ret == 0)
            {
                throw new Exception($"插入失败，执行的语句是{sql}");
            }
        }

        //对数据库进行读取操作
        public DataSet ReadDB(string sql)
        {
            DataSet ds = new DataSet();
            try
            {
                MySqlDataAdapter ad = new MySqlDataAdapter(sql,connection);
                ad.Fill(ds);
                
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                throw new Exception(e.Message);
            }
            return ds;
        }

        //返回表的第一行第一列的id
        public int GetFirstDataId(string sql)
        {
            int Id = 0;   
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;
                Id = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                throw new Exception(e.Message);
            }
            return Id;
        }

        //返回DataTable
        public DataTable ReadDBDataTable(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                MySqlDataAdapter ad = new MySqlDataAdapter(sql, connection);
                ad.Fill(dt);
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                throw new Exception(e.Message);
            }
            return dt;
        }

        //释放数据库连接
        public void Dispose()
        {
            connection.Close();
            connection.Dispose();
        }
    }
}
