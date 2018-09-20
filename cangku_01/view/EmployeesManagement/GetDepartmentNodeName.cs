using cangku_01.entity;
using System;
using System.Data;
using System.Windows.Forms;
using static cangku_01.view.AdminPage.AutoCloseMassageBox;

namespace cangku_01.view.EmployeesManagement
{
    public partial class GetDepartmentNodeName : Form
    {
        private string parentnodename;
        private int parenttier;
        private int parentnodeid;
        private int id;
        private string nodename;

        //添加节点
        public GetDepartmentNodeName(string nodename, int tier, int id)
        {
            InitializeComponent();
            parentnodename = nodename;
            parenttier = tier;
            parentnodeid = id;
            bt_alter.Visible = false;
        }

        //重命名
        public GetDepartmentNodeName(string parentnodename, int parentnodeid, string nodename, int id)
        {
            InitializeComponent();
            this.parentnodename = parentnodename;
            tb_nodename.Text = nodename;
            this.parentnodeid = parentnodeid;
            this.nodename = nodename;
            this.id = id;
            bt_sure.Visible = false;
        }

        public GetDepartmentNodeName()
        {
            InitializeComponent();
        }

        //确认
        private void bt_sure_Click(object sender, EventArgs e)
        {
            if (!FormValidation()) return;
            Department department = new Department();
            department.name = tb_nodename.Text;
            department.tier = parenttier;
            department.belongid = parentnodeid;
            if (department.NodeDuplicateChecking())
            {
                AutoClosingMessageBox.Show("已存在该节点！", "已存在该节点", 1000);
                return;
            }
            if (parentnodename.Equals(""))
            {
                Department d = new Department(tb_nodename.Text, 0, 0);
            } 

            else
            {
                Department d = new Department(tb_nodename.Text, parenttier+1, parentnodeid);
            }
            DialogResult = DialogResult.OK;
        }

        //修改
        private void bt_alter_Click(object sender, EventArgs e)
        {
            if (!FormValidation()) return;
            Department department = new Department();
            department.name = tb_nodename.Text;
            department.id = id;
            department.AlterChildNodes();
            DialogResult = DialogResult.OK;
        }

        //返回节点名称
        public string nodeName
        {
            get { return tb_nodename.Text.Trim(); }
        }

        //表单验证
        private bool FormValidation()
        {
            if (string.IsNullOrEmpty(tb_nodename.Text.Trim()))
            {
                AutoClosingMessageBox.Show("请填写节点名称！", "节点名为空", 1000);
                return false;
            }
            string textname = tb_nodename.Text.ToString();
            if (parentnodename.Equals(textname))
            {
                AutoClosingMessageBox.Show("不能与父节点重名！", "节点与父节点重名", 1000);
                return false;
            }
            Department department = new Department();
            department.belongid = parentnodeid;
            department.name = tb_nodename.Text;
            DataSet ds = department.BelongIDQueryDepartmentInformation();
            if (ds.Tables[0].Rows.Count != 0)
            {
                AutoClosingMessageBox.Show("已存在该节点名！", "节点重名", 1000);
                return false;
            }
            return true;
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
