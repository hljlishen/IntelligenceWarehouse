using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public int status;
        public TreeNode tn;
        public List<Department> LowerRank;

        public Department(string n, int r, int b)
        {
            DataMysql dbo = new DataMysql();
            id = -1;
            name = n;
            tier = r;
            belongid = b;
            status = 1;
            LowerRank = new List<Department>();
            string sql = "insert into t_department (name,tier,belongId,status) values ('" + name + "'," +tier.ToString() + "," + belongid.ToString() + "," + status.ToString() + ")";
            dbo.WriteDB(sql);
        }

        public Department(DataRow r)
        {
            id = int.Parse(r["id"].ToString());
            name = r["name"].ToString();
            tier = int.Parse(r["tier"].ToString());
            belongid = int.Parse(r["belongId"].ToString());
            status = int.Parse(r["status"].ToString());
            LowerRank = new List<Department>();

            loadLowerRankDepartment();
            getNodeStructure();
        }

        private void loadLowerRankDepartment()
        {
            List<Department> ret = new List<Department>();
            DataMysql dbo = new DataMysql();
            string sql = "select * from t_department where belongId="
                + id.ToString() + " and status = 1";
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

        private void getNodeStructure()  //生成节点的结构
        {
            List<TreeNode> ls = new List<TreeNode>();
            if (LowerRank.Count == 0)
            {
                this.tn = new TreeNode(name + "(" + id.ToString() + ")");
                tn.Tag = this;
            }
            else
            {
                foreach (Department c in LowerRank)
                {
                    c.getNodeStructure();
                    ls.Add(c.tn);
                }
                this.tn = new TreeNode(name + "(" + id.ToString() + ")", ls.ToArray());
                tn.Tag = this;
            }
        }

        public static List<TreeNode> loadDepartmentStructure()
        {
            DataMysql dbo = new DataMysql();
            string sql = "select * from t_department where tier = 0 and status = 1";
            DataSet ds = dbo.ReadDB(sql);
            List<TreeNode> ret = new List<TreeNode>();
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                Department c = new Department(r);
                ret.Add(c.tn);
            }
            return ret;
        }

        public static int getWarehouseID(string n) //用名字查找仓库ID
        {
            DataMysql dbo = new DataMysql();
            string sql = "select * from t_department where name='" + n + "'";
            DataSet ds = dbo.ReadDB(sql);
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("未找到部门" + n);
                return -1;
            }

            return int.Parse(ds.Tables[0].Rows[0][0].ToString());
        }

        public static Department getDepartment(int id)   //用ID获取warehouse对象
        {
            DataMysql dbo = new DataMysql();
            string sql = "select * from t_department where id=" + id.ToString();
            DataSet ds = dbo.ReadDB(sql);
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("未找到部门ID" + id.ToString());
                return null;
            }
            return new Department(ds.Tables[0].Rows[0]);
        }

        public void deleteSelf()
        {
            DataMysql dbo = new DataMysql();
            string sql = "select * from t_department where belongId = " + id.ToString() + " and status = 1";
            DataSet ds = dbo.ReadDB(sql);
            if (ds.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show("该部门之下还有子部门，不能删除");
                return;
            }
            else
            {
                sql = "select * from t_user where departmentId = " + id.ToString() + " and status = 1";
                ds = dbo.ReadDB(sql);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    MessageBox.Show("该部门之下还有联系人，不能删除");
                    return;
                }
            }
            sql = "update t_department set status = 0 and lastModifiedTime = '" +
                System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' where id = " +
                id.ToString();

            if (LowerRank.Count == 0)
            {
                dbo.WriteDB(sql);
            }
            else
            {
                foreach (Department c in LowerRank)
                {
                    c.deleteSelf();
                }
                dbo.WriteDB(sql);
            }
        }

        public DataSet GetUsersInfo()
        {
            string sql = "select * from t_user where departmentId =" + id.ToString() + " and status = 1 ";
            DataMysql dbo = new DataMysql();
            DataSet ds = dbo.ReadDB(sql);
            int count = ds.Tables[0].Rows.Count;

            return ds;
        }
    }
}
