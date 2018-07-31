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
using cangku_01.LK.interfacelmp;
using cangku_01.LX;
using cangku_01.YT;

namespace cangku_01
{
    public partial class Form1 : Form
    {
        Find_Items find_Items = null;
        temperatureTestInterface temp = new TemperatureTestInterfaceImp();      //实例化温度检测接口
        HumidityInterface humidityInterface = new HumidityInterfaceImp();        //实例化湿度接口
        Interface_PeopleInformation dao = new InterfaceImp_PeopleInformation();
        InstrumentInterfaces instrumentDao = new instrumentInterfaceImp();
        temperature Temperature = new temperature();    //实例化温度类
        Humidity humidity = new Humidity();     //实例化湿度类
        public Form1()
        {
            
            InitializeComponent();
            this.skinEngine1.SkinFile = "Longhorn.ssk";     //添加皮肤
            //防止屏幕闪烁
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true);

            List<User> list = dao.All_information();
            foreach(User en in list)
            {
                Tb_id.Text = en.Id.ToString();
                Tb_name.Text = en.Name;
                Tb_temp.Text = en.Temp;
            }
            Instrument instrument = new Instrument();
            Door door = new Door(instrument);
            instrument.Pass();


            //物品信息的显示
            List<Instrument> ins_list = instrumentDao.find_ins();
            foreach (Instrument ins in ins_list)
            {
                Tb_ShowId.Text = ins.Ins_id.ToString();
                Tb_ShowName.Text = ins.Ins_name;
                Tb_ShowState.Text = ins.Ins_state.ToString();
                Tb_ShowTime.Text = ins.Ins_dateTime.ToString();

            }

            //温度
            temperature temperature = new temperature();
            temperatureTest temperatureTest = new temperatureTest(temperature);
            temperature.temperatureChange();
            List<string> lists= temp.showTemperature();
            foreach(string s in lists)
            {
                Tem_num.Text = s;
            }

            //湿度
            Humidity humidity = new Humidity();
            HumidityTest humidityTest = new HumidityTest(humidity);
            humidity.HumidityChange();
            List<string> lists1 = humidityInterface.showHumidity();
            foreach (string s1 in lists1)
            {
                Hum_num.Text = s1;
            }

            //到期提醒
            Interface_remind Remind_dao = new InterfaceImp_remind();
            List<instrument> All_re = Remind_dao.All_remind();
            //循环遍历在列表中
            foreach (instrument re in All_re)
            {
                //获取当前时间并且赋值给dt
                DateTime dt = DateTime.Now;
                DataGridViewRow row = new DataGridViewRow();
                int index = Dgv_DueToSee.Rows.Add(row);
                Dgv_DueToSee.Rows[index].Cells[0].Value = re.name;
                //下一次最晚检查时间，时间格式转化，只显示年月日（下一次最晚检查时间=上次检查时间+检查周期）
                string St_Nextdate = re.lastCheckTimes.AddDays(re.checkCycle).Year.ToString() + "年" + re.lastCheckTimes.AddDays(re.checkCycle).Month.ToString() + "月" + re.lastCheckTimes.AddDays(re.checkCycle).Day.ToString() + "日";
                Dgv_DueToSee.Rows[index].Cells[1].Value = St_Nextdate;
                //剩余检查时间=下一次最晚检查时间-当前时间,只显示剩余天数
                string St_Expiredate = (re.lastCheckTimes.AddDays(re.checkCycle) - DateTime.Now).Days.ToString();
                Dgv_DueToSee.Rows[index].Cells[2].Value = St_Expiredate;
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
            
            //设置icon
            //this.Icon=
           
        }

        private void 管理员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //跳转到登录界面
            Form login = new login();
            login.Show();

        }
        //点击关闭按钮
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
