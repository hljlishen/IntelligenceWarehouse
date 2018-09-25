﻿using DbLink;
using System;

namespace cangku_01.entity
{
    public class Fingerprint : ActiveRecord
    {

        public int? fi_id { get; set; }
        public string fi_employeenumber { get; set; }
        public DateTime? fi_passtime { get; set; }

        //private int thisIsNotAProperty;
        //public int Get() => thisIsNotAProperty;
        //public void Set(int value) => thisIsNotAProperty = value;

        //public int ThisIsAproperty { get; set; }

        public Fingerprint(DbLinkFactory factory) : base("t_fingerprint", "fi_id", factory)
        {

        }
        //重写模板
        public override void Insert()
        {
            base.Insert();
        }
    }
}
