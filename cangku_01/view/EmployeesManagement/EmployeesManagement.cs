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
using cangku_01.interfaces;
using System.Collections;
using cangku_01.entity;
using cangku_01.view.EmployeesManagement;
using cangku_01.MysqlConnection;
using MySql.Data.MySqlClient;

namespace cangku_01
{
    public partial class index_employees : Form
    {
        UserInterface dao = new UserInterfaceImp();
        String s = "请输入员工的姓名";
        User user = new User();
        String currentIndex;      

        public index_employees()
        {
            InitializeComponent();
            //将全部员工加载
            List<User> allUser = dao.findAllUser();
            //循环遍历
            foreach (User u in allUser)
            {
                DataGridViewRow row2 = new DataGridViewRow();
                int index = dataGridView1.Rows.Add(row2);
                dataGridView1.Rows[index].Cells[0].Value = u.Id;
                dataGridView1.Rows[index].Cells[1].Value = u.Name;
                dataGridView1.Rows[index].Cells[2].Value = u.Sex;
                dataGridView1.Rows[index].Cells[3].Value = u.Department;

            }
        }
       
        private void index_employees_Load(object sender, EventArgs e)
        {
            this.tb_found.Text = s;
            this.tb_found.MouseClick += textBox1_MouseClick;
            this.tb_found.Leave += textBox1_Leave;
            this.Top = 0;
            this.Left = 0;
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
                    List<User> updateUser= dao.findUserById(id);
                    foreach (User u in updateUser)
                    {

                    }
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
            String tb_text = tb_found.Text;
            //根据搜索框的内容查询对应的值
            List<User> findUserById =dao.findUserByName(tb_text);
            //将查询到的结果    循环遍历到datagridview里
            foreach (User u in findUserById)
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
            string sql = "insert into TreeTest(nodeName,parentId) values" + "(" + " " + "'" + Tb_nodename.Text.Trim() + "'" + "," + "'" + 0 + "'" + ")";
            DataMysql dbo = new DataMysql();
            dbo.WriteDB(sql);
            string sql2 = "Select id from TreeTest where nodeName="+ Tb_nodename.Text+ "";
            int id = dbo.FirstValue(sql2);
            TreeNode node1 = new TreeNode();
            node1.Tag = id;
            node1.Text = Tb_nodename.Text.Trim();
            treeView1.Nodes.Add(node1);
            Tb_nodename.Text = "";
        }
    }
}
