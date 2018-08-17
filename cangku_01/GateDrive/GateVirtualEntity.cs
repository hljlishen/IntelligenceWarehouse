using cangku_01.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.GateDrive
{
    class GateVirtualEntity
    {
        public string TagId { get; set; }  //仪器标签Id
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
    }
}
