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
using cangku_01.SQQ;

namespace cangku_01
{
    public partial class index_employees : Form
    {
        UserInterface dao = new UserInterfaceImp();
        String s = "请输入员工的姓名";
        User user = new User();
        String currentIndex;
        string sex;
        
       

        public index_employees()
        {
            InitializeComponent();
            //将全部员工加载
            List<User> allUser = dao.findAllUser();
            DataGridViewRow row = new DataGridViewRow();
            dataGridView1.Rows.Insert(0, row);

            //循环遍历
            foreach (User u in allUser)
            {
                DataGridViewRow row2 = new DataGridViewRow();
                int index = dataGridView1.Rows.Add(row2);
                dataGridView1.Rows[index].Cells[0].Value = u.Id;
                dataGridView1.Rows[index].Cells[1].Value = u.Name;
                dataGridView1.Rows[index].Cells[2].Value = u.Sex;
                dataGridView1.Rows[index].Cells[4].Value = u.Department;

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
           
            if (e.ColumnIndex == 8)//点击在删除按钮上
            {
                if (MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                    string currentIndex = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    int id = int.Parse(currentIndex);
                    this.dataGridView1.Rows.RemoveAt(e.RowIndex);
                    dao.delUser(id);
                }
            }

            if (e.ColumnIndex == 9)//点击在修改按钮上
            {
                if (MessageBox.Show("是否确认修改？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Tital.Text = "修改员工";
                    Bt_change.Text = "确认修改";
                    //获取要修改的id
                    currentIndex = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    int id = int.Parse(currentIndex);
                    //根据用户id查询
                    List<User> updateUser= dao.findUserById(id);
                    foreach (User u in updateUser)
                    {
                        tb_id.Text = u.Id.ToString();
                        tb_name.Text = u.Name;
                        rb_man.Text = u.Sex;
                        rb_man.Checked = true;
                        tb_temp.Text = u.Department;
                    }
                }
            }


        }
        //添加用户
        private void button2_Click(object sender, EventArgs e)
        {
            Tital.Text = "添加员工";
            Bt_change.Text = "确认添加";
            tb_id.Text = null;
            tb_name.Text = null;
            rb_man.Checked = true;
            tb_tel.Text = null;
            tb_job.Text = null;
            tb_temp.Text = null;
            tb_salary.Text = null;
            tb_jobtime.Text = null;
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
            if (Bt_change.Text == "确认添加")
            {
                if (rb_man.Checked == true)
                {
                    sex = rb_man.Text;
                }
                else
                {
                    sex = rb_wonman.Text;
                }
                //将获取到的数据添加到最后一栏中
                DataGridViewRow row = new DataGridViewRow();
                int index = dataGridView1.Rows.Add(row);
                dataGridView1.Rows[index].Cells[0].Value = tb_id.Text;
                dataGridView1.Rows[index].Cells[1].Value = tb_name.Text;
        
                dataGridView1.Rows[index].Cells[2].Value = sex;
                dataGridView1.Rows[index].Cells[3].Value = tb_tel.Text;
                dataGridView1.Rows[index].Cells[4].Value = tb_temp.Text;
                dataGridView1.Rows[index].Cells[5].Value = tb_job.Text;
                dataGridView1.Rows[index].Cells[6].Value = tb_salary.Text;
                dataGridView1.Rows[index].Cells[7].Value = tb_jobtime.Text;
                //从用户获取的数值添加到数据库
                //日期格式的转化
                //DateTime dt = DateTime.ParseExact(tb_jobtime.Text, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                DateTime dt = Convert.ToDateTime(tb_jobtime.Text);
                // Console.WriteLine("dt=" + dt);
                user.Id = int.Parse(tb_id.Text);
                user.Name = tb_name.Text;
                user.Sex = sex;
                user.Department = tb_temp.Text;
                dao.addUser(user);
            }
            if (Bt_change.Text == "确认修改")
            {
                DialogResult dialogResult = MessageBox.Show("修改成功!!");
            }
        }
    }
}
