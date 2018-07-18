using cangku_01.LX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//仪器管理页面

namespace cangku_01
{
    public partial class index_instrument : Form
    {
        Interface_instrument dao = new InterfaceImp_instrument();
        instrument_entity instrument = new instrument_entity();

        public index_instrument()
        {
            InitializeComponent();

            //将全部仪器加载
            List<instrument_entity> All_ins = dao.All_instrument();

            //循环遍历
            foreach (instrument_entity ins in All_ins)
            {
               
                DataGridViewRow row = new DataGridViewRow();
                int index = dataGridView1.Rows.Add(row);
                dataGridView1.Rows[index].Cells[0].Value = ins.Id;
                dataGridView1.Rows[index].Cells[1].Value = ins.Name;
                dataGridView1.Rows[index].Cells[2].Value = ins.Specifications;
                dataGridView1.Rows[index].Cells[3].Value = ins.Vendor;
                dataGridView1.Rows[index].Cells[4].Value = ins.Number;
                dataGridView1.Rows[index].Cells[5].Value = ins.Productiondate;
                dataGridView1.Rows[index].Cells[6].Value = ins.Address;
                dataGridView1.Rows[index].Cells[7].Value = ins.State;
                dataGridView1.Rows[index].Cells[8].Value = ins.Cycle;
                dataGridView1.Rows[index].Cells[9].Value = ins.Effectivedate;
                dataGridView1.Rows[index].Cells[10].Value = ins.Date;
                dataGridView1.Rows[index].Cells[11].Value = ins.Head;

            }

        }

        private void index_instrument_Load(object sender, EventArgs e) //整个页面
        {
            //style win_sty = new style();
            this.Left = 0;
            this.Top = 0;
        }

        private void button1_Click(object sender, EventArgs e)  //添加仪器按钮
        {
            add_instrument adi = new add_instrument();
            adi.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) //表
        {
            //方法CellDoubleClick双击事件

            if (e.ColumnIndex == 12)//点击在删除按钮上
            {
                if (MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string currentIndex = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    int id = int.Parse(currentIndex);
                    this.dataGridView1.Rows.RemoveAt(e.RowIndex);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)  //搜索按钮
        {
            
        }

    }
}
