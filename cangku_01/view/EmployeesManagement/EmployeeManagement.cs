using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using cangku_01.interfaceImp;
using cangku_01.entity;
using cangku_01.view.AdminPage;
using cangku_01.interfaces;
using static cangku_01.view.AdminPage.AutoCloseMassageBox;
using System.Drawing;

//员工信息管理页面

namespace cangku_01.view.EmployeesManagement
{
    public partial class EmployeeManagement : Form
    {
        EmployeesInterface dao = new EmployeeDataManipulation();
        private int nodeid;
        private int level;
        private int tier;
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

        //dgv双击事件
        private void dgv_employeeinformation_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FormBorderStyle == FormBorderStyle.FixedSingle)
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
                EmployeesSelected?.Invoke(ids, name);
                Close();
            }
        }

        //鼠标点击在节点上时
        private void tv_department_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point ClickPoint = new Point(e.X, e.Y);
                int x = e.X;
                int y = e.Y;
                TreeNode CurrentNode = tv_department.GetNodeAt(ClickPoint);
                if (CurrentNode is TreeNode)//判断你点的是不是一个节点
                {
                    tv_department.SelectedNode = CurrentNode;
                    CurrentNode.ContextMenuStrip = cms_employeetreeview;
                    cms_employeetreeview.Show(MousePosition);
                    tier = tv_department.SelectedNode.Level;
                    ShowRightClickList();
                }
                else
                {
                    tier = -1;
                    ShowRightClickList();
                }
            }
        }

        //展示右键列表
        public void ShowRightClickList()
        {
            switch (tier)
            {
                case 0:
                    tsm_newcompany.Visible = false;
                    tsm_newdepartment.Visible = true;
                    tsm_newgroup.Visible = false;
                    tsm_delete.Visible = true;
                    tsm_rename.Visible = true;
                    break;
                case 1:
                    tsm_newcompany.Visible = false;
                    tsm_newdepartment.Visible = false;
                    tsm_newgroup.Visible = true;
                    tsm_delete.Visible = true;
                    tsm_rename.Visible = true;
                    break;
                case 2:
                    tsm_newcompany.Visible = false;
                    tsm_newdepartment.Visible = false;
                    tsm_newgroup.Visible = false;
                    tsm_delete.Visible = true;
                    tsm_rename.Visible = true;
                    break;
                case -1:
                    tv_department.ContextMenuStrip = cms_employeetreeview;
                    tsm_newcompany.Visible = true;
                    tsm_newdepartment.Visible = false;
                    tsm_newgroup.Visible = false;
                    tsm_delete.Visible = true;
                    tsm_rename.Visible = true;
                    cms_employeetreeview.Show(MousePosition);
                    break;
            }
        }

        //新建公司
        private void tsm_newcompany_Click(object sender, EventArgs e)
        {
            GetDepartmentNodeName getDepartmentNodeName = new GetDepartmentNodeName("",0,0);
            if (getDepartmentNodeName.ShowDialog() == DialogResult.OK)
            {
                tv_department.Nodes.Add(getDepartmentNodeName.nodeName);
                ShowTreeView();
            }
        }

        //新建部门
        private void tsm_newdepartment_Click(object sender, EventArgs e)
        {
            AddChildNodes();
        }

        //新建小组
        private void tsm_newgroup_Click(object sender, EventArgs e)
        {
            AddChildNodes();
        }

        //添加子节点
        private void AddChildNodes()
        {
            string parentnodename = tv_department.SelectedNode.Text;
            Department node = tv_department.SelectedNode.Tag as Department;
            GetDepartmentNodeName getnodename = new GetDepartmentNodeName(parentnodename, node.tier, node.id);
            if (getnodename.ShowDialog() == DialogResult.OK)
            {
                ShowTreeView();
            }
            tv_department.ExpandAll();
        }

        //删除
        private void tsm_delete_Click(object sender, EventArgs e)
        {
            Confirm cf = new Confirm("确定删除该节点？");
            cf.ShowDialog();
            if (cf.DialogResult == DialogResult.OK)
            {
                Department c = (Department)tv_department.SelectedNode.Tag;
                int i = c.deleteSelf();
                if (i == 1)
                {
                    tv_department.SelectedNode.Remove();//从TV移除
                    return;
                }
            }
        }

        //重命名
        private void tsm_rename_Click(object sender, EventArgs e)
        {
            if (tv_department.SelectedNode.Level == 0)
            {

            }
            string parentnodename = tv_department.SelectedNode.Parent.Text;
            string nodename = tv_department.SelectedNode.Text;
            Department parentnode = tv_department.SelectedNode.Parent.Tag as Department;
            Department node = tv_department.SelectedNode.Tag as Department;
            GetDepartmentNodeName getnodename = new GetDepartmentNodeName(parentnodename, parentnode.id, nodename, node.id);
            if (getnodename.ShowDialog() == DialogResult.OK)
            {
                tv_department.SelectedNode.Text = getnodename.nodeName;
            }
            tv_department.ExpandAll();
        }
    }
}
