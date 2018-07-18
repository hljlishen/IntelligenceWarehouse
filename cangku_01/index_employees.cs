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
        style sty = new style();
        String s = "请输入员工的姓名";
        User user = new User();
        String currentIndex;
        List<User> updateUser;
        
       

        public index_employees()
        {
            InitializeComponent();
            //将全部员工加载
            List<User> allUser = dao.findAllUser();
           
            //循环遍历
            foreach (User u in allUser)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = dataGridView1.Rows.Add(row);
                dataGridView1.Rows[index].Cells[0].Value = u.Id;
                dataGridView1.Rows[index].Cells[1].Value = u.Name;
                dataGridView1.Rows[index].Cells[2].Value = u.Sex;
                dataGridView1.Rows[index].Cells[3].Value = u.Tel;
                dataGridView1.Rows[index].Cells[4].Value = u.Temp;
                dataGridView1.Rows[index].Cells[5].Value = u.Job;
                dataGridView1.Rows[index].Cells[6].Value = u.Salary;
                dataGridView1.Rows[index].Cells[7].Value = u.Time;

            }
        }
       
        private void index_employees_Load(object sender, EventArgs e)
        {
            this.tb_found.Text = s;
            this.tb_found.MouseClick += textBox1_MouseClick;
            this.tb_found.Leave += textBox1_Leave;

            style style1 = new style();
            style1.Location(this);

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
                    //获取要修改的id
                    currentIndex = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    int id = int.Parse(currentIndex);
                    //根据用户id查询
                    updateUser= dao.findUserById(id);

                    //跳转到修改页面
                    updata_user updata_User = new updata_user();
                    updata_User.Show();

                }
            }


        }
        //添加用户
        private void button2_Click(object sender, EventArgs e)
        {

            
            //将获取到的数据添加到最后一栏中
            DataGridViewRow row = new DataGridViewRow();
            int index = dataGridView1.Rows.Add(row);
            dataGridView1.Rows[index].Cells[0].Value = tb_id.Text;
            dataGridView1.Rows[index].Cells[1].Value = tb_name.Text;
            dataGridView1.Rows[index].Cells[2].Value = tb_sex.Text;
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
            user.Sex = tb_sex.Text;
            user.Time = dt;
            user.Tel = tb_tel.Text;
            user.Temp = tb_temp.Text;
            user.Job = tb_job.Text;
            user.Salary = double.Parse(tb_salary.Text);
            dao.addUser(user);

        }
        //搜索框
        private void bt_found_Click(object sender, EventArgs e)
        {
            //获取搜索框中的值
            String tb_text = tb_found.Text;
            //根据搜索框的内容查询对应的值
            List<User> findUserById =dao.findUserByName(tb_text);
            //将查询到的结果    循环遍历到datagridview里
            //foreach (User u in findUserById)
            //{
              //  DataGridViewRow row = new DataGridViewRow();
                //int index = dataGridView1.Rows.Add(row);
                //dataGridView1.Rows[index].Cells[0].Value = u.Id;
                //dataGridView1.Rows[index].Cells[1].Value = u.Name;
                //dataGridView1.Rows[index].Cells[2].Value = u.Sex;
                //dataGridView1.Rows[index].Cells[3].Value = u.Tel;
                //dataGridView1.Rows[index].Cells[4].Value = u.Temp;
                //dataGridView1.Rows[index].Cells[5].Value = u.Job;
                //dataGridView1.Rows[index].Cells[6].Value = u.Salary;
                //dataGridView1.Rows[index].Cells[7].Value = u.Time;

            //}

        }
    }
}
