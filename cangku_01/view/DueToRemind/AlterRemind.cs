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

namespace cangku_01.YT
{
    public partial class Alter_remind : Form
    {
        Interface_remind dao = new InterfaceImp_remind();
        DateTime Lasttime;
        //给Alter_remind构造函数添加自定义参数，接受Due_to_remind界面传来的数据
        public Alter_remind(string Remind_id,string Remind_name,string Remind_manufacturer,string Remind_lasttime)
        {
            InitializeComponent();
            //将数据赋值给修改页面
            La_id.Text = Remind_id;
            La_name.Text = Remind_name;
            La_manufacturer.Text = Remind_manufacturer;
            Lasttime = Convert.ToDateTime(Remind_lasttime);
        }

        private void Alter_remind_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //获取到修改页面的仪器ID、转化为int
            int Remind_id = int.Parse(La_id.Text);
            //获取到修改页面的检查日期、转化为Datetime
            DateTime Remind_lastdate = Convert.ToDateTime(Dtp_lasttime.Text);
            DateTime Nowtime = DateTime.Now;
            //判断选择日期是否符合逻辑--修改时间>上次检查时间<当前时间
            if (Remind_lastdate > Lasttime && Remind_lastdate < Nowtime)
            {
                //调用修改检查日期的方法
                int a = dao.Alter_remind(Remind_id, Remind_lastdate);
                //判断是否修改成功
                if (a == 1)
                {
                    MessageBox.Show("修改成功!", "检查时间修改");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败!", "检查时间修改");
                }
            }
            else
            {
                MessageBox.Show("日期选择错误!", "检查时间修改");
            }
           
        }
    }
}
