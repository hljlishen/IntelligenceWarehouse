using cangku_01.entity;
using cangku_01.interfaceImp;
using cangku_01.interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static cangku_01.view.AdminPage.AutoCloseMassageBox;

//员工信息的添加、修改

namespace cangku_01.view.EmployeesManagement
{
    public partial class AddOrUpdateEmployee : Form
    {
        EmployeesInterface dao = new EmployeeDataManipulation();
        Employee em = new Employee();
        private EmployeeManagement fr;
        private string companytext;
        private string departmenttext;
        private string grouptext;
        private int index;

        //无参构造方法为添加状态
        public AddOrUpdateEmployee(EmployeeManagement fr)
        {
            InitializeComponent();
            bt_alteremployee.Visible = false;
            this.fr = fr;
        }

        //重写有参构造方法为修改状态
        public AddOrUpdateEmployee(EmployeeManagement fr , Employee em, string company, string department, string group ,int index)
        {
            InitializeComponent();
            Bt_addemployee.Visible = false;
            this.fr = fr;
            this.index = index;
            tb_employeesid.ReadOnly = true;
            La_addoralter.Text = "修改员工";
            tb_employeesid.Text = em.EmployeeNumber.ToString();
            tb_name.Text = em.Name;
            if (em.Sex.Equals("男"))
            {
                Rb_sexman.Checked = true;
            }
            else
            {
                Rb_sexwoman.Checked = true;
            }
            la_company.Text = company;
            la_department.Text = department;
            la_group.Text = group;
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
            if (!FormValidation()) return;
            if (dao.EmployeesRechecking(tb_employeesid.Text.ToString()) != 0)
            {
                la_errorexistnumber.Visible = true;
                la_errorexistnumber.ForeColor = Color.Red;
                return;
            }
            else la_errorexistnumber.Visible = false;
            GetEmployeeInformation();
            companytext = la_company.Text;
            departmenttext = la_department.Text;
            grouptext = la_group.Text;
            dao.AddEmployee(em);
            AutoClosingMessageBox.Show("员工信息添加成功", "员工信息添加", 1000);
            index = fr.dgv_employeeinformation.Rows.Add();
            AddOneEmployeeToTheDataGridView();
            Close();
 
        }

        //获取员工信息
        public void GetEmployeeInformation()
        {
            em.EmployeeNumber = tb_employeesid.Text.ToString();
            em.Name = tb_name.Text.ToString();
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
            if (!FormValidation()) return;
            GetEmployeeInformation();
            if (em.Group == 0)
            {
                DataTable dt = em.EmployeeNumberFindEmployee();
                DataRow myDr = dt.Rows[0];
                em.Company = (int)myDr["em_company"];
                em.Department = (int)myDr["em_department"];
                em.Group = (int)myDr["em_group"];
            }
            companytext = la_company.Text;
            departmenttext = la_department.Text;
            grouptext = la_group.Text;
            dao.UpdateEmployee(em);
            AutoClosingMessageBox.Show("员工信息修改成功", "员工信息修改", 1000);
            fr.dgv_employeeinformation.Rows.RemoveAt(index);
            index = fr.dgv_employeeinformation.Rows.Add();
            AddOneEmployeeToTheDataGridView();
            Close(); 
        }

        //选择员工的公司、部门、小组信息
        private void tv_departmentshow_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tv_departmentshow.SelectedNode.Level != 2) //确定选中到部门
            {
                AutoClosingMessageBox.Show("为精确到小组", "为精确到小组", 500);
                return;
            }
            Department d1 = tv_departmentshow.SelectedNode.Tag as Department;//获取节点id
            Department d2 = tv_departmentshow.SelectedNode.Parent.Tag as Department;
            Department d3 = tv_departmentshow.SelectedNode.Parent.Parent.Tag as Department;
            la_group.Text = tv_departmentshow.SelectedNode.Text;
            la_department.Text = tv_departmentshow.SelectedNode.Parent.Text;
            la_company.Text = tv_departmentshow.SelectedNode.Parent.Parent.Text;
            em.Company = d3.id;
            em.Department = d2.id;
            em.Group = d1.id;
        }

        //表单验证
        private bool FormValidation()
        {
            bool validation = true;
            if (tb_employeesid.Text.Trim().Equals(""))
            {
                la_errornumber.Visible = true;
                la_errornumber.ForeColor = Color.Red;
                validation = false;
            }
            else la_errornumber.Visible = false;
            if (tb_name.Text.Trim().Equals(""))
            {
                la_errorname.Visible = true;
                la_errorname.ForeColor = Color.Red;
                validation = false;
            }
            else la_errorname.Visible = false;
            if (la_group.Text.Trim().Equals("员工小组"))
            {
                la_errorgroup.Visible = true;
                la_errorgroup.ForeColor = Color.Red;
                validation = false;
            }
            else la_errorgroup.Visible = false;
            return validation;
        }
    }
}
