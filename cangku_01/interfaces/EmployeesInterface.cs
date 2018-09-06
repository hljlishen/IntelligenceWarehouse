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
        //查询全部用户
        DataTable QueryAllEmployee();

        //员工添加查重
        int EmployeesRechecking(string employeesid);

        //添加用户
        void AddEmployee(Employee em);

        //删除员工信息
        void DeleteEmployee(string employeesid);

        //修改用户
        void UpdateEmployee(Employee em);

        //树状图查询员工
        DataTable TreeQueryEmployee(int level, int nodeid);

        //编号查询员工
        DataTable EmployeeNumberQueryEmployee(Employee em);

        //Id查询员工
        DataTable IdQueryEmployee(Employee em);

        //在组中搜素员工
        DataTable QueryInTheGroupEmployee(Employee em, int level, int nodeid);

        //在全部人员中搜索
        DataTable QueryInTheAllEmployee(Employee em);

        //添加员工过门信息
        void AddEmployeePassDoorInformation(Employee em);
    }
}
