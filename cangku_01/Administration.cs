using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cangku_01;


namespace cangku_01
{
    public partial class Administration : Form
    {
        public Administration()
        {
            InitializeComponent();
        }
        style s = new style();

        private void 员工管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s.b(this);
            Form fr = new index_employees();
            fr.MdiParent = this;
            fr.Show();
        }

        private void Administration_Load(object sender, EventArgs e)
        {

        }

        private void 仪器管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s.b(this);
            Form fr = new index_instrument();
            fr.MdiParent = this;
            fr.Show();
        }
    }
}
