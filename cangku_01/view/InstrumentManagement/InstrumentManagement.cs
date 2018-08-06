using cangku_01.entity;
using cangku_01.interfaceImp;
using cangku_01.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//仪器管理

namespace cangku_01
{
    public partial class index_instrument : Form
    {
        InstrumentInterface dao = new InstrumentInterfaceImp();

        public index_instrument()
        {
            InitializeComponent();
            //将全部仪器加载
            List<Instrument> All_ins = dao.All_instrument();

            foreach (Instrument ins in All_ins)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = dataGridView1.Rows.Add(row);
                dataGridView1.Rows[index].Cells[0].Value = ins.TagId;
                dataGridView1.Rows[index].Cells[1].Value = ins.Name;
                dataGridView1.Rows[index].Cells[2].Value = ins.Model;
                dataGridView1.Rows[index].Cells[3].Value = ins.Manufactor;
                dataGridView1.Rows[index].Cells[4].Value = ins.SerialNumber;
                dataGridView1.Rows[index].Cells[5].Value = ins.DateFormatConversion(ins.ProductionDate);
                dataGridView1.Rows[index].Cells[6].Value = ins.Position;
                dataGridView1.Rows[index].Cells[7].Value = ins.IsInWareHouse;
                dataGridView1.Rows[index].Cells[8].Value = ins.CheckCycle;
                dataGridView1.Rows[index].Cells[9].Value = ins.DateFormatConversion(ins.LastCheckTimes);
                dataGridView1.Rows[index].Cells[10].Value = ins.Duty;
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
            AddInstrument add = new AddInstrument();
            add.Show();
        }

        //仪器的修改删除
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {
            //删除
            if (e.ColumnIndex == 11)
            {
                if (MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string currentIndex = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    int id = int.Parse(currentIndex);
                    int i = dao.Delete_instrument(id);
                    if (i == 1)
                    {
                        MessageBox.Show("删除成功!", "仪器管理");
                    }
                    else
                    {
                        MessageBox.Show("删除失败!", "仪器管理");
                    }
                }
            }
            //修改
            if (e.ColumnIndex == 12)
            {
                if (MessageBox.Show("是否确认修改？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //获取要修改属性
                    Instrument a = new Instrument();
                    a.TagId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    a.Name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    a.Model = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    a.Manufactor = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    a.SerialNumber = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    a.ProductionDate = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                    a.Position = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    a.IsInWareHouse = Boolean.Parse(dataGridView1.CurrentRow.Cells[7].Value.ToString());
                    a.CheckCycle = int.Parse(dataGridView1.CurrentRow.Cells[8].Value.ToString());
                    a.LastCheckTimes = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[9].Value.ToString());
                    a.Duty = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                    int i = dao.Alter_instrument(a);
                    if (i == 1)
                    {
                        MessageBox.Show("修改成功!", "仪器管理");
                    }
                    else 
                    {
                        MessageBox.Show("修改失败!", "仪器管理");
                    }

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
