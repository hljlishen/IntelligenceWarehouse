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

//用户信息接口实现

namespace cangku_01.interfaceImp
{
    class EmployeesInterfaceImp : EmployeesInterface
    {
        //查询全部的员工
        public DataTable FindAllEmployees()
        {
            DataMysql dbo = new DataMysql();
            Employees e = new Employees();
            string sql = e.FindAllEmployeesSql();
            DataTable dt = dbo.ReadDBDataTable(sql);       
            return dt;
        }

        //员工查重
        public int EmployeesRechecking(int employeesid)
        {
            DataMysql dbo = new DataMysql();
            Employees e = new Employees();
            string sql = e.EmployeesRechecking(employeesid);
            int i = dbo.FirstValue(sql);
            return i;
        }

        //添加员工
        public int AddEmployees(Employees u)
        {
            DataMysql dbo = new DataMysql();
            Employees e = new Employees();
            string sql = e.AddEmployeesSql(u);
            int i = dbo.WriteDB(sql);
            return i;
        }

        //删除员工
        public int DeleteEmployees(int usernumber)
        {
            DataMysql dbo = new DataMysql();
            Employees e = new Employees();
            string sql = e.DeleteEmployeesSql(usernumber);
            int i = dbo.WriteDB(sql);
            return i;
        }

        //更新员工
        public int UpdateEmployees(Employees u)
        {
            DataMysql dbo = new DataMysql();
            Employees e = new Employees();
            string sql = e.UpdateEmployeesSql(u);
            int i = dbo.WriteDB(sql);
            return i;
        }

        //树状图查询员工
        public DataTable TreeFindEmployees(int level, int nodeid)
        {
            DataMysql dbo = new DataMysql();
            Employees e = new Employees();
            string sql = e.TreeFindEmployeesSql(level, nodeid);
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }

        //编号查询员工
        public DataTable FindEmployeesNumber(int employeesnumber)
        {
            DataMysql dbo = new DataMysql();
            Employees e = new Employees();
            string sql = e.EmployeesRechecking(employeesnumber);
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }



        public List<Employees> findUserById(int id)
        {

            List<Employees> list = new List<Employees>();
            return list;
        }



       
    }
}
