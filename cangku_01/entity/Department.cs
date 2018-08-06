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

        //添加节点
        public Department(string n, int r, int b)
        {    
            id = -1;
            name = n;
            tier = r;
            belongid = b;
            status = 1;
            LowerRank = new List<Department>();
            string sql = "select * from t_department where de_name='" + name + "' and de_tier=" + tier + " and de_belongId=" + belongid + "";
            DataMysql dbo = new DataMysql();
            DataSet ds = dbo.ReadDB(sql);
            if (ds.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show("已存在该节点，无法重复添加！");
                return;
            }
            sql = "insert into t_department (de_name,de_tier,de_belongId,de_status) values ('" + name + "'," +tier.ToString() + "," + belongid.ToString() + "," + status.ToString() + ")";
            dbo.WriteDB(sql);
        }

        public Department(DataRow r)
        {
            id = int.Parse(r["de_id"].ToString());
            name = r["de_name"].ToString();
            tier = int.Parse(r["de_tier"].ToString());
            belongid = int.Parse(r["de_belongId"].ToString());
            status = int.Parse(r["de_status"].ToString());
            LowerRank = new List<Department>();

            loadLowerRankDepartment();
            getNodeStructure();
        }

        private void loadLowerRankDepartment()
        {
            List<Department> ret = new List<Department>();
            DataMysql dbo = new DataMysql();
            string sql = "select * from t_department where de_belongId="
                + id.ToString() + " and de_status = 1";
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
                this.tn = new TreeNode(name);

                tn.Tag = this;
            }
            else
            {
                foreach (Department c in LowerRank)
                {
                    c.getNodeStructure();
                    ls.Add(c.tn);
                }
                this.tn = new TreeNode(name,ls.ToArray());
                tn.Tag = this;
            }
        }

        public static List<TreeNode> loadDepartmentStructure()
        {
            DataMysql dbo = new DataMysql();
            string sql = "select * from t_department where de_tier = 0 and de_status = 1";
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
        public void deleteSelf(string company,string department,string group)
        {
            DataMysql dbo = new DataMysql();
            string sql = "select * from t_department where de_belongId = " + id.ToString() + " and de_status = 1";
            DataSet ds = dbo.ReadDB(sql);
            if (ds.Tables[0].Rows.Count != 0)//存在子节点
            {
                MessageBox.Show("该部门之下还有子部门，不能删除");
                return;
            }
            sql = "select de_id from t_department where de_name = '" + company + "' order by de_id ASC";
            int companyid = dbo.FirstValue(sql);
            if (company !=""&& department != ""&& group == "")//选中部门
            {
                sql = "delete from t_department where de_belongId = "+companyid+" and de_name = '" + department + "'";
                int i = dbo.WriteDB(sql);
                if(i==1)
                MessageBox.Show("已删除该节点！");
                else
                    MessageBox.Show("删除失败！");
                return;
            }
            if (company != "" && department != "" && group != "")//选中小组
            {
                sql = "select * from t_employees where em_company = '" + company + "' and  em_department = '" + department + "' and em_group = '" + group + "'";
                DataSet ds2 = dbo.ReadDB(sql);
                if (ds2.Tables[0].Rows.Count != 0)//节点下存在联系人
                {
                    MessageBox.Show("该部门之下还有员工，不能删除");
                    return;
                }
                sql = "select de_id from t_department where de_name = '" + department + "' and de_belongId = " + companyid + "";
                int departmentid = dbo.FirstValue(sql);
                sql = "delete from t_department where de_belongId = " + departmentid + " and de_name = '" + group + "'";
                int i = dbo.WriteDB(sql);
                if (i == 1)
                    MessageBox.Show("已删除该节点！");
                else
                    MessageBox.Show("删除失败！");
                return;
            }
            sql = "delete from t_department where de_id = " + companyid + "";
            int ii = dbo.WriteDB(sql);
            if (ii == 1)
                MessageBox.Show("已删除该节点！");
            else
                MessageBox.Show("删除失败！");
        }
    }
}
