using cangku_01.MysqlConnection;
using DbLink;
using System;
using System.Collections.Generic;
using System.Data;
using static cangku_01.view.AdminPage.AutoCloseMassageBox;

//员工信息

namespace cangku_01.entity
{
    public class Employee
    {
        static DbLinkFactory factory = DbLinkManager.GetLinkFactory();
        DataMysql dbo = DataMysql.GetDataMysqlGreateInstance(DataMysql.mysqldefaultconnection);

        public int Id {get;set;}                     //sql员工主键ID
        public string EmployeeNumber { get; set; }   //员工编号
        public string Name { get; set; }             //名字
        public string Sex { get; set; }              //性别
        public int Company { get; set; }             //公司
        public int Department { get; set; }          //部门
        public int Group { get; set; }               //组名 
        public int DepartmentId { get; set; }        //部门ID
        public DateTime PassDoor { get; set; }       //过门时间

        ISelectSqlMaker maker;

        //查询全部员工sql
        public DataTable QueryAllEmployee()
        {
            Setup();
            string sql = maker.MakeSelectSql();
            DataTable dataTable = dbo.ReadDBDataTable(sql);
            return dataTable;
        }

        //员工编号查询员工sql
        public string EmployeeNumberFindEmployeeSql()
        {
            string sql = "select A.em_id,A.em_employeenumber,A.em_name,A.em_sex,B.de_name AS em_company,C.de_name AS em_department,D.de_name AS em_group " +
                      "from t_employee A left join t_department B on A.em_company = B.de_id left join t_department C on A.em_department = C.de_id left join t_department D on A.em_group = D.de_id " +
                      "where em_employeenumber = " + EmployeeNumber + "";
            return sql;
        }

        //员工编号查询员工sql
        public DataTable EmployeeNumberFindEmployee()
        {
            Setup();
            maker.AddAndCondition(new IntEqual("em_employeenumber", EmployeeNumber));
            string sql = maker.MakeSelectSql();
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }

        //员工id查询员工sql
        public string IdFindEmployeeSql()
        {
            string sql = "select * from t_employee where em_id = " + Id + "";
            return sql;
        }

        //员工id查询员工sql
        public DataTable IdQueryEmployee()
        {
            Setup();
            maker.AddAndCondition(new IntEqual("em_id", Id));
            string sql = maker.MakeSelectSql();
            DataTable dataTable = dbo.ReadDBDataTable(sql);
            return dataTable;
        }

        //添加员工sql
        public string AddEmployeeSql()
        {
            string sql = "insert into t_employee (em_employeenumber,em_name,em_sex,em_departmentid)values('"
                + EmployeeNumber+ "','" + Name + "','" + Sex + "'," + DepartmentId + ")";
            return sql;
        }
 
        //删除员工sql
        public bool EmployeeIdDeleteEmployee()
        {
            Instrument instrument = new Instrument();
            instrument.Duty = Id;
            DataTable datatable = instrument.EmployeeIdQueryInstrument();
            if (datatable.Rows.Count != 0)
            {
                AutoClosingMessageBox.Show("该员工用负责仪器！", "存在负责仪器", 1000);
                return false;
            }
            string sql = "delete from t_employee where em_id = " + Id + "";
            dbo.WriteDB(sql);
            return true;
        }

        //更新员工sql
        public string UpdateEmployeeSql()
        {
            string sql = "update t_employee set em_name='"+ Name + "',em_sex ='" 
                + Sex + "',em_departmentid = " + DepartmentId + "" +
                " where em_employeenumber = " + EmployeeNumber + "";
            return sql;
        }

        //员工多条件搜素
        public DataTable QueryEmployee()
        {
            string sql = "select * from t_employee where";
            if(!EmployeeNumber.Equals(""))
            {
                sql += $" em_employeenumber={EmployeeNumber}";
            }
            if (!Name.Equals("") && EmployeeNumber.Equals(""))
            {
                sql += $" em_name like '%{Name}%'";
            }
            if (!Name.Equals("") && !EmployeeNumber.Equals(""))
            {
                sql += $" and em_name like '%{Name}%'";
            }
            if (!Sex.Equals("男/女") && !EmployeeNumber.Equals(""))
            {
                sql += $" and em_sex='{Sex}'";
            }
            if (!Sex.Equals("男/女") && !Name.Equals(""))
            {
                sql += $" and em_sex='{Sex}'";
            }
            if (!Sex.Equals("男/女") && EmployeeNumber.Equals("") && Name.Equals(""))
            {
                sql += $" em_sex='{Sex}'";
            }
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }

        //员工多条件搜素
        public DataTable QueryEmployee(List<int> departmentidlist)
        {
            string sql = "select * from t_employee where";
            if (!EmployeeNumber.Equals(""))
            {
                sql += $" em_employeenumber={EmployeeNumber}";
            }
            if (!Name.Equals("") && EmployeeNumber.Equals(""))
            {
                sql += $" em_name like '%{Name}%'";
            }
            if (!Name.Equals("") && !EmployeeNumber.Equals(""))
            {
                sql += $" and em_name like '%{Name}%'";
            }
            if (!Sex.Equals("男/女") && !EmployeeNumber.Equals(""))
            {
                sql += $" and em_sex='{Sex}'";
            }
            if (!Sex.Equals("男/女") && !Name.Equals(""))
            {
                sql += $" and em_sex='{Sex}'";
            }
            if (!Sex.Equals("男/女") && EmployeeNumber.Equals("") && Name.Equals(""))
            {
                sql += $" em_sex='{Sex}'";
            }
            string sql2 = " or em_departmentid =";
            for (int i = 0; i < departmentidlist.Count; i++)
            {
                if (i == 0)
                {
                    sql += " and (em_departmentid =" + departmentidlist[i];
                    continue;
                }
                if (i == departmentidlist.Count-1)
                {
                    sql += sql2 + departmentidlist[i] + ")" ;
                    continue;
                }
                sql += sql2 + departmentidlist[i];
            }
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }

        //查指纹信息
        public string FingerprintSql()
        {
            SetupFingerprint();
            string sql = maker.MakeSelectSql();
            return sql;
        }

        private void Setup()
        {
            maker = factory.CreateSelectSqlMaker("t_employee");
        }

        private void SetupFingerprint()
        {
            maker = factory.CreateSelectSqlMaker("t_fingerprint");
        }
    }  
}
