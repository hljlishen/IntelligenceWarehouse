using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using cangku_01.MysqlConnection;

namespace cangku_01.entity
{
    public class Department 
    {
        public int id;
        public string name;
        public int tier;
        public int belongid;
        public TreeNode tn;
        public List<Department> LowerRank;
        DataMysql dbo = DataMysql.GetDataMysqlGreateInstance(DataMysql.mysqldefaultconnection);

        //添加节点
        public Department(string n, int r, int b)
        {    
            id = -1;
            name = n;
            tier = r;
            belongid = b;
            LowerRank = new List<Department>();
            string sql = "insert into t_department (de_name,de_belongId) values ('" + name + "'," + belongid.ToString() + ")";
            dbo.WriteDB(sql);
        }

        public Department(DataRow r)
        {
            id = int.Parse(r["de_id"].ToString());
            name = r["de_name"].ToString();
            belongid = int.Parse(r["de_belongId"].ToString());
            LowerRank = new List<Department>();
            loadLowerRankDepartment();
            getNodeStructure();
        }

        public Department()
        {
           
        }

        private void loadLowerRankDepartment()
        {
            List<Department> ret = new List<Department>();
            string sql = "select * from t_department where de_belongId="
                + id.ToString() + "";
            DataSet ds = dbo.ReadDB(sql);
            if (ds.Tables[0].Rows.Count == 0)
                return;
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                Department c = new Department(r);
                LowerRank.Add(c);
            }
            return;
        }

        //生成节点的结构
        private void getNodeStructure()  
        {
            List<TreeNode> ls = new List<TreeNode>();
            if (LowerRank.Count == 0)
            {
                tn = new TreeNode(name);

                tn.Tag = this;
            }
            else
            {
                foreach (Department c in LowerRank)
                {
                    c.getNodeStructure();
                    ls.Add(c.tn);
                }
                tn = new TreeNode(name,ls.ToArray());
                tn.Tag = this;
            }
        }

        public static List<TreeNode> loadDepartmentStructure()
        {
            string sql = "select * from t_department where de_belongId = 0";
            DataMysql dbo = DataMysql.GetDataMysqlGreateInstance(DataMysql.mysqldefaultconnection);
            DataSet ds = dbo.ReadDB(sql);
            List<TreeNode> ret = new List<TreeNode>();
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                Department c = new Department(r);
                ret.Add(c.tn);
            }
            return ret;
        }

        //删除选中的节点
        public int deleteSelf()
        {
            string sql = "select * from t_department where de_belongId = " + id + "";
            DataSet ds = dbo.ReadDB(sql);
            if (ds.Tables[0].Rows.Count != 0)//存在子节点
            {
                MessageBox.Show("该部门之下还有子部门，不能删除");
                return 0;
            }
            sql = "select * from t_employee where em_group = " + id + "";
            DataSet ds2 = dbo.ReadDB(sql);
            if (ds2.Tables[0].Rows.Count != 0)//节点下存在联系人
            {
                MessageBox.Show("该部门之下还有员工，不能删除");
                return 0;
            }
            sql = "delete from t_department where de_id = " + id + "";
            dbo.WriteDB(sql);
            return 1;
        }

        //节点查重
        public bool NodeDuplicateChecking()
        {
            bool duplicatechecking = false;
            string sql = "select * from t_department where de_name='" + name + "' and de_belongId=" + belongid + "";
            DataSet ds = dbo.ReadDB(sql);
            if (ds.Tables[0].Rows.Count != 0)
            {
                duplicatechecking = true;
            }
            return duplicatechecking;
        }

        //belongid查询
        public DataSet BelongIDQueryDepartmentInformation()
        {
            string sql = "select * from t_department where de_belongId=" + belongid + " and de_name='" + name + "'";
            DataSet ds = dbo.ReadDB(sql);
            return ds;
        }

        //修改子节点
        public void AlterChildNodes()
        {
            string sql = "update t_department set de_name = '" + name + " 'where de_id = " + id + "";
            dbo.WriteDB(sql);
        }
    }
}
