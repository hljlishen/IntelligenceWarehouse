﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cangku_01
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //获取用户名和密码
            //String name = textBox1.Text;
            //String password = textBox2.Text;
            String name = "admin";
            String password = "admin";
            if (name.Equals("admin") && password.Equals("admin"))
            {
                MessageBox.Show("登录成功！！");
                //跳转到管理员操作界面，将登录界面关闭
                this.Close();
                Form administration = new Administration();
                administration.ShowDialog();


            }
            else
            {
                MessageBox.Show("用户名或密码错误！！");
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
