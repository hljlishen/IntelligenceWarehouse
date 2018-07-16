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

namespace cangku_01
{
    public partial class index_employees : Form
    {
        public index_employees()
        {
            InitializeComponent();
        }
        UserInterface dao = new UserInterfaceImp();
        style sty = new style();
        String s = "请输入员工的姓名、ID";
        User user = new User();
       
        private void index_employees_Load(object sender, EventArgs e)
        {
            this.tb_found.Text = s;
            this.tb_found.MouseClick += textBox1_MouseClick;
            this.tb_found.Leave += textBox1_Leave;


            //DataGridViewTextBoxColumn col = newDataGridViewTextBoxColumn();
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

        }

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
            user.Id = tb_id.Text;user.Name = tb_name.Text;user.Sex = tb_sex.Text;user.Time = tb_jobtime.Text;
            user.Tel = tb_tel.Text;user.Temp = tb_temp.Text;user.Job = tb_job.Text;user.Salary = tb_salary.Text;
            dao.addUser(user);

        }
        //搜索框
        private void bt_found_Click(object sender, EventArgs e)
        {
            //获取搜索框中的值
            String tb_text = tb_found.Text;

        }
    }
}
