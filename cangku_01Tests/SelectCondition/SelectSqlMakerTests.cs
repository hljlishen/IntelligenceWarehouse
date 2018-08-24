using Microsoft.VisualStudio.TestTools.UnitTesting;
using DbLink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLink.Tests
{
    [TestClass()]
    public class SelectSqlMakerTests
    {
        SelectSqlMaker maker;

        private void Setup()
        {
            maker = new SelectSqlMaker("User");
        }
        [TestMethod()]
        public void TestNoCondition()
        {
            Setup();
            string expected = "select * from User";
            //maker.AddFieldsWillBeSelected("Id");
            string actual = maker.MakeSelectSql();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestIntEqualCondition()
        {
            Setup();

            maker.AddAndCondition(new IntEqual("Id", 1));
            string expected = "select * from User where Id=1";
            string actual = maker.MakeSelectSql();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestInvalidCondition()
        {
            Setup();
            maker.AddAndCondition(new IntEqual("Id", null));
            string expected = "select * from User";
            string actual = maker.MakeSelectSql();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestDateEqualCondition()
        {
            Setup();
            maker.AddAndCondition(new DateEqual("InsertTime", new DateTime(2018,9,15), new StanderdStyleDateTimeFormater()));
            string expected = "select * from User where InsertTime='2018-09-15'";
            string actual = maker.MakeSelectSql();
            Assert.AreEqual(expected, actual);
        }
    }
}