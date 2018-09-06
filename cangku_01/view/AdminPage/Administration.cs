using System;
using System.Windows.Forms;
using cangku_01.MH;
using cangku_01.UHFReader09;
using cangku_01.view.DueToRemind;
using cangku_01.view.EmployeesManagement;
using cangku_01.view.InstrumentManagement;
using cangku_01.view.WarehouseManagement;

//管理员主页面

namespace cangku_01
{
    public partial class Administration : Form
    {
        private EmployeeManagement index_employees = null;
        private WarehouseManagement warehouseManagement = null;
        private DueToRemind Due_to_remind = null;
        private Ins_query Ins_query = null;
        private InstrumentManagement index_instrument = null;

        public Administration()
        {
            InitializeComponent();
        }


        private void Administration_Load(object sender, EventArgs e)
        {
           
        }

        private void 员工管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (index_employees == null)
            {
                index_employees = new EmployeeManagement();
            }
            else
            {
                index_employees.Close();
                index_employees = new EmployeeManagement();
            }
            index_employees.MdiParent = this;
            index_employees.Show();
            index_employees.Activate();
            
        }

        private void 仓库管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (warehouseManagement == null)
            {
                warehouseManagement = new WarehouseManagement();
            }
            else
            {
                warehouseManagement.Close();
                warehouseManagement = new WarehouseManagement();
            }
            warehouseManagement.MdiParent = this;
            warehouseManagement.Show();
            warehouseManagement.Activate();
        }

        private void 到期提醒ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Due_to_remind == null)
            {
                Due_to_remind = new DueToRemind();
            }
            else
            {
                Due_to_remind.Close();
                Due_to_remind = new DueToRemind();
            }
            Due_to_remind.MdiParent = this;
            Due_to_remind.Show();
            Due_to_remind.Activate();
        }

        private void 仪器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Ins_query == null)
            {
                Ins_query = new Ins_query();
            }
            else
            {
                Ins_query.Close();
                Ins_query = new Ins_query();
            }
            Ins_query.MdiParent = this;
            Ins_query.Show();
            Ins_query.Activate();
        }

        private void 仪器管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UHFReader reader = UHFReader.CreateInstance();
            if (index_instrument == null)
            {
                index_instrument = new InstrumentManagement();
            }
            else
            {
                index_instrument.Close();
                index_instrument = new InstrumentManagement();
            }
            index_instrument.MdiParent = this;
            index_instrument.Show();
            index_instrument.Activate();
        }
    }
}
