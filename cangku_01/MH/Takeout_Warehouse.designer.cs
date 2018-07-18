namespace cangku_01.MH
{
    partial class Takeout_Warehouse
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.负责人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_people_search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_time_search = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.仪器ID,
            this.仪器名,
            this.存放位置,
            this.出库个数,
            this.出库时间,
            this.剩余个数,
            this.仪器型号,
            this.生产厂商,
            this.生产日期,
            this.经办人,
            this.负责人});
            this.dataGridView1.Location = new System.Drawing.Point(12, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1400, 764);
            this.dataGridView1.TabIndex = 0;
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
            // 负责人
            // 
            this.负责人.HeaderText = "负责人";
            this.负责人.Name = "负责人";
            this.负责人.ReadOnly = true;
            this.负责人.Width = 133;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 21);
            this.textBox1.TabIndex = 2;
            // 
            // bt_people_search
            // 
            this.bt_people_search.Location = new System.Drawing.Point(293, 38);
            this.bt_people_search.Name = "bt_people_search";
            this.bt_people_search.Size = new System.Drawing.Size(75, 23);
            this.bt_people_search.TabIndex = 3;
            this.bt_people_search.Text = "查询";
            this.bt_people_search.UseVisualStyleBackColor = true;
            this.bt_people_search.Click += new System.EventHandler(this.bt_people_search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(690, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "时间查询：";
            // 
            // bt_time_search
            // 
            this.bt_time_search.Location = new System.Drawing.Point(992, 44);
            this.bt_time_search.Name = "bt_time_search";
            this.bt_time_search.Size = new System.Drawing.Size(75, 23);
            this.bt_time_search.TabIndex = 6;
            this.bt_time_search.Text = "查询";
            this.bt_time_search.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(751, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(103, 21);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(860, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "到";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(883, 45);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(103, 21);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // Takeout_Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.bt_time_search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_people_search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Takeout_Warehouse";
            this.Text = "Takeout_Warehouse";
            this.Load += new System.EventHandler(this.Takeout_Warehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn 负责人;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_people_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_time_search;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}