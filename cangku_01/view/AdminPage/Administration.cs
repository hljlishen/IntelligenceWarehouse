﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cangku_01.MH;
using cangku_01;
using cangku_01.YT;


namespace cangku_01
{
    public partial class Administration : Form
    {
        Form index_employees = new EmployeesManagement();
        Form Due_to_remind = new Due_to_remind();
        Form Ins_query = new Ins_query();
        Form index_instrument = new index_instrument();
        public Administration()
        {
            InitializeComponent();
        }

        private void 员工管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index_employees.MdiParent = this;
            index_employees.Show();
            index_employees.Activate();
        }

        private void Administration_Load(object sender, EventArgs e)
        {
           
        }

 

        private void 到期提醒ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Due_to_remind.MdiParent = this;
            Due_to_remind.Show();
            Due_to_remind.Activate();
        }

        private void 仪器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ins_query.MdiParent = this;
            Ins_query.Show();
            Ins_query.Activate();
        }

        private void 仪器管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index_instrument.MdiParent = this;
            index_instrument.Show();
            index_instrument.Activate();
        }
    }
}
