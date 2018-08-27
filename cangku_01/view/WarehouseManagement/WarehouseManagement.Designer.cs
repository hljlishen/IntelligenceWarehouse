namespace cangku_01.view.WarehouseManagement
{
    partial class WarehouseManagement
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
            this.tv_warehouse = new System.Windows.Forms.TreeView();
            this.la_warehouseinformation = new System.Windows.Forms.Label();
            this.cms_warehousetreeview = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_newwarehouse = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_newshelves = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_newrowandcolumn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_rename = new System.Windows.Forms.ToolStripMenuItem();
            this.la_id = new System.Windows.Forms.Label();
            this.la_name = new System.Windows.Forms.Label();
            this.la_location = new System.Windows.Forms.Label();
            this.la_companyanddepartment = new System.Windows.Forms.Label();
            this.la_warehouseintroduced = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_companyanddepartment = new System.Windows.Forms.TextBox();
            this.lb_warehouseintroduced = new System.Windows.Forms.ListBox();
            this.pb_location = new System.Windows.Forms.PictureBox();
            this.cms_warehousetreeview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_location)).BeginInit();
            this.SuspendLayout();
            // 
            // tv_warehouse
            // 
            this.tv_warehouse.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tv_warehouse.LabelEdit = true;
            this.tv_warehouse.Location = new System.Drawing.Point(61, 54);
            this.tv_warehouse.Name = "tv_warehouse";
            this.tv_warehouse.Size = new System.Drawing.Size(698, 694);
            this.tv_warehouse.TabIndex = 0;
            this.tv_warehouse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
            // 
            // la_warehouseinformation
            // 
            this.la_warehouseinformation.AutoSize = true;
            this.la_warehouseinformation.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_warehouseinformation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.la_warehouseinformation.Location = new System.Drawing.Point(1010, 54);
            this.la_warehouseinformation.Name = "la_warehouseinformation";
            this.la_warehouseinformation.Size = new System.Drawing.Size(126, 25);
            this.la_warehouseinformation.TabIndex = 16;
            this.la_warehouseinformation.Text = "仓库信息概述";
            // 
            // cms_warehousetreeview
            // 
            this.cms_warehousetreeview.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cms_warehousetreeview.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_newwarehouse,
            this.tsm_newshelves,
            this.tsm_newrowandcolumn,
            this.tsm_delete,
            this.tsm_rename});
            this.cms_warehousetreeview.Name = "contextMenuStrip1";
            this.cms_warehousetreeview.Size = new System.Drawing.Size(149, 124);
            // 
            // tsm_newwarehouse
            // 
            this.tsm_newwarehouse.Name = "tsm_newwarehouse";
            this.tsm_newwarehouse.Size = new System.Drawing.Size(148, 24);
            this.tsm_newwarehouse.Text = "创建仓库";
            this.tsm_newwarehouse.Click += new System.EventHandler(this.tsm_newwarehouse_Click);
            // 
            // tsm_newshelves
            // 
            this.tsm_newshelves.Name = "tsm_newshelves";
            this.tsm_newshelves.Size = new System.Drawing.Size(148, 24);
            this.tsm_newshelves.Text = "创建货架";
            this.tsm_newshelves.Click += new System.EventHandler(this.tsm_newshelves_Click);
            // 
            // tsm_newrowandcolumn
            // 
            this.tsm_newrowandcolumn.Name = "tsm_newrowandcolumn";
            this.tsm_newrowandcolumn.Size = new System.Drawing.Size(148, 24);
            this.tsm_newrowandcolumn.Text = "创建排列号";
            this.tsm_newrowandcolumn.Click += new System.EventHandler(this.tsm_newrowandcolumn_Click);
            // 
            // tsm_delete
            // 
            this.tsm_delete.Name = "tsm_delete";
            this.tsm_delete.Size = new System.Drawing.Size(148, 24);
            this.tsm_delete.Text = "删除";
            this.tsm_delete.Click += new System.EventHandler(this.tsm_delete_Click);
            // 
            // tsm_rename
            // 
            this.tsm_rename.Name = "tsm_rename";
            this.tsm_rename.Size = new System.Drawing.Size(148, 24);
            this.tsm_rename.Text = "重命名";
            this.tsm_rename.Click += new System.EventHandler(this.tsm_rename_Click);
            // 
            // la_id
            // 
            this.la_id.AutoSize = true;
            this.la_id.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_id.Location = new System.Drawing.Point(897, 143);
            this.la_id.Name = "la_id";
            this.la_id.Size = new System.Drawing.Size(72, 21);
            this.la_id.TabIndex = 17;
            this.la_id.Text = "仓库id：";
            // 
            // la_name
            // 
            this.la_name.AutoSize = true;
            this.la_name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_name.Location = new System.Drawing.Point(882, 228);
            this.la_name.Name = "la_name";
            this.la_name.Size = new System.Drawing.Size(90, 21);
            this.la_name.TabIndex = 18;
            this.la_name.Text = "仓库名称：";
            // 
            // la_location
            // 
            this.la_location.AutoSize = true;
            this.la_location.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_location.Location = new System.Drawing.Point(882, 313);
            this.la_location.Name = "la_location";
            this.la_location.Size = new System.Drawing.Size(90, 21);
            this.la_location.TabIndex = 19;
            this.la_location.Text = "仓库位置：";
            // 
            // la_companyanddepartment
            // 
            this.la_companyanddepartment.AutoSize = true;
            this.la_companyanddepartment.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_companyanddepartment.Location = new System.Drawing.Point(840, 507);
            this.la_companyanddepartment.Name = "la_companyanddepartment";
            this.la_companyanddepartment.Size = new System.Drawing.Size(138, 21);
            this.la_companyanddepartment.TabIndex = 20;
            this.la_companyanddepartment.Text = "所属单位及部门：";
            // 
            // la_warehouseintroduced
            // 
            this.la_warehouseintroduced.AutoSize = true;
            this.la_warehouseintroduced.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_warehouseintroduced.Location = new System.Drawing.Point(882, 589);
            this.la_warehouseintroduced.Name = "la_warehouseintroduced";
            this.la_warehouseintroduced.Size = new System.Drawing.Size(90, 21);
            this.la_warehouseintroduced.TabIndex = 22;
            this.la_warehouseintroduced.Text = "仓库介绍：";
            // 
            // tb_id
            // 
            this.tb_id.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_id.Location = new System.Drawing.Point(1026, 140);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(200, 29);
            this.tb_id.TabIndex = 23;
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_name.Location = new System.Drawing.Point(1026, 225);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(200, 29);
            this.tb_name.TabIndex = 24;
            // 
            // tb_companyanddepartment
            // 
            this.tb_companyanddepartment.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_companyanddepartment.Location = new System.Drawing.Point(1026, 504);
            this.tb_companyanddepartment.Name = "tb_companyanddepartment";
            this.tb_companyanddepartment.Size = new System.Drawing.Size(200, 29);
            this.tb_companyanddepartment.TabIndex = 26;
            // 
            // lb_warehouseintroduced
            // 
            this.lb_warehouseintroduced.FormattingEnabled = true;
            this.lb_warehouseintroduced.ItemHeight = 12;
            this.lb_warehouseintroduced.Location = new System.Drawing.Point(1026, 589);
            this.lb_warehouseintroduced.Name = "lb_warehouseintroduced";
            this.lb_warehouseintroduced.Size = new System.Drawing.Size(302, 148);
            this.lb_warehouseintroduced.TabIndex = 28;
            // 
            // pb_location
            // 
            this.pb_location.Location = new System.Drawing.Point(1026, 313);
            this.pb_location.Name = "pb_location";
            this.pb_location.Size = new System.Drawing.Size(302, 145);
            this.pb_location.TabIndex = 29;
            this.pb_location.TabStop = false;
            // 
            // WarehouseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 840);
            this.Controls.Add(this.pb_location);
            this.Controls.Add(this.lb_warehouseintroduced);
            this.Controls.Add(this.tb_companyanddepartment);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.la_warehouseintroduced);
            this.Controls.Add(this.la_companyanddepartment);
            this.Controls.Add(this.la_location);
            this.Controls.Add(this.la_name);
            this.Controls.Add(this.la_id);
            this.Controls.Add(this.la_warehouseinformation);
            this.Controls.Add(this.tv_warehouse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WarehouseManagement";
            this.Text = "WarehouseManagement";
            this.Load += new System.EventHandler(this.WarehouseManagement_Load);
            this.cms_warehousetreeview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_location)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tv_warehouse;
        private System.Windows.Forms.Label la_warehouseinformation;
        private System.Windows.Forms.ContextMenuStrip cms_warehousetreeview;
        private System.Windows.Forms.ToolStripMenuItem tsm_newwarehouse;
        private System.Windows.Forms.ToolStripMenuItem tsm_newshelves;
        private System.Windows.Forms.ToolStripMenuItem tsm_newrowandcolumn;
        private System.Windows.Forms.ToolStripMenuItem tsm_delete;
        private System.Windows.Forms.ToolStripMenuItem tsm_rename;
        private System.Windows.Forms.Label la_id;
        private System.Windows.Forms.Label la_name;
        private System.Windows.Forms.Label la_location;
        private System.Windows.Forms.Label la_companyanddepartment;
        private System.Windows.Forms.Label la_warehouseintroduced;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_companyanddepartment;
        private System.Windows.Forms.ListBox lb_warehouseintroduced;
        private System.Windows.Forms.PictureBox pb_location;
        public System.Windows.Forms.TextBox tb_id;
    }
}