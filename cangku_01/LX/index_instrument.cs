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
        string currentIndex;//放id

        String s = "请输入仪器名称";
        Interface_instrument dao = new InterfaceImp_instrument();
        instrument instrument = new instrument();

        public index_instrument()
        {
            InitializeComponent();

            //将全部仪器加载
            List<instrument> All_ins = dao.All_instrument();

            //循环遍历
            foreach (instrument ins in All_ins)
            {
               
                DataGridViewRow row = new DataGridViewRow();
                int index = dataGridView1.Rows.Add(row);
                dataGridView1.Rows[index].Cells[0].Value = ins.tagId;
                dataGridView1.Rows[index].Cells[1].Value = ins.name;
                dataGridView1.Rows[index].Cells[2].Value = ins.model;
                dataGridView1.Rows[index].Cells[3].Value = ins.manufactor;
                dataGridView1.Rows[index].Cells[4].Value = ins.serialNumber;
                dataGridView1.Rows[index].Cells[5].Value = ins.productionDate;
                dataGridView1.Rows[index].Cells[6].Value = ins.position;
                dataGridView1.Rows[index].Cells[7].Value = ins.isInWareHouse;
                dataGridView1.Rows[index].Cells[8].Value = ins.checkCycle;
                dataGridView1.Rows[index].Cells[9].Value = ins.previousCheckTimes;
                dataGridView1.Rows[index].Cells[10].Value = ins.manager;
            }
           
        }

        private void index_instrument_Load(object sender, EventArgs e) //整个页面
        {
            this.txt_found.Text = s;
            this.txt_found.MouseClick += textBox1_MouseClick;
            this.txt_found.Leave += textBox1_Leave;
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

            if (e.ColumnIndex == 11)//点击在删除按钮上
            {
                if (MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string currentIndex = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    int id = int.Parse(currentIndex);
                    this.dataGridView1.Rows.RemoveAt(e.RowIndex);

                    dao.Delete_instrument(id);
                }
            }

            if (e.ColumnIndex == 12)//点击在修改按钮上
            {
                if (MessageBox.Show("是否确认修改？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //获取要修改的id
                    currentIndex = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    int id = int.Parse(currentIndex);
                    //根据用户id查询 copy
                    //  updateUser = dao.findUserById(id);

                    //跳转到修改页面
                    Updata_instrument up = new Updata_instrument();
                    up.Show();
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
            if (this.txt_found.Text.Trim() == s)
            {
                this.txt_found.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (this.txt_found.Text.Trim() == "")
            {
                this.txt_found.Text = s;
            }
        }
        private void txt_found_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
