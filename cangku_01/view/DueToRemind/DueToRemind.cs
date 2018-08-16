using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cangku_01.entity;
using cangku_01.interfaceImp;
using cangku_01.interfaces;

namespace cangku_01.YT
{
    public partial class Due_to_remind : Form
    {
        RemindInterface dao = new RemindInterfaceImp();

        public Due_to_remind()
        {
            InitializeComponent();
            //获取所有的要提示的快过期信息
            List<Instrument> All_re = dao.All_remind();
            //循环遍历在列表中
            foreach (Instrument re in All_re)
            {
                //获取当前时间并且赋值给dt
                DateTime dt = DateTime.Now;
                //创建新的行
                DataGridViewRow row = new DataGridViewRow();
                int index = Dgv_DueToRemind.Rows.Add(row);
                //给同一行的每一列赋值
                 Dgv_DueToRemind.Rows[index].Cells[0].Value = re.TagId;  
                 Dgv_DueToRemind.Rows[index].Cells[1].Value = re.Name;
                 Dgv_DueToRemind.Rows[index].Cells[2].Value = re.Manufactor;
                 Dgv_DueToRemind.Rows[index].Cells[3].Value = re.DateFormatConversion(re.LastCheckTimes);
                 string St_Cycle = re.CheckCycle.ToString();
                 Dgv_DueToRemind.Rows[index].Cells[4].Value = St_Cycle;              
                 Dgv_DueToRemind.Rows[index].Cells[5].Value = re.NextCheckTimes();
                 Dgv_DueToRemind.Rows[index].Cells[6].Value = re.TimeRemaining();

                //判断剩余日期，并划分不同的背景色颜色
                for (int x = 0; x < this.Dgv_DueToRemind.Rows.Count; x++)
                {
                    String s = Dgv_DueToRemind.Rows[x].Cells[6].Value.ToString();
                    int Day = int.Parse(s);
                    if (Day <= 0)
                        this.Dgv_DueToRemind.Rows[x].DefaultCellStyle.BackColor = Color.Crimson;
                    else if(Day > 0 && Day <= 30)
                        this.Dgv_DueToRemind.Rows[x].DefaultCellStyle.BackColor = Color.Yellow;
                    else  if(Day >30 && Day <= 60)
                        this.Dgv_DueToRemind.Rows[x].DefaultCellStyle.BackColor = Color.DodgerBlue;
                    else
                        this.Dgv_DueToRemind.Rows[x].DefaultCellStyle.BackColor = Color.Lavender;
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
                    string Remind_id = Dgv_DueToRemind.CurrentRow.Cells[0].Value.ToString();
                    string Remind_name = Dgv_DueToRemind.CurrentRow.Cells[1].Value.ToString();
                    string Remind_manufacturer = Dgv_DueToRemind.CurrentRow.Cells[2].Value.ToString();
                    string Remind_lasttime = Dgv_DueToRemind.CurrentRow.Cells[3].Value.ToString();
                    
                    //跳转到日期修改页面、并将相关数据传入Alter_remind界面
                    Alter_remind Al_remind = new Alter_remind(Remind_id, Remind_name, Remind_manufacturer, Remind_lasttime);
                    Al_remind.Show();
                }
            }

        }
    }
}
