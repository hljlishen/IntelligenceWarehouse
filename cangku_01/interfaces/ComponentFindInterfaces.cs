using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.SQQ
{
    interface ComponentFindInterfaces
    {
        //根据元器件的名称获取位置
        List<ComponentFind> findByName(String name);
    }
}
