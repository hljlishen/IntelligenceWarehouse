using cangku_01.entity;
using DbLink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.GateDrive
{
    public class GateData
    {
        static DbLinkFactory factory = DbLinkManager.GetLinkFactory();

        public string TagId  { get; set; }  //仪器标签Id
        public DateTime Time { get; set; }//通过门的时间
        public string Direction { get; set; }//仪器过门的操作

        //添加借用信息sql 
        public string BorrowInformationSql()
        {
            string sql = "insert into t_insborrow (ins_tagid,ins_throughtime,ins_throughstate)values('"
                + TagId + "','" + Time + "','" + Direction + "')";
            return sql;
        }

        public bool IsValid()
        {
            bool ret = !string.IsNullOrEmpty(TagId) && !string.IsNullOrEmpty(Direction);
            return ret;
        }
    }
}
