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
        ArrayList arr = new ArrayList();
        User user = new User();

        public ArrayList findUser()
        {
            return arr;
        }

        void UserInterface.addUser(User u)
        {
            arr.Add(u);
        }
    }
}
