using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cangku_01;
using cangku_01.interfaceImp;
using System.Collections;
using cangku_01.entity;
using cangku_01.view.EmployeesManagement;
using cangku_01.view.AdminPage;
using cangku_01.interfaces;
using cangku_01.MysqlConnection;

namespace cangku_01
{
    public partial class index_employees : Form
    {
        EmployeesInterface dao = new EmployeesInterfaceImp();  
        public index_employees()
        {
            InitializeComponent();
        }
       
        private void index_employees_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            //加载部门树状图
            this.ShowTreeView();
            //将全部员工加载
            DataTable dt = dao.FindAllEmployees();
            this.ShowDataGridView(dt);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)//点击在删除按钮上
            {
                if (MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                    string currentIndex = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    int usernumber = int.Parse(currentIndex);
                    int i = dao.DeleteEmployees(usernumber);
                    if(i==1)
                    { 
                        MessageBox.Show("删除成功！");
                        this.dataGridView1.Rows.RemoveAt(e.RowIndex);//从DGV移除
                    }
                    else
                        MessageBox.Show("删除失败！");
                }
                
            }

            if (e.ColumnIndex == 7)//点击在修改按钮上
            {
                if (MessageBox.Show("是否确认修改？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Employees em = new Employees();
                    em.UserNumber = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    em.Name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    em.Sex = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    string company = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    string department = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    string group = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    AddOrAlterEmployees add = new AddOrAlterEmployees(em, company, department, group);
                    add.Show();
                }
            }


        }

        //添加用户
        private void button2_Click(object sender, EventArgs e)
        {
            AddOrAlterEmployees add = new AddOrAlterEmployees();
            add.Show();
        }
        //搜索框
        private void bt_found_Click(object sender, EventArgs e)
        {
            //获取搜索框中的值
            string tb_text = tb_found.Text;

        }

        private void Bt_change_Click(object sender, EventArgs e)
        {
            

        }

        private void Cms_department_Opening(object sender, CancelEventArgs e)
        {

        }

        private void userInterfaceBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Btn_addrootnode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Tb_nodename.Text.Trim()))
            {
                MessageBox.Show("请填写要添加的节点名称！");
                return;
            }
            Department d = new Department(Tb_nodename.Text,0,0);
            //tv_department.Nodes.Add(Tb_nodename.Text.Trim());
            this.ShowTreeView();
            Tb_nodename.Text = "";
        }

        private void Btn_addchildnode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Tb_nodename.Text.Trim()))
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
            string textname = Tb_nodename.Text.ToString();
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
            Department d2 = new Department(Tb_nodename.Text, d.tier + 1, d.id);
            this.ShowTreeView();
            Tb_nodename.Text = "";      
        }

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
                int i = c.deleteSelf(c.id);
                if (i == 1)
                {
                    MessageBox.Show("删除成功！");
                    tv_department.SelectedNode.Remove();//从TV移除
                }
                else
                    MessageBox.Show("删除失败！"); 
            }
        }

        private void tv_department_AfterSelect(object sender, TreeViewEventArgs e)
        {
            EmployeesInterface dao = new EmployeesInterfaceImp();
            DataTable dt = new DataTable();
            Department d = tv_department.SelectedNode.Tag as Department;//获取节点id
            int nodeid = d.id;
            int level = tv_department.SelectedNode.Level;
            dt = dao.TreeFindEmployees(level,nodeid);
            this.ShowDataGridView(dt);
        }

        //dataGridView显示数据
        public void ShowDataGridView(DataTable dt)
        {
            dataGridView1.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                DataGridViewRow row2 = new DataGridViewRow();
                int index = dataGridView1.Rows.Add(row2);
                dataGridView1.Rows[index].Cells[0].Value = dr["em_usernumber"];
                dataGridView1.Rows[index].Cells[1].Value = dr["em_name"];
                dataGridView1.Rows[index].Cells[2].Value = dr["em_sex"];
                dataGridView1.Rows[index].Cells[3].Value = dr["em_company"];
                dataGridView1.Rows[index].Cells[4].Value = dr["em_department"];
                dataGridView1.Rows[index].Cells[5].Value = dr["em_group"];
            }
        }

        //TreeView显示数据
        public void ShowTreeView()
        {
            List<TreeNode> ls = Department.loadDepartmentStructure();
            tv_department.Nodes.Clear();
            tv_department.Nodes.AddRange(ls.ToArray());
            tv_department.ExpandAll();
        }
    }
}
