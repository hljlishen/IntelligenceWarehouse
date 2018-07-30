using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.SQQ
{
    class ComponentFindInterfaceImp : ComponentFindInterfaces
    {
        public static List<ComponentFind> componentFindsList = new List<ComponentFind>();
        ComponentFind componentFind = new ComponentFind();

        public List<ComponentFind> findByName(string name)
        {
            //编写根据元器件名称查询的sql语句
            componentFind.Com_name = name;
            componentFind.Com_Location = "桌子上";
            componentFindsList.Add(componentFind);
            return componentFindsList;
        }
    }
}
