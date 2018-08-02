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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index_employees));
            this.La_founduser = new System.Windows.Forms.Label();
            this.tb_found = new System.Windows.Forms.TextBox();
            this.bt_found = new System.Windows.Forms.Button();
            this.bt_addUser = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.所属部门 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.update_ = new System.Windows.Forms.DataGridViewButtonColumn();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Btn_addrootnode = new System.Windows.Forms.Button();
            this.Btn_addchildnode = new System.Windows.Forms.Button();
            this.Btn_removenodes = new System.Windows.Forms.Button();
            this.Tb_nodename = new System.Windows.Forms.TextBox();
            this.La_nodename = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // La_founduser
            // 
            resources.ApplyResources(this.La_founduser, "La_founduser");
            this.La_founduser.Name = "La_founduser";
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
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.姓名,
            this.性别,
            this.所属部门,
            this.del,
            this.update_});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // 所属部门
            // 
            resources.ApplyResources(this.所属部门, "所属部门");
            this.所属部门.Name = "所属部门";
            this.所属部门.ReadOnly = true;
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
            // treeView1
            // 
            resources.ApplyResources(this.treeView1, "treeView1");
            this.treeView1.Name = "treeView1";
            // 
            // Btn_addrootnode
            // 
            resources.ApplyResources(this.Btn_addrootnode, "Btn_addrootnode");
            this.Btn_addrootnode.Name = "Btn_addrootnode";
            this.Btn_addrootnode.UseVisualStyleBackColor = true;
            this.Btn_addrootnode.Click += new System.EventHandler(this.Btn_addrootnode_Click);
            // 
            // Btn_addchildnode
            // 
            resources.ApplyResources(this.Btn_addchildnode, "Btn_addchildnode");
            this.Btn_addchildnode.Name = "Btn_addchildnode";
            this.Btn_addchildnode.UseVisualStyleBackColor = true;
            // 
            // Btn_removenodes
            // 
            resources.ApplyResources(this.Btn_removenodes, "Btn_removenodes");
            this.Btn_removenodes.Name = "Btn_removenodes";
            this.Btn_removenodes.UseVisualStyleBackColor = true;
            // 
            // Tb_nodename
            // 
            resources.ApplyResources(this.Tb_nodename, "Tb_nodename");
            this.Tb_nodename.Name = "Tb_nodename";
            // 
            // La_nodename
            // 
            resources.ApplyResources(this.La_nodename, "La_nodename");
            this.La_nodename.Name = "La_nodename";
            // 
            // index_employees
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.La_nodename);
            this.Controls.Add(this.Tb_nodename);
            this.Controls.Add(this.Btn_removenodes);
            this.Controls.Add(this.Btn_addchildnode);
            this.Controls.Add(this.Btn_addrootnode);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.bt_addUser);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_found);
            this.Controls.Add(this.tb_found);
            this.Controls.Add(this.La_founduser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "index_employees";
            this.Load += new System.EventHandler(this.index_employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label La_founduser;
        private System.Windows.Forms.TextBox tb_found;
        private System.Windows.Forms.Button bt_found;
        private System.Windows.Forms.Button bt_addUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 所属部门;
        private System.Windows.Forms.DataGridViewButtonColumn del;
        private System.Windows.Forms.DataGridViewButtonColumn update_;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button Btn_addrootnode;
        private System.Windows.Forms.Button Btn_addchildnode;
        private System.Windows.Forms.Button Btn_removenodes;
        private System.Windows.Forms.TextBox Tb_nodename;
        private System.Windows.Forms.Label La_nodename;
    }
}