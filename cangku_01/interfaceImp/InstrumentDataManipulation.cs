using System.Data;
using cangku_01.entity;
using cangku_01.interfaces;
using cangku_01.MysqlConnection;

//仪器信息接口实现

namespace cangku_01.interfaceImp
{
    class InstrumentDataManipulation : InstrumentInterface
    {
        DataMysql dbo = DataMysql.GetDataMysqlGreateInstance(DataMysql.mysqldefaultconnection);

        //获取全部仪器信息
        public DataTable QueryAllInstrument()
        {
            Instrument ins = new Instrument();
            string sql = ins.QueryAllInstrumentSql();
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }

        //TagId查询仪器信息
        public DataTable TagIdQueryInstrument(Instrument ins)
        {
            string sql = ins.TagIDQueryInstrumentSql();
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }

        //仪器信息添加
        public void AddInstrument(Instrument ins)
        {
            string sql = ins.AddInstrumentSql();
            dbo.WriteDB(sql);
        }

        //仪器信息删除
        public void DeleteInstrument(Instrument ins)     
        {
            string sql = ins.TagidDeleteInstrumentSql();
            dbo.WriteDB(sql);
        }

        //仪器信息修改
        public void UpdateInstrument(Instrument ins)     
        {
            string sql = ins.UpdateInstrumentSql();
            dbo.WriteDB(sql);
        }

        //仪器在库状态修改
        public void UpdateInstrumentInwarehouseState(Instrument ins)
        {
            string sql = ins.UpdateInstrumentInwarehouseStateSql();
            dbo.WriteDB(sql);
        }

        //仪器搜索
        public DataTable QueryInstrument(Instrument ins)
        {
            string sql = ins.QueryInstrumentSql();
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }

        //仪器id查仪器信息
        public DataTable IdQueryInstrument(Instrument ins)
        {
            string sql = ins.IdQueryInstrumentSql();
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }
    }
}
