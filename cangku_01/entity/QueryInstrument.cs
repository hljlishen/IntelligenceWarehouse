using DbLink;
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
        public string Name { get; set; }                //仪器名称
        public string Position { get; set; }           //仪器位置
        public string DirectionTime { get; set; }        //仪器通过时间
        public string Model { get; set; }               //仪器型号
        public string Borrow { get; set; }              //借用人
        public string Duty { get; set; }                //责任人
        public string Direction { get; set; }           //通过方向
        public string Manufactor { get; set; }        //生产厂商
        public string ProductionDate { get; set; }   //生产日期

        SelectSqlMaker maker;

        //添加仪器借用信息
        public string AddBorrowInformationSql()
        {
            string sql = "insert into t_insborrow (ins_tagid,ins_name,ins_location,ins_time,ins_model,ins_borrow,ins_duty,ins_direction,ins_manufactor,ins_productiondate)values('"
                + TagId + "','" + Name + "','" + Position + "','" + DirectionTime + "','"+ Model + "','" + Borrow + "','" + Duty + "','" + Direction + "','" + Manufactor + "','"+ ProductionDate + "')";
            return sql;
        }

        //人员刷指纹的信息
        //private string EmployeesFingerprintInformation()
        //{
        //    SetupFingerprint();

        //}

        //仪器通过门的信息
        //private string InstrumentThroughInformation()
        //{
            
        //}

        //仪器的其他信息
        //private string InstrumentOtherInformation()
        //{

        //}

        private void SetupFingerprint()
        {
            maker = new SelectSqlMaker("t_fingerprint");
        }

        private void SetupInstrument()
        {
            maker = new SelectSqlMaker("t_instrument");
        }

        private void SetupGateData()
        {
            maker = new SelectSqlMaker("t_insborrow");
        }
    }
}
