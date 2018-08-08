using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.entity
{
    public class Employees
    {
        public int Id {get;set;}                     //sql员工主键ID
        public int UserNumber { get; set; }          //员工编号
        public string Name { get; set; }             //名字
        public string Sex { get; set; }              //性别
        public int Company { get; set; }             //公司
        public int Department { get; set; }          //部门
        public int Group { get; set; }               //组名 

        //查询全部员工sql
        public string FindAllEmployeesSql()
        {
            string sql = "select A.em_id,A.em_usernumber,A.em_name,A.em_sex,B.de_name AS em_company,C.de_name AS em_department,D.de_name AS em_group " +
                        "from t_employees A left join t_department B on A.em_company = B.de_id left join t_department C on A.em_department = C.de_id left join t_department D on A.em_group = D.de_id";
            return sql;
        }

        //人员查重sql
        public string EmployeesRechecking(int employeesid)
        {
            string sql = "select * from t_employees where em_usernumber = "+ employeesid + "";
            return sql;
        }

        //添加员工sql
        public string AddEmployeesSql(Employees u)
        {
            string sql = "insert into t_employees (em_usernumber,em_name,em_sex,em_company,em_department,em_group)values('"
                +u.UserNumber+ "','" + u.Name + "','" + u.Sex + "'," + u.Company + "," + u.Department + "," + u.Group + ")";
            return sql;
        }
 
        //删除员工sql
        public string DeleteEmployeesSql(int usernumber)
        {
            string sql = "delete from t_employees where em_usernumber = " + usernumber + "";
            return sql;
        }

        //更新员工sql
        public string UpdateEmployeesSql(Employees u)
        {
            string sql = "update t_employees set em_name='"+ u.Name + "',em_sex='" 
                + u.Sex + "',em_company=" + u.Company + ",em_department=" + u.Department + ",em_group="
                + u.Group + " where em_usernumber = " + u.UserNumber + "";
            return sql;
        }

        //树状图查询员工sql
        public string TreeFindEmployeesSql(int level, int nodeid)
        {  
            if (level == 0) //选中到公司
            {
                string sql = "select A.em_id,A.em_usernumber,A.em_name,A.em_sex,B.de_name AS em_company,C.de_name AS em_department,D.de_name AS em_group " +
                       "from t_employees A left join t_department B on A.em_company = B.de_id left join t_department C on A.em_department = C.de_id left join t_department D on A.em_group = D.de_id " +
                       "where em_company = " + nodeid + "";
                return sql;
            }
            if (level == 1) //选中到部门
            {
                string sql = "select A.em_id,A.em_usernumber,A.em_name,A.em_sex,B.de_name AS em_company,C.de_name AS em_department,D.de_name AS em_group " +
                       "from t_employees A left join t_department B on A.em_company = B.de_id left join t_department C on A.em_department = C.de_id left join t_department D on A.em_group = D.de_id " +
                       "where em_department = " + nodeid + "";
                return sql;
            }
            else  //选中到小组
            {
                string sql = "select A.em_id,A.em_usernumber,A.em_name,A.em_sex,B.de_name AS em_company,C.de_name AS em_department,D.de_name AS em_group " +
                      "from t_employees A left join t_department B on A.em_company = B.de_id left join t_department C on A.em_department = C.de_id left join t_department D on A.em_group = D.de_id " +
                      "where em_group = " + nodeid + "";
                return sql;
            }
        }
    }

    
}
