using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cangku_01.interfaces;
using cangku_01.entity;

namespace cangku_01.interfaceImp
{
    class UserInterfaceImp : UserInterface
    {
        List<User> arr = new List<User>();
        User user = new User();
        User user1 = new User();


        public void delUser(int id)
        {
            //删除的sql语句
            Console.WriteLine("删除成功");
            
        }

        public List<User> findAllUser()
        {
            List<User> list = new List<User>();
            user.Id = 1;
            user.Name = "张三";
            user.Sex = "男";
            user.Time = DateTime.Now;
           
            user1.Id = 2;
            user1.Name = "李四";
            user1.Sex = "男";
            user1.Time = DateTime.Now;
            list.Add(user);
            list.Add(user1);
    
            return list;
        }

        public List<User> findUserByName(String name)
        {
            //写sql语句返回
            return arr;
        }

        void UserInterface.addUser(User u)
        {
            arr.Add(u);
        }

        public List<User> findUserById(int id)
        {
            //修改的sql语句
            return arr;
        }
    }
}
