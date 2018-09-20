﻿namespace cangku_01.view.EmployeesManagement
{
    partial class EmployeeManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManagement));
            this.tb_foundemployeeid = new System.Windows.Forms.TextBox();
            this.bt_foundnowgroup = new System.Windows.Forms.Button();
            this.bt_addemployee = new System.Windows.Forms.Button();
            this.dgv_employeeinformation = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.公司 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.部门 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.小组 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.update_ = new System.Windows.Forms.DataGridViewButtonColumn();
            this.员工Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tv_department = new System.Windows.Forms.TreeView();
            this.tb_foundname = new System.Windows.Forms.TextBox();
            this.cb_foundsex = new System.Windows.Forms.ComboBox();
            this.la_foundemployeeid = new System.Windows.Forms.Label();
            this.la_foundname = new System.Windows.Forms.Label();
            this.la_foundsex = new System.Windows.Forms.Label();
            this.gb_foundemployees = new System.Windows.Forms.GroupBox();
            this.bt_foundall = new System.Windows.Forms.Button();
            this.cms_employeetreeview = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_newcompany = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_newdepartment = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_newgroup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_rename = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employeeinformation)).BeginInit();
            this.gb_foundemployees.SuspendLayout();
            this.cms_employeetreeview.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_foundemployeeid
            // 
            resources.ApplyResources(this.tb_foundemployeeid, "tb_foundemployeeid");
            this.tb_foundemployeeid.Name = "tb_foundemployeeid";
            // 
            // bt_foundnowgroup
            // 
            resources.ApplyResources(this.bt_foundnowgroup, "bt_foundnowgroup");
            this.bt_foundnowgroup.Name = "bt_foundnowgroup";
            this.bt_foundnowgroup.UseVisualStyleBackColor = true;
            this.bt_foundnowgroup.Click += new System.EventHandler(this.bt_foundnowgroup_Click);
            // 
            // bt_addemployee
            // 
            resources.ApplyResources(this.bt_addemployee, "bt_addemployee");
            this.bt_addemployee.Name = "bt_addemployee";
            this.bt_addemployee.UseVisualStyleBackColor = true;
            this.bt_addemployee.Click += new System.EventHandler(this.bt_addemployee_Click);
            // 
            // dgv_employeeinformation
            // 
            this.dgv_employeeinformation.AllowUserToAddRows = false;
            this.dgv_employeeinformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_employeeinformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.姓名,
            this.性别,
            this.公司,
            this.部门,
            this.小组,
            this.del,
            this.update_,
            this.员工Id});
            resources.ApplyResources(this.dgv_employeeinformation, "dgv_employeeinformation");
            this.dgv_employeeinformation.MultiSelect = false;
            this.dgv_employeeinformation.Name = "dgv_employeeinformation";
            this.dgv_employeeinformation.RowTemplate.Height = 23;
            this.dgv_employeeinformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_employeeinformation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_employeeinformation_CellContentClick);
            this.dgv_employeeinformation.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_employeeinformation_CellContentDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "01";
            resources.ApplyResources(this.ID, "ID");
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // 姓名
            // 
            resources.ApplyResources(this.姓名, "姓名");
            this.姓名.Name = "姓名";
            this.姓名.ReadOnly = true;
            // 
            // 性别
            // 
            resources.ApplyResources(this.性别, "性别");
            this.性别.Name = "性别";
            this.性别.ReadOnly = true;
            // 
            // 公司
            // 
            resources.ApplyResources(this.公司, "公司");
            this.公司.Name = "公司";
            this.公司.ReadOnly = true;
            // 
            // 部门
            // 
            resources.ApplyResources(this.部门, "部门");
            this.部门.Name = "部门";
            this.部门.ReadOnly = true;
            // 
            // 小组
            // 
            resources.ApplyResources(this.小组, "小组");
            this.小组.Name = "小组";
            this.小组.ReadOnly = true;
            // 
            // del
            // 
            this.del.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(this.del, "del");
            this.del.Name = "del";
            this.del.ReadOnly = true;
            this.del.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.del.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.del.Text = "删除";
            this.del.UseColumnTextForButtonValue = true;
            // 
            // update_
            // 
            this.update_.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(this.update_, "update_");
            this.update_.Name = "update_";
            this.update_.ReadOnly = true;
            this.update_.Text = "修改";
            this.update_.UseColumnTextForButtonValue = true;
            // 
            // 员工Id
            // 
            resources.ApplyResources(this.员工Id, "员工Id");
            this.员工Id.Name = "员工Id";
            this.员工Id.ReadOnly = true;
            // 
            // tv_department
            // 
            resources.ApplyResources(this.tv_department, "tv_department");
            this.tv_department.Name = "tv_department";
            this.tv_department.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_department_AfterSelect);
            this.tv_department.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tv_department_MouseDown);
            // 
            // tb_foundname
            // 
            resources.ApplyResources(this.tb_foundname, "tb_foundname");
            this.tb_foundname.Name = "tb_foundname";
            // 
            // cb_foundsex
            // 
            this.cb_foundsex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_foundsex.FormattingEnabled = true;
            resources.ApplyResources(this.cb_foundsex, "cb_foundsex");
            this.cb_foundsex.Items.AddRange(new object[] {
            resources.GetString("cb_foundsex.Items"),
            resources.GetString("cb_foundsex.Items1"),
            resources.GetString("cb_foundsex.Items2")});
            this.cb_foundsex.Name = "cb_foundsex";
            // 
            // la_foundemployeeid
            // 
            resources.ApplyResources(this.la_foundemployeeid, "la_foundemployeeid");
            this.la_foundemployeeid.Name = "la_foundemployeeid";
            // 
            // la_foundname
            // 
            resources.ApplyResources(this.la_foundname, "la_foundname");
            this.la_foundname.Name = "la_foundname";
            // 
            // la_foundsex
            // 
            resources.ApplyResources(this.la_foundsex, "la_foundsex");
            this.la_foundsex.Name = "la_foundsex";
            // 
            // gb_foundemployees
            // 
            this.gb_foundemployees.Controls.Add(this.bt_foundall);
            this.gb_foundemployees.Controls.Add(this.la_foundemployeeid);
            this.gb_foundemployees.Controls.Add(this.cb_foundsex);
            this.gb_foundemployees.Controls.Add(this.la_foundsex);
            this.gb_foundemployees.Controls.Add(this.tb_foundemployeeid);
            this.gb_foundemployees.Controls.Add(this.la_foundname);
            this.gb_foundemployees.Controls.Add(this.tb_foundname);
            this.gb_foundemployees.Controls.Add(this.bt_foundnowgroup);
            resources.ApplyResources(this.gb_foundemployees, "gb_foundemployees");
            this.gb_foundemployees.Name = "gb_foundemployees";
            this.gb_foundemployees.TabStop = false;
            // 
            // bt_foundall
            // 
            resources.ApplyResources(this.bt_foundall, "bt_foundall");
            this.bt_foundall.Name = "bt_foundall";
            this.bt_foundall.UseVisualStyleBackColor = true;
            this.bt_foundall.Click += new System.EventHandler(this.bt_foundall_Click);
            // 
            // cms_employeetreeview
            // 
            this.cms_employeetreeview.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_newcompany,
            this.tsm_newdepartment,
            this.tsm_newgroup,
            this.tsm_delete,
            this.tsm_rename});
            this.cms_employeetreeview.Name = "cms_employeetreeview";
            resources.ApplyResources(this.cms_employeetreeview, "cms_employeetreeview");
            // 
            // tsm_newcompany
            // 
            this.tsm_newcompany.Name = "tsm_newcompany";
            resources.ApplyResources(this.tsm_newcompany, "tsm_newcompany");
            this.tsm_newcompany.Click += new System.EventHandler(this.tsm_newcompany_Click);
            // 
            // tsm_newdepartment
            // 
            this.tsm_newdepartment.Name = "tsm_newdepartment";
            resources.ApplyResources(this.tsm_newdepartment, "tsm_newdepartment");
            this.tsm_newdepartment.Click += new System.EventHandler(this.tsm_newdepartment_Click);
            // 
            // tsm_newgroup
            // 
            this.tsm_newgroup.Name = "tsm_newgroup";
            resources.ApplyResources(this.tsm_newgroup, "tsm_newgroup");
            this.tsm_newgroup.Click += new System.EventHandler(this.tsm_newgroup_Click);
            // 
            // tsm_delete
            // 
            this.tsm_delete.Name = "tsm_delete";
            resources.ApplyResources(this.tsm_delete, "tsm_delete");
            this.tsm_delete.Click += new System.EventHandler(this.tsm_delete_Click);
            // 
            // tsm_rename
            // 
            this.tsm_rename.Name = "tsm_rename";
            resources.ApplyResources(this.tsm_rename, "tsm_rename");
            this.tsm_rename.Click += new System.EventHandler(this.tsm_rename_Click);
            // 
            // EmployeeManagement
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_foundemployees);
            this.Controls.Add(this.tv_department);
            this.Controls.Add(this.bt_addemployee);
            this.Controls.Add(this.dgv_employeeinformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeManagement";
            this.Load += new System.EventHandler(this.index_employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employeeinformation)).EndInit();
            this.gb_foundemployees.ResumeLayout(false);
            this.gb_foundemployees.PerformLayout();
            this.cms_employeetreeview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tb_foundemployeeid;
        private System.Windows.Forms.Button bt_foundnowgroup;
        private System.Windows.Forms.Button bt_addemployee;
        private System.Windows.Forms.TreeView tv_department;
        public System.Windows.Forms.DataGridView dgv_employeeinformation;
        private System.Windows.Forms.TextBox tb_foundname;
        private System.Windows.Forms.ComboBox cb_foundsex;
        private System.Windows.Forms.Label la_foundemployeeid;
        private System.Windows.Forms.Label la_foundname;
        private System.Windows.Forms.Label la_foundsex;
        private System.Windows.Forms.GroupBox gb_foundemployees;
        private System.Windows.Forms.Button bt_foundall;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 公司;
        private System.Windows.Forms.DataGridViewTextBoxColumn 部门;
        private System.Windows.Forms.DataGridViewTextBoxColumn 小组;
        private System.Windows.Forms.DataGridViewButtonColumn del;
        private System.Windows.Forms.DataGridViewButtonColumn update_;
        private System.Windows.Forms.DataGridViewTextBoxColumn 员工Id;
        private System.Windows.Forms.ContextMenuStrip cms_employeetreeview;
        private System.Windows.Forms.ToolStripMenuItem tsm_newcompany;
        private System.Windows.Forms.ToolStripMenuItem tsm_newdepartment;
        private System.Windows.Forms.ToolStripMenuItem tsm_newgroup;
        private System.Windows.Forms.ToolStripMenuItem tsm_delete;
        private System.Windows.Forms.ToolStripMenuItem tsm_rename;
    }
}