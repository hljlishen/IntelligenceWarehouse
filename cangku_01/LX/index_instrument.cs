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

namespace cangku_01
{
    public partial class index_instrument : Form
    {
        Interface_instrument dao = new InterfaceImp_instrument();
        instrument instrument = new instrument();

        public index_instrument()
        {
            InitializeComponent();
            //将全部仪器加载
            List<instrument> All_ins = dao.All_instrument();

            foreach (instrument ins in All_ins)
            {
               
                DataGridViewRow row = new DataGridViewRow();
                int index = dataGridView1.Rows.Add(row);
                dataGridView1.Rows[index].Cells[0].Value = ins.tagId;
                dataGridView1.Rows[index].Cells[1].Value = ins.name;
                dataGridView1.Rows[index].Cells[2].Value = ins.model;
                dataGridView1.Rows[index].Cells[3].Value = ins.manufactor;
                dataGridView1.Rows[index].Cells[4].Value = ins.serialNumber;
                string productionDate = ins.productionDate.Year.ToString() + "年" + ins.productionDate.Month.ToString() + "月" + ins.productionDate.Day.ToString() + "日";
                dataGridView1.Rows[index].Cells[5].Value = productionDate;
                dataGridView1.Rows[index].Cells[6].Value = ins.position;
                dataGridView1.Rows[index].Cells[7].Value = ins.isInWareHouse;
                dataGridView1.Rows[index].Cells[8].Value = ins.checkCycle;
                string lastCheckTimes = ins.lastCheckTimes.Year.ToString() + "年" + ins.lastCheckTimes.Month.ToString() + "月" + ins.lastCheckTimes.Day.ToString() + "日";
                dataGridView1.Rows[index].Cells[9].Value = lastCheckTimes;
                dataGridView1.Rows[index].Cells[10].Value = ins.instrumentNumber;
                dataGridView1.Rows[index].Cells[11].Value = ins.manager;
            }
           
        }

        private void index_instrument_Load(object sender, EventArgs e)
        {
            this.txt_found.Text = "请输入仪器名称";
            this.txt_found.MouseClick += textBox1_MouseClick;
            this.txt_found.Leave += textBox1_Leave;
            this.Left = 0;
            this.Top = 0;
        }

        //仪器添加
        private void button1_Click(object sender, EventArgs e)  
        {
            AddOrModifyInstrument add = new AddOrModifyInstrument();
            add.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {
            //删除
            if (e.ColumnIndex == 12)
            {
                if (MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string currentIndex = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    int id = int.Parse(currentIndex);
                    this.dataGridView1.Rows.RemoveAt(e.RowIndex);

                    dao.Delete_instrument(id);
                }
            }
            //修改
            if (e.ColumnIndex == 13)
            {
                if (MessageBox.Show("是否确认修改？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //获取要修改属性
                    string[] alter_instrument = new string[13];
                    for(int i = 0; i <= 12; i++)
                    {
                        alter_instrument[i] = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                    }
                    //跳转到修改页面
                    AddOrModifyInstrument  mod = new AddOrModifyInstrument(alter_instrument);
                    mod.Show();
                }
            }
        }

        

        private void button2_Click(object sender, EventArgs e)  //搜索按钮
        {
            //获取搜索框中的值  name查
            String tb_text = txt_found.Text;
            //根据搜索框的内容查询对应的值
            dao.findInstrumentByName(tb_text);
        }
        //搜索框
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.txt_found.Text.Trim() == "请输入仪器名称")
            {
                this.txt_found.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (this.txt_found.Text.Trim() == "")
            {
                this.txt_found.Text = "请输入仪器名称";
            }
        }
        private void txt_found_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
