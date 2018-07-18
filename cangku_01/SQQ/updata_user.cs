using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cangku_01.interfaceImp;
using cangku_01.interfaces;
using cangku_01.entity;
using cangku_01;

namespace cangku_01.SQQ
{
   
    public partial class updata_user : Form
    {

        UserInterface dao = new UserInterfaceImp();
        public updata_user()
        {
            InitializeComponent();
            List<User> list = dao.UpdateUserList();
            foreach(User u in list) { 
            update_tb_id.Text = u.Id.ToString();
            update_tb_name.Text = u.Name;
            update_tb_sex.Text = u.Sex;
            update_tb_tel.Text = u.Tel;
            update_tb_job.Text = u.Job;
            update_tb_temp.Text = u.Temp;
            update_tb_salary.Text = u.Salary.ToString();
            update_tb_jobtime.Text = u.Time.ToString();
            }

        }

        private void updata_user_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //关闭修改界面
            index_employees index_Employees = new index_employees();
            this.Close();

        }
    }
}
