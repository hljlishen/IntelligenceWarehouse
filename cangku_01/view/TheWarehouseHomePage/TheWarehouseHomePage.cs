﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cangku_01.SQQ;
using cangku_01.entity;
using cangku_01.interfaceImp;
using cangku_01.interfaces;
using cangku_01.GateDrive;

namespace cangku_01
{
    public partial class Form1 : Form
    {
        Find_Items find_Items = null;

        public Form1()
        {
            InitializeComponent();
            //添加皮肤
            this.skinEngine1.SkinFile = "Longhorn.ssk";    
            //防止屏幕闪烁
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); 
            SetStyle(ControlStyles.DoubleBuffer, true);
            
            

            //到期提醒-首页
            RemindInterface Remind_dao = new RemindInterfaceImp();
            List<Instrument> All_re = Remind_dao.All_remind();
            foreach (Instrument re in All_re)
            {
                DateTime dt = DateTime.Now;
                DataGridViewRow row = new DataGridViewRow();
                int index = Dgv_DueToSee.Rows.Add(row);
                Dgv_DueToSee.Rows[index].Cells[0].Value = re.Name;
                Dgv_DueToSee.Rows[index].Cells[1].Value = re.NextCheckTimes();
                Dgv_DueToSee.Rows[index].Cells[2].Value = re.TimeRemaining();
            }

        }
        GateInterface gate = new GateInterfaceImp();
        private void timer1_Tick(object sender, EventArgs e)
        {
           label1.Text= DateTime.Now.ToString();
           gate.StartDetect(this);
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            lock (this)
            {
                timer2.Stop();
                if (Tb_ShowId.Text != string.Empty)
                {
                    Tb_ShowId.Text = "";
                    Tb_ShowState.Text = "";
                    Tb_ShowTime.Text = "";
                }
            }
        }
        private void Tb_ShowId_TextChanged(object sender, EventArgs e)
        {
            lock (this)
            {
                timer2.Stop();
                timer2.Start();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            this.timer1.Start();
            timer2.Interval = 20000;//延时20000毫秒
            timer2.Tick += new EventHandler(timer2_Tick);
            gate.Open();
        }

        //跳转到登录界面
        private void 管理员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form login = new login();
            login.Show();

        }
        //点击关闭按钮
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = MessageBox.Show("是否退出？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //点击查询按钮
        private void button1_Click(object sender, EventArgs e)
        {
            //如果窗口已经存在就不能再次打开

            if (find_Items == null)
            {
                find_Items = new Find_Items();
                find_Items.Show();
            }
            else if (find_Items.IsDisposed)
            {
                find_Items = null;
            }
            else if (find_Items != null)
            {
                DialogResult result = MessageBox.Show("查询窗口已经存在！！");
            }
            
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form login = new login();
            login.Show();
        }


    }
}
