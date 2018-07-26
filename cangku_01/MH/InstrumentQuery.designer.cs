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
            this.namequery = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.timequery = new System.Windows.Forms.Label();
            this.btnquery = new System.Windows.Forms.Button();
            this.dtpstartdate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpenddate = new System.Windows.Forms.DateTimePicker();
            this.modelquery = new System.Windows.Forms.Label();
            this.tbmodel = new System.Windows.Forms.TextBox();
            this.dgvInstrumentOutQuery = new System.Windows.Forms.DataGridView();
            this.仪器标签ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.仪器名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.存放位置 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.操作个数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.操作时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.剩余个数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.仪器型号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.生产厂商 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.生产日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.经办人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.负责人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.操作 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnqueryout = new System.Windows.Forms.Button();
            this.btnqueryin = new System.Windows.Forms.Button();
            this.btnqueryoutandin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrumentOutQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // namequery
            // 
            this.namequery.AutoSize = true;
            this.namequery.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.namequery.Location = new System.Drawing.Point(121, 44);
            this.namequery.Name = "namequery";
            this.namequery.Size = new System.Drawing.Size(77, 14);
            this.namequery.TabIndex = 1;
            this.namequery.Text = "人员查询：";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(204, 41);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(124, 21);
            this.tbname.TabIndex = 2;
            // 
            // timequery
            // 
            this.timequery.AutoSize = true;
            this.timequery.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timequery.Location = new System.Drawing.Point(674, 48);
            this.timequery.Name = "timequery";
            this.timequery.Size = new System.Drawing.Size(77, 14);
            this.timequery.TabIndex = 4;
            this.timequery.Text = "时间查询：";
            // 
            // btnquery
            // 
            this.btnquery.Location = new System.Drawing.Point(1071, 43);
            this.btnquery.Name = "btnquery";
            this.btnquery.Size = new System.Drawing.Size(75, 23);
            this.btnquery.TabIndex = 6;
            this.btnquery.Text = "查询";
            this.btnquery.UseVisualStyleBackColor = true;
            this.btnquery.Click += new System.EventHandler(this.btnquery_Click);
            // 
            // dtpstartdate
            // 
            this.dtpstartdate.Location = new System.Drawing.Point(757, 44);
            this.dtpstartdate.Name = "dtpstartdate";
            this.dtpstartdate.Size = new System.Drawing.Size(103, 21);
            this.dtpstartdate.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(866, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "至";
            // 
            // dtpenddate
            // 
            this.dtpenddate.Location = new System.Drawing.Point(893, 44);
            this.dtpenddate.Name = "dtpenddate";
            this.dtpenddate.Size = new System.Drawing.Size(103, 21);
            this.dtpenddate.TabIndex = 9;
            // 
            // modelquery
            // 
            this.modelquery.AutoSize = true;
            this.modelquery.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.modelquery.Location = new System.Drawing.Point(399, 44);
            this.modelquery.Name = "modelquery";
            this.modelquery.Size = new System.Drawing.Size(77, 14);
            this.modelquery.TabIndex = 11;
            this.modelquery.Text = "型号查询：";
            // 
            // tbmodel
            // 
            this.tbmodel.Location = new System.Drawing.Point(482, 43);
            this.tbmodel.Name = "tbmodel";
            this.tbmodel.Size = new System.Drawing.Size(124, 21);
            this.tbmodel.TabIndex = 12;
            // 
            // dgvInstrumentOutQuery
            // 
            this.dgvInstrumentOutQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstrumentOutQuery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.仪器标签ID,
            this.仪器名,
            this.存放位置,
            this.操作个数,
            this.操作时间,
            this.剩余个数,
            this.仪器型号,
            this.生产厂商,
            this.生产日期,
            this.经办人,
            this.负责人,
            this.操作});
            this.dgvInstrumentOutQuery.Location = new System.Drawing.Point(12, 85);
            this.dgvInstrumentOutQuery.Name = "dgvInstrumentOutQuery";
            this.dgvInstrumentOutQuery.RowTemplate.Height = 23;
            this.dgvInstrumentOutQuery.Size = new System.Drawing.Size(1400, 764);
            this.dgvInstrumentOutQuery.TabIndex = 0;
            // 
            // 仪器标签ID
            // 
            this.仪器标签ID.HeaderText = "仪器标签ID";
            this.仪器标签ID.Name = "仪器标签ID";
            this.仪器标签ID.ReadOnly = true;
            this.仪器标签ID.Width = 115;
            // 
            // 仪器名
            // 
            this.仪器名.HeaderText = "仪器名";
            this.仪器名.Name = "仪器名";
            this.仪器名.ReadOnly = true;
            this.仪器名.Width = 115;
            // 
            // 存放位置
            // 
            this.存放位置.HeaderText = "存放位置";
            this.存放位置.Name = "存放位置";
            this.存放位置.ReadOnly = true;
            this.存放位置.Width = 115;
            // 
            // 操作个数
            // 
            this.操作个数.HeaderText = "操作个数";
            this.操作个数.Name = "操作个数";
            this.操作个数.ReadOnly = true;
            this.操作个数.Width = 115;
            // 
            // 操作时间
            // 
            this.操作时间.HeaderText = "操作时间";
            this.操作时间.Name = "操作时间";
            this.操作时间.ReadOnly = true;
            this.操作时间.Width = 115;
            // 
            // 剩余个数
            // 
            this.剩余个数.HeaderText = "剩余个数";
            this.剩余个数.Name = "剩余个数";
            this.剩余个数.ReadOnly = true;
            this.剩余个数.Width = 115;
            // 
            // 仪器型号
            // 
            this.仪器型号.HeaderText = "仪器型号";
            this.仪器型号.Name = "仪器型号";
            this.仪器型号.ReadOnly = true;
            this.仪器型号.Width = 115;
            // 
            // 生产厂商
            // 
            this.生产厂商.HeaderText = "生产厂商";
            this.生产厂商.Name = "生产厂商";
            this.生产厂商.ReadOnly = true;
            this.生产厂商.Width = 115;
            // 
            // 生产日期
            // 
            this.生产日期.HeaderText = "生产日期";
            this.生产日期.Name = "生产日期";
            this.生产日期.ReadOnly = true;
            this.生产日期.Width = 115;
            // 
            // 经办人
            // 
            this.经办人.HeaderText = "经办人";
            this.经办人.Name = "经办人";
            this.经办人.ReadOnly = true;
            this.经办人.Width = 115;
            // 
            // 负责人
            // 
            this.负责人.HeaderText = "负责人";
            this.负责人.Name = "负责人";
            this.负责人.Width = 115;
            // 
            // 操作
            // 
            this.操作.HeaderText = "操作";
            this.操作.Name = "操作";
            this.操作.ReadOnly = true;
            // 
            // btnqueryout
            // 
            this.btnqueryout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnqueryout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnqueryout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnqueryout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnqueryout.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnqueryout.Location = new System.Drawing.Point(12, 0);
            this.btnqueryout.Name = "btnqueryout";
            this.btnqueryout.Size = new System.Drawing.Size(75, 23);
            this.btnqueryout.TabIndex = 13;
            this.btnqueryout.Text = "出库";
            this.btnqueryout.UseVisualStyleBackColor = false;
            // 
            // btnqueryin
            // 
            this.btnqueryin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnqueryin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnqueryin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnqueryin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnqueryin.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnqueryin.Location = new System.Drawing.Point(125, 0);
            this.btnqueryin.Name = "btnqueryin";
            this.btnqueryin.Size = new System.Drawing.Size(75, 23);
            this.btnqueryin.TabIndex = 14;
            this.btnqueryin.Text = "入库";
            this.btnqueryin.UseVisualStyleBackColor = false;
            // 
            // btnqueryoutandin
            // 
            this.btnqueryoutandin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnqueryoutandin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnqueryoutandin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnqueryoutandin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnqueryoutandin.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnqueryoutandin.Location = new System.Drawing.Point(238, 0);
            this.btnqueryoutandin.Name = "btnqueryoutandin";
            this.btnqueryoutandin.Size = new System.Drawing.Size(75, 23);
            this.btnqueryoutandin.TabIndex = 15;
            this.btnqueryoutandin.Text = "出入库";
            this.btnqueryoutandin.UseVisualStyleBackColor = false;
            // 
            // InstrumentQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.btnqueryoutandin);
            this.Controls.Add(this.btnqueryin);
            this.Controls.Add(this.btnqueryout);
            this.Controls.Add(this.dgvInstrumentOutQuery);
            this.Controls.Add(this.tbmodel);
            this.Controls.Add(this.modelquery);
            this.Controls.Add(this.dtpenddate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpstartdate);
            this.Controls.Add(this.btnquery);
            this.Controls.Add(this.timequery);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.namequery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InstrumentQuery";
            this.Text = "InstrumentQuery";
            this.Load += new System.EventHandler(this.InstrumentQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrumentOutQuery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label namequery;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label timequery;
        private System.Windows.Forms.Button btnquery;
        private System.Windows.Forms.DateTimePicker dtpstartdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpenddate;
        private System.Windows.Forms.Label modelquery;
        private System.Windows.Forms.TextBox tbmodel;
        private System.Windows.Forms.DataGridView dgvInstrumentOutQuery;
        private System.Windows.Forms.Button btnqueryout;
        private System.Windows.Forms.Button btnqueryin;
        private System.Windows.Forms.Button btnqueryoutandin;
        private System.Windows.Forms.DataGridViewTextBoxColumn 仪器标签ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 仪器名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 存放位置;
        private System.Windows.Forms.DataGridViewTextBoxColumn 操作个数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 操作时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 剩余个数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 仪器型号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生产厂商;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生产日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 经办人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 负责人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 操作;
    }
}