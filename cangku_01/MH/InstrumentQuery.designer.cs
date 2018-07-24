namespace cangku_01.MH
{
    partial class InstrumentQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstrumentQuery));
            this.dgvInstrumentOutQuery = new System.Windows.Forms.DataGridView();
            this.仪器ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.仪器名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.存放位置 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出库个数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出库时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.剩余个数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.仪器型号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.生产厂商 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.生产日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.经办人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnquery = new System.Windows.Forms.Button();
            this.dtpstartdate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpenddate = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnstate = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmOutQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.tbmodle = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrumentOutQuery)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInstrumentOutQuery
            // 
            this.dgvInstrumentOutQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstrumentOutQuery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.仪器ID,
            this.仪器名,
            this.存放位置,
            this.出库个数,
            this.出库时间,
            this.剩余个数,
            this.仪器型号,
            this.生产厂商,
            this.生产日期,
            this.经办人});
            this.dgvInstrumentOutQuery.Location = new System.Drawing.Point(0, 0);
            this.dgvInstrumentOutQuery.Name = "dgvInstrumentOutQuery";
            this.dgvInstrumentOutQuery.RowTemplate.Height = 23;
            this.dgvInstrumentOutQuery.Size = new System.Drawing.Size(1400, 764);
            this.dgvInstrumentOutQuery.TabIndex = 0;
            // 
            // 仪器ID
            // 
            this.仪器ID.HeaderText = "仪器ID";
            this.仪器ID.Name = "仪器ID";
            this.仪器ID.ReadOnly = true;
            this.仪器ID.Width = 123;
            // 
            // 仪器名
            // 
            this.仪器名.HeaderText = "仪器名";
            this.仪器名.Name = "仪器名";
            this.仪器名.ReadOnly = true;
            this.仪器名.Width = 123;
            // 
            // 存放位置
            // 
            this.存放位置.HeaderText = "存放位置";
            this.存放位置.Name = "存放位置";
            this.存放位置.ReadOnly = true;
            this.存放位置.Width = 123;
            // 
            // 出库个数
            // 
            this.出库个数.HeaderText = "出库个数";
            this.出库个数.Name = "出库个数";
            this.出库个数.ReadOnly = true;
            this.出库个数.Width = 123;
            // 
            // 出库时间
            // 
            this.出库时间.HeaderText = "出库时间";
            this.出库时间.Name = "出库时间";
            this.出库时间.ReadOnly = true;
            this.出库时间.Width = 123;
            // 
            // 剩余个数
            // 
            this.剩余个数.HeaderText = "剩余个数";
            this.剩余个数.Name = "剩余个数";
            this.剩余个数.ReadOnly = true;
            this.剩余个数.Width = 123;
            // 
            // 仪器型号
            // 
            this.仪器型号.HeaderText = "仪器型号";
            this.仪器型号.Name = "仪器型号";
            this.仪器型号.ReadOnly = true;
            this.仪器型号.Width = 123;
            // 
            // 生产厂商
            // 
            this.生产厂商.HeaderText = "生产厂商";
            this.生产厂商.Name = "生产厂商";
            this.生产厂商.ReadOnly = true;
            this.生产厂商.Width = 123;
            // 
            // 生产日期
            // 
            this.生产日期.HeaderText = "生产日期";
            this.生产日期.Name = "生产日期";
            this.生产日期.ReadOnly = true;
            this.生产日期.Width = 123;
            // 
            // 经办人
            // 
            this.经办人.HeaderText = "经办人";
            this.经办人.Name = "经办人";
            this.经办人.ReadOnly = true;
            this.经办人.Width = 123;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "人员查询：";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(163, 38);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(124, 21);
            this.tbname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(654, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "时间查询：";
            // 
            // btnquery
            // 
            this.btnquery.Location = new System.Drawing.Point(994, 36);
            this.btnquery.Name = "btnquery";
            this.btnquery.Size = new System.Drawing.Size(75, 23);
            this.btnquery.TabIndex = 6;
            this.btnquery.Text = "查询";
            this.btnquery.UseVisualStyleBackColor = true;
            this.btnquery.Click += new System.EventHandler(this.bt_time_search_Click);
            // 
            // dtpstartdate
            // 
            this.dtpstartdate.Location = new System.Drawing.Point(725, 38);
            this.dtpstartdate.Name = "dtpstartdate";
            this.dtpstartdate.Size = new System.Drawing.Size(103, 21);
            this.dtpstartdate.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(834, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "到";
            // 
            // dtpenddate
            // 
            this.dtpenddate.Location = new System.Drawing.Point(857, 38);
            this.dtpenddate.Name = "dtpenddate";
            this.dtpenddate.Size = new System.Drawing.Size(103, 21);
            this.dtpenddate.TabIndex = 9;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnstate});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1424, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnstate
            // 
            this.btnstate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnstate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOutQuery,
            this.tsmInQuery});
            this.btnstate.Image = ((System.Drawing.Image)(resources.GetObject("btnstate.Image")));
            this.btnstate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnstate.Name = "btnstate";
            this.btnstate.Size = new System.Drawing.Size(32, 22);
            this.btnstate.Text = "出入库查询";
            // 
            // tsmOutQuery
            // 
            this.tsmOutQuery.Name = "tsmOutQuery";
            this.tsmOutQuery.Size = new System.Drawing.Size(124, 22);
            this.tsmOutQuery.Text = "出库查询";
            this.tsmOutQuery.Click += new System.EventHandler(this.tsmOutQuery_Click);
            // 
            // tsmInQuery
            // 
            this.tsmInQuery.Name = "tsmInQuery";
            this.tsmInQuery.Size = new System.Drawing.Size(124, 22);
            this.tsmInQuery.Text = "入库查询";
            this.tsmInQuery.Click += new System.EventHandler(this.tsmInQuery_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "型号查询：";
            // 
            // tbmodle
            // 
            this.tbmodle.Location = new System.Drawing.Point(443, 38);
            this.tbmodle.Name = "tbmodle";
            this.tbmodle.Size = new System.Drawing.Size(124, 21);
            this.tbmodle.TabIndex = 12;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dgvInstrumentOutQuery);
            this.panel.Location = new System.Drawing.Point(12, 85);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1400, 764);
            this.panel.TabIndex = 13;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // InstrumentQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.tbmodle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dtpenddate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpstartdate);
            this.Controls.Add(this.btnquery);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InstrumentQuery";
            this.Text = "InstrumentQuery";
            this.Load += new System.EventHandler(this.Takeout_Warehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrumentOutQuery)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInstrumentOutQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnquery;
        private System.Windows.Forms.DateTimePicker dtpstartdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpenddate;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton btnstate;
        private System.Windows.Forms.ToolStripMenuItem tsmOutQuery;
        private System.Windows.Forms.ToolStripMenuItem tsmInQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn 仪器ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 仪器名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 存放位置;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出库个数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出库时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 剩余个数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 仪器型号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生产厂商;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生产日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 经办人;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbmodle;
        private System.Windows.Forms.Panel panel;
    }
}