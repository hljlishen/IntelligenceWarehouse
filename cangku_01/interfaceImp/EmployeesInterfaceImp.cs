using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cangku_01.entity;
using cangku_01.interfaces;
using cangku_01.MysqlConnection;

//用户信息接口实现

namespace cangku_01.interfaceImp
{
    class EmployeesInterfaceImp : EmployeesInterface
    {
        List<Employees> arr = new List<Employees>();
  
        public void delUser(int id)
        {
            Console.WriteLine("删除成功");
        }

        public List<Employees> findAllUser()
        {
            List<Employees> list = new List<Employees>();
            Employees user = new Employees();
            Employees user1 = new Employees();
            user.Id = 1;
            user.Name = "张三";
            user.Sex = "男";
            user.Department = "人事";
           
            user1.Id = 2;
            user1.Name = "李四";
            user1.Sex = "男";
            user1.Department = "研发部";
            list.Add(user);
            list.Add(user1);
    
            return list;
        }

        public List<Employees> findUserByName(String name)
        {
            //写sql语句返回
            return arr;
        }

        //添加员工
        int EmployeesInterface.AddEmployees(Employees u)
        {
            DataMysql dbo = new DataMysql();
            Employees e = new Employees();
            string sql = e.AddEmployeesSql(u);
            int i = dbo.WriteDB(sql);
            return i;
        }

        public List<Employees> findUserById(int id)
        {
   
            return arr;
        }

        //更新员工
        public List<Employees> UpdateUserList()
        {
            throw new NotImplementedException();
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
    }
}
