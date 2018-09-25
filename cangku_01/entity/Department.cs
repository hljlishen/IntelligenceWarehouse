using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using cangku_01.MysqlConnection;
using DbLink;
using static cangku_01.view.AdminPage.AutoCloseMassageBox;

namespace cangku_01.entity
{
    public class Department : ActiveRecord
    {
        static DbLinkFactory factory = DbLinkManager.GetLinkFactory();
        DataMysql dbo = DataMysql.GetDataMysqlGreateInstance(DataMysql.mysqldefaultconnection);

        public int? de_id { get; set; }
        public string de_name { get; set; }
        public int? de_belongid { get; set; }
        public List<int> DepartmentId = new List<int>();
       
        public Department(DbLinkFactory factory) : base("t_department", "de_id", factory)
        {

        }

        //树状图生成 --Tag中只存入节点id
        public void GetTreeView(TreeView treeView, int parentId)
        {
            ISelectSqlMaker maker = factory.CreateSelectSqlMaker("t_department");
            maker.AddAndCondition(new IntEqual("de_belongid", parentId));
            DataTable dt = Select(maker.MakeSelectSql());
            if (dt.Rows.Count > 0)
            {
                int pId = -1;
                foreach (DataRow row in dt.Rows)
                {
                    TreeNode node = new TreeNode();
                    node.Text = row["de_name"].ToString();
                    node.Tag = (int)row["de_id"];
                    pId = (int)row["de_belongid"];
                    if (pId == 0)
                    {
                        treeView.Nodes.Add(node);//添加根节点
                    }
                    else
                    {
                        RefreshChildNode(treeView, node, pId);//添加根节点之外的其他节点
                    }
                    GetTreeView(treeView, (int)node.Tag);//查找以node为父节点的子节点
                }
            }
        }

        //处理根节点的子节点
        private void RefreshChildNode(TreeView treeView, TreeNode treeNode, int parentId)
        {
            foreach (TreeNode node in treeView.Nodes)
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
                    return;
                }
                else if (node.Nodes.Count > 0)
                {
                    FindChildNode(node, treeNode, parentId);
                }
            }
        }

        //添加节点
        public void AddDepartmentNode()
        {
            Insert();
        }

        //删除选中的节点
        public bool DeleteNode()
        {
            ISelectSqlMaker maker = factory.CreateSelectSqlMaker("t_department");
            maker.AddAndCondition(new IntEqual("de_belongid", de_id.Value));
            DataTable departmentDataTable = Select(maker.MakeSelectSql());
            if (departmentDataTable.Rows.Count != 0)
            {
                AutoClosingMessageBox.Show("该部门之下还有子部门，不能删除", "存在子部门", 1000);
                return false;
            }
            maker = factory.CreateSelectSqlMaker("t_employee");
            maker.AddAndCondition(new IntEqual("em_departmentid", de_id.Value));
            DataTable employeeDataTable = Select(maker.MakeSelectSql());
            if (employeeDataTable.Rows.Count != 0)
            {
                AutoClosingMessageBox.Show("该部门之下还有员工，不能删除", "存在员工", 1000);
                return false;
            }
            Delete();
            return true;
        }

        //节点查重
        public bool NodeDuplicateChecking()
        {
            ISelectSqlMaker maker = factory.CreateSelectSqlMaker("t_department");
            maker.AddAndCondition(new StringEqual("de_name", de_name));
            maker.AddAndCondition(new IntEqual("de_belongid",de_belongid.Value));
            DataTable departmentDataTable = Select(maker.MakeSelectSql());
            if (departmentDataTable.Rows.Count != 0)
            {
                return true;
            }
            return false;
        }

        //表单验证
        public bool DepartmentFormValidation()
        {
            if (string.IsNullOrEmpty(de_name.Trim()))
            {
                AutoClosingMessageBox.Show("请填写节点名称！", "节点名为空", 1000);
                return false;
            }
            DataTable departmentDataTable = BelongIDQueryDepartmentInformation();
            if (departmentDataTable.Rows.Count != 0)
            {
                AutoClosingMessageBox.Show("已存在该节点名！", "节点重名", 1000);
                return false;
            }
            ISelectSqlMaker maker = factory.CreateSelectSqlMaker("t_department");
            maker.AddAndCondition(new IntEqual("de_id", de_belongid.Value));
            DataTable departmentname = Select(maker.MakeSelectSql());
            if (departmentname.Rows.Count == 0)
            {
                return true;
            }
            DataRow myDr = departmentname.Rows[0];
            if (myDr["de_name"].ToString().Equals(de_name))
            {
                AutoClosingMessageBox.Show("不能与父节点重名！", "节点与父节点重名", 1000);
                return false;
            }
            return true;
        }

        //belongid查询
        public DataTable BelongIDQueryDepartmentInformation()
        {
            ISelectSqlMaker maker = factory.CreateSelectSqlMaker("t_department");
            maker.AddAndCondition(new StringEqual("de_name", de_name));
            maker.AddAndCondition(new IntEqual("de_belongid",de_belongid.Value));
            DataTable departmentDataTable = Select(maker.MakeSelectSql());
            return departmentDataTable;
        }

        //节点重命名
        public void RenameNodes()
        {
            Update();
        }

        //查询节点名字，以及父节点名
        public List<string> DepartmentName()
        {
            List<string> mList = new List<string>();
            while (true)
            {  
                ISelectSqlMaker maker = factory.CreateSelectSqlMaker("t_department");
                maker.AddAndCondition(new IntEqual("de_id", de_id.Value));
                DataTable departmentDataTable = Select(maker.MakeSelectSql());
                DataRow myDr = departmentDataTable.Rows[0];
                mList.Add(myDr["de_name"].ToString());
                if ((int)myDr["de_belongid"] == 0) break;
                de_id = (int)myDr["de_belongid"];
            }
            return mList;
        }

        //查找树状图下的员工
        public DataTable FindAllEmployeeOf(TreeNode treeNode)
        {
            readNode(treeNode);
            DataTable datatable = new DataTable();
            string sql1 = "select * from t_employee where em_departmentid =";
            string sql2 = " or em_departmentid =";
            string sql = "";
            for (int i=0; i< DepartmentId.Count; i++)
            {
                if (i == 0)
                {
                    sql = sql1 + DepartmentId[i];
                }
                sql += sql2 + DepartmentId[i];
            }
            datatable = Select(sql);
            return datatable;
        }

        //读取节点的叶子节点ID
        public void readNode(TreeNode treeNode)
        {
            if (treeNode.Nodes.Count == 0)
            {
                DepartmentId.Add((int)treeNode.Tag);
                return;
            }
            foreach (TreeNode children in treeNode.Nodes)
            {
                
                if (children.Nodes.Count == 0)
                {
                    DepartmentId.Add((int)children.Tag);
                    readNode(children);
                }
                readNode(children);
            }
        }

    }
}
