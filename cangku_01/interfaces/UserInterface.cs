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
        //查询所有用户
       void addUser(User user);

       ArrayList findUser();
    }
}
