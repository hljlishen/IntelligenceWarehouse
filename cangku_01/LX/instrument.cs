﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.LX
{
    public class instrument
    {

        public int tagId { get; set; }     //仪器标签ID
        public string name { get; set; }    //仪器名称
        public string model { get; set; }      //型号规格
        public string manufactor { get; set; }       //生产厂商
        public string serialNumber { get; set; }       //出厂编号
        public DateTime productionDate { get; set; }     //生产日期
        public string position { get; set; }      //货架位置    写成类！！！！！！！！！
        public string isInWareHouse { get; set; }       //在库状态       bool!!!!!!!!!!!!!
        public string checkCycle { get; set; }       //检定周期
        public string previousCheckTimes { get; set; }     //历次检验时间
        public string manager { get; set; }    //负责人

        

    }
}