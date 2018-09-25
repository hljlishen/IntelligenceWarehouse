using cangku_01.entity;
using DbLink;
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

namespace cangku_01.view.EmployeesManagement
{
    public partial class GetDepartmentNodeName : Form
    {
        static DbLinkFactory factory = DbLinkManager.GetLinkFactory();

        private int _parentnodeid;
        private int _id;

        //添加节点
        public GetDepartmentNodeName(int id)
        {
            InitializeComponent();
            _parentnodeid = id;
            bt_alter.Visible = false;
        }

        //重命名
        public GetDepartmentNodeName(int parentnodeid, int id)
        {
            InitializeComponent();
            this._parentnodeid = parentnodeid;
            this._id = id;
            bt_sure.Visible = false;
        }

        public GetDepartmentNodeName()
        {
            InitializeComponent();
        }

        //确认
        private void bt_sure_Click(object sender, EventArgs e)
        {
            Department department = new Department(factory);
            department.de_name = tb_nodename.Text;
            department.de_belongid = _parentnodeid;
            if (!department.DepartmentFormValidation()) return;
            if (department.NodeDuplicateChecking())
            {
                AutoClosingMessageBox.Show("已存在该节点！", "存在节点", 1000);
                return;
            }
            else
            {
                department.AddDepartmentNode();
            }
            DialogResult = DialogResult.OK;
        }

        //修改
        private void bt_alter_Click(object sender, EventArgs e)
        {
            Department department = new Department(factory);
            department.de_name = tb_nodename.Text;
            department.de_id = _id;
            department.de_belongid = _parentnodeid;
            if (!department.DepartmentFormValidation()) return;
            department.RenameNodes();
            DialogResult = DialogResult.OK;
        }

        //返回节点名称
        public string nodeName
        {
            get { return tb_nodename.Text.Trim(); }
        }

        //取消
        private void bt_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void GetDepartmentNodeName_Load(object sender, EventArgs e)
        {

        }
    }
}
