using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.LK
{
    //实体类
    class entity_peopleinformation
    {
        //人员信息显示
        int id;                       //人员编号
        String name;            //人员姓名
        String department;  //人员所属部门
        String picture;       //人员肖像

        //实体get,set 方法
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Department { get => department; set => department = value; }
        public string Picture { get => picture; set => picture = value; }
    }
}
