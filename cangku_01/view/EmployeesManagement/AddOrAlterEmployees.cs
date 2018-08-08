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
        Employees em = new Employees();
        public AddOrAlterEmployees()
        {
            InitializeComponent();
            bt_alter.Visible = false;

        }

        private void AddOrAlterEmployees_Load(object sender, EventArgs e)
        {
            //加载部门树状图
            List<TreeNode> ls = Department.loadDepartmentStructure();
            tv_departmentshow.Nodes.Clear();
            tv_departmentshow.Nodes.AddRange(ls.ToArray());
            tv_departmentshow.ExpandAll();

        }

        public AddOrAlterEmployees(Employees em, string company, string department, string group)
        {
            InitializeComponent();
            Bt_add.Visible = false;
            this.Tb_employeesid.ReadOnly = true;
            this.La_addoralter.Text = "修改员工";
            this.Tb_employeesid.Text = em.UserNumber.ToString();
            this.Tb_name.Text = em.Name;
            if (em.Sex.Equals("男"))
            {
                this.Rb_sexman.Checked = true;
            }
            else
            {
                this.Rb_sexwoman.Checked = true;
            }
            this.la_company.Text = company;
            this.la_department.Text = department;
            this.la_group.Text = group;
        }

        //添加员工
        private void Bt_add_Click(object sender, EventArgs e)
        {
            EmployeesInterface dao = new EmployeesInterfaceImp();
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
            if (la_group.Text.Equals("员工小组")) //没有选中节点
            {
                MessageBox.Show("请先选择要添加联系人的部门");
                return;
            }
            em.UserNumber = int.Parse(Tb_employeesid.Text.ToString());
            em.Name = Tb_name.Text.ToString();
            if (Rb_sexman.Checked) em.Sex = "男";
            else em.Sex = "女";
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

        //修改员工
        private void bt_alter_Click(object sender, EventArgs e)
        {
            EmployeesInterface dao = new EmployeesInterfaceImp();
            if (Tb_employeesid.Text == "" || Tb_name.Text == "")
            {
                MessageBox.Show("请填写完整信息！");
                return;
            }
            em.UserNumber = int.Parse(Tb_employeesid.Text.ToString());
            em.Name = Tb_name.Text.ToString();
            if (Rb_sexman.Checked) em.Sex = "男";
            else em.Sex = "女";
            if (em.Group == 0)
            {
                DataTable dt = dao.FindEmployeesNumber(em.UserNumber);
                DataRow myDr = dt.Rows[0];
                em.Company = int.Parse(myDr["em_company"].ToString());
                em.Department = int.Parse(myDr["em_department"].ToString());
                em.Group = int.Parse(myDr["em_group"].ToString());
            }
            int i = dao.UpdateEmployees(em);
            if (i == 1)
            {
                MessageBox.Show("修改员工完成！");
                DialogResult = DialogResult.OK;
                Close();

            }
            else
            {
                MessageBox.Show("修改员工失败！");
            }

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tv_departmentshow.SelectedNode.Level != 2) //确定选中到部门
            {
                MessageBox.Show("未精确到小组");
                return;
            }
            Department d1 = tv_departmentshow.SelectedNode.Tag as Department;//获取节点id
            Department d2 = tv_departmentshow.SelectedNode.Parent.Tag as Department;
            Department d3 = tv_departmentshow.SelectedNode.Parent.Parent.Tag as Department;
            this.la_group.Text = tv_departmentshow.SelectedNode.Text;
            this.la_department.Text = tv_departmentshow.SelectedNode.Parent.Text;
            this.la_company.Text = tv_departmentshow.SelectedNode.Parent.Parent.Text;
            em.Company = d3.id;
            em.Department = d2.id;
            em.Group = d1.id;
        }
    }
}
