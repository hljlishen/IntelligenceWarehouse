using cangku_01.MH.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//仪器出入库接口实现
namespace cangku_01.MH.interfaceImp
{
    class InterfaceImp_warehouse : Interface_warehouse
    {
        //定义接收实体类数据的数组
        List<Warehouse> Warehouses_list = new List<Warehouse>();

        //实例化实体类
        Warehouse warehouse1 = new Warehouse();
        Warehouse warehouse2 = new Warehouse();

        //在数据库查询所有出入库仪器，并存放在数组中

        List<Warehouse> Interface_warehouse.All_warehouse()
        {

            warehouse1.Warehouse_id = 1 ;
            warehouse1.Warehouse_name = "电脑";
            warehouse1.Location = "08-01-05-06";
            warehouse1.Model = "oppo r9";
            warehouse1.Manufacturers = "红叶";
            warehouse1.ProductionDate = DateTime.Now;
            warehouse1.Name = "李四";
            warehouse1.Principal = "王五";
            warehouse1.Outbound_number = 100;
            warehouse1.Inbound_number = 50;
            warehouse1.Remaining_number = 50;
            warehouse1.OutboundDate = DateTime.Now;
            warehouse1.InboundDate = DateTime.Now;
            Warehouses_list.Add(warehouse1);

            warehouse2.Warehouse_id = 2;
            warehouse2.Warehouse_name = "笔记本";
            warehouse2.Location = "07-02-06-07";
            warehouse2.Model = "360s";
            warehouse2.Manufacturers = "红叶2";
            warehouse2.ProductionDate = DateTime.Parse("2018-07-18");
            warehouse2.Name = "张三";
            warehouse2.Principal = "王五";
            warehouse2.Outbound_number = 100;
            warehouse2.Inbound_number = 50;
            warehouse2.Remaining_number = 50;
            warehouse2.OutboundDate = DateTime.Parse("2018-07-18");
            warehouse2.InboundDate = DateTime.Parse("2018-07-18");
            Warehouses_list.Add(warehouse2);

            return Warehouses_list;
        }
        //在数据库查询所有出入库仪器，并存放在集合   人员查询
        public List<Warehouse> findUserByName(string Name)
        {
            //写sql语句返回
            return Warehouses_list;
        }
        //时间查询
        public List<Warehouse> findDate(DateTime Date1, DateTime Date2)
        {
            //写sql语句返回
            return Warehouses_list;
        }
    }
}
