using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cangku_01.view.AdminPage
{
    public partial class Confirm : Form
    {
        public Confirm(string m)
        {
            InitializeComponent();
            La_text.Text = m;
        }

        private void Confirm_Load(object sender, EventArgs e)
        {

        }

        private void Btn_yes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void Btn_no_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
