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
    public partial class Takeout_Warehouse : Form
    {
        public Takeout_Warehouse()
        {
            InitializeComponent();
        }

        private void Takeout_Warehouse_Load(object sender, EventArgs e)
        {
            Take_Window_style win_sty = new Take_Window_style();
            win_sty.Top_and_Left_(this);
        }
    }
}
