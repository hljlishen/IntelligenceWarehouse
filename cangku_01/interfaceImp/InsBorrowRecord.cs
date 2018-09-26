﻿using cangku_01.entity;
using cangku_01.GateDrive;
using cangku_01.interfaces;
using cangku_01.MysqlConnection;
using System;
using System.Data;

//仪器出入库接口实现
namespace cangku_01.interfaceImp
{
    internal class InsBorrowRecord : InstrumenBorrowRecord
    {
        DataMysql dbo = DataMysql.GetDataMysqlGreateInstance(DataMysql.mysqldefaultconnection);

        //全部仪器出库和入库记录
        public DataTable AllInAndOutRecords(InstrumentInAndOutRecord record)
        {
            string sql = record.QueryAllInstrumentInAndOutRecordsSql();
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }

        //添加仪器出入记录
        public void AddInAndOutRecords(InstrumentInAndOutRecord record, Fingerprint fingerprint, GateData door)
        {
            MergeInAndOutRecord(fingerprint, door, record);
            record.ins_direct = door.Direction;
            record.ins_time = door.Time;
            record.ins_tagid = door.TagId;
            if (record.ins_instrumentid != null && record.ins_employeeid != null && record.ins_direct != null && record.ins_time != null)
            {
                string sql = record.AddInstrumentRecordSql();
                dbo.WriteDB(sql);
            }
        }

        private void MergeInAndOutRecord(Fingerprint fingerprint, GateData door, InstrumentInAndOutRecord record)
        {
            DataTable findt = Fingerprint(fingerprint);
            DataTable insdt = InsBorrow(door);
            for (int i = 0; i < findt.Rows.Count; i++)
            {
                for (int j = 0;j<insdt.Rows.Count;j++)
                {
                    DataRow finmyDr = findt.Rows[i];
                    DataRow insmyDr = insdt.Rows[j];
                    DateTime emPassTime = Convert.ToDateTime(finmyDr["fi_passtime"]);
                    DateTime insPassTime = door.Time;
                    TimeSpan td = emPassTime.Subtract(insPassTime).Duration();
                    double timeInterval = td.TotalSeconds;
                    if (timeInterval <= 12000)
                    {
                        record.ins_instrumentid = int.Parse(insmyDr["ins_borrowid"].ToString());
                        record.ins_employeeid = int.Parse(finmyDr["fi_id"].ToString());
                        record.ins_emnumber = finmyDr["fi_employeenumber"].ToString();
                    }
                }
            }
        }

        //查fingerprint表
        private DataTable Fingerprint(Fingerprint fingerprint)
        {
            string sql = fingerprint.FingerprintSql();
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }

        //查insborrow表
        private DataTable InsBorrow(GateData gateData)
        {
            string sql = gateData.InsBorrowSql();
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }
    }
}
