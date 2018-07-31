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
            this.La_BorrowQuery = new System.Windows.Forms.Label();
            this.Tb_borrow = new System.Windows.Forms.TextBox();
            this.La_TimeQuery = new System.Windows.Forms.Label();
            this.Btn_query = new System.Windows.Forms.Button();
            this.Dtp_begin = new System.Windows.Forms.DateTimePicker();
            this.La_to = new System.Windows.Forms.Label();
            this.Dtp_end = new System.Windows.Forms.DateTimePicker();
            this.La_ModelQuery = new System.Windows.Forms.Label();
            this.Tb_model = new System.Windows.Forms.TextBox();
            this.Dgv_InstrumentQuery = new System.Windows.Forms.DataGridView();
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
            this.Tt_checkborrow = new System.Windows.Forms.ToolTip(this.components);
            this.La_DutyQuery = new System.Windows.Forms.Label();
            this.Tb_duty = new System.Windows.Forms.TextBox();
            this.La_ManufacturerQuery = new System.Windows.Forms.Label();
            this.Tb_manufacturer = new System.Windows.Forms.TextBox();
            this.Cb_query = new System.Windows.Forms.ComboBox();
            this.Tt_checkduty = new System.Windows.Forms.ToolTip(this.components);
            this.Tt_checkmodel = new System.Windows.Forms.ToolTip(this.components);
            this.Tt_checkmanufacturer = new System.Windows.Forms.ToolTip(this.components);
            this.Tt_checktime = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_InstrumentQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // La_BorrowQuery
            // 
            this.La_BorrowQuery.AutoSize = true;
            this.La_BorrowQuery.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.La_BorrowQuery.Location = new System.Drawing.Point(144, 51);
            this.La_BorrowQuery.Name = "La_BorrowQuery";
            this.La_BorrowQuery.Size = new System.Drawing.Size(91, 14);
            this.La_BorrowQuery.TabIndex = 1;
            this.La_BorrowQuery.Text = "借用人查询：";
            // 
            // Tb_borrow
            // 
            this.Tb_borrow.Location = new System.Drawing.Point(241, 47);
            this.Tb_borrow.Name = "Tb_borrow";
            this.Tb_borrow.Size = new System.Drawing.Size(124, 21);
            this.Tb_borrow.TabIndex = 2;
            // 
            // La_TimeQuery
            // 
            this.La_TimeQuery.AutoSize = true;
            this.La_TimeQuery.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.La_TimeQuery.Location = new System.Drawing.Point(750, 51);
            this.La_TimeQuery.Name = "La_TimeQuery";
            this.La_TimeQuery.Size = new System.Drawing.Size(77, 14);
            this.La_TimeQuery.TabIndex = 4;
            this.La_TimeQuery.Text = "时间查询：";
            // 
            // Btn_query
            // 
            this.Btn_query.Location = new System.Drawing.Point(1078, 92);
            this.Btn_query.Name = "Btn_query";
            this.Btn_query.Size = new System.Drawing.Size(75, 23);
            this.Btn_query.TabIndex = 6;
            this.Btn_query.Text = "查询";
            this.Btn_query.UseVisualStyleBackColor = true;
            this.Btn_query.Click += new System.EventHandler(this.Btnquery_Click);
            // 
            // Dtp_begin
            // 
            this.Dtp_begin.Location = new System.Drawing.Point(833, 48);
            this.Dtp_begin.Name = "Dtp_begin";
            this.Dtp_begin.Size = new System.Drawing.Size(103, 21);
            this.Dtp_begin.TabIndex = 7;
            // 
            // La_to
            // 
            this.La_to.AutoSize = true;
            this.La_to.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.La_to.Location = new System.Drawing.Point(942, 52);
            this.La_to.Name = "La_to";
            this.La_to.Size = new System.Drawing.Size(21, 14);
            this.La_to.TabIndex = 8;
            this.La_to.Text = "至";
            // 
            // Dtp_end
            // 
            this.Dtp_end.Location = new System.Drawing.Point(969, 48);
            this.Dtp_end.Name = "Dtp_end";
            this.Dtp_end.Size = new System.Drawing.Size(103, 21);
            this.Dtp_end.TabIndex = 9;
            // 
            // La_ModelQuery
            // 
            this.La_ModelQuery.AutoSize = true;
            this.La_ModelQuery.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.La_ModelQuery.Location = new System.Drawing.Point(467, 48);
            this.La_ModelQuery.Name = "La_ModelQuery";
            this.La_ModelQuery.Size = new System.Drawing.Size(77, 14);
            this.La_ModelQuery.TabIndex = 11;
            this.La_ModelQuery.Text = "型号查询：";
            // 
            // Tb_model
            // 
            this.Tb_model.Location = new System.Drawing.Point(550, 44);
            this.Tb_model.Name = "Tb_model";
            this.Tb_model.Size = new System.Drawing.Size(124, 21);
            this.Tb_model.TabIndex = 12;
            // 
            // Dgv_InstrumentQuery
            // 
            this.Dgv_InstrumentQuery.AllowUserToAddRows = false;
            this.Dgv_InstrumentQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_InstrumentQuery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.Dgv_InstrumentQuery.Location = new System.Drawing.Point(12, 137);
            this.Dgv_InstrumentQuery.Name = "Dgv_InstrumentQuery";
            this.Dgv_InstrumentQuery.RowTemplate.Height = 23;
            this.Dgv_InstrumentQuery.Size = new System.Drawing.Size(1400, 712);
            this.Dgv_InstrumentQuery.TabIndex = 0;
            // 
            // 仪器标签ID
            // 
            this.仪器标签ID.HeaderText = "仪器标签ID";
            this.仪器标签ID.Name = "仪器标签ID";
            this.仪器标签ID.ReadOnly = true;
            this.仪器标签ID.Width = 138;
            // 
            // 仪器名
            // 
            this.仪器名.HeaderText = "仪器名";
            this.仪器名.Name = "仪器名";
            this.仪器名.ReadOnly = true;
            this.仪器名.Width = 138;
            // 
            // 存放位置
            // 
            this.存放位置.HeaderText = "存放位置";
            this.存放位置.Name = "存放位置";
            this.存放位置.ReadOnly = true;
            this.存放位置.Width = 138;
            // 
            // 操作时间
            // 
            this.操作时间.HeaderText = "操作时间";
            this.操作时间.Name = "操作时间";
            this.操作时间.ReadOnly = true;
            this.操作时间.Width = 138;
            // 
            // 仪器型号
            // 
            this.仪器型号.HeaderText = "仪器型号";
            this.仪器型号.Name = "仪器型号";
            this.仪器型号.ReadOnly = true;
            this.仪器型号.Width = 138;
            // 
            // 借用人
            // 
            this.借用人.HeaderText = "借用人";
            this.借用人.Name = "借用人";
            this.借用人.ReadOnly = true;
            this.借用人.Width = 138;
            // 
            // 责任人
            // 
            this.责任人.HeaderText = "责任人";
            this.责任人.Name = "责任人";
            this.责任人.Width = 138;
            // 
            // 操作
            // 
            this.操作.HeaderText = "操作";
            this.操作.Name = "操作";
            this.操作.ReadOnly = true;
            this.操作.Width = 138;
            // 
            // 生产厂商
            // 
            this.生产厂商.HeaderText = "生产厂商";
            this.生产厂商.Name = "生产厂商";
            this.生产厂商.ReadOnly = true;
            this.生产厂商.Width = 138;
            // 
            // 生产日期
            // 
            this.生产日期.HeaderText = "生产日期";
            this.生产日期.Name = "生产日期";
            this.生产日期.ReadOnly = true;
            this.生产日期.Width = 138;
            // 
            // Tt_checkborrow
            // 
            this.Tt_checkborrow.AutoPopDelay = 5000;
            this.Tt_checkborrow.BackColor = System.Drawing.Color.Red;
            this.Tt_checkborrow.ForeColor = System.Drawing.Color.Red;
            this.Tt_checkborrow.InitialDelay = 1000;
            this.Tt_checkborrow.ReshowDelay = 500;
            this.Tt_checkborrow.ShowAlways = true;
            this.Tt_checkborrow.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Tt_checkborrow.ToolTipTitle = "错误提示";
            // 
            // La_DutyQuery
            // 
            this.La_DutyQuery.AutoSize = true;
            this.La_DutyQuery.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.La_DutyQuery.Location = new System.Drawing.Point(144, 96);
            this.La_DutyQuery.Name = "La_DutyQuery";
            this.La_DutyQuery.Size = new System.Drawing.Size(91, 14);
            this.La_DutyQuery.TabIndex = 13;
            this.La_DutyQuery.Text = "责任人查询：";
            // 
            // Tb_duty
            // 
            this.Tb_duty.Location = new System.Drawing.Point(241, 92);
            this.Tb_duty.Name = "Tb_duty";
            this.Tb_duty.Size = new System.Drawing.Size(124, 21);
            this.Tb_duty.TabIndex = 14;
            // 
            // La_ManufacturerQuery
            // 
            this.La_ManufacturerQuery.AutoSize = true;
            this.La_ManufacturerQuery.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.La_ManufacturerQuery.Location = new System.Drawing.Point(467, 96);
            this.La_ManufacturerQuery.Name = "La_ManufacturerQuery";
            this.La_ManufacturerQuery.Size = new System.Drawing.Size(77, 14);
            this.La_ManufacturerQuery.TabIndex = 15;
            this.La_ManufacturerQuery.Text = "厂商查询：";
            // 
            // Tb_manufacturer
            // 
            this.Tb_manufacturer.Location = new System.Drawing.Point(550, 92);
            this.Tb_manufacturer.Name = "Tb_manufacturer";
            this.Tb_manufacturer.Size = new System.Drawing.Size(124, 21);
            this.Tb_manufacturer.TabIndex = 16;
            // 
            // Cb_query
            // 
            this.Cb_query.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_query.FormattingEnabled = true;
            this.Cb_query.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Cb_query.Items.AddRange(new object[] {
            "出入库",
            "出库",
            "入库"});
            this.Cb_query.Location = new System.Drawing.Point(12, 12);
            this.Cb_query.Name = "Cb_query";
            this.Cb_query.Size = new System.Drawing.Size(121, 20);
            this.Cb_query.TabIndex = 17;
            // 
            // Tt_checkduty
            // 
            this.Tt_checkduty.AutoPopDelay = 5000;
            this.Tt_checkduty.BackColor = System.Drawing.Color.Red;
            this.Tt_checkduty.ForeColor = System.Drawing.Color.Red;
            this.Tt_checkduty.InitialDelay = 500;
            this.Tt_checkduty.ReshowDelay = 100;
            this.Tt_checkduty.ShowAlways = true;
            this.Tt_checkduty.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Tt_checkduty.ToolTipTitle = "错误提示";
            // 
            // Tt_checkmodel
            // 
            this.Tt_checkmodel.AutoPopDelay = 5000;
            this.Tt_checkmodel.BackColor = System.Drawing.Color.Red;
            this.Tt_checkmodel.ForeColor = System.Drawing.Color.Red;
            this.Tt_checkmodel.InitialDelay = 500;
            this.Tt_checkmodel.ReshowDelay = 100;
            this.Tt_checkmodel.ShowAlways = true;
            this.Tt_checkmodel.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Tt_checkmodel.ToolTipTitle = "错误提示";
            // 
            // Tt_checkmanufacturer
            // 
            this.Tt_checkmanufacturer.AutoPopDelay = 5000;
            this.Tt_checkmanufacturer.BackColor = System.Drawing.Color.Red;
            this.Tt_checkmanufacturer.ForeColor = System.Drawing.Color.Red;
            this.Tt_checkmanufacturer.InitialDelay = 500;
            this.Tt_checkmanufacturer.ReshowDelay = 100;
            this.Tt_checkmanufacturer.ShowAlways = true;
            this.Tt_checkmanufacturer.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Tt_checkmanufacturer.ToolTipTitle = "错误提示";
            // 
            // Tt_checktime
            // 
            this.Tt_checktime.AutoPopDelay = 5000;
            this.Tt_checktime.BackColor = System.Drawing.Color.Red;
            this.Tt_checktime.ForeColor = System.Drawing.Color.Red;
            this.Tt_checktime.InitialDelay = 500;
            this.Tt_checktime.ReshowDelay = 100;
            this.Tt_checktime.ShowAlways = true;
            this.Tt_checktime.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Tt_checktime.ToolTipTitle = "错误提示";
            // 
            // InstrumentQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.Cb_query);
            this.Controls.Add(this.Tb_manufacturer);
            this.Controls.Add(this.La_ManufacturerQuery);
            this.Controls.Add(this.Tb_duty);
            this.Controls.Add(this.La_DutyQuery);
            this.Controls.Add(this.Dgv_InstrumentQuery);
            this.Controls.Add(this.Tb_model);
            this.Controls.Add(this.La_ModelQuery);
            this.Controls.Add(this.Dtp_end);
            this.Controls.Add(this.La_to);
            this.Controls.Add(this.Dtp_begin);
            this.Controls.Add(this.Btn_query);
            this.Controls.Add(this.La_TimeQuery);
            this.Controls.Add(this.Tb_borrow);
            this.Controls.Add(this.La_BorrowQuery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InstrumentQuery";
            this.Text = "InstrumentQuery";
            this.Load += new System.EventHandler(this.InstrumentQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_InstrumentQuery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label La_BorrowQuery;
        private System.Windows.Forms.TextBox Tb_borrow;
        private System.Windows.Forms.Label La_TimeQuery;
        private System.Windows.Forms.Button Btn_query;
        private System.Windows.Forms.DateTimePicker Dtp_begin;
        private System.Windows.Forms.Label La_to;
        private System.Windows.Forms.DateTimePicker Dtp_end;
        private System.Windows.Forms.Label La_ModelQuery;
        private System.Windows.Forms.TextBox Tb_model;
        private System.Windows.Forms.DataGridView Dgv_InstrumentQuery;
        private System.Windows.Forms.ToolTip Tt_checkborrow;
        private System.Windows.Forms.Label La_DutyQuery;
        private System.Windows.Forms.TextBox Tb_duty;
        private System.Windows.Forms.Label La_ManufacturerQuery;
        private System.Windows.Forms.TextBox Tb_manufacturer;
        private System.Windows.Forms.ComboBox Cb_query;
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
        private System.Windows.Forms.ToolTip Tt_checkduty;
        private System.Windows.Forms.ToolTip Tt_checkmodel;
        private System.Windows.Forms.ToolTip Tt_checkmanufacturer;
        private System.Windows.Forms.ToolTip Tt_checktime;
    }
}