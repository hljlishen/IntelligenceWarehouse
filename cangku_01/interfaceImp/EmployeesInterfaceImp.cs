using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cangku_01.entity;
using cangku_01.interfaces;
using cangku_01.MysqlConnection;

//员工信息接口实现

namespace cangku_01.interfaceImp
{
    class EmployeesInterfaceImp : EmployeesInterface
    {
        DataMysql dbo = DataMysql.GetDataMysql();

        //查询全部的员工
        public DataTable QueryAllEmployee()
        {
            Employee e = new Employee();
            string sql = e.FindAllEmployeeSql();
            DataTable dt = dbo.ReadDBDataTable(sql);       
            return dt;
        }

        //员工查重
        public int EmployeesRechecking(int employeenumber)
        {
            Employee e = new Employee();
            string sql = e.EmployeeNumberFindEmployeeSql(employeenumber);
            int i = dbo.FirstValue(sql);
            return i;
        }

        //添加员工
        public int AddEmployee(Employee em)
        {
            string sql = em.AddEmployeeSql();
            int i = dbo.WriteDB(sql);
            return i;
        }

        //删除员工
        public int DeleteEmployee(int employeenumber)
        {
            Employee e = new Employee();
            string sql = e.EmployeeNumberDeleteEmployeeSql(employeenumber);
            int i = dbo.WriteDB(sql);
            return i;
        }

        //更新员工
        public int UpdateEmployee(Employee em)
        {
            string sql = em.UpdateEmployeeSql();
            int i = dbo.WriteDB(sql);
            return i;
        }

        //树状图查询员工
        public DataTable TreeQueryEmployee(int level, int nodeid)
        {
            Employee e = new Employee();
            string sql = e.TreeFindEmployeeSql(level, nodeid);
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }

        //编号查询员工
        public DataTable EmployeeNumberQueryEmployee(int employeesnumber)
        {
            Employee e = new Employee();
            string sql = e.EmployeeNumberFindEmployeeSql(employeesnumber);
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }

        //在当前分组中搜索
        public DataTable QueryInTheGroupEmployee(Employee em , int level, int nodeid)
        {
            string sql = em.QueryEmployeeSql(level,nodeid);
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }

        //在全部人员中搜索
        public DataTable QueryInTheAllEmployee(Employee em)
        {
            string sql = em.QueryEmployeeSql(0, 0);
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }
    }
}
