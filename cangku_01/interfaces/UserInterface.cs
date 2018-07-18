using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using cangku_01.entity;

namespace cangku_01.interfaces
{
    interface UserInterface
    {
        //添加用户
       void addUser(User user);
        //查询用户
       List<User> findAllUser();
        //根据用户名查找
       List<User> findUserByName(String Name);
        //删除员工信息
       void delUser(int id);
        //根据id查找用户信息
        List<User> findUserById(int id);
        //根据id已经查到的数值
        List<User> UpdateUserList();
       
    }
}
