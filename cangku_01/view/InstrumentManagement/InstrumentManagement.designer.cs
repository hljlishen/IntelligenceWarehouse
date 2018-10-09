namespace cangku_01.view.InstrumentManagement
{
    partial class InstrumentManagement
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
            this.button1 = new System.Windows.Forms.Button();
            this.la_instrumentname = new System.Windows.Forms.Label();
            this.tb_instrumentname = new System.Windows.Forms.TextBox();
            this.bt_queryinstrument = new System.Windows.Forms.Button();
            this.dgv_instrumentinformation = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.型号规格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.生产厂商 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.货架位置 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.在库状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.仪器状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用于型号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.负责人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.查看详情 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.仪器id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.la_tagid = new System.Windows.Forms.Label();
            this.tb_tagid = new System.Windows.Forms.TextBox();
            this.bt_selectduty = new System.Windows.Forms.Button();
            this.tb_model = new System.Windows.Forms.TextBox();
            this.la_model = new System.Windows.Forms.Label();
            this.cb_IsInWareHouse = new System.Windows.Forms.ComboBox();
            this.la_duty = new System.Windows.Forms.Label();
            this.tb_duty = new System.Windows.Forms.TextBox();
            this.la_IsInWareHouse = new System.Windows.Forms.Label();
            this.bt_dgvchangeexcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_instrumentinformation)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(1266, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "添加仪器";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // la_instrumentname
            // 
            this.la_instrumentname.AutoSize = true;
            this.la_instrumentname.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_instrumentname.Location = new System.Drawing.Point(310, 20);
            this.la_instrumentname.Name = "la_instrumentname";
            this.la_instrumentname.Size = new System.Drawing.Size(79, 20);
            this.la_instrumentname.TabIndex = 1;
            this.la_instrumentname.Text = "仪器名称：";
            // 
            // tb_instrumentname
            // 
            this.tb_instrumentname.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_instrumentname.Location = new System.Drawing.Point(389, 17);
            this.tb_instrumentname.Name = "tb_instrumentname";
            this.tb_instrumentname.Size = new System.Drawing.Size(120, 26);
            this.tb_instrumentname.TabIndex = 2;
            // 
            // bt_queryinstrument
            // 
            this.bt_queryinstrument.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_queryinstrument.Location = new System.Drawing.Point(1091, 16);
            this.bt_queryinstrument.Name = "bt_queryinstrument";
            this.bt_queryinstrument.Size = new System.Drawing.Size(79, 30);
            this.bt_queryinstrument.TabIndex = 3;
            this.bt_queryinstrument.Text = "搜索";
            this.bt_queryinstrument.UseVisualStyleBackColor = true;
            this.bt_queryinstrument.Click += new System.EventHandler(this.button2_Click);
            this.bt_queryinstrument.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bt_queryinstrument_KeyPress);
            // 
            // dgv_instrumentinformation
            // 
            this.dgv_instrumentinformation.AllowUserToAddRows = false;
            this.dgv_instrumentinformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_instrumentinformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.型号规格,
            this.生产厂商,
            this.货架位置,
            this.在库状态,
            this.仪器状态,
            this.用于型号,
            this.负责人,
            this.Column1,
            this.Column2,
            this.查看详情,
            this.仪器id});
            this.dgv_instrumentinformation.Location = new System.Drawing.Point(73, 95);
            this.dgv_instrumentinformation.MultiSelect = false;
            this.dgv_instrumentinformation.Name = "dgv_instrumentinformation";
            this.dgv_instrumentinformation.RowTemplate.Height = 23;
            this.dgv_instrumentinformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_instrumentinformation.Size = new System.Drawing.Size(1273, 659);
            this.dgv_instrumentinformation.TabIndex = 4;
            this.dgv_instrumentinformation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_instrumentinformation_CellContentClick);
            this.dgv_instrumentinformation.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_instrumentinformation_CellContentDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "标签ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 165;
            // 
            // name
            // 
            this.name.HeaderText = "仪器名称";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 130;
            // 
            // 型号规格
            // 
            this.型号规格.HeaderText = "型号规格";
            this.型号规格.Name = "型号规格";
            this.型号规格.ReadOnly = true;
            this.型号规格.Width = 130;
            // 
            // 生产厂商
            // 
            this.生产厂商.HeaderText = "生产厂商";
            this.生产厂商.Name = "生产厂商";
            this.生产厂商.ReadOnly = true;
            this.生产厂商.Width = 130;
            // 
            // 货架位置
            // 
            this.货架位置.HeaderText = "货架位置";
            this.货架位置.Name = "货架位置";
            this.货架位置.ReadOnly = true;
            this.货架位置.Width = 130;
            // 
            // 在库状态
            // 
            this.在库状态.HeaderText = "在库状态";
            this.在库状态.Name = "在库状态";
            this.在库状态.ReadOnly = true;
            this.在库状态.Width = 90;
            // 
            // 仪器状态
            // 
            this.仪器状态.HeaderText = "仪器状态";
            this.仪器状态.Name = "仪器状态";
            this.仪器状态.ReadOnly = true;
            // 
            // 用于型号
            // 
            this.用于型号.HeaderText = "用于型号";
            this.用于型号.Name = "用于型号";
            this.用于型号.ReadOnly = true;
            this.用于型号.Width = 145;
            // 
            // 负责人
            // 
            this.负责人.HeaderText = "负责人";
            this.负责人.Name = "负责人";
            this.负责人.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "删除";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "删除";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 90;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "修改";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Text = "修改";
            this.Column2.UseColumnTextForButtonValue = true;
            this.Column2.Width = 90;
            // 
            // 查看详情
            // 
            this.查看详情.HeaderText = "查看详情";
            this.查看详情.Name = "查看详情";
            this.查看详情.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.查看详情.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.查看详情.Text = "查看详情";
            this.查看详情.UseColumnTextForButtonValue = true;
            this.查看详情.Width = 94;
            // 
            // 仪器id
            // 
            this.仪器id.HeaderText = "仪器id";
            this.仪器id.Name = "仪器id";
            this.仪器id.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.la_tagid);
            this.groupBox1.Controls.Add(this.tb_tagid);
            this.groupBox1.Controls.Add(this.bt_selectduty);
            this.groupBox1.Controls.Add(this.tb_model);
            this.groupBox1.Controls.Add(this.la_model);
            this.groupBox1.Controls.Add(this.cb_IsInWareHouse);
            this.groupBox1.Controls.Add(this.la_duty);
            this.groupBox1.Controls.Add(this.tb_duty);
            this.groupBox1.Controls.Add(this.la_IsInWareHouse);
            this.groupBox1.Controls.Add(this.bt_queryinstrument);
            this.groupBox1.Controls.Add(this.la_instrumentname);
            this.groupBox1.Controls.Add(this.tb_instrumentname);
            this.groupBox1.Location = new System.Drawing.Point(73, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1187, 55);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "仪器搜索";
            // 
            // la_tagid
            // 
            this.la_tagid.AutoSize = true;
            this.la_tagid.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_tagid.Location = new System.Drawing.Point(8, 20);
            this.la_tagid.Name = "la_tagid";
            this.la_tagid.Size = new System.Drawing.Size(79, 20);
            this.la_tagid.TabIndex = 71;
            this.la_tagid.Text = "仪器编号：";
            // 
            // tb_tagid
            // 
            this.tb_tagid.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_tagid.Location = new System.Drawing.Point(87, 17);
            this.tb_tagid.Name = "tb_tagid";
            this.tb_tagid.ReadOnly = true;
            this.tb_tagid.Size = new System.Drawing.Size(218, 26);
            this.tb_tagid.TabIndex = 72;
            // 
            // bt_selectduty
            // 
            this.bt_selectduty.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_selectduty.Location = new System.Drawing.Point(1040, 16);
            this.bt_selectduty.Name = "bt_selectduty";
            this.bt_selectduty.Size = new System.Drawing.Size(30, 26);
            this.bt_selectduty.TabIndex = 70;
            this.bt_selectduty.Text = "...";
            this.bt_selectduty.UseVisualStyleBackColor = true;
            this.bt_selectduty.Click += new System.EventHandler(this.bt_selectduty_Click);
            // 
            // tb_model
            // 
            this.tb_model.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_model.Location = new System.Drawing.Point(593, 17);
            this.tb_model.Name = "tb_model";
            this.tb_model.Size = new System.Drawing.Size(120, 26);
            this.tb_model.TabIndex = 22;
            // 
            // la_model
            // 
            this.la_model.AutoSize = true;
            this.la_model.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_model.Location = new System.Drawing.Point(517, 20);
            this.la_model.Name = "la_model";
            this.la_model.Size = new System.Drawing.Size(79, 20);
            this.la_model.TabIndex = 21;
            this.la_model.Text = "仪器规格：";
            // 
            // cb_IsInWareHouse
            // 
            this.cb_IsInWareHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_IsInWareHouse.FormattingEnabled = true;
            this.cb_IsInWareHouse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_IsInWareHouse.Items.AddRange(new object[] {
            "全部",
            "在库",
            "不在库"});
            this.cb_IsInWareHouse.Location = new System.Drawing.Point(797, 20);
            this.cb_IsInWareHouse.Name = "cb_IsInWareHouse";
            this.cb_IsInWareHouse.Size = new System.Drawing.Size(66, 20);
            this.cb_IsInWareHouse.TabIndex = 19;
            // 
            // la_duty
            // 
            this.la_duty.AutoSize = true;
            this.la_duty.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_duty.Location = new System.Drawing.Point(872, 20);
            this.la_duty.Name = "la_duty";
            this.la_duty.Size = new System.Drawing.Size(65, 20);
            this.la_duty.TabIndex = 8;
            this.la_duty.Text = "负责人：";
            // 
            // tb_duty
            // 
            this.tb_duty.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_duty.Location = new System.Drawing.Point(938, 17);
            this.tb_duty.Name = "tb_duty";
            this.tb_duty.ReadOnly = true;
            this.tb_duty.Size = new System.Drawing.Size(96, 26);
            this.tb_duty.TabIndex = 9;
            // 
            // la_IsInWareHouse
            // 
            this.la_IsInWareHouse.AutoSize = true;
            this.la_IsInWareHouse.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_IsInWareHouse.Location = new System.Drawing.Point(721, 20);
            this.la_IsInWareHouse.Name = "la_IsInWareHouse";
            this.la_IsInWareHouse.Size = new System.Drawing.Size(79, 20);
            this.la_IsInWareHouse.TabIndex = 6;
            this.la_IsInWareHouse.Text = "在库状态：";
            // 
            // bt_dgvchangeexcel
            // 
            this.bt_dgvchangeexcel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_dgvchangeexcel.Location = new System.Drawing.Point(1266, 760);
            this.bt_dgvchangeexcel.Name = "bt_dgvchangeexcel";
            this.bt_dgvchangeexcel.Size = new System.Drawing.Size(80, 25);
            this.bt_dgvchangeexcel.TabIndex = 6;
            this.bt_dgvchangeexcel.Text = "导出Excel";
            this.bt_dgvchangeexcel.UseVisualStyleBackColor = true;
            this.bt_dgvchangeexcel.Click += new System.EventHandler(this.bt_dgvchangeexcel_Click);
            // 
            // InstrumentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 840);
            this.Controls.Add(this.bt_dgvchangeexcel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_instrumentinformation);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InstrumentManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InstrumentManagement";
            this.Load += new System.EventHandler(this.index_instrument_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_instrumentinformation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label la_instrumentname;
        private System.Windows.Forms.TextBox tb_instrumentname;
        private System.Windows.Forms.Button bt_queryinstrument;
        public System.Windows.Forms.DataGridView dgv_instrumentinformation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label la_duty;
        private System.Windows.Forms.TextBox tb_duty;
        private System.Windows.Forms.Label la_IsInWareHouse;
        private System.Windows.Forms.ComboBox cb_IsInWareHouse;
        private System.Windows.Forms.Label la_model;
        private System.Windows.Forms.TextBox tb_model;
        private System.Windows.Forms.Button bt_selectduty;
        private System.Windows.Forms.Label la_tagid;
        private System.Windows.Forms.TextBox tb_tagid;
        private System.Windows.Forms.Button bt_dgvchangeexcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn 型号规格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生产厂商;
        private System.Windows.Forms.DataGridViewTextBoxColumn 货架位置;
        private System.Windows.Forms.DataGridViewTextBoxColumn 在库状态;
        private System.Windows.Forms.DataGridViewTextBoxColumn 仪器状态;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用于型号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 负责人;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn 查看详情;
        private System.Windows.Forms.DataGridViewTextBoxColumn 仪器id;
    }
}