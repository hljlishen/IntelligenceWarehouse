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
    class RemindInterfaceImp : RemindInterface
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

        //将修改的信息传入，对数据库进行修改
        int RemindInterface.Alter_remind(int Remind_id, DateTime Remind_lastdate)
        {
            int i = 1;
           
            return i;
        }
    }
}
