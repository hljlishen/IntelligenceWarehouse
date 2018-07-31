﻿using cangku_01.LX;
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
        //时间查询
        public List<instrument> FindInstrumentBetween(DateTime begin, DateTime end)
        {
            //写sql语句返回
            return instrument_list;
        }
        //型号查询
        public List<instrument> FindInstrumentByModel(string Model)
        {
            // 写sql语句返回
            return instrument_list;
        }
        //借用人姓名查询
        public List<instrument> FindInstrumentByBorrow(string Name)
        {
            // 写sql语句返回
            return instrument_list;
        }
        //责任人姓名查询
        public List<instrument> FindInstrumentByDuty(string Name)
        {
            // 写sql语句返回
            return instrument_list;
        }
        //生产厂商查询
        public List<instrument> FindInstrumentByManufacturer(string Manufacturer)
        {
            // 写sql语句返回
            return instrument_list;
        }
    }
}
