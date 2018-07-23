using cangku_01.MH.interfaceImp;
using cangku_01.MH.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cangku_01.MH
{
    //仪器入库页面
    public partial class Takein_Warehouse : Form
    {
        Interface_warehouse dao = new InterfaceImp_warehouse();
        style sty = new style();
        String s = "请输入员工的姓名";
        Warehouse user = new Warehouse();
        public Takein_Warehouse()
        {
            InitializeComponent();
            //将全部出入库仪器加载
            List<Warehouse> All_ware = dao.All_warehouse();

            //循环遍历
            foreach (Warehouse wh in All_ware)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = dataGridView1.Rows.Add(row);
                dataGridView1.Rows[index].Cells[0].Value = wh.Warehouse_id;
                dataGridView1.Rows[index].Cells[1].Value = wh.Warehouse_name;
                dataGridView1.Rows[index].Cells[2].Value = wh.Location;
                dataGridView1.Rows[index].Cells[3].Value = wh.Inbound_number;
                dataGridView1.Rows[index].Cells[4].Value = wh.InboundDate;
                dataGridView1.Rows[index].Cells[5].Value = wh.Remaining_number;
                dataGridView1.Rows[index].Cells[6].Value = wh.Model;
                dataGridView1.Rows[index].Cells[7].Value = wh.Manufacturers;
                dataGridView1.Rows[index].Cells[8].Value = wh.ProductionDate;
                dataGridView1.Rows[index].Cells[9].Value = wh.Name;
                dataGridView1.Rows[index].Cells[10].Value = wh.Principal;

            }
        }
        //调用方法固定页面
        private void Takein_Warehouse_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = s;
            this.textBox1.MouseClick += textBox1_MouseClick;
            this.textBox1.Leave += textBox1_Leave;
            Take_Window_style win_sty = new Take_Window_style();
            win_sty.Top_and_Left_(this);
        }
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.textBox1.Text.Trim() == s)
            {
                this.textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Trim() == "")
            {
                this.textBox1.Text = s;
            }
        }
        //搜索框
        private void bt_people_search_Click(object sender, EventArgs e)
        {
            //获取搜索框中的值
            String tb_name = textBox1.Text;
            //根据搜索框的内容查询对应的值
            dao.findUserByName(tb_name);
        }

        private void bt_time_search_Click(object sender, EventArgs e)
        {
            DateTime dt1 = Convert.ToDateTime(dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"));  //获取的日期1
            DateTime dt2 = Convert.ToDateTime(dateTimePicker2.Value.Date.ToString("yyyy-MM-dd"));   //获取的日期2,需增加部分代码使dt2大于dt1
            if (DateTime.Compare(dt1, dt2) > 0) //判断日期大小
            {

                MessageBox.Show("dateTimePicker1的日期大于dateTimePicker2的日期");
            }
     
            //根据搜索框的内容查询对应的值
            dao.findDate(dt1,dt2);
        }
    }
}
