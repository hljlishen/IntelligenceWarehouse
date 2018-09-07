using cangku_01.entity;
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
    public partial class Ins_query : Form
    {
        InstrumenBorrowRecord dao = new InsBorrowRecord();
        InstrumentInAndOutRecord record ;
        InstrumentManagement selectInstrument;
        EmployeeManagement selectEmployees;
        DbLinkFactory factory;

        public Ins_query()
        {
            InitializeComponent();
        }


        private void InstrumentQuery_Load(object sender, EventArgs e)
        {
            cb_query.Text = "出入库";
            //选择时间查询
            cb_choicetime.MouseClick += cb_choicetime_MouseClick;
            //调用方法固定页面
            Top = 0;
            Left = 0;
            DataTable dt = dao.AllInAndOutRecords();//将全部员工加载
            ShowDataGridView(dt);
        }

        //DataGridView显示数据
        public void ShowDataGridView(DataTable dt)
        {
            dgv_InstrumentInAndOutrecord.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                DataGridViewRow row2 = new DataGridViewRow();
                int index = dgv_InstrumentInAndOutrecord.Rows.Add(row2);
                //dr["ins_instrumentid"];
                dgv_InstrumentInAndOutrecord.Rows[index].Cells[0].Value = SelectInstrument((int)dr["ins_instrumentid"]);
                //dgv_InstrumentInAndOutrecord.Rows[index].Cells[1].Value = SelectTagIdInstrument((int)dr["ins_instrumentid"]);
                //dgv_InstrumentInAndOutrecord.Rows[index].Cells[2].Value = SelectInstrument((int)dr["ins_instrumentid"]);
                dgv_InstrumentInAndOutrecord.Rows[index].Cells[3].Value = dr["ins_time"];
                dgv_InstrumentInAndOutrecord.Rows[index].Cells[4].Value = dr["ins_direct"];
                //dgv_InstrumentInAndOutrecord.Rows[index].Cells[5].Value = dr["in_model"];
                dgv_InstrumentInAndOutrecord.Rows[index].Cells[6].Value = SelectEmployee((int)dr["ins_employeeid"]);
                //dgv_InstrumentInAndOutrecord.Rows[index].Cells[7].Value = dr["in_duty"];
                //dgv_InstrumentInAndOutrecord.Rows[index].Cells[8].Value = dr["in_manufactor"];
                //dgv_InstrumentInAndOutrecord.Rows[index].Cells[9].Value = dr["in_productiondate"];
            }
        }

        //仪器信息查询
        public string SelectInstrument(int id)
        {
            string query;
            InstrumentInterface dao = new InstrumentDataManipulation();
            InstrumentInAndOutRecord rec = new InstrumentInAndOutRecord();
            Instrument ins = new Instrument();
            rec.ins_instrumentid = id;
            DataTable dt = dao.IdQueryInstrument(ins);
            DataRow myDr = dt.Rows[0];
            query = myDr["in_tagid"].ToString();
            return query;
        }

        public string SelectEmployee(int id)
        {
            string query;
            InstrumenBorrowRecord dao = new InsBorrowRecord();
            InstrumentInAndOutRecord rec = new InstrumentInAndOutRecord();
            rec.ins_employeeid = id;
            DataTable dt = dao.IdQueryEmployee(rec);
            DataRow myDr = dt.Rows[0];
            query = myDr["em_name"].ToString();
            return query;
        }

        //搜索仪器出入库信息按钮
        private void Btnquery_Click(object sender, EventArgs e)
        {
            //ISelectSqlMaker maker = DbLinkManager.GetLinkFactory().CreateSelectSqlMaker("t_insinandoutrecords");
            record.ins_instrumentid = Convert.ToUInt16(tb_instrument.Text);
            record.ins_employeeid = Convert.ToUInt16(tb_employee.Text);
            record.ins_direct = cb_query.Text.Equals("出入库") ? null : cb_query.Text;
            ShowDataGridView(dao.SearchRecords(record));
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

        private void InstrumentSelected(List<int> instrumentIds,List<string> insNameAndModel)
        {
            tb_instrument.Text = "";
            la_intrument.Text = "";
            foreach (var name in insNameAndModel)
            {
                la_intrument.Text += name;
                la_intrument.Text += ",";
            }
            foreach (var name in instrumentIds)
            {
                tb_instrument.Text += name;
            }
            la_intrument.Text = la_intrument.Text.Substring(0, la_intrument.Text.Length-1);
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

        private void EmployeesSelected(List<int> employeesIds, List<string> emNameAndId)
        {
            tb_employee.Text = "";
            la_employee.Text = "";
            foreach (var name in emNameAndId)
            {
                la_employee.Text += name;
                la_employee.Text += ",";
            }
            foreach (var name in employeesIds)
            {
                tb_employee.Text += name;
            }
            tb_employee.Text = tb_employee.Text.Substring(0, tb_employee.Text.Length);
            la_employee.Text = la_employee.Text.Substring(0, la_employee.Text.Length-1);
        }

        //双击清空textbox
        private void tb_employee_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tb_employee.Text = "";
        }

        //双击清空textbox
        private void tb_instrument_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tb_instrument.Text = "";
        }
    }
}
