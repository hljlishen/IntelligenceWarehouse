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
        DataTable FindAllEmployees();

        //员工添加查重
        int EmployeesRechecking(int employeesid);

        //添加用户
        int AddEmployees(Employees user);

        //删除员工信息
        int DeleteEmployees(int id);

        //添加用户
        int UpdateEmployees(Employees user);

        //树状图查询员工
        DataTable TreeFindEmployees(int level, int nodeid);

        //编号查询员工
        DataTable FindEmployeesNumber(int employeesnumber);
     
        //根据id查找用户信息
        List<Employees> findUserById(int id);
    }
}
