namespace cangku_01.MH
{
    partial class Ins_query
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
            this.la_BorrowQuery = new System.Windows.Forms.Label();
            this.tb_borrow = new System.Windows.Forms.TextBox();
            this.La_TimeQuery = new System.Windows.Forms.Label();
            this.btn_query = new System.Windows.Forms.Button();
            this.dtp_begin = new System.Windows.Forms.DateTimePicker();
            this.la_to = new System.Windows.Forms.Label();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.la_ModelQuery = new System.Windows.Forms.Label();
            this.tb_model = new System.Windows.Forms.TextBox();
            this.dgv_InstrumentQuery = new System.Windows.Forms.DataGridView();
            this.仪器标签ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.仪器名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.存放位置 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.操作时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.仪器型号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.借用人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.责任人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.操作 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.生产厂商 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.生产日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tt_checkborrow = new System.Windows.Forms.ToolTip(this.components);
            this.la_DutyQuery = new System.Windows.Forms.Label();
            this.tb_duty = new System.Windows.Forms.TextBox();
            this.la_ManufacturerQuery = new System.Windows.Forms.Label();
            this.tb_manufacturer = new System.Windows.Forms.TextBox();
            this.cb_query = new System.Windows.Forms.ComboBox();
            this.tt_checkduty = new System.Windows.Forms.ToolTip(this.components);
            this.tt_checkmodel = new System.Windows.Forms.ToolTip(this.components);
            this.tt_checkmanufacturer = new System.Windows.Forms.ToolTip(this.components);
            this.tt_checktime = new System.Windows.Forms.ToolTip(this.components);
            this.la_TagQuery = new System.Windows.Forms.Label();
            this.tb_tag = new System.Windows.Forms.TextBox();
            this.cb_choicetime = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InstrumentQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // la_BorrowQuery
            // 
            this.la_BorrowQuery.AutoSize = true;
            this.la_BorrowQuery.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_BorrowQuery.Location = new System.Drawing.Point(270, 48);
            this.la_BorrowQuery.Name = "la_BorrowQuery";
            this.la_BorrowQuery.Size = new System.Drawing.Size(91, 14);
            this.la_BorrowQuery.TabIndex = 1;
            this.la_BorrowQuery.Text = "借用人查询：";
            // 
            // tb_borrow
            // 
            this.tb_borrow.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_borrow.Location = new System.Drawing.Point(367, 45);
            this.tb_borrow.Name = "tb_borrow";
            this.tb_borrow.Size = new System.Drawing.Size(124, 21);
            this.tb_borrow.TabIndex = 2;
            // 
            // La_TimeQuery
            // 
            this.La_TimeQuery.AutoSize = true;
            this.La_TimeQuery.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.La_TimeQuery.Location = new System.Drawing.Point(927, 44);
            this.La_TimeQuery.Name = "La_TimeQuery";
            this.La_TimeQuery.Size = new System.Drawing.Size(77, 14);
            this.La_TimeQuery.TabIndex = 4;
            this.La_TimeQuery.Text = "时间查询：";
            // 
            // btn_query
            // 
            this.btn_query.Location = new System.Drawing.Point(1251, 90);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(75, 23);
            this.btn_query.TabIndex = 6;
            this.btn_query.Text = "查询";
            this.btn_query.UseVisualStyleBackColor = true;
            this.btn_query.Click += new System.EventHandler(this.Btnquery_Click);
            // 
            // dtp_begin
            // 
            this.dtp_begin.Enabled = false;
            this.dtp_begin.Location = new System.Drawing.Point(1010, 41);
            this.dtp_begin.Name = "dtp_begin";
            this.dtp_begin.Size = new System.Drawing.Size(103, 21);
            this.dtp_begin.TabIndex = 7;
            // 
            // la_to
            // 
            this.la_to.AutoSize = true;
            this.la_to.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_to.Location = new System.Drawing.Point(1119, 44);
            this.la_to.Name = "la_to";
            this.la_to.Size = new System.Drawing.Size(21, 14);
            this.la_to.TabIndex = 8;
            this.la_to.Text = "至";
            // 
            // dtp_end
            // 
            this.dtp_end.Enabled = false;
            this.dtp_end.Location = new System.Drawing.Point(1146, 41);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(103, 21);
            this.dtp_end.TabIndex = 9;
            // 
            // la_ModelQuery
            // 
            this.la_ModelQuery.AutoSize = true;
            this.la_ModelQuery.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_ModelQuery.Location = new System.Drawing.Point(596, 45);
            this.la_ModelQuery.Name = "la_ModelQuery";
            this.la_ModelQuery.Size = new System.Drawing.Size(77, 14);
            this.la_ModelQuery.TabIndex = 11;
            this.la_ModelQuery.Text = "型号查询：";
            // 
            // tb_model
            // 
            this.tb_model.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_model.Location = new System.Drawing.Point(679, 43);
            this.tb_model.Name = "tb_model";
            this.tb_model.Size = new System.Drawing.Size(124, 21);
            this.tb_model.TabIndex = 12;
            // 
            // dgv_InstrumentQuery
            // 
            this.dgv_InstrumentQuery.AllowUserToAddRows = false;
            this.dgv_InstrumentQuery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_InstrumentQuery.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_InstrumentQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_InstrumentQuery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.仪器标签ID,
            this.仪器名,
            this.存放位置,
            this.操作时间,
            this.仪器型号,
            this.借用人,
            this.责任人,
            this.操作,
            this.生产厂商,
            this.生产日期});
            this.dgv_InstrumentQuery.Location = new System.Drawing.Point(12, 137);
            this.dgv_InstrumentQuery.Name = "dgv_InstrumentQuery";
            this.dgv_InstrumentQuery.RowTemplate.Height = 23;
            this.dgv_InstrumentQuery.Size = new System.Drawing.Size(1378, 712);
            this.dgv_InstrumentQuery.TabIndex = 0;
            // 
            // 仪器标签ID
            // 
            this.仪器标签ID.HeaderText = "仪器标签ID";
            this.仪器标签ID.Name = "仪器标签ID";
            this.仪器标签ID.ReadOnly = true;
            // 
            // 仪器名
            // 
            this.仪器名.HeaderText = "仪器名";
            this.仪器名.Name = "仪器名";
            this.仪器名.ReadOnly = true;
            // 
            // 存放位置
            // 
            this.存放位置.HeaderText = "存放位置";
            this.存放位置.Name = "存放位置";
            this.存放位置.ReadOnly = true;
            // 
            // 操作时间
            // 
            this.操作时间.HeaderText = "操作时间";
            this.操作时间.Name = "操作时间";
            this.操作时间.ReadOnly = true;
            // 
            // 仪器型号
            // 
            this.仪器型号.HeaderText = "仪器型号";
            this.仪器型号.Name = "仪器型号";
            this.仪器型号.ReadOnly = true;
            // 
            // 借用人
            // 
            this.借用人.HeaderText = "借用人";
            this.借用人.Name = "借用人";
            this.借用人.ReadOnly = true;
            // 
            // 责任人
            // 
            this.责任人.HeaderText = "责任人";
            this.责任人.Name = "责任人";
            // 
            // 操作
            // 
            this.操作.HeaderText = "操作";
            this.操作.Name = "操作";
            this.操作.ReadOnly = true;
            // 
            // 生产厂商
            // 
            this.生产厂商.HeaderText = "生产厂商";
            this.生产厂商.Name = "生产厂商";
            this.生产厂商.ReadOnly = true;
            // 
            // 生产日期
            // 
            this.生产日期.HeaderText = "生产日期";
            this.生产日期.Name = "生产日期";
            this.生产日期.ReadOnly = true;
            // 
            // tt_checkborrow
            // 
            this.tt_checkborrow.AutoPopDelay = 5000;
            this.tt_checkborrow.BackColor = System.Drawing.Color.Red;
            this.tt_checkborrow.ForeColor = System.Drawing.Color.Red;
            this.tt_checkborrow.InitialDelay = 1000;
            this.tt_checkborrow.ReshowDelay = 500;
            this.tt_checkborrow.ShowAlways = true;
            this.tt_checkborrow.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tt_checkborrow.ToolTipTitle = "错误提示";
            // 
            // la_DutyQuery
            // 
            this.la_DutyQuery.AutoSize = true;
            this.la_DutyQuery.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_DutyQuery.Location = new System.Drawing.Point(270, 92);
            this.la_DutyQuery.Name = "la_DutyQuery";
            this.la_DutyQuery.Size = new System.Drawing.Size(91, 14);
            this.la_DutyQuery.TabIndex = 13;
            this.la_DutyQuery.Text = "责任人查询：";
            // 
            // tb_duty
            // 
            this.tb_duty.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_duty.Location = new System.Drawing.Point(367, 85);
            this.tb_duty.Name = "tb_duty";
            this.tb_duty.Size = new System.Drawing.Size(124, 21);
            this.tb_duty.TabIndex = 14;
            // 
            // la_ManufacturerQuery
            // 
            this.la_ManufacturerQuery.AutoSize = true;
            this.la_ManufacturerQuery.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_ManufacturerQuery.Location = new System.Drawing.Point(596, 90);
            this.la_ManufacturerQuery.Name = "la_ManufacturerQuery";
            this.la_ManufacturerQuery.Size = new System.Drawing.Size(77, 14);
            this.la_ManufacturerQuery.TabIndex = 15;
            this.la_ManufacturerQuery.Text = "厂商查询：";
            // 
            // tb_manufacturer
            // 
            this.tb_manufacturer.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_manufacturer.Location = new System.Drawing.Point(679, 85);
            this.tb_manufacturer.Name = "tb_manufacturer";
            this.tb_manufacturer.Size = new System.Drawing.Size(124, 21);
            this.tb_manufacturer.TabIndex = 16;
            // 
            // cb_query
            // 
            this.cb_query.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_query.FormattingEnabled = true;
            this.cb_query.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_query.Items.AddRange(new object[] {
            "出入库",
            "出库",
            "入库"});
            this.cb_query.Location = new System.Drawing.Point(71, 48);
            this.cb_query.Name = "cb_query";
            this.cb_query.Size = new System.Drawing.Size(121, 20);
            this.cb_query.TabIndex = 17;
            // 
            // tt_checkduty
            // 
            this.tt_checkduty.AutoPopDelay = 5000;
            this.tt_checkduty.BackColor = System.Drawing.Color.Red;
            this.tt_checkduty.ForeColor = System.Drawing.Color.Red;
            this.tt_checkduty.InitialDelay = 500;
            this.tt_checkduty.ReshowDelay = 100;
            this.tt_checkduty.ShowAlways = true;
            this.tt_checkduty.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tt_checkduty.ToolTipTitle = "错误提示";
            // 
            // tt_checkmodel
            // 
            this.tt_checkmodel.AutoPopDelay = 5000;
            this.tt_checkmodel.BackColor = System.Drawing.Color.Red;
            this.tt_checkmodel.ForeColor = System.Drawing.Color.Red;
            this.tt_checkmodel.InitialDelay = 500;
            this.tt_checkmodel.ReshowDelay = 100;
            this.tt_checkmodel.ShowAlways = true;
            this.tt_checkmodel.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tt_checkmodel.ToolTipTitle = "错误提示";
            // 
            // tt_checkmanufacturer
            // 
            this.tt_checkmanufacturer.AutoPopDelay = 5000;
            this.tt_checkmanufacturer.BackColor = System.Drawing.Color.Red;
            this.tt_checkmanufacturer.ForeColor = System.Drawing.Color.Red;
            this.tt_checkmanufacturer.InitialDelay = 500;
            this.tt_checkmanufacturer.ReshowDelay = 100;
            this.tt_checkmanufacturer.ShowAlways = true;
            this.tt_checkmanufacturer.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tt_checkmanufacturer.ToolTipTitle = "错误提示";
            // 
            // tt_checktime
            // 
            this.tt_checktime.AutoPopDelay = 5000;
            this.tt_checktime.BackColor = System.Drawing.Color.Red;
            this.tt_checktime.ForeColor = System.Drawing.Color.Red;
            this.tt_checktime.InitialDelay = 500;
            this.tt_checktime.ReshowDelay = 100;
            this.tt_checktime.ShowAlways = true;
            this.tt_checktime.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tt_checktime.ToolTipTitle = "错误提示";
            // 
            // la_TagQuery
            // 
            this.la_TagQuery.AutoSize = true;
            this.la_TagQuery.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_TagQuery.Location = new System.Drawing.Point(927, 90);
            this.la_TagQuery.Name = "la_TagQuery";
            this.la_TagQuery.Size = new System.Drawing.Size(77, 14);
            this.la_TagQuery.TabIndex = 18;
            this.la_TagQuery.Text = "标签查询：";
            // 
            // tb_tag
            // 
            this.tb_tag.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_tag.Location = new System.Drawing.Point(1010, 85);
            this.tb_tag.Name = "tb_tag";
            this.tb_tag.Size = new System.Drawing.Size(124, 21);
            this.tb_tag.TabIndex = 19;
            // 
            // cb_choicetime
            // 
            this.cb_choicetime.AutoSize = true;
            this.cb_choicetime.Location = new System.Drawing.Point(906, 44);
            this.cb_choicetime.Name = "cb_choicetime";
            this.cb_choicetime.Size = new System.Drawing.Size(15, 14);
            this.cb_choicetime.TabIndex = 21;
            this.cb_choicetime.UseVisualStyleBackColor = true;
            // 
            // Ins_query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.cb_choicetime);
            this.Controls.Add(this.tb_tag);
            this.Controls.Add(this.la_TagQuery);
            this.Controls.Add(this.cb_query);
            this.Controls.Add(this.tb_manufacturer);
            this.Controls.Add(this.la_ManufacturerQuery);
            this.Controls.Add(this.tb_duty);
            this.Controls.Add(this.la_DutyQuery);
            this.Controls.Add(this.dgv_InstrumentQuery);
            this.Controls.Add(this.tb_model);
            this.Controls.Add(this.la_ModelQuery);
            this.Controls.Add(this.dtp_end);
            this.Controls.Add(this.la_to);
            this.Controls.Add(this.dtp_begin);
            this.Controls.Add(this.btn_query);
            this.Controls.Add(this.La_TimeQuery);
            this.Controls.Add(this.tb_borrow);
            this.Controls.Add(this.la_BorrowQuery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ins_query";
            this.Text = "InstrumentQuery";
            this.Load += new System.EventHandler(this.InstrumentQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InstrumentQuery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label la_BorrowQuery;
        private System.Windows.Forms.TextBox tb_borrow;
        private System.Windows.Forms.Label La_TimeQuery;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.DateTimePicker dtp_begin;
        private System.Windows.Forms.Label la_to;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Label la_ModelQuery;
        private System.Windows.Forms.TextBox tb_model;
        private System.Windows.Forms.DataGridView dgv_InstrumentQuery;
        private System.Windows.Forms.ToolTip tt_checkborrow;
        private System.Windows.Forms.Label la_DutyQuery;
        private System.Windows.Forms.TextBox tb_duty;
        private System.Windows.Forms.Label la_ManufacturerQuery;
        private System.Windows.Forms.TextBox tb_manufacturer;
        private System.Windows.Forms.ComboBox cb_query;
        private System.Windows.Forms.DataGridViewTextBoxColumn 仪器标签ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 仪器名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 存放位置;
        private System.Windows.Forms.DataGridViewTextBoxColumn 操作时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 仪器型号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 借用人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 责任人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 操作;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生产厂商;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生产日期;
        private System.Windows.Forms.ToolTip tt_checkduty;
        private System.Windows.Forms.ToolTip tt_checkmodel;
        private System.Windows.Forms.ToolTip tt_checkmanufacturer;
        private System.Windows.Forms.ToolTip tt_checktime;
        private System.Windows.Forms.Label la_TagQuery;
        private System.Windows.Forms.TextBox tb_tag;
        private System.Windows.Forms.CheckBox cb_choicetime;
    }
}