using cangku_01.GateDrive;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    tsm_newrowandcolumn.Visible = false;
                    tsm_delete.Visible = true;
                    tsm_rename.Visible = true;
                    break;
                case 1:
                    tsm_newwarehouse.Visible = false;
                    tsm_newshelves.Visible = false;
                    tsm_newrowandcolumn.Visible = true;
                    tsm_delete.Visible = true;
                    tsm_rename.Visible = true;
                    break;
                case 2:
                    tsm_newwarehouse.Visible = false;
                    tsm_newshelves.Visible = false;
                    tsm_newrowandcolumn.Visible = false;
                    tsm_delete.Visible = true;
                    tsm_rename.Visible = true;
                    break;
                case -1:
                    tv_warehouse.ContextMenuStrip = cms_warehousetreeview;
                    tsm_newwarehouse.Visible = true;
                    tsm_newshelves.Visible = false;
                    tsm_newrowandcolumn.Visible = false;
                    tsm_delete.Visible = false;
                    tsm_rename.Visible = false;
                    cms_warehousetreeview.Show(MousePosition);
                    break;
            }
        }

        //创建仓库
        private void tsm_newwarehouse_Click(object sender, EventArgs e)
        {
            GetNodeName getnodename = new GetNodeName();
            if (getnodename.ShowDialog() == DialogResult.OK)
            {
                tv_warehouse.Nodes.Add(getnodename.nodeName);
            }
        }

        //创建货架
        private void tsm_newshelves_Click(object sender, EventArgs e)
        {
            GetNodeName getnodename = new GetNodeName();
            if (getnodename.ShowDialog() == DialogResult.OK)
            {
                tv_warehouse.SelectedNode.Nodes.Add(getnodename.nodeName);
            }
        }

        //创建排列号
        private void tsm_newrowandcolumn_Click(object sender, EventArgs e)
        {
            tsm_newshelves_Click(sender,e);
        }

        //删除节点
        private void tsm_delete_Click(object sender, EventArgs e)
        {
            tv_warehouse.SelectedNode.Remove();
        }

        //重命名
        private void tsm_rename_Click(object sender, EventArgs e)
        {

        }

        private void tv_warehouse_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            e.DrawDefault = true; //只需要在TreeView失去焦点时选中节点仍然突显  
        }

    }
}
