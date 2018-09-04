using cangku_01.interfaceImp;
using cangku_01.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using DbLink;
using cangku_01.view.InstrumentManagement;
using cangku_01.view.EmployeesManagement;

namespace cangku_01.MH
{
    //仪器出入库查询页面
    public partial class Ins_query : Form
    {
        InstrumenBorrowRecord dao = new InsBorrowRecord();
        InstrumentManagement selectInstrument;
        EmployeesManagement selectEmployees;

        public Ins_query()
        {
            InitializeComponent();
        }

        private void InstrumentQuery_Load(object sender, EventArgs e)
        {
            cb_query.Text = "出入库";
            //选择时间查询
            this.cb_choicetime.MouseClick += cb_openchoicetime_MouseClick;
            this.cb_choicetime.MouseClick += cb_closechoicetime_MouseClick;
            //调用方法固定页面
            Top = 0;
            Left = 0;
        }

        private void Btnquery_Click(object sender, EventArgs e)
        {
            ISelectSqlMaker maker = DbLinkManager.GetLinkFactory().CreateSelectSqlMaker("t_insinandoutrecords");
        }

        private void cb_openchoicetime_MouseClick(object sender, MouseEventArgs e)
        {
            if (cb_choicetime.Checked.Equals(true))
            {
                dtp_begin.Enabled = true;
                dtp_end.Enabled = true;

            }
        }
        private void cb_closechoicetime_MouseClick(object sender, MouseEventArgs e)
        {
            if (cb_choicetime.Checked.Equals(false))
            {
                dtp_begin.Enabled = false;
                dtp_end.Enabled = false;
            }
        }

        private void btn_selectInstrument_Click(object sender, EventArgs e)
        {
            selectInstrument = new InstrumentManagement();
            selectInstrument.FormBorderStyle = FormBorderStyle.FixedSingle;
            selectInstrument.InstrumentSelected += InstrumentSelected;
            selectInstrument.ShowDialog();
            selectInstrument.InstrumentSelected -= InstrumentSelected;
        }

        private void InstrumentSelected(List<int> instrumentIds)
        {
            tb_instrumentId.Text = "";
            foreach(var id in instrumentIds)
            {
                tb_instrumentId.Text += id;
            }
            tb_instrumentId.Text = tb_instrumentId.Text.Substring(0, tb_instrumentId.Text.Length);
        }

        private void btn_selectemployee_Click(object sender, EventArgs e)
        {
            selectEmployees = new EmployeesManagement();
            selectEmployees.FormBorderStyle = FormBorderStyle.FixedSingle;
            selectEmployees.EmployeesSelected += EmployeesSelected;
            selectEmployees.ShowDialog();
            selectEmployees.EmployeesSelected -= EmployeesSelected;
        }

        private void EmployeesSelected(List<int> employeesIds)
        {
            tb_employeeId.Text = "";
            foreach (var id in employeesIds)
            {
                tb_employeeId.Text += id;
            }
            tb_employeeId.Text = tb_employeeId.Text.Substring(0, tb_employeeId.Text.Length);
        }


    }
}
