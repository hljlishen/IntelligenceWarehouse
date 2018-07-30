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
        List<instrument> instrument_list = new List<instrument>();
        //在数据库查询所用快要到期的仪器，并存放在数组中
        List<instrument> interfaces.InstrumentQuery.All_remind()
        {
            instrument remind1 = new instrument();
            instrument remind2 = new instrument();

            remind1.tagId = 001;
            remind1.name = "电子标签卡";
            remind1.model = "001za250";
            remind1.manufactor = "红叶";
            remind1.productionDate = DateTime.Parse("2018-2-12"); ;
            remind1.position = "1-2-8-2";
            remind1.instrumentNumber = 50;
            remind1.isInWareHouse = true;
            instrument_list.Add(remind1);

            remind2.tagId = 002;
            remind2.name = "UFH读写器";
            remind2.model = "001za2501111111";
            remind2.manufactor = "红叶2";
            remind2.productionDate = DateTime.Parse("2018-2-12"); ;
            remind2.position = "1-3-6-9";
            remind2.instrumentNumber = 50;
            remind1.isInWareHouse = true;
            instrument_list.Add(remind2);
            return instrument_list;
        }


            //时间查询
            public List<instrument> FindDate(DateTime Date1, DateTime Date2)
        {
            //写sql语句返回
            return instrument_list;
        }
        //型号查询
        public List<instrument> FindModel(string Model)
        {
            // 写sql语句返回
            return instrument_list;
        }
        //姓名查询
        public List<instrument> FindUserByName(string Name)
        {
            // 写sql语句返回
            return instrument_list;
        }
    
    }
}
