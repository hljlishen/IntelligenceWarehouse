using cangku_01.entity;
using System;
using System.Data;
using System.Windows.Forms;
using static cangku_01.view.AdminPage.AutoCloseMassageBox;

//添加子节点

namespace cangku_01.view.WarehouseManagement
{
    public partial class GetWarehouseLocationNodeName : Form
    {
        private string parentnodename;
        private int parenttier;
        private int parentnodeid;
        private int id;
        private string nodename;

        //添加节点
        public GetWarehouseLocationNodeName(string parentnodename, int parenttier, int parentid)
        {
            InitializeComponent();
            this.parentnodename = parentnodename;
            this.parenttier = parenttier;
            parentnodeid = parentid;
            bt_alter.Visible = false;
        }

        //重命名
        public GetWarehouseLocationNodeName(string parentnodename, int parentnodeid, string nodename, int id)
        {
            InitializeComponent();
            this.parentnodename = parentnodename;
            tb_nodename.Text = nodename;
            this.parentnodeid = parentnodeid;
            this.nodename = nodename;
            this.id = id;
            bt_sure.Visible = false;
        }

        private void GetNodeName_Load(object sender, EventArgs e)
        {

        }

        //确认
        private void bt_sure_Click(object sender, EventArgs e)
        {
            if (!FormValidation()) return;
            WarehouseLocation warehouselocation = new WarehouseLocation();
            warehouselocation.name = tb_nodename.Text;
            warehouselocation.tier = parenttier + 1;
            warehouselocation.belongid = parentnodeid;
            warehouselocation.AddChildNodes();
            DialogResult = DialogResult.OK;
        }

        //表单验证
        private bool FormValidation()
        {
            bool validation = true;
            if (string.IsNullOrEmpty(tb_nodename.Text.Trim()))
            {
                AutoClosingMessageBox.Show("请填写节点名称！", "节点名为空", 1000);
                validation = false;
            }
            string textname = tb_nodename.Text.ToString();
            if (parentnodename.Equals(textname))
            {
                AutoClosingMessageBox.Show("不能与父节点重名！", "节点与父节点重名", 1000);
                validation = false;
            }
            WarehouseLocation warehuoselocation = new WarehouseLocation();
            warehuoselocation.belongid = parentnodeid;
            warehuoselocation.name = tb_nodename.Text;
            DataSet ds = warehuoselocation.BelongIDQueryWarehouseInformation();
            if (ds.Tables[0].Rows.Count != 0)
            {
                AutoClosingMessageBox.Show("已存在该货架名！", "货架重名", 1000);
                validation = false;
            }
            return validation;
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

        //修改
        private void bt_alter_Click(object sender, EventArgs e)
        {
            if (!FormValidation()) return;
            WarehouseLocation warehouselocation = new WarehouseLocation();
            warehouselocation.name = tb_nodename.Text;
            warehouselocation.id = id;
            warehouselocation.AlterChildNodes();
            DialogResult = DialogResult.OK;
        }
    }
}
