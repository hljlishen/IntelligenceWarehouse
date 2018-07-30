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
            this.La_namequery = new System.Windows.Forms.Label();
            this.Tb_name = new System.Windows.Forms.TextBox();
            this.La_timequery = new System.Windows.Forms.Label();
            this.Btn_query = new System.Windows.Forms.Button();
            this.Dtpstartdate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Dtpenddate = new System.Windows.Forms.DateTimePicker();
            this.La_modelquery = new System.Windows.Forms.Label();
            this.Tb_model = new System.Windows.Forms.TextBox();
            this.Dgv_InstrumentQuery = new System.Windows.Forms.DataGridView();
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
            this.Btn_queryout = new System.Windows.Forms.Button();
            this.Btn_queryin = new System.Windows.Forms.Button();
            this.Btn_queryoutandin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_InstrumentQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // La_namequery
            // 
            this.La_namequery.AutoSize = true;
            this.La_namequery.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.La_namequery.Location = new System.Drawing.Point(121, 44);
            this.La_namequery.Name = "La_namequery";
            this.La_namequery.Size = new System.Drawing.Size(77, 14);
            this.La_namequery.TabIndex = 1;
            this.La_namequery.Text = "人员查询：";
            // 
            // Tb_name
            // 
            this.Tb_name.Location = new System.Drawing.Point(204, 41);
            this.Tb_name.Name = "Tb_name";
            this.Tb_name.Size = new System.Drawing.Size(124, 21);
            this.Tb_name.TabIndex = 2;
            // 
            // La_timequery
            // 
            this.La_timequery.AutoSize = true;
            this.La_timequery.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.La_timequery.Location = new System.Drawing.Point(674, 48);
            this.La_timequery.Name = "La_timequery";
            this.La_timequery.Size = new System.Drawing.Size(77, 14);
            this.La_timequery.TabIndex = 4;
            this.La_timequery.Text = "时间查询：";
            // 
            // Btn_query
            // 
            this.Btn_query.Location = new System.Drawing.Point(1071, 43);
            this.Btn_query.Name = "Btn_query";
            this.Btn_query.Size = new System.Drawing.Size(75, 23);
            this.Btn_query.TabIndex = 6;
            this.Btn_query.Text = "查询";
            this.Btn_query.UseVisualStyleBackColor = true;
            this.Btn_query.Click += new System.EventHandler(this.btnquery_Click);
            // 
            // Dtpstartdate
            // 
            this.Dtpstartdate.Location = new System.Drawing.Point(757, 44);
            this.Dtpstartdate.Name = "Dtpstartdate";
            this.Dtpstartdate.Size = new System.Drawing.Size(103, 21);
            this.Dtpstartdate.TabIndex = 7;
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
            // Dtpenddate
            // 
            this.Dtpenddate.Location = new System.Drawing.Point(893, 44);
            this.Dtpenddate.Name = "Dtpenddate";
            this.Dtpenddate.Size = new System.Drawing.Size(103, 21);
            this.Dtpenddate.TabIndex = 9;
            // 
            // La_modelquery
            // 
            this.La_modelquery.AutoSize = true;
            this.La_modelquery.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.La_modelquery.Location = new System.Drawing.Point(399, 44);
            this.La_modelquery.Name = "La_modelquery";
            this.La_modelquery.Size = new System.Drawing.Size(77, 14);
            this.La_modelquery.TabIndex = 11;
            this.La_modelquery.Text = "型号查询：";
            // 
            // Tb_model
            // 
            this.Tb_model.Location = new System.Drawing.Point(482, 43);
            this.Tb_model.Name = "Tb_model";
            this.Tb_model.Size = new System.Drawing.Size(124, 21);
            this.Tb_model.TabIndex = 12;
            // 
            // Dgv_InstrumentQuery
            // 
            this.Dgv_InstrumentQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_InstrumentQuery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.Dgv_InstrumentQuery.Location = new System.Drawing.Point(12, 85);
            this.Dgv_InstrumentQuery.Name = "Dgv_InstrumentQuery";
            this.Dgv_InstrumentQuery.RowTemplate.Height = 23;
            this.Dgv_InstrumentQuery.Size = new System.Drawing.Size(1400, 764);
            this.Dgv_InstrumentQuery.TabIndex = 0;
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
            // Btn_queryout
            // 
            this.Btn_queryout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_queryout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_queryout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_queryout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_queryout.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_queryout.Location = new System.Drawing.Point(12, 0);
            this.Btn_queryout.Name = "Btn_queryout";
            this.Btn_queryout.Size = new System.Drawing.Size(75, 23);
            this.Btn_queryout.TabIndex = 13;
            this.Btn_queryout.Text = "出库";
            this.Btn_queryout.UseVisualStyleBackColor = false;
            // 
            // Btn_queryin
            // 
            this.Btn_queryin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_queryin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_queryin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_queryin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_queryin.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_queryin.Location = new System.Drawing.Point(125, 0);
            this.Btn_queryin.Name = "Btn_queryin";
            this.Btn_queryin.Size = new System.Drawing.Size(75, 23);
            this.Btn_queryin.TabIndex = 14;
            this.Btn_queryin.Text = "入库";
            this.Btn_queryin.UseVisualStyleBackColor = false;
            // 
            // Btn_queryoutandin
            // 
            this.Btn_queryoutandin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_queryoutandin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_queryoutandin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_queryoutandin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_queryoutandin.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_queryoutandin.Location = new System.Drawing.Point(238, 0);
            this.Btn_queryoutandin.Name = "Btn_queryoutandin";
            this.Btn_queryoutandin.Size = new System.Drawing.Size(75, 23);
            this.Btn_queryoutandin.TabIndex = 15;
            this.Btn_queryoutandin.Text = "出入库";
            this.Btn_queryoutandin.UseVisualStyleBackColor = false;
            // 
            // InstrumentQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.Btn_queryoutandin);
            this.Controls.Add(this.Btn_queryin);
            this.Controls.Add(this.Btn_queryout);
            this.Controls.Add(this.Dgv_InstrumentQuery);
            this.Controls.Add(this.Tb_model);
            this.Controls.Add(this.La_modelquery);
            this.Controls.Add(this.Dtpenddate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Dtpstartdate);
            this.Controls.Add(this.Btn_query);
            this.Controls.Add(this.La_timequery);
            this.Controls.Add(this.Tb_name);
            this.Controls.Add(this.La_namequery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InstrumentQuery";
            this.Text = "InstrumentQuery";
            this.Load += new System.EventHandler(this.InstrumentQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_InstrumentQuery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label La_namequery;
        private System.Windows.Forms.TextBox Tb_name;
        private System.Windows.Forms.Label La_timequery;
        private System.Windows.Forms.Button Btn_query;
        private System.Windows.Forms.DateTimePicker Dtpstartdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Dtpenddate;
        private System.Windows.Forms.Label La_modelquery;
        private System.Windows.Forms.TextBox Tb_model;
        private System.Windows.Forms.DataGridView Dgv_InstrumentQuery;
        private System.Windows.Forms.Button Btn_queryout;
        private System.Windows.Forms.Button Btn_queryin;
        private System.Windows.Forms.Button Btn_queryoutandin;
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