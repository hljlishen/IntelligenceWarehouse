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
        public index_instrument()
        {
            InitializeComponent();
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
            MessageBox.Show("单击弹出");
            //方法CellDoubleClick双击事件
        }

        private void button2_Click(object sender, EventArgs e)  //搜索按钮
        {
            //add_instrument adi = new add_instrument();//创建实例，没有值，测试值显示到列表

            //点击添加数据
            string[] values = {"1","name","specifications","vendor","number","productiondate",
                "address","state","cycle","effectivedate","date","head"};
            dataGridView1.Rows.Add(values);
        }

    }
}
