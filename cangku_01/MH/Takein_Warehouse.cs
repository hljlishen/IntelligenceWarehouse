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
        public Takein_Warehouse()
        {
            InitializeComponent();
        }
        //调用方法固定页面
        private void Takein_Warehouse_Load(object sender, EventArgs e)
        {
            Take_Window_style win_sty = new Take_Window_style();
            win_sty.Top_and_Left_(this);
        }
    }
}
