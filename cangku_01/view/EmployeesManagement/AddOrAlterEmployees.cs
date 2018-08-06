using cangku_01.entity;
using cangku_01.interfaceImp;
using cangku_01.interfaces;
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
        private string group;
        private string department;
        private string company;
        public AddOrAlterEmployees(string group, string department, string company)
        {
            InitializeComponent();
            this.group = group;
            this.department = department;
            this.company = company;
        }

        private void Bt_department_Click(object sender, EventArgs e)
        {
            DepartmentShow add = new DepartmentShow();
            add.Show();
        }

        private void AddOrAlterEmployees_Load(object sender, EventArgs e)
        {

        }

        private void Bt_addoralter_Click(object sender, EventArgs e)
        {
            EmployeesInterface dao = new EmployeesInterfaceImp();
            Employees em = new Employees();
            if (Tb_employeesid.Text == "" || Tb_name.Text == "" )
            {
                MessageBox.Show("请填写完整信息！");
                return;
            }
            if (dao.EmployeesRechecking(int.Parse(Tb_employeesid.Text.ToString())) != 0)
            {
                MessageBox.Show("已存在该员工编号！");
                return;
            }
            em.UserNumber = int.Parse(Tb_employeesid.Text.ToString());
            em.Name = Tb_name.Text.ToString();
            if (Rb_sexman.Checked) em.Sex = "男";
            else em.Sex = "女";
            em.Company = company;
            em.Department = department;
            em.Group = group;
            int i= dao.AddEmployees(em);
            if (i == 1)
            {
                MessageBox.Show("添加员工完成！");
                DialogResult = DialogResult.OK;
                Close();

            }
            else
            {
                MessageBox.Show("添加员工失败！");
            }    
        }
    }
}
