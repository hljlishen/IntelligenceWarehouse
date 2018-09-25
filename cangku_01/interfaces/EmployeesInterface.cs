using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using cangku_01.entity;
using System.Data;

//员工信息接口

namespace cangku_01.interfaces
{
    interface EmployeesInterface
    {
        //员工添加查重
        int EmployeesRechecking(string employeesid);

        //添加用户
        void AddEmployee(Employee em);

        //修改用户
        void UpdateEmployee(Employee em);

        //编号查询员工
        DataTable EmployeeNumberQueryEmployee(Employee em);

        //Id查询员工
        DataTable IdQueryEmployee(Employee em);
    }
}
