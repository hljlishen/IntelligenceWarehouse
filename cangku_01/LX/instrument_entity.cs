using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.LX
{
    public class instrument_entity
    {

        public int id;       //ID
        public string name;     //仪器名称
        public string specifications;       //型号规格
        public string vendor;       //生产厂商
        public string number;       //出厂编号
        public DateTime productiondate;     //生产日期
        public string address;      //货架位置
        public string state;        //在库状态
        public string cycle;        //检定周期
        public DateTime effectivedate;        //有效日期
        public string date;     //历次检验时间
        public string head;      //负责人

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Specifications { get => specifications; set => specifications = value; }
        public string Vendor { get => vendor; set => vendor = value; }
        public string Number { get => number; set => number = value; }
        public DateTime Productiondate { get => productiondate; set => productiondate = value; }
        public string Address { get => address; set => address = value; }
        public string State { get => state; set => state = value; }
        public string Cycle { get => cycle; set => cycle = value; }
        public DateTime Effectivedate { get => effectivedate; set => effectivedate = value; }
        public string Date { get => date; set => date = value; }
        public string Head { get => head; set => head = value; }

    }
}
