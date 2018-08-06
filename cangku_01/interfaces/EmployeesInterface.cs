using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using cangku_01.entity;

//员工信息接口

namespace cangku_01.interfaces
{
    interface EmployeesInterface
    {
        //添加用户
       int AddEmployees(Employees user);
        //查询用户
       List<Employees> findAllUser();
        //根据用户名查找
       List<Employees> findUserByName(String Name);
        //删除员工信息
       void delUser(int id);
        //根据id查找用户信息
        List<Employees> findUserById(int id);
        //根据id已经查到的数值
        List<Employees> UpdateUserList();

        //员工添加查重
        int EmployeesRechecking(int employeesid);


    }
}
