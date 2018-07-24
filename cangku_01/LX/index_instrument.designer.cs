namespace cangku_01
{
    partial class index_instrument
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.当前数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.负责人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "添加仪器";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "搜索仪器：";
            // 
            // txt_found
            // 
            this.txt_found.Location = new System.Drawing.Point(277, 16);
            this.txt_found.Name = "txt_found";
            this.txt_found.Size = new System.Drawing.Size(161, 21);
            this.txt_found.TabIndex = 2;
            this.txt_found.TextChanged += new System.EventHandler(this.txt_found_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(467, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "搜索";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.当前数量,
            this.负责人,
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(3, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1344, 849);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "标签ID";
            this.ID.Name = "ID";
            // 
            // name
            // 
            this.name.HeaderText = "仪器名称";
            this.name.Name = "name";
            // 
            // 型号规格
            // 
            this.型号规格.HeaderText = "型号规格";
            this.型号规格.Name = "型号规格";
            // 
            // 生产厂商
            // 
            this.生产厂商.HeaderText = "生产厂商";
            this.生产厂商.Name = "生产厂商";
            // 
            // 出厂编号
            // 
            this.出厂编号.HeaderText = "出厂编号";
            this.出厂编号.Name = "出厂编号";
            // 
            // 生产日期
            // 
            this.生产日期.HeaderText = "生产日期";
            this.生产日期.Name = "生产日期";
            // 
            // 货架位置
            // 
            this.货架位置.HeaderText = "货架位置";
            this.货架位置.Name = "货架位置";
            // 
            // 在库状态
            // 
            this.在库状态.HeaderText = "在库状态";
            this.在库状态.Name = "在库状态";
            // 
            // 检定周期
            // 
            this.检定周期.HeaderText = "检定周期";
            this.检定周期.Name = "检定周期";
            // 
            // 上次检验时间
            // 
            this.上次检验时间.HeaderText = "上次检验时间";
            this.上次检验时间.Name = "上次检验时间";
            // 
            // 当前数量
            // 
            this.当前数量.HeaderText = "当前数量";
            this.当前数量.Name = "当前数量";
            this.当前数量.Width = 80;
            // 
            // 负责人
            // 
            this.负责人.HeaderText = "负责人";
            this.负责人.Name = "负责人";
            this.负责人.Width = 80;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "删除";
            this.Column1.Name = "Column1";
            this.Column1.Text = "删除";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "修改";
            this.Column2.Name = "Column2";
            this.Column2.Text = "修改";
            this.Column2.UseColumnTextForButtonValue = true;
            this.Column2.Width = 70;
            // 
            // index_instrument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_found);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "index_instrument";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "index_instrument";
            this.Load += new System.EventHandler(this.index_instrument_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_found;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn 当前数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 负责人;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
    }
}