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
    public partial class AddOrAlterEmployees : Form
    {
        public AddOrAlterEmployees()
        {
            InitializeComponent();
        }

        private void Bt_department_Click(object sender, EventArgs e)
        {
            DepartmentShow add = new DepartmentShow();
            add.Show();
        }
    }
}
