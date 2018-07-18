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
    public partial class Due_to_remind : Form
    {
        Interface_remind dao = new InterfaceImp_remind();
        Entity_remind remind = new Entity_remind();

        public Due_to_remind()
        {
            InitializeComponent();

            //将全部员工加载
            List<Entity_remind> All_re = dao.All_remind();

            //循环遍历
            foreach (Entity_remind re in All_re)
            {
                DateTime dt = DateTime.Now;

                DataGridViewRow row = new DataGridViewRow();
                int index = dataGridView1.Rows.Add(row);
                dataGridView1.Rows[index].Cells[0].Value = re.Id;
                dataGridView1.Rows[index].Cells[1].Value = re.Name;
                dataGridView1.Rows[index].Cells[2].Value = re.Manufacturer;
                dataGridView1.Rows[index].Cells[3].Value = re.Lastdate;
                dataGridView1.Rows[index].Cells[4].Value = re.Cycle;
                dataGridView1.Rows[index].Cells[5].Value = re.Lastdate.AddDays(re.Cycle);
                dataGridView1.Rows[index].Cells[6].Value = re.Lastdate.AddDays(re.Cycle) - DateTime.Now; 

            }

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            this.La_nowtime.Text = DateTime.Now.ToString();
        }

        private void Due_to_remind_Load(object sender, EventArgs e)
        {
            Window_style win_sty = new Window_style();
            win_sty.Top_and_Left(this);
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
            if (e.ColumnIndex == 7)//点击在删除按钮上
            {
                if (MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string currentIndex = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    int id = int.Parse(currentIndex);
                    this.dataGridView1.Rows.RemoveAt(e.RowIndex);
                   
                }
            }

        }
    }
}
