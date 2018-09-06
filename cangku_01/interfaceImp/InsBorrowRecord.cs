using cangku_01.entity;
using cangku_01.GateDrive;
using cangku_01.interfaceImp;
using cangku_01.interfaces;
using cangku_01.MysqlConnection;
using DbLink;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//仪器出入库接口实现
namespace cangku_01.interfaceImp
{
    internal class InsBorrowRecord : InstrumenBorrowRecord
    {
        ISelectSqlMaker maker = DbLinkManager.GetLinkFactory().CreateSelectSqlMaker("t_insinandoutrecords");
        DataMysql dbo = DataMysql.GetDataMysqlGreateInstance(DataMysql.mysqldefaultconnection);

        //查看全部仪器出库和入库记录
        public DataTable AllInAndOutRecords()
        {
            throw new NotImplementedException();
        }

        //记录搜索
        public DataTable SearchRecords(InstrumentInAndOutRecord rec)
        {
            throw new NotImplementedException();
        }

        //添加仪器出入记录
        public void AddInAndOutRecords(InstrumentInAndOutRecord rec, Employee ee, GateData door)
        {
            DateTime emPassTime = ee.PassDoor;
            DateTime insPassTime = DateTime.Parse(door.ThroughDoorTime);
            TimeSpan td = emPassTime.Subtract(insPassTime).Duration();
            double timeInterval = td.TotalSeconds;
            if (timeInterval<=1800)
            {

            }
        }
    }
}
