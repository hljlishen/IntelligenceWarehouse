using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using cangku_01.interfaceImp;
using cangku_01.entity;
using cangku_01.view.AdminPage;
using cangku_01.interfaces;
using static cangku_01.view.AdminPage.AutoCloseMassageBox;

//员工信息管理页面

namespace cangku_01.view.EmployeesManagement
{
    public partial class EmployeeManagement : Form
    {
        EmployeesInterface dao = new EmployeeDataManipulation();
        private int nodeid;
        private int level;
        public delegate void EmployeesSelectedHandler(List<int> employeesIds,List<string> emNameAndId);
        public event EmployeesSelectedHandler EmployeesSelected;

        public EmployeeManagement()
        {
            InitializeComponent();
        }

        //初始化页面信息
        public void index_employees_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            ShowTreeView();  //加载部门树状图
            DataTable dt = dao.QueryAllEmployee();//将全部员工加载
            ShowDataGridView(dt);
            cb_foundsex.Text = "男/女";
        }

        //TreeView显示数据
        public void ShowTreeView()
        {
            List<TreeNode> ls = Department.loadDepartmentStructure();
            tv_department.Nodes.Clear();
            tv_department.Nodes.AddRange(ls.ToArray());
            tv_department.ExpandAll();
        }

        //DataGridView显示数据
        public void ShowDataGridView(DataTable dt)
        {
            dgv_employeeinformation.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                DataGridViewRow row2 = new DataGridViewRow();
                int index = dgv_employeeinformation.Rows.Add(row2);
                dgv_employeeinformation.Rows[index].Cells[0].Value = dr["em_employeenumber"];
                dgv_employeeinformation.Rows[index].Cells[1].Value = dr["em_name"];
                dgv_employeeinformation.Rows[index].Cells[2].Value = dr["em_sex"];
                dgv_employeeinformation.Rows[index].Cells[3].Value = dr["em_company"];
                dgv_employeeinformation.Rows[index].Cells[4].Value = dr["em_department"];
                dgv_employeeinformation.Rows[index].Cells[5].Value = dr["em_group"];
                dgv_employeeinformation.Rows[index].Cells[8].Value = dr["em_id"];
            }
        }

        //删除与修改员工
        private void dgv_employeeinformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)//点击在删除按钮上
            {
                if (MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {  
                    string currentIndex = dgv_employeeinformation.CurrentRow.Cells[0].Value.ToString();
                    string usernumber = currentIndex;
                    dao.DeleteEmployee(usernumber);
                    AutoClosingMessageBox.Show("员工信息删除成功", "员工信息删除", 1000);
                    dgv_employeeinformation.Rows.RemoveAt(e.RowIndex);//从DGV移除
                }
            }

            if (e.ColumnIndex == 7)//点击在修改按钮上
            {
                if (MessageBox.Show("是否确认修改？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Employee em = new Employee();
                    em.EmployeeNumber = dgv_employeeinformation.CurrentRow.Cells[0].Value.ToString();
                    em.Name = dgv_employeeinformation.CurrentRow.Cells[1].Value.ToString();
                    em.Sex = dgv_employeeinformation.CurrentRow.Cells[2].Value.ToString();
                    string company = dgv_employeeinformation.CurrentRow.Cells[3].Value.ToString();
                    string department = dgv_employeeinformation.CurrentRow.Cells[4].Value.ToString();
                    string group = dgv_employeeinformation.CurrentRow.Cells[5].Value.ToString();
                    AddOrUpdateEmployee add = new AddOrUpdateEmployee(this,em, company, department, group,e.RowIndex);
                    add.Show();
                }
            }
        }

        //添加员工
        private void bt_addemployee_Click(object sender, EventArgs e)
        {
            AddOrUpdateEmployee add = new AddOrUpdateEmployee(this);
            add.Show();
        }

        //搜索框-在当前分组中搜索
        private void bt_foundnowgroup_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            if (tb_foundemployeeid.Text.ToString().Equals(""))
            {
                em.EmployeeNumber = "";
            }
            else
            {
                em.EmployeeNumber = tb_foundemployeeid.Text;
            }
            em.Name = tb_foundname.Text;
            em.Sex = cb_foundsex.Text;
            if (em.EmployeeNumber.Equals("") && em.Name.Equals("") && em.Sex.Equals("男/女"))
            {
                this.ShowDataGridView(dao.TreeQueryEmployee(level, nodeid));
                return;
            }
            this.ShowDataGridView(dao.QueryInTheGroupEmployee(em, level, nodeid));
        }

        //搜索框-在全部人员中搜索
        private void bt_foundall_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            if(tb_foundemployeeid.Text.ToString().Equals(""))
            {
                em.EmployeeNumber = "";
            }
            else
            {
                em.EmployeeNumber = tb_foundemployeeid.Text;
            }  
            em.Name = tb_foundname.Text;
            em.Sex = cb_foundsex.Text;
            if (em.EmployeeNumber.Equals("") && em.Name.Equals("") && em.Sex.Equals("男/女"))
            {
                this.ShowDataGridView(dao.QueryAllEmployee());
                return;
            }
            this.ShowDataGridView(dao.QueryInTheAllEmployee(em));
        }

        //添加根节点
        private void Btn_addrootnode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_nodename.Text.Trim()))
            {
                MessageBox.Show("请填写要添加的节点名称！");
                return;
            }
            Department department = new Department();
            department.name = tb_nodename.Text;
            department.tier = 0;
            department.belongid = 0;
            if (department.NodeDuplicateChecking())
            {
                MessageBox.Show("已存在该节点，无法重复添加！");
                return;
            }
            Department d = new Department(tb_nodename.Text,0,0);
            ShowTreeView();
            tb_nodename.Text = "";
        }

        //添加子节点
        private void Btn_addchildnode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_nodename.Text.Trim()))
            {
                MessageBox.Show("请填写要添加的节点名称！");
                return;
            }
            if (tv_department.SelectedNode == null)
            {
                MessageBox.Show("请选择父节点！");
                return;
            }
            string treename = tv_department.SelectedNode.FullPath.ToString().Replace("\\", ".");
            string textname = tb_nodename.Text.ToString();
            if (treename.Equals(textname))
            {
                MessageBox.Show("不能与父节点有相同的名字！");
                return;
            }
            Department d = tv_department.SelectedNode.Tag as Department;//获取节点id
            if (d.tier+1 >= 3)
            {
                MessageBox.Show("无法添加小于组的节点！");
                return;
            }
            Department department = new Department();
            department.name = tb_nodename.Text;
            department.tier = d.tier + 1;
            department.belongid = d.id;
            if (department.NodeDuplicateChecking())
            {
                MessageBox.Show("已存在该节点，无法重复添加！");
                return;
            }
            Department de = new Department(tb_nodename.Text, d.tier + 1, d.id);
            ShowTreeView();
            tb_nodename.Text = "";      
        }

        //删除节点
        private void Btn_removenodes_Click(object sender, EventArgs e)
        {
            if (tv_department.SelectedNode == null)
            {
                MessageBox.Show("请选择一个节点");
                return;
            }
            Confirm cf = new Confirm("确定删除该节点？");
            cf.ShowDialog();
            if (cf.DialogResult == DialogResult.OK)
            {
                Department c = (Department)tv_department.SelectedNode.Tag;
                int i = c.deleteSelf();
                if(i==1)
                {
                    tv_department.SelectedNode.Remove();//从TV移除
                    return;
                }
            }
        }

        //选取部门树状图刷新员工信息
        private void tv_department_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DataTable dt = new DataTable();
            Department d = tv_department.SelectedNode.Tag as Department;//获取节点id
            nodeid = d.id;
            level = tv_department.SelectedNode.Level;
            dt = dao.TreeQueryEmployee(level,nodeid);
            ShowDataGridView(dt);
        }

        private void dgv_employeeinformation_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var selectedRows = dgv_employeeinformation.SelectedRows;
            List<int> ids = new List<int>();
            List<string> name = new List<string>();
            foreach (var row in selectedRows)
            {
                int id = int.Parse(((DataGridViewRow)row).Cells[8].Value.ToString());
                string na = (((DataGridViewRow)row).Cells[0].Value.ToString());
                string number = (((DataGridViewRow)row).Cells[1].Value.ToString());
                ids.Add(id);
                name.Add(na);
                name.Add(number);
            }
            EmployeesSelected?.Invoke(ids,name);
        }
    }
}
