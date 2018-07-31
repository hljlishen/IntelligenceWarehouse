using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.entity
{
    class User
    {
        public int Id {get;set;}                        //sql主键ID
        public string UserNumber { get; set; }          //员工编号
        public string Name { get; set; }                //名字
        public string Sex { get; set; }                 //性别
        public string Department { get; set; }          //部门
    }
}
