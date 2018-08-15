﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cangku_01.entity;
using cangku_01.interfaces;
using cangku_01.MysqlConnection;

//员工信息接口实现

namespace cangku_01.interfaceImp
{
    class EmployeesInterfaceImp : EmployeesInterface
    {
        DataMysql dbo = DataMysql.GetDataMysqlGreateInstance(DataMysql.mysqldefaultconnection);

        //查询全部的员工
        public DataTable QueryAllEmployee()
        {
            Employee e = new Employee();
            string sql = e.QueryAllEmployeeSql();
            DataTable dt = dbo.ReadDBDataTable(sql);       
            return dt;
        }

        //员工查重
        public int EmployeesRechecking(int employeenumber)
        {
            Employee e = new Employee();
            e.EmployeeNumber = employeenumber;
            string sql = e.EmployeeNumberFindEmployeeSql();
            int i = dbo.GetFirstDataId(sql);
            return i;
        }

        //添加员工
        public void AddEmployee(Employee em)
        {
            string sql = em.AddEmployeeSql();
            dbo.WriteDB(sql);
        }

        //删除员工
        public void DeleteEmployee(int employeenumber)
        {
            Employee e = new Employee();
            e.EmployeeNumber = employeenumber;
            string sql = e.EmployeeNumberDeleteEmployeeSql();
            dbo.WriteDB(sql);
        }

        //更新员工
        public void UpdateEmployee(Employee em)
        {
            string sql = em.UpdateEmployeeSql();
            dbo.WriteDB(sql);
        }

        //树状图查询员工
        public DataTable TreeQueryEmployee(int level, int nodeid)
        {
            Employee e = new Employee();
            string sql = e.TreeFindEmployeeSql(level, nodeid);
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }

        //编号查询员工
        public DataTable EmployeeNumberQueryEmployee(Employee em)
        {
            string sql = em.EmployeeNumberFindEmployeeSql();
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }

        //在当前分组中搜索
        public DataTable QueryInTheGroupEmployee(Employee em , int level, int nodeid)
        {
            string sql = em.QueryEmployeeSql(level,nodeid);
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }

        //在全部人员中搜索
        public DataTable QueryInTheAllEmployee(Employee em)
        {
            string sql = em.QueryEmployeeSql(0, 0);
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }
    }
}