using cangku_01.entity;
using DbLink;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static cangku_01.view.AdminPage.AutoCloseMassageBox;

//添加和修改仓库页面

namespace cangku_01.view.WarehouseManagement
{
    public partial class AlterAndAddWarehouse : Form
    {
        static DbLinkFactory factory = DbLinkManager.GetLinkFactory();
        private int _id;
        private string _oldname;

        //添加仓库构造方法
        public AlterAndAddWarehouse()
        {
            InitializeComponent();
            la_errornamenull.Visible = false;
            la_errortempnull.Visible = false;
            la_errorsynopisi.Visible = false;
            bt_alter.Visible = false;
        }

        //修改仓库构造方法
        public AlterAndAddWarehouse(int id)
        {
            InitializeComponent();
            _id = id;
            la_errornamenull.Visible = false;
            la_errortempnull.Visible = false;
            la_errorsynopisi.Visible = false;
            bt_add.Visible = false;
            WarehouseLocation warehuoselocation = new WarehouseLocation();
            warehuoselocation.id = id;
            DataTable dt = warehuoselocation.SqlIdQueryWarehouseInformation();
            DataRow myDr = dt.Rows[0];
            tb_name.Text = myDr["wa_name"].ToString();
            tb_companyanddepartment.Text = myDr["wa_temp"].ToString();
            tb_synopsis.Text = myDr["wa_synopsis"].ToString();
            _oldname = myDr["wa_name"].ToString();
        }

        //加载部门树状图
        private void AlterAndAddWarehouse_Load(object sender, EventArgs e)
        {
            tv_temp.Nodes.Clear();
            Department department = new Department(factory);
            department.GetTreeView(tv_temp, 0);
            tv_temp.ExpandAll();
        }

        //返回节点名称
        public string WarehouseName
        {
            get { return tb_name.Text.Trim(); }
        }

        //添加仓库信息
        private void bt_add_Click(object sender, EventArgs e)
        {
            if (!FormValidation()) return;
            if (!tb_name.Text.Trim().Equals(""))
            {
                WarehouseLocation warehuoselocation = new WarehouseLocation();
                warehuoselocation.name = tb_name.Text;
                DataSet ds = warehuoselocation.NameQueryWarehouseInformation();
                if (ds.Tables[0].Rows.Count != 0)
                {
                    la_errornamenull.Text = "*已存在该仓库名称";
                    la_errornamenull.ForeColor = Color.Red;
                    la_errornamenull.Visible = true;
                    return;
                }
            }
            WarehouseLocation d = new WarehouseLocation(tb_name.Text, 0, 0, tb_companyanddepartment.Text, tb_synopsis.Text);
            DialogResult = DialogResult.OK;
            Close();
        }

        //修改仓库信息
        private void bt_alter_Click(object sender, EventArgs e)
        {
            if (!FormValidation()) return;
            if (!tb_name.Text.Trim().Equals(_oldname))
            {
                WarehouseLocation warehuoselocation = new WarehouseLocation();
                warehuoselocation.name = tb_name.Text;
                DataSet ds = warehuoselocation.NameQueryWarehouseInformation();
                if (ds.Tables[0].Rows.Count != 0)
                {
                    la_errornamenull.Text = "*已存在该仓库名称";
                    la_errornamenull.ForeColor = Color.Red;
                    la_errornamenull.Visible = true;
                    return;
                }
            }
            WarehouseLocation d = new WarehouseLocation(_id, tb_name.Text, tb_companyanddepartment.Text, tb_synopsis.Text);
            DialogResult = DialogResult.OK;
            Close();
        }

        //表单验证
        private bool FormValidation()
        {
            bool validation = true;
            if (tb_name.Text.Trim().Equals(""))
            {
                la_errornamenull.Visible = true;
                la_errornamenull.ForeColor = Color.Red;
                validation = false;
            }
            if (tb_companyanddepartment.Text.Trim().Equals(""))
            {
                la_errortempnull.Visible = true;
                la_errortempnull.ForeColor = Color.Red;
                validation = false;
            }
            if (tb_synopsis.Text.Trim().Equals(""))
            {
                la_errorsynopisi.Visible = true;
                la_errorsynopisi.ForeColor = Color.Red;
                validation = false;
            }
            return validation;
        }

        //取消
        private void bt_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //获取仓库的小组或者部门
        private void tv_temp_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tv_temp.SelectedNode.Level == 0) //选中到根节点
            {
                AutoClosingMessageBox.Show("请精确到部门或小组", "未精确到部门或小组", 1000);
                return;
            }
            tb_companyanddepartment.Text = tv_temp.SelectedNode.Text;
        }
    }
}
