﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace DbLink
{
    public abstract class ActiveRecord
    {
        private readonly List<TableField> _selectFields;
        protected string TableName;
        protected IDatabaseDrive DatabaseDrive;
        protected IDateTimeFormater DateTimeFormater;
        private string _primaryKeyName = "";
        private const string Space = " ";
        private readonly TableFieldManager _tableFieldManager;

        protected ActiveRecord(string tableName, string primaryKeyName, DbLinkFactory factory)
        {
            TableName = tableName;
            DatabaseDrive = factory.CreateDatabaseDrive();
            DateTimeFormater = factory.CreateDateTimeFormater();
            _selectFields = new List<TableField>();
            _tableFieldManager = new TableFieldManager(this, DateTimeFormater);
            AddTableFieldsFromProperties();
            SetPrimaryKey(primaryKeyName);
        }

        private void SetPrimaryKey(string primaryKeyName)
        {
            if(FieldNameAlreadyExists(primaryKeyName))
                _primaryKeyName = primaryKeyName;
            else throw new Exception($"指定的主键<{primaryKeyName}>不存在");
        }

        private void AddTableFieldsFromProperties()
        {
            var fields = _tableFieldManager.CreateTableFields();
            foreach (TableField tableField in fields)
            {
                AddField(tableField);
            }
        }

        private void AddField(TableField field)
        {
            string fieldName = field.GetFieldName();

            if (FieldNameAlreadyExists(fieldName))
                throw new Exception($"添加的域已经在列表中<{fieldName}>");

            _selectFields.Add(field);
        }

        private bool FieldNameAlreadyExists(string fieldName)
        {
            foreach (TableField field in _selectFields)
            {
                if (field.GetFieldName() == fieldName)
                    return true;
            }

            return false;
        }

        private void SetFieldValue(string fieldName, object value)
        {
            TableField field = FindTableFieldByName(fieldName);
            field.SetValue(value);
        }

        private TableField FindTableFieldByName(string fieldName)
        {
            if (!FieldNameAlreadyExists(fieldName))
                throw new Exception($"域{fieldName}不存在");

            foreach (TableField field in _selectFields)
            {
                if (field.GetFieldName() == fieldName)
                    return field;
            }

            return null;
        }

        private object GetFieldValue(string fieldName)
        {
            if (!FieldNameAlreadyExists(fieldName))
                throw new Exception($"域名<{fieldName}>不存在");
            TableField field = FindTableFieldByName(fieldName);
            return field.FieldValue;
        }

        public string MakeInsertSqlCommand()
        {
            _tableFieldManager.UpdateFields();
            return $"insert into {TableName} " + MakeSelectFieldsClause() + MakeSelectValuesClause();
        }

        private string MakeSelectFieldsClause()
        {
            string fieldsClause = "(";

            foreach (TableField field in _selectFields)
            {
                if(!field.HasValue())
                {
                    if (IsTheLastField(field))      //列表中最后一个域为空值时，应该删除上一个
                        fieldsClause = RemoveLastIndex(fieldsClause);
                    continue;
                }
                fieldsClause += field.GetFieldName();
                if (!IsTheLastField(field))
                    fieldsClause += ",";
            }

            fieldsClause += ")" + Space;
            return fieldsClause;
        }

        private bool IsTheLastField(TableField field) => field == _selectFields[_selectFields.Count - 1];

        private string RemoveLastIndex(string str) => str.Substring(0, str.Length - 1);

        private string MakeSelectValuesClause()
        {
            string valuesClause = "values (";

            foreach (TableField field in _selectFields)
            {
                if (!field.HasValue())
                {
                    if (IsTheLastField(field))      
                        valuesClause = RemoveLastIndex(valuesClause);
                    continue;
                }
                valuesClause += field.GetValueString();
                if (!IsTheLastField(field))
                    valuesClause += ",";
            }

            valuesClause += ")";
            return valuesClause;
        }

        public virtual string MakeUpdateSqlCommand()
        {
            _tableFieldManager.UpdateFields();
            TableField keyField = FindTableFieldByName(_primaryKeyName);
            string updateSql = $"update {TableName} set" + Space;
            updateSql += MakeUpdateValuesClause() + Space;
            updateSql += $"where {keyField.MakeClause()}";
            return updateSql;
        }

        protected string MakeUpdateValuesClause()
        {
            _tableFieldManager.UpdateFields();
            string updateValuesClause = "";
            foreach (TableField field in _selectFields)
            {
                if (!field.HasValue())
                {
                    if (IsTheLastField(field))
                        updateValuesClause = RemoveLastIndex(updateValuesClause);
                    continue;
                }
                updateValuesClause += field.MakeUpdateClause();
                if (!IsTheLastField(field))
                    updateValuesClause += ",";
            }

            return updateValuesClause;
        }

        public string MakeDeleteSqlCommand()
        {
            _tableFieldManager.UpdateFields();
            TableField keyField = FindTableFieldByName(_primaryKeyName);
            return $"delete from {TableName} where {keyField.MakeClause()}";
        }

        public virtual void Insert()
        {
            if (!IsThisRecordAlreadyInDataBase())
                DatabaseDrive.ExecuteInsert(MakeInsertSqlCommand());
            else
                throw new Exception($"主键{_primaryKeyName}值不为null，不能执行Insert");
        }

        private bool IsThisRecordAlreadyInDataBase()
        {
            _tableFieldManager.UpdateFields();
            object primaryKeyValue = GetFieldValue(_primaryKeyName);
            return primaryKeyValue != null;
        }

        public virtual void Update()
        {
            if(IsThisRecordAlreadyInDataBase())
                DatabaseDrive.ExecuteUpdate(MakeUpdateSqlCommand());
            else
                throw new Exception($"主键{_primaryKeyName}值为null，不能执行update");
        }

        public virtual void Delete()
        {
            if (IsThisRecordAlreadyInDataBase())
                DatabaseDrive.ExecuteDelete(MakeDeleteSqlCommand());
            else
                throw new Exception($"主键{_primaryKeyName}值为null，不能执行delete");
        }

        public static DataTable Select(string selectSql, IDatabaseDrive dbDrive)
        {
            DataSet queryResult = dbDrive.ExecuteSelect(selectSql);
            return queryResult.Tables[0];
        }

        public DataTable Select(string selectSql) => Select(selectSql, DatabaseDrive);

        public virtual void LoadDataRow(DataRow row)
        {
            PropertyInfo[] property = GetType().GetProperties();
            try
            {
                foreach (PropertyInfo propertyInfo in property)
                {
                    string name = propertyInfo.Name;
                    object value = row[name];
                    if(value is System.DBNull)
                        propertyInfo.SetValue(this, null);
                    else
                        propertyInfo.SetValue(this, value);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public virtual void LoadDataGridViewRow(DataGridViewRow row)
        {
            PropertyInfo[] property = GetType().GetProperties();
            try
            {
                foreach (PropertyInfo propertyInfo in property)
                {
                    string name = propertyInfo.Name;
                    object value = row.Cells[name].Value;
                    if (value is System.DBNull)
                        propertyInfo.SetValue(this, null);
                    else
                        propertyInfo.SetValue(this, value);
                }
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
