using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static cangku_01.view.AdminPage.AutoCloseMassageBox;

namespace cangku_01.view.WarehouseManagement
{
    public partial class GetNodeName : Form
    {
        public GetNodeName()
        {
            InitializeComponent();
        }

        private void GetNodeName_Load(object sender, EventArgs e)
        {
            
        }

        //确认
        private void bt_sure_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_nodename.Text.Trim()))
            {
                AutoClosingMessageBox.Show("请填写节点名称！", "节点名为空", 1000);
                return;
            }
            DialogResult = DialogResult.OK;
        }

        //取消
        private void bt_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        //返回节点名称
        public string nodeName
        {
            get { return tb_nodename.Text.Trim(); }
        }


    }
}
