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
using static cangku_01.view.AdminPage.AutoCloseMassageBox;

//员工信息的添加、修改

namespace cangku_01.view.EmployeesManagement
{
    public partial class AddOrUpdateEmployees : Form
    {
        EmployeesInterface dao = new EmployeesInterfaceImp();
        Employee em = new Employee();
        private EmployeesManagement fr;
        private string companytext;
        private string departmenttext;
        private string grouptext;
        private int index;

        //无参构造方法为添加状态
        public AddOrUpdateEmployees(EmployeesManagement fr)
        {
            InitializeComponent();
            bt_alteremployee.Visible = false;
            this.fr = fr;
        }

        //重写有参构造方法为修改状态
        public AddOrUpdateEmployees(EmployeesManagement fr , Employee em, string company, string department, string group ,int index)
        {
            InitializeComponent();
            Bt_addemployee.Visible = false;
            this.fr = fr;
            this.index = index;
            this.Tb_employeesid.ReadOnly = true;
            this.La_addoralter.Text = "修改员工";
            this.Tb_employeesid.Text = em.EmployeeNumber.ToString();
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

        //加载部门树状图
        private void AddOrAlterEmployees_Load(object sender, EventArgs e)
        {
            List<TreeNode> ls = Department.loadDepartmentStructure();
            tv_departmentshow.Nodes.Clear();
            tv_departmentshow.Nodes.AddRange(ls.ToArray());
            tv_departmentshow.ExpandAll();
        }

        //员工信息添加
        private void Bt_addemployee_Click(object sender, EventArgs e)
        {
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
            this.GetEmployeeInformation();
            companytext = la_company.Text;
            departmenttext = la_department.Text;
            grouptext = la_group.Text;
            dao.AddEmployee(em);
            AutoClosingMessageBox.Show("员工信息添加成功", "员工信息添加", 1000);
            index = fr.dgv_employeeinformation.Rows.Add();
            this.AddOneEmployeeToTheDataGridView();
            Close();
 
        }

        //获取员工信息
        public void GetEmployeeInformation()
        {
            em.EmployeeNumber = int.Parse(Tb_employeesid.Text.ToString());
            em.Name = Tb_name.Text.ToString();
            if (Rb_sexman.Checked) em.Sex = "男";
            else em.Sex = "女";
        }

        //给DataGridView添加一行数据
        public void AddOneEmployeeToTheDataGridView()
        {
            fr.dgv_employeeinformation.Rows[index].Cells[0].Value = em.EmployeeNumber;
            fr.dgv_employeeinformation.Rows[index].Cells[1].Value = em.Name;
            fr.dgv_employeeinformation.Rows[index].Cells[2].Value = em.Sex;
            fr.dgv_employeeinformation.Rows[index].Cells[3].Value = companytext;
            fr.dgv_employeeinformation.Rows[index].Cells[4].Value = departmenttext;
            fr.dgv_employeeinformation.Rows[index].Cells[5].Value = grouptext;
        }

        //员工信息修改
        private void bt_alteremployee_Click(object sender, EventArgs e)
        {
            if (Tb_employeesid.Text == "" || Tb_name.Text == "")
            {
                MessageBox.Show("请填写完整信息！");
                return;
            }
            this.GetEmployeeInformation();
            if (em.Group == 0)
            {
                DataTable dt = dao.EmployeeNumberQueryEmployee(em);
                DataRow myDr = dt.Rows[0];
                em.Company = int.Parse(myDr["em_company"].ToString());
                em.Department = int.Parse(myDr["em_department"].ToString());
                em.Group = int.Parse(myDr["em_group"].ToString());
            }
            companytext = la_company.Text;
            departmenttext = la_department.Text;
            grouptext = la_group.Text;
            dao.UpdateEmployee(em);
            AutoClosingMessageBox.Show("员工信息修改成功", "员工信息修改", 1000);
            fr.dgv_employeeinformation.Rows.RemoveAt(index);
            index = fr.dgv_employeeinformation.Rows.Add();
            this.AddOneEmployeeToTheDataGridView();
            Close(); 
        }

        //选择员工的公司、部门、小组信息
        private void tv_departmentshow_AfterSelect(object sender, TreeViewEventArgs e)
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
