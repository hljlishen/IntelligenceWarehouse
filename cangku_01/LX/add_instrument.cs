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

//添加仪器页面

namespace cangku_01
{
    public partial class add_instrument : Form
    {
        public int id;       //ID
        public string name;     //仪器名称
        public string specifications;       //型号规格
        public string vendor;       //生产厂商
        public string number;       //出厂编号
        public DateTime productiondate;     //生产日期
        public string address;      //货架位置
        public string state;        //在库状态
        public string cycle;        //检定周期
        public DateTime effectivedate;        //有效日期
        public string date;     //历次检验时间
        public string head;      //负责人


        public add_instrument()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)      //取消按钮
        {
            //关闭当前页面
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)      //确定按钮
        {
            //点击确定,弹出输入信息,可以获取到输入的值
            
             List<instrument_entity> s = Collection();
            foreach (instrument_entity ins in s) {
                MessageBox.Show("ID:" + ins.id + "\r\n" + "name:" + ins.name + ins.specifications + ins.vendor +
                    ins.number + ins.productiondate + ins.address + ins.state + ins.cycle + ins.effectivedate +
                    ins.date + ins.head);
            }
                this.Close();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //ID
        {
            //获取textbox中的值
            string txt_id = textBox1.Text.ToString();
            id = int.Parse(txt_id);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)  //name
        {
            string txt_name = textBox2.Text.ToString();
            name = txt_name;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)   //specifications
        {
            string txt_specifications = textBox3.Text.ToString();
            specifications = txt_specifications;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)   //vendor
        {
            string txt_vendor = textBox4.Text.ToString();
            vendor = txt_vendor;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)   //number
        {
            string txt_number = textBox5.Text.ToString();
            number = txt_number;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)//productiondate
        {
            string txt_productiondate = Time1.Text.ToString();
            productiondate = Convert.ToDateTime(txt_productiondate);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)   //address
        {
            string txt_address = textBox7.Text.ToString();
            address = txt_address;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)   //state
        {
            string txt_state = textBox8.Text.ToString();
            state = txt_state;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)   //cycle
        {
            string txt_cycle = textBox9.Text.ToString();
            cycle = txt_cycle;
        }

        private void Time2_ValueChanged(object sender, EventArgs e)  //effectivedate
        {
            string txt_effectivedate =  Time2.Text.ToString();
            effectivedate = Convert.ToDateTime(txt_effectivedate);
        }

        private void textBox11_TextChanged(object sender, EventArgs e)  //date
        {
            string txt_date = textBox11.Text.ToString();
            date = txt_date;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)  //headd
        {
            string txt_head = textBox12.Text.ToString();
            head = txt_head;
        }

        List<instrument_entity> Collection()        //输入的值放在数组中
        {
            List<instrument_entity> list = new List<instrument_entity>();
            instrument_entity a = new instrument_entity();
            a.id = id;
            a.name = name;
            a.specifications = specifications;
            a.vendor = vendor;
            a.number = number;
            a.productiondate = productiondate;
            a.address = address;
            a.state = state;
            a.cycle = cycle;
            a.effectivedate = effectivedate;
            a.date = date;
            a.head = head;

            list.Add(a);
            return list;
        }

       
       
    }
}
