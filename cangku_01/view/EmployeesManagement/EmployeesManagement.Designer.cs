namespace cangku_01
{
    partial class EmployeesManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesManagement));
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
            this.tv_department = new System.Windows.Forms.TreeView();
            this.btn_addrootnode = new System.Windows.Forms.Button();
            this.btn_addchildnode = new System.Windows.Forms.Button();
            this.btn_removenodes = new System.Windows.Forms.Button();
            this.tb_nodename = new System.Windows.Forms.TextBox();
            this.la_nodename = new System.Windows.Forms.Label();
            this.tb_foundname = new System.Windows.Forms.TextBox();
            this.cb_foundsex = new System.Windows.Forms.ComboBox();
            this.la_foundemployeeid = new System.Windows.Forms.Label();
            this.la_foundname = new System.Windows.Forms.Label();
            this.la_foundsex = new System.Windows.Forms.Label();
            this.gb_foundemployees = new System.Windows.Forms.GroupBox();
            this.bt_foundall = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employeeinformation)).BeginInit();
            this.gb_foundemployees.SuspendLayout();
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
            this.dgv_employeeinformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_employeeinformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_employeeinformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.姓名,
            this.性别,
            this.公司,
            this.部门,
            this.小组,
            this.del,
            this.update_});
            resources.ApplyResources(this.dgv_employeeinformation, "dgv_employeeinformation");
            this.dgv_employeeinformation.Name = "dgv_employeeinformation";
            this.dgv_employeeinformation.ReadOnly = true;
            this.dgv_employeeinformation.RowHeadersVisible = false;
            this.dgv_employeeinformation.RowTemplate.Height = 23;
            this.dgv_employeeinformation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_employeeinformation_CellContentClick);
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
            // tv_department
            // 
            resources.ApplyResources(this.tv_department, "tv_department");
            this.tv_department.Name = "tv_department";
            this.tv_department.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_department_AfterSelect);
            // 
            // btn_addrootnode
            // 
            resources.ApplyResources(this.btn_addrootnode, "btn_addrootnode");
            this.btn_addrootnode.Name = "btn_addrootnode";
            this.btn_addrootnode.UseVisualStyleBackColor = true;
            this.btn_addrootnode.Click += new System.EventHandler(this.Btn_addrootnode_Click);
            // 
            // btn_addchildnode
            // 
            resources.ApplyResources(this.btn_addchildnode, "btn_addchildnode");
            this.btn_addchildnode.Name = "btn_addchildnode";
            this.btn_addchildnode.UseVisualStyleBackColor = true;
            this.btn_addchildnode.Click += new System.EventHandler(this.Btn_addchildnode_Click);
            // 
            // btn_removenodes
            // 
            resources.ApplyResources(this.btn_removenodes, "btn_removenodes");
            this.btn_removenodes.Name = "btn_removenodes";
            this.btn_removenodes.UseVisualStyleBackColor = true;
            this.btn_removenodes.Click += new System.EventHandler(this.Btn_removenodes_Click);
            // 
            // tb_nodename
            // 
            resources.ApplyResources(this.tb_nodename, "tb_nodename");
            this.tb_nodename.Name = "tb_nodename";
            // 
            // la_nodename
            // 
            resources.ApplyResources(this.la_nodename, "la_nodename");
            this.la_nodename.Name = "la_nodename";
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
            // EmployeesManagement
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_foundemployees);
            this.Controls.Add(this.la_nodename);
            this.Controls.Add(this.tb_nodename);
            this.Controls.Add(this.btn_removenodes);
            this.Controls.Add(this.btn_addchildnode);
            this.Controls.Add(this.btn_addrootnode);
            this.Controls.Add(this.tv_department);
            this.Controls.Add(this.bt_addemployee);
            this.Controls.Add(this.dgv_employeeinformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeesManagement";
            this.Load += new System.EventHandler(this.index_employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employeeinformation)).EndInit();
            this.gb_foundemployees.ResumeLayout(false);
            this.gb_foundemployees.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_foundemployeeid;
        private System.Windows.Forms.Button bt_foundnowgroup;
        private System.Windows.Forms.Button bt_addemployee;
        private System.Windows.Forms.TreeView tv_department;
        private System.Windows.Forms.Button btn_addrootnode;
        private System.Windows.Forms.Button btn_addchildnode;
        private System.Windows.Forms.Button btn_removenodes;
        private System.Windows.Forms.TextBox tb_nodename;
        private System.Windows.Forms.Label la_nodename;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 公司;
        private System.Windows.Forms.DataGridViewTextBoxColumn 部门;
        private System.Windows.Forms.DataGridViewTextBoxColumn 小组;
        private System.Windows.Forms.DataGridViewButtonColumn del;
        private System.Windows.Forms.DataGridViewButtonColumn update_;
        public System.Windows.Forms.DataGridView dgv_employeeinformation;
        private System.Windows.Forms.TextBox tb_foundname;
        private System.Windows.Forms.ComboBox cb_foundsex;
        private System.Windows.Forms.Label la_foundemployeeid;
        private System.Windows.Forms.Label la_foundname;
        private System.Windows.Forms.Label la_foundsex;
        private System.Windows.Forms.GroupBox gb_foundemployees;
        private System.Windows.Forms.Button bt_foundall;
    }
}