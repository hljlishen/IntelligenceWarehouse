using cangku_01.entity;
using DbLink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.GateDrive
{
    class GateData
    {
        static DbLinkFactory factory = DbLinkManager.GetLinkFactory();

        public string TagId  { get; set; }  //仪器标签Id
        public string Name { get; set; }   //仪器名称
        public string ThroughDoorTime { get; set; }//通过门的时间
        public string ThroughDoorDirection { get; set; }//仪器过门的操作

        ISelectSqlMaker maker;
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
            SetupInstrument();
            maker.AddAndCondition(new StringEqual("in_tagid", TagId));
            string sql = maker.MakeSelectSql();
            return sql;
        }

        private void SetupInstrument()
        {
            maker = factory.CreateSelectSqlMaker("t_instrument");
        }
    }
}
