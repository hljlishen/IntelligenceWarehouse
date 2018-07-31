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
        List<instrument> list = new List<instrument>();

        List<instrument> Interface_instrument.All_instrument()
        {
            //text
            instrument a1 = new instrument();
            instrument a2 = new instrument();

            a1.tagId = 0001;   
            a1.name = "离心机";     
            a1.model = "540 x 650 x 390";      
            a1.manufactor = " WIGGENS";      
            a1.serialNumber = "qwev123";      
            a1.productionDate = DateTime.Parse("2017-3-7");   
            a1.position = "2-1-14";      
            a1.isInWareHouse = true;       
            a1.checkCycle = 7;       
            a1.lastCheckTimes = DateTime.Parse("2017 -7-7");            
            a1.manager = "张三";      
            list.Add(a1);


            a2.tagId = 0002;  
            a2.name = "超声波清洗器";
            a2.model = "320 x 264 x 345";       
            a2.manufactor = " 舒美";       
            a2.serialNumber = "ty120868";       
            a2.productionDate = DateTime.Parse("2013-5-12");     
            a2.position = "4-2-1";      
            a2.isInWareHouse = false;        
            a2.checkCycle = 2;             
            a2.lastCheckTimes = DateTime.Parse("2013-5-20");
            a2.manager = "李四";     
            list.Add(a2);

            return list;
            }

        //添加仪器
        public int Add_instrument(List<instrument> instrument)   
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
        public int Alter_instrument(instrument instrument)     
        {
            int i = 1;
            return i;
        }

       

        public List<instrument> findInstrumentById(int id)
        {
            //写sql语句返回
            Console.WriteLine("id查找成功");
            return list;
        }

        public List<instrument> findInstrumentByName(string name)
        {
            //写sql语句返回
            Console.WriteLine("name查找成功");
            return list;
        }
    }
}
