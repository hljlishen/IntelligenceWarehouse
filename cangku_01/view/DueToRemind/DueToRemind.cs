using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using cangku_01.entity;
using cangku_01.interfaceImp;
using cangku_01.interfaces;

//到期提醒主页面

namespace cangku_01.view.DueToRemind
{
    public partial class DueToRemind : Form
    {
        RemindInterface dao = new CheckTimeQueryAndUpdate();

        public DueToRemind()
        {
            InitializeComponent();
            DataTable dt = dao.QueryRemindInstrument();
            ShowDataGridView(dt);
            DataGridViewColorTips();
        }

        //DataGridView显示到期数据
        public void ShowDataGridView(DataTable dt)
        {
            Instrument ins = new Instrument();
            dgv_duetoremind.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = dgv_duetoremind.Rows.Add(row);
                ins.LastCheckTime = (DateTime)dr["in_lastchecktimes"];
                ins.CheckCycle = (int)dr["in_checkcycle"]; ;
                dgv_duetoremind.Rows[index].Cells[0].Value = dr["in_tagid"];
                dgv_duetoremind.Rows[index].Cells[1].Value = dr["in_name"];
                dgv_duetoremind.Rows[index].Cells[2].Value = dr["in_manufactor"];
                dgv_duetoremind.Rows[index].Cells[3].Value = dr["in_lastchecktimes"];
                dgv_duetoremind.Rows[index].Cells[4].Value = dr["in_checkcycle"];
                dgv_duetoremind.Rows[index].Cells[5].Value = ins.NextCheckTimes();
                dgv_duetoremind.Rows[index].Cells[6].Value = ins.TimeRemaining();
            }
            dgv_duetoremind.Sort(dgv_duetoremind.Columns[6], ListSortDirection.Descending);
        }

        //DataGridView色彩提示
        public void DataGridViewColorTips()
        {
            for (int x = 0; x < dgv_duetoremind.Rows.Count; x++)
            {
                String s = dgv_duetoremind.Rows[x].Cells[6].Value.ToString();
                int Day = int.Parse(s);
                if (Day <= 0)
                    dgv_duetoremind.Rows[x].DefaultCellStyle.BackColor = Color.Crimson;
                else if (Day > 0 && Day <= 30)
                    dgv_duetoremind.Rows[x].DefaultCellStyle.BackColor = Color.Yellow;
                else if (Day > 30 && Day <= 60)
                    dgv_duetoremind.Rows[x].DefaultCellStyle.BackColor = Color.DodgerBlue;
                else
                    dgv_duetoremind.Rows[x].DefaultCellStyle.BackColor = Color.Lavender;
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            La_nowtime.Text = DateTime.Now.ToString();
        }

        private void Due_to_remind_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            la_time.Text = DateTime.Now.ToString();
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
                    string Remind_id = dgv_duetoremind.CurrentRow.Cells[0].Value.ToString();
                    string Remind_name = dgv_duetoremind.CurrentRow.Cells[1].Value.ToString();
                    string Remind_manufacturer = dgv_duetoremind.CurrentRow.Cells[2].Value.ToString();
                    string Remind_lasttime = dgv_duetoremind.CurrentRow.Cells[3].Value.ToString();                  
                    //跳转到日期修改页面、并将相关数据传入Alter_remind界面
                    UpdateRemind updateremind = new UpdateRemind(Remind_id, Remind_name, Remind_manufacturer, Remind_lasttime);
                    updateremind.ShowDialog();
                }
            }

        }
    }
}
