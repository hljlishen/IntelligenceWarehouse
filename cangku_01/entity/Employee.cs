using DbLink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//员工信息

namespace cangku_01.entity
{
    public class Employee
    {
        public int Id {get;set;}                     //sql员工主键ID
        public string EmployeeNumber { get; set; }   //员工编号
        public string Name { get; set; }             //名字
        public string Sex { get; set; }              //性别
        public int Company { get; set; }             //公司
        public int Department { get; set; }          //部门
        public int Group { get; set; }               //组名 
        public DateTime PassDoor { get; set; }       //过门时间

        SelectSqlMaker maker;

        //查询全部员工sql
        public string QueryAllEmployeeSql()
        {
            string sql = "select A.em_id,A.em_employeenumber,A.em_name,A.em_sex,B.de_name AS em_company,C.de_name AS em_department,D.de_name AS em_group " +
                        "from t_employee A left join t_department B on A.em_company = B.de_id left join t_department C on A.em_department = C.de_id left join t_department D on A.em_group = D.de_id";
            return sql;
        }

        //员工编号查询员工sql
        public string EmployeeNumberFindEmployeeSql()
        {
            string sql = "select A.em_id,A.em_employeenumber,A.em_name,A.em_sex,B.de_name AS em_company,C.de_name AS em_department,D.de_name AS em_group " +
                      "from t_employee A left join t_department B on A.em_company = B.de_id left join t_department C on A.em_department = C.de_id left join t_department D on A.em_group = D.de_id " +
                      "where em_employeenumber = " + EmployeeNumber + "";
            return sql;
        }

        //员工id查询员工sql
        public string IdFindEmployeeSql()
        {
            string sql = "select A.em_id,A.em_employeenumber,A.em_name,A.em_sex,B.de_name AS em_company,C.de_name AS em_department,D.de_name AS em_group " +
                      "from t_employee A left join t_department B on A.em_company = B.de_id left join t_department C on A.em_department = C.de_id left join t_department D on A.em_group = D.de_id " +
                      "where em_id = " + Id + "";
            return sql;
        }

        //添加员工sql
        public string AddEmployeeSql()
        {
            string sql = "insert into t_employee (em_employeenumber,em_name,em_sex,em_company,em_department,em_group)values('"
                + EmployeeNumber+ "','" + Name + "','" + Sex + "'," + Company + "," + Department + "," + Group + ")";
            return sql;
        }
 
        //删除员工sql
        public string EmployeeNumberDeleteEmployeeSql()
        {
            string sql = "delete from t_employee where em_employeenumber = " + EmployeeNumber + "";
            return sql;
        }

        //更新员工sql
        public string UpdateEmployeeSql()
        {
            string sql = "update t_employee set em_name='"+ Name + "',em_sex='" 
                + Sex + "',em_company=" + Company + ",em_department=" + Department + ",em_group="
                + Group + " where em_employeenumber = " + EmployeeNumber + "";
            return sql;
        }

        //树状图查询员工sql
        public string TreeFindEmployeeSql(int level, int nodeid)
        {
            string sql = "select A.em_id,A.em_employeenumber,A.em_name,A.em_sex,B.de_name AS em_company,C.de_name AS em_department,D.de_name AS em_group " +
                       "from t_employee A left join t_department B on A.em_company = B.de_id left join t_department C on A.em_department = C.de_id left join t_department D on A.em_group = D.de_id ";
            if (level == 0) //选中到公司
            {
                sql += $" where em_company ={nodeid}";
                return sql;
            }
            if (level == 1) //选中到部门
            {
                sql += $" where em_department ={nodeid}";
                return sql;
            }
            else  //选中到小组
            {
                sql += $" where em_group ={nodeid}";
                return sql;
            }
        }

        //添加员工过门信息
        public string AddEmployeePassDoorInformationSql()
        {
            string sql = "insert into t_fingerprint (fi_employeenumber,fi_passtime)values('"
                + EmployeeNumber + "','" + PassDoor + "')";
            return sql;
        }

        //员工多条件搜素
        public string QueryEmployeeSql(int level,int nondeid)
        {
            string sql = "select A.em_id,A.em_employeenumber,A.em_name,A.em_sex,B.de_name AS em_company,C.de_name AS em_department,D.de_name AS em_group " +
                        "from t_employee A left join t_department B on A.em_company = B.de_id left join t_department C on A.em_department = C.de_id left join t_department D on A.em_group = D.de_id where ";
            if(!EmployeeNumber.Equals(""))
            {
                sql += $" em_employeenumber={EmployeeNumber}";
            }
            if (!Name.Equals("") && EmployeeNumber.Equals(""))
            {
                sql += $" em_name='{Name}'";
            }
            if (!Name.Equals("") && !EmployeeNumber.Equals(""))
            {
                sql += $" and em_name='{Name}'";
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
            if (nondeid != 0 && level == 0)
            {
                sql += $" and B.de_id={nondeid}";
            }
            if (nondeid != 0 && level == 1)
            {
                sql += $" and C.de_id={nondeid}";
            }
            if (nondeid != 0 && level == 2)
            {
                sql += $" and D.de_id={nondeid}";
            }
            return sql;
        }

        private void Setup()
        {
            maker = new SelectSqlMaker("User");
        }
    }  
}
