using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.entity
{
    class User
    {
        private String id;
        private String name;
        private String sex;
        private String tel;
        private String temp;
        private String job;
        private String salary;
        private String time;

        public String Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Temp { get => temp; set => temp = value; }
        public string Job { get => job; set => job = value; }
        public String Salary { get => salary; set => salary = value; }
        public String Time { get => time; set => time = value; }
    }
}
