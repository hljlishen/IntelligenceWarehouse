using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cangku_01.SQQ;

namespace cangku_01.SQQ
{
    public partial class Find_Items : Form
    {
        String instrument_query_info = "请输入仪器的名称";
        String Component_query_info = "请输入元器件的名称";
        public Find_Items()
        {
            InitializeComponent();
            Component.Text = Component_query_info;
            Instrument.Text = instrument_query_info;
        }

        private void Find_Items_Load(object sender, EventArgs e)
        {
            

        }

        private void Instrument_Leave(object sender, EventArgs e)
        {
            if (this.Instrument.Text.Trim() == "")
            {
                this.Instrument.Text = instrument_query_info;
            }
        }

        private void Instrument_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.Instrument.Text.Trim() == instrument_query_info)
            {
                this.Instrument.Text = "";
            }
        }

        private void Component_Leave(object sender, EventArgs e)
        {
            if (this.Component.Text.Trim() == "")
            {
                this.Component.Text = Component_query_info;
            }
        }
 
        private void Component_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.Component.Text.Trim() == Component_query_info)
            {
                this.Component.Text = "";
            }
        }
       
        private void Info_title_Enter(object sender, EventArgs e)
        {

        }
    }
}
