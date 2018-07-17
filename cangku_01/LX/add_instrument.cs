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
        public string id;       //ID
        public string name;     //仪器名称
        public string specifications;       //型号规格
        public string vendor;       //生产厂商
        public string number;       //出厂编号
        public string productiondate;     //生产日期
        public string address;      //货架位置
        public string state;        //在库状态
        public string cycle;        //检定周期
        public string effectivedate;        //有效日期
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
            // MessageBox.Show("ID:"+id+"\r\n"+"name:"+name+ specifications+ vendor+ number+ productiondate+ address+
            //   state+ cycle+ effectivedate+ date+ head);
            String[] s = Values();
            foreach (String st in s) {
                MessageBox.Show(st);
            }
            this.Close();
            //index_instrument ins = new index_instrument();
            //ins.dataGridView1_CellContentClick.
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //ID
        {
            //获取textbox中的值
            string idd = textBox1.Text.ToString();
            id = idd;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)  //name
        {
            string namee = textBox2.Text.ToString();
            name = namee;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)   //specifications
        {
            string specificationss = textBox3.Text.ToString();
            specifications = specificationss;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)   //vendor
        {
            string vendorr = textBox4.Text.ToString();
            vendor = vendorr;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)   //number
        {
            string numberr = textBox5.Text.ToString();
            number = numberr;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)   //productiondate
        {
            string productiondatee = textBox6.Text.ToString();
            productiondate = productiondatee;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)   //address
        {
            string addresss = textBox7.Text.ToString();
            address = addresss;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)   //state
        {
            string statee = textBox8.Text.ToString();
            state = statee;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)   //cycle
        {
            string cyclee = textBox9.Text.ToString();
            cycle = cyclee;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)  //effectivedate
        {
            string effectivedatee = textBox10.Text.ToString();
            effectivedate = effectivedatee;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)  //date
        {
            string datee = textBox11.Text.ToString();
            date = datee;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)  //headd
        {
            string headd = textBox12.Text.ToString();
            head = headd;
        }

        public string[] Values()        //输入的值放在数组中，在其他窗口获取不到数组中的值
        {
            string[] values = {id,name,specifications,vendor,number,productiondate,
                address,state,cycle,effectivedate,date,head};
            
            return values;
        }

    }
}
