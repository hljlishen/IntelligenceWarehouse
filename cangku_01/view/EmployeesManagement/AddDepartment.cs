using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cangku_01.view.EmployeesManagement
{
    public partial class AddDepartment : Form
    {
        public string nodeName
        {
            get { return Tb_departmentname.Text.Trim(); }
        }
        public AddDepartment()
        {
            InitializeComponent();

        }

        private void Bt_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void AddDepartment_Load(object sender, EventArgs e)
        {

        }

        private void Bt_confirm_Click(object sender, EventArgs e)
        {
            if (Tb_departmentname.Text == "")
            {
                MessageBox.Show("请填写名称");
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
