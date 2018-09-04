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
            this.La_TimeQuery = new System.Windows.Forms.Label();
            this.btn_query = new System.Windows.Forms.Button();
            this.dtp_begin = new System.Windows.Forms.DateTimePicker();
            this.la_to = new System.Windows.Forms.Label();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
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
            this.cb_query = new System.Windows.Forms.ComboBox();
            this.la_TagQuery = new System.Windows.Forms.Label();
            this.tb_tag = new System.Windows.Forms.TextBox();
            this.cb_choicetime = new System.Windows.Forms.CheckBox();
            this.btn_selectInstrument = new System.Windows.Forms.Button();
            this.tb_instrumentId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_employeeId = new System.Windows.Forms.TextBox();
            this.btn_selectemployee = new System.Windows.Forms.Button();
            this.gb_foundrecord = new System.Windows.Forms.GroupBox();
            this.l_instrument = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InstrumentQuery)).BeginInit();
            this.gb_foundrecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // La_TimeQuery
            // 
            this.La_TimeQuery.AutoSize = true;
            this.La_TimeQuery.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.La_TimeQuery.Location = new System.Drawing.Point(948, 33);
            this.La_TimeQuery.Name = "La_TimeQuery";
            this.La_TimeQuery.Size = new System.Drawing.Size(77, 14);
            this.La_TimeQuery.TabIndex = 4;
            this.La_TimeQuery.Text = "时间查询：";
            // 
            // btn_query
            // 
            this.btn_query.Location = new System.Drawing.Point(1167, 70);
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
            this.dtp_begin.Location = new System.Drawing.Point(1031, 29);
            this.dtp_begin.Name = "dtp_begin";
            this.dtp_begin.Size = new System.Drawing.Size(103, 21);
            this.dtp_begin.TabIndex = 7;
            // 
            // la_to
            // 
            this.la_to.AutoSize = true;
            this.la_to.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_to.Location = new System.Drawing.Point(1140, 32);
            this.la_to.Name = "la_to";
            this.la_to.Size = new System.Drawing.Size(21, 14);
            this.la_to.TabIndex = 8;
            this.la_to.Text = "至";
            // 
            // dtp_end
            // 
            this.dtp_end.Enabled = false;
            this.dtp_end.Location = new System.Drawing.Point(1167, 29);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(103, 21);
            this.dtp_end.TabIndex = 9;
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
            this.dgv_InstrumentQuery.Location = new System.Drawing.Point(69, 117);
            this.dgv_InstrumentQuery.Name = "dgv_InstrumentQuery";
            this.dgv_InstrumentQuery.RowTemplate.Height = 23;
            this.dgv_InstrumentQuery.Size = new System.Drawing.Size(1279, 732);
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
            // cb_query
            // 
            this.cb_query.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_query.FormattingEnabled = true;
            this.cb_query.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_query.Items.AddRange(new object[] {
            "出入库",
            "出库",
            "入库"});
            this.cb_query.Location = new System.Drawing.Point(543, 29);
            this.cb_query.Name = "cb_query";
            this.cb_query.Size = new System.Drawing.Size(121, 20);
            this.cb_query.TabIndex = 17;
            // 
            // la_TagQuery
            // 
            this.la_TagQuery.AutoSize = true;
            this.la_TagQuery.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_TagQuery.Location = new System.Drawing.Point(688, 32);
            this.la_TagQuery.Name = "la_TagQuery";
            this.la_TagQuery.Size = new System.Drawing.Size(77, 14);
            this.la_TagQuery.TabIndex = 18;
            this.la_TagQuery.Text = "标签查询：";
            // 
            // tb_tag
            // 
            this.tb_tag.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tb_tag.Location = new System.Drawing.Point(771, 28);
            this.tb_tag.Name = "tb_tag";
            this.tb_tag.ReadOnly = true;
            this.tb_tag.Size = new System.Drawing.Size(124, 21);
            this.tb_tag.TabIndex = 19;
            // 
            // cb_choicetime
            // 
            this.cb_choicetime.AutoSize = true;
            this.cb_choicetime.Location = new System.Drawing.Point(927, 34);
            this.cb_choicetime.Name = "cb_choicetime";
            this.cb_choicetime.Size = new System.Drawing.Size(15, 14);
            this.cb_choicetime.TabIndex = 21;
            this.cb_choicetime.UseVisualStyleBackColor = true;
            // 
            // btn_selectInstrument
            // 
            this.btn_selectInstrument.Location = new System.Drawing.Point(193, 28);
            this.btn_selectInstrument.Name = "btn_selectInstrument";
            this.btn_selectInstrument.Size = new System.Drawing.Size(28, 23);
            this.btn_selectInstrument.TabIndex = 22;
            this.btn_selectInstrument.Text = "...";
            this.btn_selectInstrument.UseVisualStyleBackColor = true;
            this.btn_selectInstrument.Click += new System.EventHandler(this.btn_selectInstrument_Click);
            // 
            // tb_instrumentId
            // 
            this.tb_instrumentId.Location = new System.Drawing.Point(87, 29);
            this.tb_instrumentId.Name = "tb_instrumentId";
            this.tb_instrumentId.ReadOnly = true;
            this.tb_instrumentId.Size = new System.Drawing.Size(100, 21);
            this.tb_instrumentId.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "仪器Id：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(238, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 24;
            this.label2.Text = "员工Id：";
            // 
            // tb_employeeId
            // 
            this.tb_employeeId.Location = new System.Drawing.Point(307, 28);
            this.tb_employeeId.Name = "tb_employeeId";
            this.tb_employeeId.ReadOnly = true;
            this.tb_employeeId.Size = new System.Drawing.Size(100, 21);
            this.tb_employeeId.TabIndex = 25;
            // 
            // btn_selectemployee
            // 
            this.btn_selectemployee.Location = new System.Drawing.Point(413, 27);
            this.btn_selectemployee.Name = "btn_selectemployee";
            this.btn_selectemployee.Size = new System.Drawing.Size(28, 23);
            this.btn_selectemployee.TabIndex = 26;
            this.btn_selectemployee.Text = "...";
            this.btn_selectemployee.UseVisualStyleBackColor = true;
            this.btn_selectemployee.Click += new System.EventHandler(this.btn_selectemployee_Click);
            // 
            // gb_foundrecord
            // 
            this.gb_foundrecord.Controls.Add(this.l_instrument);
            this.gb_foundrecord.Controls.Add(this.label3);
            this.gb_foundrecord.Controls.Add(this.cb_choicetime);
            this.gb_foundrecord.Controls.Add(this.btn_query);
            this.gb_foundrecord.Controls.Add(this.label1);
            this.gb_foundrecord.Controls.Add(this.btn_selectemployee);
            this.gb_foundrecord.Controls.Add(this.dtp_end);
            this.gb_foundrecord.Controls.Add(this.cb_query);
            this.gb_foundrecord.Controls.Add(this.la_to);
            this.gb_foundrecord.Controls.Add(this.tb_tag);
            this.gb_foundrecord.Controls.Add(this.dtp_begin);
            this.gb_foundrecord.Controls.Add(this.tb_instrumentId);
            this.gb_foundrecord.Controls.Add(this.la_TagQuery);
            this.gb_foundrecord.Controls.Add(this.La_TimeQuery);
            this.gb_foundrecord.Controls.Add(this.tb_employeeId);
            this.gb_foundrecord.Controls.Add(this.btn_selectInstrument);
            this.gb_foundrecord.Controls.Add(this.label2);
            this.gb_foundrecord.Location = new System.Drawing.Point(69, 12);
            this.gb_foundrecord.Name = "gb_foundrecord";
            this.gb_foundrecord.Size = new System.Drawing.Size(1279, 99);
            this.gb_foundrecord.TabIndex = 27;
            this.gb_foundrecord.TabStop = false;
            this.gb_foundrecord.Text = "搜索记录";
            // 
            // l_instrument
            // 
            this.l_instrument.AutoSize = true;
            this.l_instrument.Location = new System.Drawing.Point(87, 70);
            this.l_instrument.Name = "l_instrument";
            this.l_instrument.Size = new System.Drawing.Size(41, 12);
            this.l_instrument.TabIndex = 28;
            this.l_instrument.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(460, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 27;
            this.label3.Text = "状态记录：";
            // 
            // Ins_query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.gb_foundrecord);
            this.Controls.Add(this.dgv_InstrumentQuery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ins_query";
            this.Text = "InstrumentQuery";
            this.Load += new System.EventHandler(this.InstrumentQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InstrumentQuery)).EndInit();
            this.gb_foundrecord.ResumeLayout(false);
            this.gb_foundrecord.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label La_TimeQuery;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.DateTimePicker dtp_begin;
        private System.Windows.Forms.Label la_to;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.DataGridView dgv_InstrumentQuery;
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
        private System.Windows.Forms.Label la_TagQuery;
        private System.Windows.Forms.TextBox tb_tag;
        private System.Windows.Forms.CheckBox cb_choicetime;
        private System.Windows.Forms.Button btn_selectInstrument;
        private System.Windows.Forms.TextBox tb_instrumentId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_employeeId;
        private System.Windows.Forms.Button btn_selectemployee;
        private System.Windows.Forms.GroupBox gb_foundrecord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l_instrument;
    }
}