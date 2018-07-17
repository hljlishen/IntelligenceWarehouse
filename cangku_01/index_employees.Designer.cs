namespace cangku_01
{
    partial class index_employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index_employees));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_found = new System.Windows.Forms.TextBox();
            this.bt_found = new System.Windows.Forms.Button();
            this.bt_addUser = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_sex = new System.Windows.Forms.TextBox();
            this.tb_tel = new System.Windows.Forms.TextBox();
            this.tb_temp = new System.Windows.Forms.TextBox();
            this.tb_job = new System.Windows.Forms.TextBox();
            this.tb_salary = new System.Windows.Forms.TextBox();
            this.tb_jobtime = new System.Windows.Forms.DateTimePicker();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.联系电话 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.所属部门 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.职位 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.薪资 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入职时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.update_ = new System.Windows.Forms.DataGridViewButtonColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userInterfaceImpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userInterfaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInterfaceImpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInterfaceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tb_found
            // 
            resources.ApplyResources(this.tb_found, "tb_found");
            this.tb_found.Name = "tb_found";
            this.tb_found.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.tb_found.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // bt_found
            // 
            resources.ApplyResources(this.bt_found, "bt_found");
            this.bt_found.Name = "bt_found";
            this.bt_found.UseVisualStyleBackColor = true;
            this.bt_found.Click += new System.EventHandler(this.bt_found_Click);
            // 
            // bt_addUser
            // 
            resources.ApplyResources(this.bt_addUser, "bt_addUser");
            this.bt_addUser.Name = "bt_addUser";
            this.bt_addUser.UseVisualStyleBackColor = true;
            this.bt_addUser.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.姓名,
            this.性别,
            this.联系电话,
            this.所属部门,
            this.职位,
            this.薪资,
            this.入职时间,
            this.del,
            this.update_});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tb_id
            // 
            resources.ApplyResources(this.tb_id, "tb_id");
            this.tb_id.Name = "tb_id";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // tb_name
            // 
            resources.ApplyResources(this.tb_name, "tb_name");
            this.tb_name.Name = "tb_name";
            // 
            // tb_sex
            // 
            resources.ApplyResources(this.tb_sex, "tb_sex");
            this.tb_sex.Name = "tb_sex";
            // 
            // tb_tel
            // 
            resources.ApplyResources(this.tb_tel, "tb_tel");
            this.tb_tel.Name = "tb_tel";
            // 
            // tb_temp
            // 
            resources.ApplyResources(this.tb_temp, "tb_temp");
            this.tb_temp.Name = "tb_temp";
            // 
            // tb_job
            // 
            resources.ApplyResources(this.tb_job, "tb_job");
            this.tb_job.Name = "tb_job";
            // 
            // tb_salary
            // 
            resources.ApplyResources(this.tb_salary, "tb_salary");
            this.tb_salary.Name = "tb_salary";
            // 
            // tb_jobtime
            // 
            resources.ApplyResources(this.tb_jobtime, "tb_jobtime");
            this.tb_jobtime.Name = "tb_jobtime";
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
            // 联系电话
            // 
            resources.ApplyResources(this.联系电话, "联系电话");
            this.联系电话.Name = "联系电话";
            this.联系电话.ReadOnly = true;
            // 
            // 所属部门
            // 
            resources.ApplyResources(this.所属部门, "所属部门");
            this.所属部门.Name = "所属部门";
            this.所属部门.ReadOnly = true;
            // 
            // 职位
            // 
            resources.ApplyResources(this.职位, "职位");
            this.职位.Name = "职位";
            this.职位.ReadOnly = true;
            // 
            // 薪资
            // 
            resources.ApplyResources(this.薪资, "薪资");
            this.薪资.Name = "薪资";
            this.薪资.ReadOnly = true;
            // 
            // 入职时间
            // 
            resources.ApplyResources(this.入职时间, "入职时间");
            this.入职时间.Name = "入职时间";
            this.入职时间.ReadOnly = true;
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
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(cangku_01.entity.User);
            // 
            // userInterfaceImpBindingSource
            // 
            this.userInterfaceImpBindingSource.DataSource = typeof(cangku_01.interfaceImp.UserInterfaceImp);
            // 
            // userInterfaceBindingSource
            // 
            this.userInterfaceBindingSource.DataSource = typeof(cangku_01.interfaces.UserInterface);
            // 
            // index_employees
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tb_jobtime);
            this.Controls.Add(this.tb_salary);
            this.Controls.Add(this.tb_job);
            this.Controls.Add(this.tb_temp);
            this.Controls.Add(this.tb_tel);
            this.Controls.Add(this.tb_sex);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.bt_addUser);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_found);
            this.Controls.Add(this.tb_found);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "index_employees";
            this.Load += new System.EventHandler(this.index_employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInterfaceImpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInterfaceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_found;
        private System.Windows.Forms.Button bt_found;
        private System.Windows.Forms.Button bt_addUser;
        private System.Windows.Forms.BindingSource userInterfaceBindingSource;
        private System.Windows.Forms.BindingSource userInterfaceImpBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_sex;
        private System.Windows.Forms.TextBox tb_tel;
        private System.Windows.Forms.TextBox tb_temp;
        private System.Windows.Forms.TextBox tb_job;
        private System.Windows.Forms.TextBox tb_salary;
        private System.Windows.Forms.DateTimePicker tb_jobtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 联系电话;
        private System.Windows.Forms.DataGridViewTextBoxColumn 所属部门;
        private System.Windows.Forms.DataGridViewTextBoxColumn 职位;
        private System.Windows.Forms.DataGridViewTextBoxColumn 薪资;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入职时间;
        private System.Windows.Forms.DataGridViewButtonColumn del;
        private System.Windows.Forms.DataGridViewButtonColumn update_;
    }
}