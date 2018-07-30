using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cangku_01.entity;

namespace cangku_01.LK
{
    //人员信息显示接口实现
    class InterfaceImp_PeopleInformation : Interface_PeopleInformation
    {
        //定义接收实体类的数组
        List<User> peopleinformations_list = new List<User>();

        //实例化实体类
        User information1 = new User();
        User information2 = new User();

        //在数据库查询人员的信息，并存放在数组中
        List<User> Interface_PeopleInformation.All_information()
        {
            information1.Id = 00011;
            information1.Name = "白宇";
            information1.Temp = "工程技术部";
            peopleinformations_list.Add(information1);

            return peopleinformations_list;    
        }

        //显示肖像
  

        public string[] person_picture()
        {
            throw new NotImplementedException();
        }

        string Interface_PeopleInformation.person_picture()
        {
            throw new NotImplementedException();
        }
    }
}
