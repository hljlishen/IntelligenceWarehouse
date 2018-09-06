using cangku_01.MysqlConnection;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static cangku_01.view.AdminPage.AutoCloseMassageBox;

//仓库位置树状图实体类

namespace cangku_01.entity
{
    class WarehouseLocation
    {

        public int id;                      //仓库位置SQLid
        public string name;                 //仓库位置节点名
        public int tier;                    //节点深度
        public int belongid;                //父节点SQLid
        private string synopsis;            //仓库简介
        public string instrumenttagid;      //仓库储存仪器Tageid
        private string temp;                //仓库所属部门
        public TreeNode tn;
        private List<WarehouseLocation> LowerRank;

        DataMysql dbo = DataMysql.GetDataMysqlGreateInstance(DataMysql.mysqldefaultconnection);

        //添加根节点
        public WarehouseLocation(string name, int tier, int belongid, string temp, string synopsis)
        {
            id = -1;
            this.name = name;
            this.tier = tier;
            this.belongid = belongid;
            this.synopsis = synopsis;
            this.temp = temp;
            LowerRank = new List<WarehouseLocation>();
            string sql = "insert into t_warehouselocation (wa_name,wa_tier,wa_belongId,wa_synopsis,wa_temp) " +
                "values ('" + name + "'," + tier + "," + belongid + ",'" + synopsis + "','" + temp + "')";
            dbo.WriteDB(sql);
        }

        //修改根节点
        public WarehouseLocation(int id, string name, string temp, string synopsis)
        {
            this.id = id;
            this.name = name;
            this.synopsis = synopsis;
            this.temp = temp;
            LowerRank = new List<WarehouseLocation>();
            string sql = "update t_warehouselocation set wa_name = '" + name + "',wa_synopsis = '" + synopsis + "',wa_temp = '" + temp + "' " +
                "where wa_id = " + id + "";
            dbo.WriteDB(sql);
        }

        //添加子节点
        public void AddChildNodes()
        {
            string sql = "insert into t_warehouselocation (wa_name,wa_tier,wa_belongId) " +
               "values ('" + name + "'," + tier + "," + belongid + ")";
            dbo.WriteDB(sql);
        }

        //修改子节点
        public void AlterChildNodes()
        {
            string sql = "update t_warehouselocation set wa_name = '" + name + " 'where wa_id = " + id + "";
            dbo.WriteDB(sql);
        }

        public WarehouseLocation(DataRow r)
        {
            id = int.Parse(r["wa_id"].ToString());
            name = r["wa_name"].ToString();
            tier = int.Parse(r["wa_tier"].ToString());
            belongid = int.Parse(r["wa_belongId"].ToString());
            instrumenttagid = r["wa_instrumenttagid"].ToString();
            LowerRank = new List<WarehouseLocation>();
            loadLowerRankDepartment();
            getNodeStructure();
        }

        public WarehouseLocation()
        {
        }

        private void loadLowerRankDepartment()
        {
            List<WarehouseLocation> ret = new List<WarehouseLocation>();
            string sql = "select * from t_warehouselocation where wa_belongId="
                + id.ToString() + "";
            DataSet ds = dbo.ReadDB(sql);
            if (ds.Tables[0].Rows.Count == 0)
                return;
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                WarehouseLocation c = new WarehouseLocation(r);
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
                foreach (WarehouseLocation c in LowerRank)
                {
                    c.getNodeStructure();
                    ls.Add(c.tn);
                }
                tn = new TreeNode(name, ls.ToArray());
                tn.Tag = this;
            }
        }

        //生成节点的结构
        private void getNodeStructure2()
        {
            List<TreeNode> ls = new List<TreeNode>();
            if (LowerRank.Count == 0)
            {
                tn = new TreeNode(name + "(" + instrumenttagid + ")");
                tn.Tag = this;
            }
            else
            {
                foreach (WarehouseLocation c in LowerRank)
                {
                    c.getNodeStructure();
                    ls.Add(c.tn);
                }
                tn = new TreeNode(name + "(" + instrumenttagid + ")", ls.ToArray());
                tn.Tag = this;
            }
        }

        public static List<TreeNode> loadDepartmentStructure()
        {
            string sql = "select * from t_warehouselocation where wa_tier = 0";
            DataMysql dbo = DataMysql.GetDataMysqlGreateInstance(DataMysql.mysqldefaultconnection);
            DataSet ds = dbo.ReadDB(sql);
            List<TreeNode> ret = new List<TreeNode>();
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                WarehouseLocation c = new WarehouseLocation(r);
                ret.Add(c.tn);
            }
            return ret;
        }

        //删除选中的节点
        public int DeleteSelf()
        {
            string sql = "select * from t_warehouselocation where wa_belongId = " + id + "";
            DataSet ds = dbo.ReadDB(sql);
            if (ds.Tables[0].Rows.Count != 0)//存在子节点
            {
                AutoClosingMessageBox.Show("该节点之下还有子节点，不能删除", "存在子节点", 1000);
                return 0;
            }
            sql = "select wa_instrumenttagid from t_warehouselocation where wa_id = '" + id + "'";
            DataTable dt = dbo.ReadDBDataTable(sql);
            DataRow myDr = dt.Rows[0];
            if (!myDr["wa_instrumenttagid"].ToString().Equals(""))//节点下存获取
            {
                AutoClosingMessageBox.Show("该节点之有货物存放，不能删除", "存在货物", 1000);
                return 0;
            }
            sql = "delete from t_warehouselocation where wa_id = " + id + "";
            dbo.WriteDB(sql);
            return 1;
        }

        //SqlId查询仓库信息
        public DataTable SqlIdQueryWarehouseInformation()
        {
            string sql = "select * from t_warehouselocation where wa_id = " + id + "";
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }

        //name查询仓库信息
        public DataSet NameQueryWarehouseInformation()
        {
            string sql = "select * from t_warehouselocation where wa_name='" + name + "' and wa_tier=" + 0 + " and wa_belongId=" + 0 + "";
            DataSet ds = dbo.ReadDB(sql);
            return ds;
        }

        //belongid查询
        public DataSet BelongIDQueryWarehouseInformation()
        {
            string sql = "select * from t_warehouselocation where wa_belongId=" + belongid + " and wa_name='" + name + "'";
            DataSet ds = dbo.ReadDB(sql);
            return ds;
        }

        //tier查询
        public DataTable TierQueryWarehouseInformation()
        {
            string sql = "select * from t_warehouselocation where wa_tier=" + tier + "";
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }

        //给位置添加货物
        public void AddInstrument()
        {
            string sql = "update t_warehouselocation set wa_instrumenttagid = '" + instrumenttagid + " 'where wa_id = " + id + "";
            dbo.WriteDB(sql);
        }

    }
}
