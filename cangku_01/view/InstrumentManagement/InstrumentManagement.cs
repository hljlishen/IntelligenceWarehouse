using cangku_01.entity;
using cangku_01.interfaceImp;
using cangku_01.interfaces;
using cangku_01.view.InstrumentManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static cangku_01.view.AdminPage.AutoCloseMassageBox;

//仪器管理

namespace cangku_01.view.InstrumentManagement
{
    public partial class InstrumentManagement : Form
    {
        InstrumentInterface dao = new InstrumentInterfaceImp();
        Instrument ins = new Instrument();

        public InstrumentManagement()
        {
            InitializeComponent();
        }

        private void index_instrument_Load(object sender, EventArgs e)
        {
            this.txt_found.Text = "请输入仪器名称";
            this.txt_found.MouseClick += textBox1_MouseClick;
            this.txt_found.Leave += textBox1_Leave;
            this.Left = 0;
            this.Top = 0;
            DataTable dt = dao.QueryAllInstrument();//将全部员工加载
            this.ShowDataGridView(dt);
        }

        //DataGridView显示数据
        public void ShowDataGridView(DataTable dt)
        {
            dgv_instrumentinformation.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                DataGridViewRow row2 = new DataGridViewRow();
                int index = dgv_instrumentinformation.Rows.Add(row2);
                dgv_instrumentinformation.Rows[index].Cells[0].Value = dr["in_tagid"];
                dgv_instrumentinformation.Rows[index].Cells[1].Value = dr["in_name"];
                dgv_instrumentinformation.Rows[index].Cells[2].Value = dr["in_model"];
                dgv_instrumentinformation.Rows[index].Cells[3].Value = dr["in_manufactor"];
                dgv_instrumentinformation.Rows[index].Cells[4].Value = dr["in_position"];
                dgv_instrumentinformation.Rows[index].Cells[5].Value = dr["in_isinwarehouse"];
                dgv_instrumentinformation.Rows[index].Cells[6].Value = dr["in_duty"];
            }
        }

        //仪器添加
        private void button1_Click(object sender, EventArgs e)  
        {
            AddOrUpdateInstrument add = new AddOrUpdateInstrument(this);
            add.ShowDialog();
        }

        //仪器的修改删除
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {
            //删除
            if (e.ColumnIndex == 7)
            {
                if (MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ins.TagId = dgv_instrumentinformation.CurrentRow.Cells[0].Value.ToString();
                    dao.DeleteInstrument(ins);
                    AutoClosingMessageBox.Show("仪器信息删除成功", "仪器信息删除", 1000);
                    dgv_instrumentinformation.Rows.RemoveAt(e.RowIndex);//从DGV移除
                }
            }
            //修改
            if (e.ColumnIndex == 8)
            {
                if (MessageBox.Show("是否确认修改？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //获取要修改属性
                    Instrument ins = new Instrument();
                    ins.TagId = dgv_instrumentinformation.CurrentRow.Cells[0].Value.ToString();
                    AddOrUpdateInstrument Update = new AddOrUpdateInstrument(this, ins, e.RowIndex);
                    Update.ShowDialog();
                }
            }
            //修改
            if (e.ColumnIndex == 9)
            {
                 //获取要修改属性
                 Instrument ins = new Instrument();
                 ins.TagId = dgv_instrumentinformation.CurrentRow.Cells[0].Value.ToString();
                 AddOrUpdateInstrument add = new AddOrUpdateInstrument(ins);
                 add.ShowDialog(); 
            }
        }

        //搜索按钮
        private void button2_Click(object sender, EventArgs e)  
        {
            //获取搜索框中的值  name查
            String tb_text = txt_found.Text;
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
