using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cangku_01.entity;

//接口实现

namespace cangku_01.LX
{
    class InterfaceImp_instrument : Interface_instrument
    {
        List<Instrument> list = new List<Instrument>();

        List<Instrument> Interface_instrument.All_instrument()
        {
            //text
            Instrument a1 = new Instrument();
            Instrument a2 = new Instrument();

            a1.TagId = 0001;   
            a1.Name = "离心机";     
            a1.Model = "540 x 650 x 390";      
            a1.Manufactor = " WIGGENS";      
            a1.SerialNumber = "qwev123";      
            a1.ProductionDate = DateTime.Parse("2017-3-7");   
            a1.Position = "2-1-14";      
            a1.IsInWareHouse = true;       
            a1.CheckCycle = 7;       
            a1.LastCheckTimes = DateTime.Parse("2017 -7-7");            
            a1.Duty = "张三";      
            list.Add(a1);


            a2.TagId = 0002;  
            a2.Name = "超声波清洗器";
            a2.Model = "320 x 264 x 345";       
            a2.Manufactor = " 舒美";       
            a2.SerialNumber = "ty120868";       
            a2.ProductionDate = DateTime.Parse("2013-5-12");     
            a2.Position = "4-2-1";      
            a2.IsInWareHouse = false;        
            a2.CheckCycle = 2;             
            a2.LastCheckTimes = DateTime.Parse("2013-5-20");
            a2.Duty = "李四";     
            list.Add(a2);

            return list;
            }

        //添加仪器
        public int Add_instrument(List<Instrument> instrument)   
        {
            int i = 1;
            return i;
        }

        //删除仪器
        public int Delete_instrument(int id)     
        {
            int i = 1;
            return i;
        }

        //修改仪器
        public int Alter_instrument(Instrument instrument)     
        {
            int i = 1;
            return i;
        }

       

        public List<Instrument> findInstrumentById(int id)
        {
            //写sql语句返回
            Console.WriteLine("id查找成功");
            return list;
        }

        public List<Instrument> findInstrumentByName(string name)
        {
            //写sql语句返回
            Console.WriteLine("name查找成功");
            return list;
        }
    }
}
