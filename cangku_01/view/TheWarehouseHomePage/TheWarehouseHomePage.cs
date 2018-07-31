using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cangku_01.SQQ;
using cangku_01.LK;
using cangku_01.entity;
using cangku_01.interfaceImp;
using cangku_01.interfaces;

namespace cangku_01
{
    public partial class Form1 : Form
    {
        Find_Items find_Items = null;
        Interface_PeopleInformation dao = new InterfaceImp_PeopleInformation();
        InstrumentInterfaces instrumentDao = new instrumentInterfaceImp();
        public Form1()
        {
            
            InitializeComponent();
            //添加皮肤
            this.skinEngine1.SkinFile = "Longhorn.ssk";    
            //防止屏幕闪烁
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); 
            SetStyle(ControlStyles.DoubleBuffer, true);

            List<User> list = dao.All_information();
            foreach(User en in list)
            {
                Tb_id.Text = en.Id.ToString();
                Tb_name.Text = en.Name;
                Tb_temp.Text = en.Department;
            }
            
            //物品信息的显示
            List<Instrument> ins_list = instrumentDao.find_ins();
            foreach (Instrument ins in ins_list)
            {
                Tb_ShowId.Text = ins.TagId.ToString();
                Tb_ShowName.Text = ins.Name;
                Tb_ShowState.Text = ins.IsInWareHouse.ToString();
                Tb_ShowTime.Text = DateTime.Now.ToString();

            }

            //到期提醒-首页
            Interface_remind Remind_dao = new InterfaceImp_remind();
            List<Instrument> All_re = Remind_dao.All_remind();
            foreach (Instrument re in All_re)
            {
                DateTime dt = DateTime.Now;
                DataGridViewRow row = new DataGridViewRow();
                int index = Dgv_DueToSee.Rows.Add(row);
                Dgv_DueToSee.Rows[index].Cells[0].Value = re.Name;
                Dgv_DueToSee.Rows[index].Cells[1].Value = re.NextCheckTimes(re.LastCheckTimes,re.CheckCycle);
                Dgv_DueToSee.Rows[index].Cells[2].Value = re.TimeRemaining(re.LastCheckTimes,re.CheckCycle);
            }

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        //点击查询按钮
        private void button1_Click(object sender, EventArgs e)
        {
            //如果窗口已经存在就不能再次打开
           
            if (find_Items==null)
            {
                find_Items = new Find_Items();
                find_Items.Show();
            }else if (find_Items.IsDisposed)
            {
                find_Items = null;
            }
            else if (find_Items != null) { 
            {
                DialogResult result = MessageBox.Show("查询窗口已经存在！！");
            }
            }


        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tem_num_Click(object sender, EventArgs e)
        {

        }

        private void Hum_num_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form login = new login();
            login.Show();
        }
    }
}
