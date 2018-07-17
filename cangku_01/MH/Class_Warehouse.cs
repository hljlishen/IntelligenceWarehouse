using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.MH
{
    //实体类
    class Class_Warehouse
    {
        String warehouse_id;          //仪器id
        String warehouse_name;        //仪器名
        String location;     //仪器位置
        String model;         //仪器型号
        String manufacturers;      //生产厂商
        DateTime  productionDate;    //生产日期
        String name;          //经办人
        String principal;       //负责人
        int outbound_number;     //出库个数
        int intbound_number;      //入库个数
        int remaining_number;     //剩余个数
        DateTime outboundDate;     //出库时间
        DateTime inboundDate;       //入库时间

        //实体类get、set方法
        public string Warehouse_id { get => warehouse_id; set => warehouse_id = value; }
        public string Warehouse_name { get => warehouse_name; set => warehouse_name = value; }
        public string Location { get => location; set => location = value; }
        public string Model { get => model; set => model = value; }
        public string Manufacturers { get => manufacturers; set => manufacturers = value; }
        public DateTime ProductionDate { get => productionDate; set => productionDate = value; }
        public string Name { get => name; set => name = value; }
        public string Principal { get => principal; set => principal = value; }
        public int Outbound_number { get => outbound_number; set => outbound_number = value; }
        public int Intbound_number { get => intbound_number; set => intbound_number = value; }
        public int Remaining_number { get => remaining_number; set => remaining_number = value; }
        public DateTime OutboundDate { get => outboundDate; set => outboundDate = value; }
        public DateTime InboundDate { get => inboundDate; set => inboundDate = value; }
    }
}
