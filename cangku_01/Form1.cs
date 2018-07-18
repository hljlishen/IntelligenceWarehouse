using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.skinEngine1.SkinFile = "Longhorn.ssk";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           label1.Text= DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            this.timer1.Start();
        }

        private void 管理员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //跳转到登录界面
            Form login = new login();
            login.Show();


        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = MessageBox.Show("是否退出？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //this.Dispose();
                Application.Exit();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
