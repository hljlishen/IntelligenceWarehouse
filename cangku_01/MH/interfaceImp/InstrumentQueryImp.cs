using cangku_01.LX;
using cangku_01.MH.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//仪器出入库接口实现
namespace cangku_01.MH.interfaceImp
{
    class InstrumentQueryImp : interfaces.InstrumentQuery
    {
        //定义接收实体类数据的数组
        List<instrument> Warehouses_list = new List<instrument>();

        //实例化实体类
        instrument warehouse1 = new instrument();
        instrument warehouse2 = new instrument();

        //在数据库查询所有出入库仪器，并存放在数组中

        //List<instrument> WarehouseQuery.AllWarehouse()
        //{

           // warehouse1.warehouse_id = 1 ;
           // warehouse1.warehouse_name = "电脑";
           // warehouse1.location = "08-01-05-06";
           // warehouse1.model = "oppo r9";
           // warehouse1.manufacturers = "红叶";
           // warehouse1.productiondate = datetime.now;
           // warehouse1.name = "李四";
           // warehouse1.principal = "王五";
           // warehouse1.outbound_number = 100;
           // warehouse1.inbound_number = 50;
           // warehouse1.remaining_number = 50;
           // warehouse1.outbounddate = datetime.now;
           // warehouse1.inbounddate = datetime.now;
           // warehouses_list.add(warehouse1);

           // warehouse2.warehouse_id = 2;
           // warehouse2.warehouse_name = "笔记本";
           // warehouse2.location = "07-02-06-07";
           // warehouse2.model = "360s";
           // warehouse2.manufacturers = "红叶2";
           // warehouse2.productiondate = datetime.parse("2018-07-18");
           // warehouse2.name = "张三";
           // warehouse2.principal = "王五";
           // warehouse2.outbound_number = 100;
           // warehouse2.inbound_number = 50;
           // warehouse2.remaining_number = 50;
           // warehouse2.outbounddate = datetime.parse("2018-07-18");
           // warehouse2.inbounddate = datetime.parse("2018-07-18");
           // warehouses_list.add(warehouse2);

           // return warehouses_list;
        //}
        //在数据库查询所有出入库仪器，并存放在集合   人员查询
        public List<instrument> FindUserByName(string Name)
        {
            //写sql语句返回
            return Warehouses_list;
        }
        //时间查询
        public List<instrument> FindDate(DateTime Date1, DateTime Date2)
        {
            //写sql语句返回
            return Warehouses_list;
        }

        public List<instrument> AllWarehouse()
        {
            //写sql语句返回
            return Warehouses_list;
        }
    }
}
