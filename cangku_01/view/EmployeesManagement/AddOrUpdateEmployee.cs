﻿using cangku_01.entity;
using cangku_01.interfaceImp;
using cangku_01.interfaces;
using DbLink;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static cangku_01.view.AdminPage.AutoCloseMassageBox;

//员工信息的添加、修改

namespace cangku_01.view.EmployeesManagement
{
    public partial class AddOrUpdateEmployee : Form
    {
        static DbLinkFactory factory = DbLinkManager.GetLinkFactory();
        EmployeesInterface dao = new EmployeeDataManipulation();
        private Employee _employee = new Employee();
        private EmployeeManagement _employeefrom;
        private string _companyname;
        private string _departmentname;
        private string _groupname;
        private int _index;

        //无参构造方法为添加状态
        public AddOrUpdateEmployee(EmployeeManagement form)
        {
            InitializeComponent();
            bt_alteremployee.Visible = false;
            _employeefrom = form;
        }

        //重写有参构造方法为修改状态
        public AddOrUpdateEmployee(EmployeeManagement from , Employee employee, string company, string department, string group ,int index)
        {
            InitializeComponent();
            Bt_addemployee.Visible = false;
            _employeefrom = from;
            _index = index;
            tb_employeesid.ReadOnly = true;
            La_addoralter.Text = "修改员工";
            tb_employeesid.Text = employee.EmployeeNumber.ToString();
            tb_name.Text = employee.Name;
            if (employee.Sex.Equals("男"))
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
            tv_departmentshow.Nodes.Clear();
            Department department = new Department(factory);
            department.GetTreeView(tv_departmentshow,0);
            tv_departmentshow.ExpandAll();
        }

        //员工信息添加
        private void Bt_addemployee_Click(object sender, EventArgs e)
        {
            if (!FormValidation()) return;
            _employee.EmployeeNumber = tb_employeesid.Text;
            if (_employee.EmployeeNumberFindEmployee().Rows.Count != 0)
            {
                la_errorexistnumber.Visible = true;
                la_errorexistnumber.ForeColor = Color.Red;
                return;
            }
            else la_errorexistnumber.Visible = false;
            GetEmployeeInformation();
            _companyname = la_company.Text;
            _departmentname = la_department.Text;
            _groupname = la_group.Text;
            dao.AddEmployee(_employee);
            AutoClosingMessageBox.Show("员工信息添加成功", "员工信息添加", 1000);
            _index = _employeefrom.dgv_employeeinformation.Rows.Add();
            AddOneEmployeeToTheDataGridView();
            Close();
 
        }

        //获取员工信息
        public void GetEmployeeInformation()
        {
            _employee.EmployeeNumber = tb_employeesid.Text.ToString();
            _employee.Name = tb_name.Text.ToString();
            if (Rb_sexman.Checked) _employee.Sex = "男";
            else _employee.Sex = "女";
        }

        //给DataGridView添加一行数据
        public void AddOneEmployeeToTheDataGridView()
        {
            _employeefrom.dgv_employeeinformation.Rows[_index].Cells[0].Value = _employee.EmployeeNumber;
            _employeefrom.dgv_employeeinformation.Rows[_index].Cells[1].Value = _employee.Name;
            _employeefrom.dgv_employeeinformation.Rows[_index].Cells[2].Value = _employee.Sex;
            _employeefrom.dgv_employeeinformation.Rows[_index].Cells[3].Value = _companyname;
            _employeefrom.dgv_employeeinformation.Rows[_index].Cells[4].Value = _departmentname;
            _employeefrom.dgv_employeeinformation.Rows[_index].Cells[5].Value = _groupname;
        }

        //员工信息修改
        private void bt_alteremployee_Click(object sender, EventArgs e)
        {
            if (!FormValidation()) return;
            GetEmployeeInformation();
            if (_employee.Group == 0)
            {
                DataTable dt = _employee.EmployeeNumberFindEmployee();
                DataRow myDr = dt.Rows[0];
                _employee.DepartmentId = (int)myDr["em_departmentid"];
            }
            _companyname = la_company.Text;
            _departmentname = la_department.Text;
            _groupname = la_group.Text;
            dao.UpdateEmployee(_employee);
            AutoClosingMessageBox.Show("员工信息修改成功", "员工信息修改", 1000);
            Employee employee = new Employee();
            DataTable datatable = employee.QueryAllEmployee();//将全部员工加载
            _employeefrom.ShowDataGridView(datatable);
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
            la_group.Text = tv_departmentshow.SelectedNode.Text;
            la_department.Text = tv_departmentshow.SelectedNode.Parent.Text;
            la_company.Text = tv_departmentshow.SelectedNode.Parent.Parent.Text;
            _employee.DepartmentId = (int)tv_departmentshow.SelectedNode.Tag;
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
