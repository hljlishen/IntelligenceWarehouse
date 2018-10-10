namespace cangku_01.MH
{
    partial class Ins_InAndOutRecord
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
            this.btn_search = new System.Windows.Forms.Button();
            this.dtp_begin = new System.Windows.Forms.DateTimePicker();
            this.la_to = new System.Windows.Forms.Label();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.dgv_InstrumentInAndOutrecord = new System.Windows.Forms.DataGridView();
            this.仪器标签ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.仪器名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.仪器型号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.生产厂商 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.通过时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.通过方向 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.借用人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.负责人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.仪器id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_directquery = new System.Windows.Forms.ComboBox();
            this.cb_choicetime = new System.Windows.Forms.CheckBox();
            this.btn_selectInstrument = new System.Windows.Forms.Button();
            this.tb_instrument = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_employee = new System.Windows.Forms.TextBox();
            this.btn_selectemployee = new System.Windows.Forms.Button();
            this.gb_foundrecord = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_exceloperator = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InstrumentInAndOutrecord)).BeginInit();
            this.gb_foundrecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // La_TimeQuery
            // 
            this.La_TimeQuery.AutoSize = true;
            this.La_TimeQuery.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.La_TimeQuery.Location = new System.Drawing.Point(861, 34);
            this.La_TimeQuery.Name = "La_TimeQuery";
            this.La_TimeQuery.Size = new System.Drawing.Size(79, 20);
            this.La_TimeQuery.TabIndex = 4;
            this.La_TimeQuery.Text = "时间查询：";
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_search.Location = new System.Drawing.Point(1192, 32);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "查询";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.Btnsearch_Click);
            // 
            // dtp_begin
            // 
            this.dtp_begin.Enabled = false;
            this.dtp_begin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp_begin.Location = new System.Drawing.Point(944, 32);
            this.dtp_begin.Name = "dtp_begin";
            this.dtp_begin.Size = new System.Drawing.Size(103, 23);
            this.dtp_begin.TabIndex = 7;
            // 
            // la_to
            // 
            this.la_to.AutoSize = true;
            this.la_to.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_to.Location = new System.Drawing.Point(1053, 33);
            this.la_to.Name = "la_to";
            this.la_to.Size = new System.Drawing.Size(23, 20);
            this.la_to.TabIndex = 8;
            this.la_to.Text = "至";
            // 
            // dtp_end
            // 
            this.dtp_end.Enabled = false;
            this.dtp_end.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp_end.Location = new System.Drawing.Point(1080, 32);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(103, 23);
            this.dtp_end.TabIndex = 9;
            // 
            // dgv_InstrumentInAndOutrecord
            // 
            this.dgv_InstrumentInAndOutrecord.AllowUserToAddRows = false;
            this.dgv_InstrumentInAndOutrecord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_InstrumentInAndOutrecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_InstrumentInAndOutrecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.仪器标签ID,
            this.仪器名,
            this.仪器型号,
            this.生产厂商,
            this.通过时间,
            this.通过方向,
            this.借用人,
            this.负责人,
            this.仪器id});
            this.dgv_InstrumentInAndOutrecord.Location = new System.Drawing.Point(69, 97);
            this.dgv_InstrumentInAndOutrecord.Name = "dgv_InstrumentInAndOutrecord";
            this.dgv_InstrumentInAndOutrecord.RowTemplate.Height = 23;
            this.dgv_InstrumentInAndOutrecord.Size = new System.Drawing.Size(1279, 669);
            this.dgv_InstrumentInAndOutrecord.TabIndex = 0;
            this.dgv_InstrumentInAndOutrecord.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_InstrumentInAndOutrecord_CellMouseDoubleClick);
            // 
            // 仪器标签ID
            // 
            this.仪器标签ID.HeaderText = "仪器编号";
            this.仪器标签ID.Name = "仪器标签ID";
            this.仪器标签ID.ReadOnly = true;
            this.仪器标签ID.Width = 185;
            // 
            // 仪器名
            // 
            this.仪器名.HeaderText = "仪器名";
            this.仪器名.Name = "仪器名";
            this.仪器名.ReadOnly = true;
            this.仪器名.Width = 177;
            // 
            // 仪器型号
            // 
            this.仪器型号.HeaderText = "仪器型号";
            this.仪器型号.Name = "仪器型号";
            this.仪器型号.ReadOnly = true;
            this.仪器型号.Width = 177;
            // 
            // 生产厂商
            // 
            this.生产厂商.HeaderText = "生产厂商";
            this.生产厂商.Name = "生产厂商";
            this.生产厂商.ReadOnly = true;
            this.生产厂商.Width = 177;
            // 
            // 通过时间
            // 
            this.通过时间.HeaderText = "通过时间";
            this.通过时间.Name = "通过时间";
            this.通过时间.ReadOnly = true;
            this.通过时间.Width = 138;
            // 
            // 通过方向
            // 
            this.通过方向.HeaderText = "通过方向";
            this.通过方向.Name = "通过方向";
            this.通过方向.ReadOnly = true;
            this.通过方向.Width = 127;
            // 
            // 借用人
            // 
            this.借用人.HeaderText = "借用人";
            this.借用人.Name = "借用人";
            this.借用人.ReadOnly = true;
            this.借用人.Width = 127;
            // 
            // 负责人
            // 
            this.负责人.HeaderText = "负责人";
            this.负责人.Name = "负责人";
            this.负责人.Width = 128;
            // 
            // 仪器id
            // 
            this.仪器id.HeaderText = "仪器id";
            this.仪器id.Name = "仪器id";
            this.仪器id.Visible = false;
            // 
            // cb_directquery
            // 
            this.cb_directquery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_directquery.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_directquery.FormattingEnabled = true;
            this.cb_directquery.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_directquery.Items.AddRange(new object[] {
            "出入库",
            "出库",
            "入库"});
            this.cb_directquery.Location = new System.Drawing.Point(679, 32);
            this.cb_directquery.Name = "cb_directquery";
            this.cb_directquery.Size = new System.Drawing.Size(100, 25);
            this.cb_directquery.TabIndex = 17;
            // 
            // cb_choicetime
            // 
            this.cb_choicetime.AutoSize = true;
            this.cb_choicetime.Location = new System.Drawing.Point(843, 39);
            this.cb_choicetime.Name = "cb_choicetime";
            this.cb_choicetime.Size = new System.Drawing.Size(15, 14);
            this.cb_choicetime.TabIndex = 21;
            this.cb_choicetime.UseVisualStyleBackColor = true;
            // 
            // btn_selectInstrument
            // 
            this.btn_selectInstrument.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_selectInstrument.Location = new System.Drawing.Point(273, 32);
            this.btn_selectInstrument.Name = "btn_selectInstrument";
            this.btn_selectInstrument.Size = new System.Drawing.Size(28, 23);
            this.btn_selectInstrument.TabIndex = 22;
            this.btn_selectInstrument.Text = "...";
            this.btn_selectInstrument.UseVisualStyleBackColor = true;
            this.btn_selectInstrument.Click += new System.EventHandler(this.btn_selectInstrument_Click);
            // 
            // tb_instrument
            // 
            this.tb_instrument.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_instrument.Location = new System.Drawing.Point(87, 32);
            this.tb_instrument.Name = "tb_instrument";
            this.tb_instrument.ReadOnly = true;
            this.tb_instrument.Size = new System.Drawing.Size(180, 23);
            this.tb_instrument.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "仪器编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(357, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "借用人编号：";
            // 
            // tb_employee
            // 
            this.tb_employee.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_employee.Location = new System.Drawing.Point(451, 32);
            this.tb_employee.Name = "tb_employee";
            this.tb_employee.ReadOnly = true;
            this.tb_employee.Size = new System.Drawing.Size(82, 23);
            this.tb_employee.TabIndex = 25;
            // 
            // btn_selectemployee
            // 
            this.btn_selectemployee.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_selectemployee.Location = new System.Drawing.Point(538, 32);
            this.btn_selectemployee.Name = "btn_selectemployee";
            this.btn_selectemployee.Size = new System.Drawing.Size(28, 23);
            this.btn_selectemployee.TabIndex = 26;
            this.btn_selectemployee.Text = "...";
            this.btn_selectemployee.UseVisualStyleBackColor = true;
            this.btn_selectemployee.Click += new System.EventHandler(this.btn_selectemployee_Click);
            // 
            // gb_foundrecord
            // 
            this.gb_foundrecord.Controls.Add(this.label3);
            this.gb_foundrecord.Controls.Add(this.cb_choicetime);
            this.gb_foundrecord.Controls.Add(this.btn_search);
            this.gb_foundrecord.Controls.Add(this.label1);
            this.gb_foundrecord.Controls.Add(this.btn_selectemployee);
            this.gb_foundrecord.Controls.Add(this.dtp_end);
            this.gb_foundrecord.Controls.Add(this.cb_directquery);
            this.gb_foundrecord.Controls.Add(this.la_to);
            this.gb_foundrecord.Controls.Add(this.dtp_begin);
            this.gb_foundrecord.Controls.Add(this.tb_instrument);
            this.gb_foundrecord.Controls.Add(this.La_TimeQuery);
            this.gb_foundrecord.Controls.Add(this.tb_employee);
            this.gb_foundrecord.Controls.Add(this.btn_selectInstrument);
            this.gb_foundrecord.Controls.Add(this.label2);
            this.gb_foundrecord.Location = new System.Drawing.Point(69, 15);
            this.gb_foundrecord.Name = "gb_foundrecord";
            this.gb_foundrecord.Size = new System.Drawing.Size(1279, 76);
            this.gb_foundrecord.TabIndex = 27;
            this.gb_foundrecord.TabStop = false;
            this.gb_foundrecord.Text = "搜索记录";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(626, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "方向：";
            // 
            // btn_exceloperator
            // 
            this.btn_exceloperator.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_exceloperator.Location = new System.Drawing.Point(1263, 772);
            this.btn_exceloperator.Name = "btn_exceloperator";
            this.btn_exceloperator.Size = new System.Drawing.Size(75, 23);
            this.btn_exceloperator.TabIndex = 28;
            this.btn_exceloperator.Text = "导出Excel";
            this.btn_exceloperator.UseVisualStyleBackColor = true;
            this.btn_exceloperator.Click += new System.EventHandler(this.btn_exceloperator_Click);
            // 
            // Ins_InAndOutRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.btn_exceloperator);
            this.Controls.Add(this.gb_foundrecord);
            this.Controls.Add(this.dgv_InstrumentInAndOutrecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ins_InAndOutRecord";
            this.Text = "InstrumentQuery";
            this.Load += new System.EventHandler(this.InstrumentQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InstrumentInAndOutrecord)).EndInit();
            this.gb_foundrecord.ResumeLayout(false);
            this.gb_foundrecord.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label La_TimeQuery;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DateTimePicker dtp_begin;
        private System.Windows.Forms.Label la_to;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.DataGridView dgv_InstrumentInAndOutrecord;
        private System.Windows.Forms.ComboBox cb_directquery;
        private System.Windows.Forms.CheckBox cb_choicetime;
        private System.Windows.Forms.Button btn_selectInstrument;
        private System.Windows.Forms.TextBox tb_instrument;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_employee;
        private System.Windows.Forms.Button btn_selectemployee;
        private System.Windows.Forms.GroupBox gb_foundrecord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_exceloperator;
        private System.Windows.Forms.DataGridViewTextBoxColumn 仪器标签ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 仪器名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 仪器型号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生产厂商;
        private System.Windows.Forms.DataGridViewTextBoxColumn 通过时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 通过方向;
        private System.Windows.Forms.DataGridViewTextBoxColumn 借用人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 负责人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 仪器id;
    }
}