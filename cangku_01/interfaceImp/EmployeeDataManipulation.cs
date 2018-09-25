using System.Data;
using cangku_01.entity;
using cangku_01.interfaces;
using cangku_01.MysqlConnection;

//员工信息接口实现

namespace cangku_01.interfaceImp
{
    class EmployeeDataManipulation : EmployeesInterface
    {
        DataMysql dbo = DataMysql.GetDataMysqlGreateInstance(DataMysql.mysqldefaultconnection);

        //员工查重
        public int EmployeesRechecking(string employeenumber)
        {
            Employee e = new Employee();
            e.EmployeeNumber = employeenumber;
            string sql = e.EmployeeNumberFindEmployeeSql();
            int i = dbo.GetFirstDataId(sql);
            return i;
        }

        //添加员工
        public void AddEmployee(Employee em)
        {
            string sql = em.AddEmployeeSql();
            dbo.WriteDB(sql);
        }

        //更新员工
        public void UpdateEmployee(Employee em)
        {
            string sql = em.UpdateEmployeeSql();
            dbo.WriteDB(sql);
        }

        //编号查询员工
        public DataTable EmployeeNumberQueryEmployee(Employee em)
        {
            string sql = em.EmployeeNumberFindEmployeeSql();
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }


        //编号查询员工
        public DataTable IdQueryEmployee(Employee em)
        {
            string sql = em.IdFindEmployeeSql();
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }
    }
}
