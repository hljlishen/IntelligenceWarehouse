using cangku_01.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

//选择仓库位置

namespace cangku_01.view.InstrumentManagement
{
    public partial class ShelvesTreeView : Form
    {
        string locationcoding;

        public ShelvesTreeView()
        {
            InitializeComponent();
        }

        private void ShelvesTreeView_Load(object sender, EventArgs e)
        {
            ShowTreeView();
            la_errorexistcargo.Visible = false;
            la_errornamenull.Visible = false;
        }

        //加载仓库位置树状图
        private void ShowTreeView()
        {
            List<TreeNode> ls = WarehouseLocation.loadDepartmentStructure();
            tv_shelves.Nodes.Clear();
            tv_shelves.Nodes.AddRange(ls.ToArray());
            tv_shelves.ExpandAll();
        }

        //返回节点名称
        public string locationName
        {
            get { return tb_location.Text.Trim(); }
        }

        //返回位置编码
        public string PlaceIdCoding
        {
            get { return locationcoding; }
        }

        //确认
        private void bt_affirm_Click(object sender, EventArgs e)
        {
            if (!FormValidation()) return;
            DialogResult = DialogResult.OK;
        }

        //取消
        private void bt_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //选择位置
        private void tv_shelves_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string location;
            WarehouseLocation warehouselocation = tv_shelves.SelectedNode.Tag as WarehouseLocation;//获取节点id
            int level = tv_shelves.SelectedNode.Level;
            if (level == 3)
            {
                location = tv_shelves.SelectedNode.Parent.Parent.Parent.Text.Trim();
                location += tv_shelves.SelectedNode.Parent.Parent.Text.Trim();
                location += tv_shelves.SelectedNode.Parent.Text.Trim();
                location += tv_shelves.SelectedNode.Text.Trim();
                tb_location.Text = location;
                GeneratePlaceIdCoding();
            }
        }

        //生成位置编码
        private void GeneratePlaceIdCoding()
        {
            WarehouseLocation placeid = tv_shelves.SelectedNode.Tag as WarehouseLocation;//获取节点id
            WarehouseLocation tierid = tv_shelves.SelectedNode.Parent.Tag as WarehouseLocation;
            WarehouseLocation shelvesid = tv_shelves.SelectedNode.Parent.Parent.Tag as WarehouseLocation;
            WarehouseLocation warehouseid = tv_shelves.SelectedNode.Parent.Parent.Parent.Tag as WarehouseLocation;
            locationcoding = warehouseid.id + "-" + shelvesid.id + "-" + tierid.id + "-" + placeid.id;
        }

        //表单验证
        private bool FormValidation()
        {
            bool validation = true;
            if (tb_location.Text.Trim().Equals(""))
            {
                la_errornamenull.Visible = true;
                la_errornamenull.ForeColor = Color.Red;
                validation = false;
            }
            WarehouseLocation node = tv_shelves.SelectedNode.Tag as WarehouseLocation;//获取节点id
            DataTable dt = node.SqlIdQueryWarehouseInformation();
            DataRow myDr = dt.Rows[0];
            if (!myDr["wa_instrumenttagid"].ToString().Equals(""))
            {
                la_errorexistcargo.Visible = true;
                la_errorexistcargo.ForeColor = Color.Red;
                validation = false;
            }
            return validation;
        }
    }
}
