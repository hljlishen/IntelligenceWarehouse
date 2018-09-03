using cangku_01.entity;
using cangku_01.view.AdminPage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static cangku_01.view.AdminPage.AutoCloseMassageBox;

//仓库位置管理

namespace cangku_01.view.WarehouseManagement
{
    public partial class WarehouseManagement : Form
    {
        private int tier;

        public WarehouseManagement()
        {
            InitializeComponent();
            tv_warehouse.DrawMode = TreeViewDrawMode.OwnerDrawText;
            tv_warehouse.DrawNode += new DrawTreeNodeEventHandler(tv_warehouse_DrawNode);
        }

        private void WarehouseManagement_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            ShowTreeView();
            tv_warehouse.HideSelection = false;
        }

        //右键单击仓库树状图事件
        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point ClickPoint = new Point(e.X, e.Y);
                int x = e.X;
                int y = e.Y;
                TreeNode CurrentNode = tv_warehouse.GetNodeAt(ClickPoint);
                if (CurrentNode is TreeNode)//判断你点的是不是一个节点
                {
                    tv_warehouse.SelectedNode = CurrentNode;
                    CurrentNode.ContextMenuStrip = cms_warehousetreeview;
                    cms_warehousetreeview.Show(MousePosition);
                    tier = tv_warehouse.SelectedNode.Level;
                    ShowRightClickList();
                }
                else
                {
                    tier = -1;
                    ShowRightClickList();
                }
            }
        }

        //展示右键列表
        public void ShowRightClickList()
        {
            switch (tier)
            {
                case 0:
                    tsm_newwarehouse.Visible = false;
                    tsm_newshelves.Visible = true;
                    tsm_newtier.Visible = false;
                    tsm_newplace.Visible = false;
                    tsm_delete.Visible = true;
                    tsm_rename.Visible = false;
                    tsm_alterinformation.Visible = true;
                    break;
                case 1:
                    tsm_newwarehouse.Visible = false;
                    tsm_newshelves.Visible = false;
                    tsm_newtier.Visible = true;
                    tsm_newplace.Visible = false;
                    tsm_delete.Visible = true;
                    tsm_rename.Visible = true;
                    tsm_alterinformation.Visible = false;
                    break;
                case 2:
                    tsm_newwarehouse.Visible = false;
                    tsm_newshelves.Visible = false;
                    tsm_newtier.Visible = false;
                    tsm_newplace.Visible = true;
                    tsm_delete.Visible = true;
                    tsm_rename.Visible = true;
                    tsm_alterinformation.Visible = false;
                    break;
                case 3:
                    tsm_newwarehouse.Visible = false;
                    tsm_newshelves.Visible = false;
                    tsm_newtier.Visible = false;
                    tsm_newplace.Visible = false;
                    tsm_delete.Visible = true;
                    tsm_rename.Visible = true;
                    tsm_alterinformation.Visible = false;
                    break;
                case -1:
                    tv_warehouse.ContextMenuStrip = cms_warehousetreeview;
                    tsm_newwarehouse.Visible = true;
                    tsm_newshelves.Visible = false;
                    tsm_newtier.Visible = false;
                    tsm_newplace.Visible = false;
                    tsm_delete.Visible = false;
                    tsm_rename.Visible = false;
                    tsm_alterinformation.Visible = false;
                    cms_warehousetreeview.Show(MousePosition);
                    break;
            }
        }

        //创建仓库
        private void tsm_newwarehouse_Click(object sender, EventArgs e)
        {
            AlterAndAddWarehouse addWarehouse = new AlterAndAddWarehouse();
            if (addWarehouse.ShowDialog() == DialogResult.OK)
            {
                tv_warehouse.Nodes.Add(addWarehouse.WarehouseName);
                ShowTreeView();
            }

        }

        //修改仓库
        private void tsm_alterinformation_Click(object sender, EventArgs e)
        {
            WarehouseLocation node = tv_warehouse.SelectedNode.Tag as WarehouseLocation;
            AlterAndAddWarehouse alterWarehouse = new AlterAndAddWarehouse(node.id);
            if (alterWarehouse.ShowDialog() == DialogResult.OK)
            {
                tv_warehouse.SelectedNode.Text = alterWarehouse.WarehouseName;
            }
        }

        //创建货架编码
        private void tsm_newshelves_Click(object sender, EventArgs e)
        {
            AddChildNodes();
        }

        //创建货架层编码
        private void tsm_newrowandcolumn_Click(object sender, EventArgs e)
        {
            AddChildNodes();
        }

        //创建货架位编码
        private void 创建货架位编码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddChildNodes();
        }

        //添加子节点
        private void AddChildNodes()
        {
            string parentnodename = tv_warehouse.SelectedNode.Text;
            WarehouseLocation node = tv_warehouse.SelectedNode.Tag as WarehouseLocation;//获取节点id
            GetNodeName getnodename = new GetNodeName(parentnodename, node.tier, node.id);
            if (getnodename.ShowDialog() == DialogResult.OK)
            {
                ShowTreeView();
            }
            tv_warehouse.ExpandAll();
        }

        //删除节点
        private void tsm_delete_Click(object sender, EventArgs e)
        {
            Confirm cf = new Confirm("确定删除该节点？");
            cf.ShowDialog();
            if (cf.DialogResult == DialogResult.OK)
            {
                WarehouseLocation warehouselocation = (WarehouseLocation)tv_warehouse.SelectedNode.Tag;
                int deletenode = warehouselocation.DeleteSelf();
                if (deletenode == 1)
                {
                    AutoClosingMessageBox.Show("节点删除成功", "节点删除", 1000);
                    tv_warehouse.SelectedNode.Remove();//从TV移除
                    return;
                }
            }
        }

        //重命名
        private void tsm_rename_Click(object sender, EventArgs e)
        {
            string parentnodename = tv_warehouse.SelectedNode.Parent.Text;
            string nodename = tv_warehouse.SelectedNode.Text;
            WarehouseLocation parentnode = tv_warehouse.SelectedNode.Parent.Tag as WarehouseLocation;//获取节点id
            WarehouseLocation node = tv_warehouse.SelectedNode.Tag as WarehouseLocation;
            GetNodeName getnodename = new GetNodeName(parentnodename, parentnode.id, nodename, node.id);
            if (getnodename.ShowDialog() == DialogResult.OK)
            {
                tv_warehouse.SelectedNode.Text = getnodename.nodeName;
            }
            tv_warehouse.ExpandAll();
        }

        private void tv_warehouse_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            e.DrawDefault = true; //只需要在TreeView失去焦点时选中节点仍然突显  
        }

        //加载仓库位置树状图
        private void ShowTreeView()
        {
            List<TreeNode> ls = WarehouseLocation.loadDepartmentStructure();
            tv_warehouse.Nodes.Clear();
            tv_warehouse.Nodes.AddRange(ls.ToArray());
            tv_warehouse.ExpandAll();
        }

        //树状图刷新仓库数据
        private void tv_warehouse_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DataTable dt = new DataTable();
            WarehouseLocation warehouselocation = tv_warehouse.SelectedNode.Tag as WarehouseLocation;//获取节点id
            int level = tv_warehouse.SelectedNode.Level;
            if (level == 0)
            {
                dt = warehouselocation.SqlIdQueryWarehouseInformation();
                DataRow myDr = dt.Rows[0];
                tb_id.Text = myDr["wa_id"].ToString();
                tb_name.Text = myDr["wa_name"].ToString();
                tb_companyanddepartment.Text = myDr["wa_temp"].ToString();
                tb_synopsis.Text = myDr["wa_synopsis"].ToString();
            }
        }
    }
}
