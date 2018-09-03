namespace cangku_01.view.WarehouseManagement
{
    partial class AlterAndAddWarehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterAndAddWarehouse));
            this.la_errorsynopisi = new System.Windows.Forms.Label();
            this.tb_synopsis = new System.Windows.Forms.TextBox();
            this.la_errortempnull = new System.Windows.Forms.Label();
            this.la_errornamenull = new System.Windows.Forms.Label();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_alter = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.la_fromname = new System.Windows.Forms.Label();
            this.tv_temp = new System.Windows.Forms.TreeView();
            this.tb_companyanddepartment = new System.Windows.Forms.TextBox();
            this.la_warehouseintroduced = new System.Windows.Forms.Label();
            this.la_companyanddepartment = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.la_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // la_errorsynopisi
            // 
            this.la_errorsynopisi.AutoSize = true;
            this.la_errorsynopisi.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_errorsynopisi.ForeColor = System.Drawing.Color.Red;
            this.la_errorsynopisi.Location = new System.Drawing.Point(485, 432);
            this.la_errorsynopisi.Name = "la_errorsynopisi";
            this.la_errorsynopisi.Size = new System.Drawing.Size(109, 17);
            this.la_errorsynopisi.TabIndex = 55;
            this.la_errorsynopisi.Text = "*仓库简介不能为空";
            // 
            // tb_synopsis
            // 
            this.tb_synopsis.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_synopsis.Location = new System.Drawing.Point(488, 241);
            this.tb_synopsis.Multiline = true;
            this.tb_synopsis.Name = "tb_synopsis";
            this.tb_synopsis.Size = new System.Drawing.Size(240, 175);
            this.tb_synopsis.TabIndex = 54;
            // 
            // la_errortempnull
            // 
            this.la_errortempnull.AutoSize = true;
            this.la_errortempnull.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_errortempnull.ForeColor = System.Drawing.Color.Red;
            this.la_errortempnull.Location = new System.Drawing.Point(485, 210);
            this.la_errortempnull.Name = "la_errortempnull";
            this.la_errortempnull.Size = new System.Drawing.Size(73, 17);
            this.la_errortempnull.TabIndex = 53;
            this.la_errortempnull.Text = "*未选择部门";
            // 
            // la_errornamenull
            // 
            this.la_errornamenull.AutoSize = true;
            this.la_errornamenull.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_errornamenull.ForeColor = System.Drawing.Color.Red;
            this.la_errornamenull.Location = new System.Drawing.Point(485, 129);
            this.la_errornamenull.Name = "la_errornamenull";
            this.la_errornamenull.Size = new System.Drawing.Size(85, 17);
            this.la_errornamenull.TabIndex = 52;
            this.la_errornamenull.Text = "*名称不能为空";
            // 
            // bt_cancel
            // 
            this.bt_cancel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_cancel.Location = new System.Drawing.Point(510, 480);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 30);
            this.bt_cancel.TabIndex = 51;
            this.bt_cancel.Text = "取消";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_alter
            // 
            this.bt_alter.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_alter.Location = new System.Drawing.Point(190, 480);
            this.bt_alter.Name = "bt_alter";
            this.bt_alter.Size = new System.Drawing.Size(75, 30);
            this.bt_alter.TabIndex = 50;
            this.bt_alter.Text = "修改";
            this.bt_alter.UseVisualStyleBackColor = true;
            this.bt_alter.Click += new System.EventHandler(this.bt_alter_Click);
            // 
            // bt_add
            // 
            this.bt_add.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_add.Location = new System.Drawing.Point(190, 480);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 30);
            this.bt_add.TabIndex = 49;
            this.bt_add.Text = "添加";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // la_fromname
            // 
            this.la_fromname.AutoSize = true;
            this.la_fromname.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_fromname.Location = new System.Drawing.Point(345, 22);
            this.la_fromname.Name = "la_fromname";
            this.la_fromname.Size = new System.Drawing.Size(88, 25);
            this.la_fromname.TabIndex = 48;
            this.la_fromname.Text = "添加仓库";
            // 
            // tv_temp
            // 
            this.tv_temp.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tv_temp.Location = new System.Drawing.Point(44, 78);
            this.tv_temp.Name = "tv_temp";
            this.tv_temp.Size = new System.Drawing.Size(299, 381);
            this.tv_temp.TabIndex = 47;
            this.tv_temp.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_temp_AfterSelect);
            // 
            // tb_companyanddepartment
            // 
            this.tb_companyanddepartment.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_companyanddepartment.Location = new System.Drawing.Point(488, 168);
            this.tb_companyanddepartment.Name = "tb_companyanddepartment";
            this.tb_companyanddepartment.ReadOnly = true;
            this.tb_companyanddepartment.Size = new System.Drawing.Size(240, 26);
            this.tb_companyanddepartment.TabIndex = 46;
            // 
            // la_warehouseintroduced
            // 
            this.la_warehouseintroduced.AutoSize = true;
            this.la_warehouseintroduced.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_warehouseintroduced.Location = new System.Drawing.Point(392, 241);
            this.la_warehouseintroduced.Name = "la_warehouseintroduced";
            this.la_warehouseintroduced.Size = new System.Drawing.Size(79, 20);
            this.la_warehouseintroduced.TabIndex = 45;
            this.la_warehouseintroduced.Text = "仓库介绍：";
            // 
            // la_companyanddepartment
            // 
            this.la_companyanddepartment.AutoSize = true;
            this.la_companyanddepartment.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_companyanddepartment.Location = new System.Drawing.Point(392, 171);
            this.la_companyanddepartment.Name = "la_companyanddepartment";
            this.la_companyanddepartment.Size = new System.Drawing.Size(79, 20);
            this.la_companyanddepartment.TabIndex = 44;
            this.la_companyanddepartment.Text = "所属部门：";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_name.Location = new System.Drawing.Point(488, 90);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(240, 26);
            this.tb_name.TabIndex = 43;
            // 
            // la_name
            // 
            this.la_name.AutoSize = true;
            this.la_name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_name.Location = new System.Drawing.Point(392, 93);
            this.la_name.Name = "la_name";
            this.la_name.Size = new System.Drawing.Size(79, 20);
            this.la_name.TabIndex = 42;
            this.la_name.Text = "仓库名称：";
            // 
            // AlterAndAddWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 532);
            this.Controls.Add(this.la_errorsynopisi);
            this.Controls.Add(this.tb_synopsis);
            this.Controls.Add(this.la_errortempnull);
            this.Controls.Add(this.la_errornamenull);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_alter);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.la_fromname);
            this.Controls.Add(this.tv_temp);
            this.Controls.Add(this.tb_companyanddepartment);
            this.Controls.Add(this.la_warehouseintroduced);
            this.Controls.Add(this.la_companyanddepartment);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.la_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlterAndAddWarehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "仓库位置编辑";
            this.Load += new System.EventHandler(this.AlterAndAddWarehouse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label la_errorsynopisi;
        private System.Windows.Forms.TextBox tb_synopsis;
        private System.Windows.Forms.Label la_errortempnull;
        private System.Windows.Forms.Label la_errornamenull;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_alter;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Label la_fromname;
        private System.Windows.Forms.TreeView tv_temp;
        private System.Windows.Forms.TextBox tb_companyanddepartment;
        private System.Windows.Forms.Label la_warehouseintroduced;
        private System.Windows.Forms.Label la_companyanddepartment;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label la_name;
    }
}