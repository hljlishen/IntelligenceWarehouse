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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_found = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dgv_instrumentinformation = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.型号规格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.生产厂商 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出厂编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.生产日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.货架位置 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.在库状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.检定周期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.上次检验时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.责任人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.查看详情 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_instrumentinformation)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(35, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "添加仪器";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(181, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "搜索仪器：";
            // 
            // txt_found
            // 
            this.txt_found.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_found.Location = new System.Drawing.Point(277, 25);
            this.txt_found.Name = "txt_found";
            this.txt_found.Size = new System.Drawing.Size(161, 26);
            this.txt_found.TabIndex = 2;
            this.txt_found.TextChanged += new System.EventHandler(this.txt_found_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(480, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "搜索";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.出厂编号,
            this.生产日期,
            this.货架位置,
            this.在库状态,
            this.检定周期,
            this.上次检验时间,
            this.责任人,
            this.Column1,
            this.Column2,
            this.查看详情});
            this.dgv_instrumentinformation.Location = new System.Drawing.Point(35, 73);
            this.dgv_instrumentinformation.Name = "dgv_instrumentinformation";
            this.dgv_instrumentinformation.RowTemplate.Height = 23;
            this.dgv_instrumentinformation.Size = new System.Drawing.Size(1340, 700);
            this.dgv_instrumentinformation.TabIndex = 4;
            this.dgv_instrumentinformation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "标签ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "仪器名称";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 110;
            // 
            // 型号规格
            // 
            this.型号规格.HeaderText = "型号规格";
            this.型号规格.Name = "型号规格";
            this.型号规格.ReadOnly = true;
            this.型号规格.Width = 110;
            // 
            // 生产厂商
            // 
            this.生产厂商.HeaderText = "生产厂商";
            this.生产厂商.Name = "生产厂商";
            this.生产厂商.ReadOnly = true;
            this.生产厂商.Width = 110;
            // 
            // 出厂编号
            // 
            this.出厂编号.HeaderText = "出厂编号";
            this.出厂编号.Name = "出厂编号";
            this.出厂编号.ReadOnly = true;
            this.出厂编号.Width = 110;
            // 
            // 生产日期
            // 
            this.生产日期.HeaderText = "生产日期";
            this.生产日期.Name = "生产日期";
            this.生产日期.ReadOnly = true;
            this.生产日期.Width = 110;
            // 
            // 货架位置
            // 
            this.货架位置.HeaderText = "货架位置";
            this.货架位置.Name = "货架位置";
            this.货架位置.ReadOnly = true;
            this.货架位置.Width = 110;
            // 
            // 在库状态
            // 
            this.在库状态.HeaderText = "在库状态";
            this.在库状态.Name = "在库状态";
            this.在库状态.ReadOnly = true;
            this.在库状态.Width = 80;
            // 
            // 检定周期
            // 
            this.检定周期.HeaderText = "检定周期";
            this.检定周期.Name = "检定周期";
            this.检定周期.ReadOnly = true;
            this.检定周期.Width = 80;
            // 
            // 上次检验时间
            // 
            this.上次检验时间.HeaderText = "上次检验时间";
            this.上次检验时间.Name = "上次检验时间";
            this.上次检验时间.ReadOnly = true;
            this.上次检验时间.Width = 110;
            // 
            // 责任人
            // 
            this.责任人.HeaderText = "责任人";
            this.责任人.Name = "责任人";
            this.责任人.ReadOnly = true;
            this.责任人.Width = 80;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "删除";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "删除";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "修改";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Text = "修改";
            this.Column2.UseColumnTextForButtonValue = true;
            this.Column2.Width = 50;
            // 
            // 查看详情
            // 
            this.查看详情.HeaderText = "查看详情";
            this.查看详情.Name = "查看详情";
            this.查看详情.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.查看详情.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.查看详情.Text = "查看详情";
            this.查看详情.UseColumnTextForButtonValue = true;
            this.查看详情.Width = 90;
            // 
            // InstrumentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 840);
            this.Controls.Add(this.dgv_instrumentinformation);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_found);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InstrumentManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InstrumentManagement";
            this.Load += new System.EventHandler(this.index_instrument_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_instrumentinformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_found;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView dgv_instrumentinformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn 型号规格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生产厂商;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出厂编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生产日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 货架位置;
        private System.Windows.Forms.DataGridViewTextBoxColumn 在库状态;
        private System.Windows.Forms.DataGridViewTextBoxColumn 检定周期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 上次检验时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 责任人;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn 查看详情;
    }
}