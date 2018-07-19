using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//接口实现

namespace cangku_01.LX
{
    class InterfaceImp_instrument : Interface_instrument
    {
        //存放实体数据
        List<instrument_entity> list = new List<instrument_entity>();
        //实体
        instrument_entity a1 = new instrument_entity();
        instrument_entity a2 = new instrument_entity();

        List<instrument_entity> Interface_instrument.All_instrument()
        {
            a1.id = 0001;   //ID
            a1.name = "离心机";     //仪器名称
            a1.specifications = "540 x 650 x 390";       //型号规格
            a1.vendor = " WIGGENS";       //生产厂商
            a1.number = "qwev123";       //出厂编号
            a1.productiondate = DateTime.Parse("2017-3-7");     //生产日期
            a1.address = "2-1-14";      //货架位置
            a1.state = "良好";        //在库状态
            a1.cycle = "2个月";        //检定周期
            a1.effectivedate = DateTime.Parse("2020 -10-12");        //有效日期
            a1.date = "2017-5-7,2017-7-7";     //历次检验时间
            a1.head = "张三";       //负责人
            list.Add(a1);


            a2.id = 0002;  
            a2.name = "超声波清洗器";
            a2.specifications = "320 x 264 x 345";       
            a2.vendor = " 舒美";       
            a2.number = "ty120868";       
            a2.productiondate = DateTime.Parse("2013-5-12");     
            a2.address = "4-2-1";      
            a2.state = "良好";        
            a2.cycle = "2年";        
            a2.effectivedate = DateTime.Parse("2050-5-20");      
            a2.date = "2013-5-20，2015-5-20，2017-5-20";   
            a2.head = "李四";     
            list.Add(a2);

            return list;
            }

        public void Add_instrument(instrument_entity instrument)    //增
        {
            //list.Add(instrument);
        }

        public void Delete_instrument(instrument_entity instrument)     //删
        {

        }

        public void Alter_instrument(instrument_entity instrument)     //改
        {
            
        }

        public void Select_instrument(instrument_entity instrument)     //查
        {
            
        }
    }
}
