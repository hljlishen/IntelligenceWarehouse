using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cangku_01.LX;

namespace cangku_01.YT
{
    public partial class Due_to_remind : Form
    {
        Interface_remind dao = new InterfaceImp_remind();
        instrument remind = new instrument();

        public Due_to_remind()
        {
            InitializeComponent();

            //获取所有的要提示的快过期信息
            List<instrument> All_re = dao.All_remind();

            //循环遍历在列表中
            foreach (instrument re in All_re)
            {
                //获取当前时间并且赋值给dt
                DateTime dt = DateTime.Now;
               
                //创建新的行
                DataGridViewRow row = new DataGridViewRow();
                int index = dataGridView1.Rows.Add(row);
               
                //给同一行的每一列赋值
                 //id
                 dataGridView1.Rows[index].Cells[0].Value = re.tagId;  
                 //name
                 dataGridView1.Rows[index].Cells[1].Value = re.name;
                 //生产厂商
                 dataGridView1.Rows[index].Cells[2].Value = re.manufactor;
                 //上一次检查时间，时间格式转化，只显示年月日
                 string St_Lastdate = re.lastCheckTimes.Year.ToString() + "年" + re.lastCheckTimes.Month.ToString() + "月" + re.lastCheckTimes.Day.ToString() + "日";
                 dataGridView1.Rows[index].Cells[3].Value = St_Lastdate;
                 //检查周期
                 string St_Cycle = re.checkCycle.ToString();
                 dataGridView1.Rows[index].Cells[4].Value = St_Cycle;
                 //下一次最晚检查时间，时间格式转化，只显示年月日（下一次最晚检查时间=上次检查时间+检查周期）
                 string St_Nextdate = re.lastCheckTimes.AddDays(re.checkCycle).Year.ToString() + "年" + re.lastCheckTimes.AddDays(re.checkCycle).Month.ToString() + "月" + re.lastCheckTimes.AddDays(re.checkCycle).Day.ToString() + "日";
                 dataGridView1.Rows[index].Cells[5].Value = St_Nextdate;
                 //剩余检查时间=下一次最晚检查时间-当前时间,只显示剩余天数
                 string St_Expiredate = (re.lastCheckTimes.AddDays(re.checkCycle) - DateTime.Now).Days.ToString();
                 dataGridView1.Rows[index].Cells[6].Value = St_Expiredate;


                //判断剩余日期，并划分不同的背景色颜色
                for (int x = 0; x < this.dataGridView1.Rows.Count - 1; x++)
                {
                    String s = dataGridView1.Rows[x].Cells[6].Value.ToString();
                    int Day = int.Parse(s);
                    if (Day <= 0)
                        this.dataGridView1.Rows[x].DefaultCellStyle.BackColor = Color.Crimson;
                    else if(Day > 0 && Day <= 30)
                        this.dataGridView1.Rows[x].DefaultCellStyle.BackColor = Color.Yellow;
                    else  if(Day >30 && Day <= 60)
                        this.dataGridView1.Rows[x].DefaultCellStyle.BackColor = Color.DodgerBlue;
                    else
                        this.dataGridView1.Rows[x].DefaultCellStyle.BackColor = Color.Lavender;
                }


            }

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            this.La_nowtime.Text = DateTime.Now.ToString();
        }

        private void Due_to_remind_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.la_time.Text = DateTime.Now.ToString();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.ColumnIndex == 7)//点击在修改按钮上
            {
                if (MessageBox.Show("是否确认修改检查时间？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //获取要修改的id、名字、生产厂商
                    string Remind_id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    string Remind_name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    string Remind_manufacturer = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                    //跳转到日期修改页面、并将相关数据传入Alter_remind界面
                    Alter_remind Al_remind = new Alter_remind(Remind_id, Remind_name, Remind_manufacturer);
                    Al_remind.Show();
                }
            }

        }
    }
}
