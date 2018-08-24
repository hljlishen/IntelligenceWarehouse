using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cangku_01.entity;
using cangku_01.interfaces;
using cangku_01.MysqlConnection;

//到期提醒接口实现

namespace cangku_01.interfaceImp
{
    class CheckTimeQueryAndUpdate : RemindInterface
    {
        DataMysql dbo = DataMysql.GetDataMysqlGreateInstance(DataMysql.mysqldefaultconnection);

        //在数据库查询所用快要到期的仪器
        public DataTable QueryAllExpireInstrument()
        {
            Instrument ins = new Instrument();
            string sql = ins.QueryAllInstrumentSql();
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }

        //仪器信息修改
        public void UpdateInstrumentLastCheckTime(Instrument ins)
        {
            string sql = ins.UpdateInstrumentLastCheckTimeSql();
            dbo.WriteDB(sql);
        }

        //仪器历次检查日期添加
        public void AddInstrumentAllPreviousCheckDate(Instrument ins)
        {
            string sql = ins.AddInstrumentAllPreviousCheckDateSql();
            dbo.WriteDB(sql);
        }

        //查询仪器历次检查信息
        public DataSet QueryInstrumentAllCheckDate(Instrument ins)
        {
            string sql = ins.QueryAllCheckDateSql();
            DataSet ds = dbo.ReadDB(sql);
            return ds;
        }
    }
}
