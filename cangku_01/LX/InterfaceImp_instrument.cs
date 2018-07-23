﻿using System;
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
        List<instrument> list = new List<instrument>();
        //实体
        instrument a1 = new instrument();
        instrument a2 = new instrument();

        List<instrument> Interface_instrument.All_instrument()//显示所有
        {
            a1.tagId = 0001;   //ID
            a1.name = "离心机";     //仪器名称
            a1.model = "540 x 650 x 390";       //型号规格
            a1.manufactor = " WIGGENS";       //生产厂商
            a1.serialNumber = "qwev123";       //出厂编号
            a1.productionDate = DateTime.Parse("2017-3-7");     //生产日期
            a1.position = "2-1-14";      //货架位置
            a1.isInWareHouse = "在库";        //在库状态
            a1.checkCycle = "2个月";        //检定周期
            a1.previousCheckTimes = "2017-5-7,2017-7-7";     //历次检验时间
            a1.manager = "张三";       //负责人
            list.Add(a1);


            a2.tagId = 0002;  
            a2.name = "超声波清洗器";
            a2.model = "320 x 264 x 345";       
            a2.manufactor = " 舒美";       
            a2.serialNumber = "ty120868";       
            a2.productionDate = DateTime.Parse("2013-5-12");     
            a2.position = "4-2-1";      
            a2.isInWareHouse = "良好";        
            a2.checkCycle = "2年";             
            a2.previousCheckTimes = "2013-5-20，2015-5-20，2017-5-20";   
            a2.manager = "李四";     
            list.Add(a2);

            return list;
            }

        public void Add_instrument(List<instrument> instrument)    //增
        {
            //sql语句
            Console.WriteLine("添加成功");
        }

        public void Delete_instrument(int id)     //删
        {
            //sql语句
            Console.WriteLine("删除成功");
        }

        public void Alter_instrument(List<instrument> instrument)     //改
        {
            //sql语句
            Console.WriteLine("更改成功");
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
