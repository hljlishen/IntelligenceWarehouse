using System;
using System.Windows.Forms;
using cangku_01.entity;
using cangku_01.interfaceImp;
using cangku_01.interfaces;
using static cangku_01.view.AdminPage.AutoCloseMassageBox;

//检查日期修改界面

namespace cangku_01.view.DueToRemind
{
    public partial class UpdateRemind : Form
    {
        RemindInterface dao = new CheckTimeQueryAndUpdate();
        DateTime Lasttime;
        int _id;
        //给UpdateRemind构造函数添加自定义参数，接受DueToRemind界面传来的数据
        public UpdateRemind(string Remind_id,string Remind_name,string Remind_manufacturer,string Remind_lasttime,int id)
        {
            InitializeComponent();
            //将数据赋值给修改页面
            la_tageid.Text = Remind_id;
            la_name.Text = Remind_name;
            la_manufacturer.Text = Remind_manufacturer;
            _id = id;
            Lasttime = Convert.ToDateTime(Remind_lasttime);
        }

        private void UpdateRemind_Load(object sender, EventArgs e)
        {

        }

        private void bt_updateremind_Click(object sender, EventArgs e)
        {
            Instrument ins = new Instrument();
            //获取到修改页面的仪器ID、转化为int
            ins.TagId = la_tageid.Text;
            ins.Id = _id;
            //获取到修改页面的检查日期、转化为Datetime
            ins.LastCheckTime = Convert.ToDateTime(dtp_lasttime.Text);
            DateTime Nowtime = DateTime.Now;
            //判断选择日期是否符合逻辑--上次检查时间<修改时间<当前时间 
            if (ins.LastCheckTime > Lasttime && ins.LastCheckTime < Nowtime)
            {
                //调用修改检查日期的方法
                dao.UpdateInstrumentLastCheckTime(ins);
                dao.AddInstrumentAllPreviousCheckDate(ins);
                AutoClosingMessageBox.Show("检查日期修改成功", "检查日期修", 1000);
                Close();
                DialogResult = DialogResult.OK;
            }
            else
            {
                AutoClosingMessageBox.Show("日期选择错误", "日期错误", 1000);
            }
           
        }
    }
}
