using cangku_01.entity;
using cangku_01.GateDrive;
using cangku_01.interfaceImp;
using cangku_01.interfaces;
using cangku_01.view.EmployeesManagement;
using cangku_01.view.InstrumentManagement;
using DbLink;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace cangku_01.MH
{
    //仪器出入库查询页面
    public partial class Ins_InAndOutRecord : Form
    {
        static DbLinkFactory factory = DbLinkManager.GetLinkFactory();
        IGateDataProcessor insdao = new JointProcessor();
        GateData door = new GateData();
        Instrument ins = new Instrument();
        InstrumentManagement selectInstrument;
        EmployeeManagement selectEmployees;

        private string query;

        public Ins_InAndOutRecord()
        {
            InitializeComponent();
        }

        private void InstrumentQuery_Load(object sender, EventArgs e)
        {
            InstrumenBorrowRecord dao = new InsBorrowRecord();
            InstrumentInAndOutRecord record = new InstrumentInAndOutRecord(factory);
            cb_directquery.Text = "出入库";
            //选择时间查询
            cb_choicetime.MouseClick += cb_choicetime_MouseClick;
            //调用方法固定页面
            Top = 0;
            Left = 0;
            DataTable dt = dao.AllInAndOutRecords(record);
            ShowDataGridView(dt);
        }

        //DataGridView显示数据
        private void ShowDataGridView(DataTable dt)
        {
            dgv_InstrumentInAndOutrecord.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                DataGridViewRow row2 = new DataGridViewRow();
                int index = dgv_InstrumentInAndOutrecord.Rows.Add(row2);
                dgv_InstrumentInAndOutrecord.Rows[index].Cells[0].Value = SelectTagidInstrument(int.Parse(dr["insr_insborrowid"].ToString()));
                dgv_InstrumentInAndOutrecord.Rows[index].Cells[1].Value = SelectNameInstrument(int.Parse(dr["insr_insborrowid"].ToString()));
                dgv_InstrumentInAndOutrecord.Rows[index].Cells[2].Value = SelectModelInstrument(int.Parse(dr["insr_insborrowid"].ToString()));
                ins.Position = SelectPositionInstrument(int.Parse(dr["insr_insborrowid"].ToString()));
                dgv_InstrumentInAndOutrecord.Rows[index].Cells[3].Value = ins.PlaceUnscramble();
                dgv_InstrumentInAndOutrecord.Rows[index].Cells[4].Value = SelectManufactorInstrument(int.Parse(dr["insr_insborrowid"].ToString()));
                dgv_InstrumentInAndOutrecord.Rows[index].Cells[5].Value = dr["insr_time"];
                dgv_InstrumentInAndOutrecord.Rows[index].Cells[6].Value = dr["insr_direct"]; 
                dgv_InstrumentInAndOutrecord.Rows[index].Cells[7].Value = SelectEmployee(int.Parse(dr["insr_fingerprintid"].ToString()));
                dgv_InstrumentInAndOutrecord.Rows[index].Cells[8].Value = SelectDutyInstrument(int.Parse(dr["insr_insborrowid"].ToString()));
            }
        }
            
        //仪器信息查询
        private string SelectTagidInstrument(int id)
        {
            door.Id = id;
            DataTable dt = insdao.IdQueryInstrumentBorrow(door);
            DataRow myDr = dt.Rows[0];
            query = myDr["ins_tagid"].ToString();
            return query;
        }

        private string SelectNameInstrument(int id)
        {
            door.Id = id;
            DataTable dt = insdao.IdQueryInstrumentBorrow(door);
            DataRow myDr = dt.Rows[0];
            query = myDr["ins_name"].ToString();
            return query;
        }

        private string SelectPositionInstrument(int id)
        {
            door.Id = id;
            DataTable dt = insdao.IdQueryInstrumentBorrow(door);
            DataRow myDr = dt.Rows[0];
            query = myDr["ins_position"].ToString();
            return query;
        }

        private string SelectModelInstrument(int id)
        {
            door.Id = id;
            DataTable dt = insdao.IdQueryInstrumentBorrow(door);
            DataRow myDr = dt.Rows[0];
            query = myDr["ins_model"].ToString();
            return query;
        }

        private string SelectDutyInstrument(int id)
        {
            door.Id = id;
            DataTable dt = insdao.IdQueryInstrumentBorrow(door);
            DataRow myDr = dt.Rows[0];
            query = myDr["ins_duty"].ToString();
            return query;
        }

        private string SelectManufactorInstrument(int id)
        {
            door.Id = id;
            DataTable dt = insdao.IdQueryInstrumentBorrow(door);
            DataRow myDr = dt.Rows[0];
            query = myDr["ins_manufactor"].ToString();
            return query;
        }

        //员工信息查询
        private string SelectEmployee(int id)
        {
            Fingerprint fingerprint = new Fingerprint(factory);
            fingerprint.fi_id = id;
            DataTable dt = fingerprint.FingerprinIdQueryEmployee(fingerprint);
            DataRow myDr = dt.Rows[0];
            query = myDr["fi_name"].ToString();
            return query;
        }

        //搜索仪器出入库信息按钮
        private void Btnsearch_Click(object sender, EventArgs e)
        {
            ISelectSqlMaker maker = factory.CreateSelectSqlMaker("t_insinandoutrecords");
            maker.AddAndCondition(new StringEqual("insr_tagid", tb_instrument.Text));
            maker.AddAndCondition(new StringEqual("insr_emnumber", tb_employee.Text));
            if (cb_directquery.Text == "出入库")
                maker.AddAndCondition(new StringLike("insr_direct", "库"));
            else
                maker.AddAndCondition(new StringEqual("insr_direct", cb_directquery.Text));
            if (cb_choicetime.Checked.Equals(true))
                maker.AddAndCondition(new DateBetweenOpenInterval("insr_time", dtp_begin.Value, dtp_end.Value.AddDays(1), factory.CreateDateTimeFormater()));
            var sql = maker.MakeSelectSql();
            var queryResult = InstrumentInAndOutRecord.Select(sql, factory.CreateDatabaseDrive());
            tb_instrument.Text = "";
            tb_employee.Text = "";
            ShowDataGridView(queryResult);
        }

        //点击勾选框选择时间查询
        private void cb_choicetime_MouseClick(object sender, MouseEventArgs e)
        {
            if (cb_choicetime.Checked.Equals(true))
            {
                dtp_begin.Enabled = true;
                dtp_end.Enabled = true;
            }
            else
            {
                dtp_begin.Enabled = false;
                dtp_end.Enabled = false;
            }
        }

        //查找仪器信息
        private void btn_selectInstrument_Click(object sender, EventArgs e)
        {
            selectInstrument = new InstrumentManagement();
            selectInstrument.FormBorderStyle = FormBorderStyle.FixedSingle;
            selectInstrument.InstrumentSelected += InstrumentSelected;
            selectInstrument.ShowDialog();
            selectInstrument.InstrumentSelected -= InstrumentSelected;
        }

        private void InstrumentSelected(List<int> instrumentIds,List<string> insTagids)
        {
            tb_instrument.Text = "";
            foreach (var name in insTagids)
            {
                tb_instrument.Text += name;
            }
            tb_instrument.Text = tb_instrument.Text.Substring(0, tb_instrument.Text.Length);
        }

        //查找员工信息
        private void btn_selectemployee_Click(object sender, EventArgs e)
        {
            selectEmployees = new EmployeeManagement();
            selectEmployees.FormBorderStyle = FormBorderStyle.FixedSingle;
            selectEmployees.EmployeesSelected += EmployeesSelected;
            selectEmployees.ShowDialog();
            selectEmployees.EmployeesSelected -= EmployeesSelected;
        }

        private void EmployeesSelected(List<int> employeesIds, List<string> emNumbers)
        {
            tb_employee.Text = "";
            foreach (var name in emNumbers)
            {
                tb_employee.Text += name;
            }
            tb_employee.Text = tb_employee.Text.Substring(0, tb_employee.Text.Length);
        }
    }
}
