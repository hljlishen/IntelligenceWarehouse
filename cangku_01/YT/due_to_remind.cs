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
    public partial class Due_to_remind : Form
    {
        public Due_to_remind()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.La_nowtime.Text = DateTime.Now.ToString();
        }

        private void due_to_remind_Load(object sender, EventArgs e)
        {
            Window_style win_sty = new Window_style();
            win_sty.Top_and_Left(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.la_time.Text = DateTime.Now.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
