using DbLink;
using System;

namespace cangku_01.GateDrive
{
    public class GateData
    {
        static DbLinkFactory factory = DbLinkManager.GetLinkFactory();

        public int Id { get; set; }//主键ID
        public string TagId  { get; set; }  //仪器标签Id
        public DateTime Time { get; set; }//通过门的时间
        public string Direction { get; set; }//仪器过门的方向
        public string Name { get; set; }             //仪器名称
        public string Model { get; set; }            //型号规格
        public string Manufactor { get; set; }       //生产厂商
        public string Position { get; set; }         //货架位置       
        public string Duty { get; set; }                //责任人

        ISelectSqlMaker maker;
        public GateData()
        {

        }

        public GateData(string tagId, string direction, DateTime time)
        {
            TagId = tagId;
            Direction = direction;
            Time = time;
        }

        //添加借用信息sql 
        public string BorrowInformationSql()
        {
            string sql = "insert into t_insborrow (ins_tagid,ins_throughtime,ins_throughstate,ins_name,ins_model,ins_manufactor,ins_position,ins_duty)values('"
                + TagId + "','" + Time + "','" + Direction + "','"+Name+"','"+Model+"','"+Manufactor+"','"+Position+"','"+Duty+"')";
            return sql;
        }

        //仪器id查仪器信息
        public string IdQueryInstrumentBorrowSql()
        {
            SetupInstrumentBorrow();
            maker.AddAndCondition(new IntEqual("ins_borrowid", Id));
            string sql = maker.MakeSelectSql();
            return sql;
        }

        private void SetupInstrumentBorrow()
        {
            maker = factory.CreateSelectSqlMaker("t_insborrow");
        }

        //查仪器过门信息
        public string InsBorrowSql()
        {
            SetupInsBorrow();
            string sql = maker.MakeSelectSql();
            return sql;
        }

        private void SetupInsBorrow()
        {
            maker = factory.CreateSelectSqlMaker("t_insborrow");
        }

        public bool IsValid()
        {
            bool ret = !string.IsNullOrEmpty(TagId) && !string.IsNullOrEmpty(Direction);
            return ret;
        }
    }
}
