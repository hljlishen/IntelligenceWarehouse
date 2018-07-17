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
    //仪器出库页面
    public partial class Takeout_Warehouse : Form
    {
        WarehInterface dao = new WarehInterfaceImp();
        style sty = new style();
        String s = "请输入员工的姓名";
        Class_Warehouse user = new Class_Warehouse();
        public Takeout_Warehouse()
        {
            InitializeComponent();
        }
        //调用方法固定页面
        private void Takeout_Warehouse_Load(object sender, EventArgs e)
        {
            Take_Window_style win_sty = new Take_Window_style();
            win_sty.Top_and_Left_(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
