using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cangku_01.YT
{
    public partial class Alter_remind : Form
    {
        Interface_remind dao = new InterfaceImp_remind();
        //给Alter_remind构造函数添加自定义参数，接受Due_to_remind界面传来的数据
        public Alter_remind(String Remind_id,String Remind_name,String Remind_manufacturer)
        {
            InitializeComponent();
            //将数据赋值给修改页面
            La_id.Text = Remind_id;
            La_name.Text = Remind_name;
            La_manufacturer.Text = Remind_manufacturer;
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
            //调用修改检查日期的方法
            int a = dao.Alter_remind(Remind_id, Remind_lastdate);
            //判断是否修改成功
            if (a == 1)
            { 
                MessageBox.Show("修改成功!","检查时间修改");
                this.Close();
            }
            else
            { 
                MessageBox.Show("修改失败!","检查时间修改");
            }
        }
    }
}
