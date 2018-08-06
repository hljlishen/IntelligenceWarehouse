using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.entity
{
    public class Employees
    {
        public int Id {get;set;}                        //sql员工主键ID
        public int UserNumber { get; set; }             //员工编号
        public string Name { get; set; }                //名字
        public string Sex { get; set; }                 //性别
        public string Company { get; set; }             //公司
        public string Department { get; set; }          //部门
        public string Group { get; set; }               //组名 

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
                +u.UserNumber+ "','" + u.Name + "','" + u.Sex + "','" + u.Company + "','" + u.Department + "','" + u.Group + "')";
            return sql;
        }
    }

    
}
