using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cangku_01.entity;
//添加仪器  观察者模式
namespace cangku_01.LX
{
    public partial class AddInstrument : Form 
    {
        Interface_instrument dao = new InterfaceImp_instrument();
        Instrument ins = new Instrument();

        public AddInstrument()
        {
            InitializeComponent();
            title.Text = "添加仪器基本信息";
        }

        //取消按钮
        private void bt_no_Click_1(object sender, EventArgs e)     
        {
            this.Close();
        }

        //确定按钮
        private void bt_yes_Click(object sender, EventArgs e)    
        {
           
            this.Close();
        }

        private void AddOrModifyInstrument_Load(object sender, EventArgs e)
        {

        }
    }


}
