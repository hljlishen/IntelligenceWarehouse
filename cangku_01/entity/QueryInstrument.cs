using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.entity
{
    class QueryInstrument
    {
        public int Id { get; set; }                        //sql仪器主键id
        public string TagId { get; set; }                  //仪器标签Id
        public string InsName { get; set; }                //仪器名称
        public string InsLocaltion { get; set; }           //仪器位置
        public DateTime OperatingTime { get; set; }        //仪器操作时间
        public string InsModel { get; set; }               //仪器型号
        public string InsBorrow { get; set; }              //借用人
        public string InsDuty { get; set; }                //责任人
        public Boolean isOperating { get; set; }           //操作
        public string InsManufacturer { get; set; }        //生产厂商
        public DateTime InsManufactureTime { get; set; }   //生产日期
    }
}
