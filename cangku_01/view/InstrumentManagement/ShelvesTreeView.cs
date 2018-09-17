using cangku_01.entity;
using cangku_01.interfaceImp;
using cangku_01.interfaces;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

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
            tv_shelves.Nodes.Clear();
            setTreeView(tv_shelves, 0);
            tv_shelves.ExpandAll();
            la_errorexistcargo.Visible = false;
            la_errornamenull.Visible = false;
        }

        //调用的时候parentId以0值开始 setTreeView(treeView1, 0);
        private void setTreeView(TreeView tr1, int parentId)
        {
            WarehouseLocation warehouseLocation = new WarehouseLocation();
            warehouseLocation.belongid = parentId;
            DataTable dt = warehouseLocation.BelongIDQuery();
            if (dt.Rows.Count > 0)
            {
                int pId = -1;
                foreach (DataRow row in dt.Rows)
                {
                    TreeNode node = new TreeNode();
                    node.Text = row["wa_name"].ToString();
                    node.Tag = (int)row["wa_id"];
                    pId = (int)row["wa_belongid"];
                    if (pId == 0)
                    {
                        //添加根节点
                        tr1.Nodes.Add(node);
                    }
                    else
                    {
                        //添加根节点之外的其他节点
                        RefreshChildNode(tr1, node, pId);
                    }
                    //查找以node为父节点的子节点
                    setTreeView(tr1, (int)node.Tag);
                }
            }
        }
        
        //处理根节点的子节点
        private void RefreshChildNode(TreeView tr1, TreeNode treeNode, int parentId)
        {
            foreach (TreeNode node in tr1.Nodes)
            {
                if ((int)node.Tag == parentId)
                {
                    node.Nodes.Add(treeNode);
                    return;
                }
                else if (node.Nodes.Count > 0)
                {
                    FindChildNode(node, treeNode, parentId);
                }
            }
        }
        
        //处理根节点的子节点的子节点
        private void FindChildNode(TreeNode tNode, TreeNode treeNode, int parentId)
        {
            foreach (TreeNode node in tNode.Nodes)
            {
                if ((int)node.Tag == parentId)
                {
                    node.Nodes.Add(treeNode);
                    if (treeNode.Level == 3)
                    {
                        WarehouseLocation warehouseLocation = new WarehouseLocation();
                        warehouseLocation.id = (int)treeNode.Tag;
                        DataTable dt = warehouseLocation.SqlIdQueryWarehouseInstrument();
                        DataRow myDr = dt.Rows[0];
                        string instrumenttagid = myDr["wa_instrumenttagid"].ToString();
                        if (!instrumenttagid.Equals(""))
                        {
                            treeNode.BackColor = Color.Red;
                            InstrumentInterface dao = new InstrumentDataManipulation();
                            Instrument ins = new Instrument();
                            ins.TagId = instrumenttagid;
                            DataTable dataTable = dao.TagIdQueryInstrument(ins);
                            DataRow dataTableDr = dataTable.Rows[0];
                            treeNode.Text = treeNode.Text + "(" + dataTableDr["in_name"].ToString() + ")";
                        }
                        
                        else treeNode.BackColor = Color.Green;
                    } 
                    return;
                }
                else if (node.Nodes.Count > 0)
                {
                    FindChildNode(node, treeNode, parentId);
                }
            }
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
            else tb_location.Text = "";
        }

        //生成位置编码
        private void GeneratePlaceIdCoding()
        {
            int placeid = (int)tv_shelves.SelectedNode.Tag ;//获取节点id
            int tierid = (int)tv_shelves.SelectedNode.Parent.Tag;
            int shelvesid = (int)tv_shelves.SelectedNode.Parent.Parent.Tag;
            int warehouseid = (int)tv_shelves.SelectedNode.Parent.Parent.Parent.Tag;
            locationcoding = warehouseid + "-" + shelvesid + "-" + tierid + "-" + placeid;
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
            WarehouseLocation warehouseLocation = new WarehouseLocation();
            warehouseLocation.id = (int)tv_shelves.SelectedNode.Tag;
            DataTable dt = warehouseLocation.SqlIdQueryWarehouseInformation();
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
