using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.LK
{
    //人员信息显示接口实现
    class interfaceImp_peopleinformation : interface_peopleinformation
    {
        //定义接收实体类的数组
        List<entity_peopleinformation> peopleinformations_list = new List<entity_peopleinformation>();

        //实例化实体类
        entity_peopleinformation information1 = new entity_peopleinformation();
        entity_peopleinformation information2 = new entity_peopleinformation();

        //在数据库查询人员的信息，并存放在数组中
        List<entity_peopleinformation> interface_peopleinformation.All_information()
        {
            information1.Id = 00011;
            information1.Name = "白宇";
            information1.Department = "工程技术部";
            peopleinformations_list.Add(information1);

            return peopleinformations_list;    
        }

        //显示肖像
  

        public string[] person_picture()
        {
            throw new NotImplementedException();
        }

        string interface_peopleinformation.person_picture()
        {
            throw new NotImplementedException();
        }
    }
}
