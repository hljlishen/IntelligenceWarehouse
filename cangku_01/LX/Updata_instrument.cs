using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//修改仪器页面

namespace cangku_01.LX
{
    public partial class Updata_instrument : Form
    {
        Interface_instrument dao = new InterfaceImp_instrument();

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

        public Updata_instrument()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//确定按钮
        {
            List<instrument_entity> s = Updata_Collection();
            dao.Alter_instrument(s);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string txt_name = textBox2.Text.ToString();
            name = txt_name;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string txt_name = textBox2.Text.ToString();
            name = txt_name;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string txt_specifications = textBox3.Text.ToString();
            specifications = txt_specifications;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string txt_vendor = textBox4.Text.ToString();
            vendor = txt_vendor;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string txt_number = textBox5.Text.ToString();
            number = txt_number;
        }

        private void Time1_ValueChanged(object sender, EventArgs e)
        {
            string txt_productiondate = Time1.Text.ToString();
            productiondate = Convert.ToDateTime(txt_productiondate);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string txt_address = textBox7.Text.ToString();
            address = txt_address;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            string txt_state = textBox8.Text.ToString();
            state = txt_state;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            string txt_cycle = textBox9.Text.ToString();
            cycle = txt_cycle;
        }

        private void Time2_ValueChanged(object sender, EventArgs e)
        {
            string txt_effectivedate = Time2.Text.ToString();
            effectivedate = Convert.ToDateTime(txt_effectivedate);
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            string txt_date = textBox11.Text.ToString();
            date = txt_date;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            string txt_head = textBox12.Text.ToString();
            head = txt_head;
        }

        public List<instrument_entity> Updata_Collection()        //输入的值放在数组中
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
