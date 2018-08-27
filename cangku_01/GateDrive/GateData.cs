using cangku_01.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.FingerprintDrive
{
    class GateData
    {
        public string TagId  { get; set; }  //仪器标签Id
        public string Name { get; set; }   //仪器名称
        public string ThroughDoorTime { get; set; }//通过门的时间
        public string ThroughDoorDirection { get; set; }//仪器过门的操作

        //添加借用信息sql 
        public string BorrowInformationSql()
        {
            string sql = "insert into t_insborrow (ins_tagid,ins_name,ins_throughtime,ins_throughstate)values('"
                + TagId + "','" + Name + "','" + ThroughDoorTime + "','" + ThroughDoorDirection + "')";
            return sql;
        }

        //TagID查询仪器名称信息
        public string TagIDQueryInstrumentNameSql()
        {
            string sql = "select in_name from t_instrument where in_tagid ='"+ TagId + "'";
            return sql;
        }
        
    }
}
