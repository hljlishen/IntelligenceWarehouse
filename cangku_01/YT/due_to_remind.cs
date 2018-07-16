using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cangku_01.YT
{
    public partial class due_to_remind : Form
    {
        public due_to_remind()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.la_nowtime.Text = DateTime.Now.ToString();
        }

        private void due_to_remind_Load(object sender, EventArgs e)
        {
            window_style win_sty = new window_style();
            win_sty.Top_and_Left(this);
        }
    }
}
