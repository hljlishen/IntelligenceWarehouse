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

namespace cangku_01
{
    public partial class index_employees : Form
    {
        EmployeesInterface dao = new EmployeesInterfaceImp();
        String s = "请输入员工的姓名";
        Employees user = new Employees();
        String currentIndex;      

        public index_employees()
        {
            InitializeComponent();
        }
       
        private void index_employees_Load(object sender, EventArgs e)
        {
            this.tb_found.Text = s;
            this.tb_found.MouseClick += textBox1_MouseClick;
            this.tb_found.Leave += textBox1_Leave;
            this.Top = 0;
            this.Left = 0;

            //加载部门树状图
            List<TreeNode> ls = Department.loadDepartmentStructure();
            tv_department.Nodes.Clear();
            tv_department.Nodes.AddRange(ls.ToArray());
            tv_department.ExpandAll();

            //将全部员工加载
            List<Employees> allUser = dao.findAllUser();
            //循环遍历
            foreach (Employees u in allUser)
            {
                DataGridViewRow row2 = new DataGridViewRow();
                int index = dataGridView1.Rows.Add(row2);
                dataGridView1.Rows[index].Cells[0].Value = u.Id;
                dataGridView1.Rows[index].Cells[1].Value = u.Name;
                dataGridView1.Rows[index].Cells[2].Value = u.Sex;
                dataGridView1.Rows[index].Cells[3].Value = u.Department;

            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.tb_found.Text.Trim() == s)
            {
                this.tb_found.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (this.tb_found.Text.Trim()== "")
            {
                this.tb_found.Text = s;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.ColumnIndex == 4)//点击在删除按钮上
            {
                if (MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                    string currentIndex = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    int id = int.Parse(currentIndex);
                    this.dataGridView1.Rows.RemoveAt(e.RowIndex);
                    dao.delUser(id);
                }
            }

            if (e.ColumnIndex == 5)//点击在修改按钮上
            {
                if (MessageBox.Show("是否确认修改？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //获取要修改的id
                    currentIndex = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    int id = int.Parse(currentIndex);
                    //根据用户id查询
                    List<Employees> updateUser= dao.findUserById(id);
                    foreach (Employees u in updateUser)
                    {

                    }
                }
            }


        }

        //添加用户
        private void button2_Click(object sender, EventArgs e)
        {
            TreeNode tn = tv_department.SelectedNode;
            TreeNode group;
            TreeNode department;
            TreeNode company;
            if (tn == null) //没有选中节点
            {
                MessageBox.Show("请先选择要添加联系人的部门");
                return;
            }
            if (tn.Nodes.Count != 0 || tn.Parent.Parent.Parent != null) //确定选中到部门
            {
                MessageBox.Show("未精确到小组");
                return;
            }
            group = tv_department.SelectedNode;
            department = group.Parent;
            company = department.Parent;
            string group1 = group.Text.ToString();
            string department1 = department.Text.ToString();
            string company1 = company.Text.ToString();
            AddOrAlterEmployees add = new AddOrAlterEmployees(group1, department1, company1);
            add.Show();
        }
        //搜索框
        private void bt_found_Click(object sender, EventArgs e)
        {
            //获取搜索框中的值
            String tb_text = tb_found.Text;
            //根据搜索框的内容查询对应的值
            List<Employees> findUserById =dao.findUserByName(tb_text);
            //将查询到的结果    循环遍历到datagridview里
            foreach (Employees u in findUserById)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = dataGridView1.Rows.Add(row);
                dataGridView1.Rows[index].Cells[0].Value = u.Id;
                dataGridView1.Rows[index].Cells[1].Value = u.Name;
                dataGridView1.Rows[index].Cells[2].Value = u.Sex;
                dataGridView1.Rows[index].Cells[4].Value = u.Department;

            }

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
            Tb_nodename.Text = "";
            //从新加载数据
            this.index_employees_Load(sender, e);
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
            Department d = tv_department.SelectedNode.Tag as Department;
            if (d.tier+1 >= 3)
            {
                MessageBox.Show("无法添加小于组的节点！");
                return;
            }
            Department d2 = new Department(Tb_nodename.Text, d.tier + 1, d.id);
            Tb_nodename.Text = "";
            this.index_employees_Load(sender, e);
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
                TreeNode node = tv_department.SelectedNode;
                string nodename1 = node.Text.ToString();
                string nodename2 = "";
                string nodename3 = "";
                if (node.Parent == null)
                {
                    c.deleteSelf(nodename1, nodename2, nodename3);
                    this.index_employees_Load(sender, e);
                    return;
                }
                if (node.Parent != null && node.Parent.Parent == null)
                {
                    nodename3 = node.Parent.Text.ToString();
                    c.deleteSelf(nodename3, nodename1, nodename2);
                    this.index_employees_Load(sender, e);
                    return;
                }
                nodename2 = node.Parent.Text.ToString();
                nodename3 = node.Parent.Parent.Text.ToString();
                c.deleteSelf(nodename3, nodename2, nodename1);
                this.index_employees_Load(sender, e);
            }
        }
    }
}
