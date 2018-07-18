namespace cangku_01.YT
{
    partial class Due_to_remind
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tr_nowtime = new System.Windows.Forms.Timer(this.components);
            this.la_nowtxt = new System.Windows.Forms.Label();
            this.La_nowtime = new System.Windows.Forms.Label();
            this.la_time = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.La_day0 = new System.Windows.Forms.Label();
            this.La_day30 = new System.Windows.Forms.Label();
            this.La_day3060 = new System.Windows.Forms.Label();
            this.La_day60 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(59, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1294, 700);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Tr_nowtime
            // 
            this.Tr_nowtime.Enabled = true;
            this.Tr_nowtime.Interval = 1000;
            this.Tr_nowtime.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // la_nowtxt
            // 
            this.la_nowtxt.AutoSize = true;
            this.la_nowtxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_nowtxt.Location = new System.Drawing.Point(56, 45);
            this.la_nowtxt.Name = "la_nowtxt";
            this.la_nowtxt.Size = new System.Drawing.Size(90, 21);
            this.la_nowtxt.TabIndex = 1;
            this.la_nowtxt.Text = "当前时间：";
            // 
            // La_nowtime
            // 
            this.La_nowtime.AutoSize = true;
            this.La_nowtime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.La_nowtime.Location = new System.Drawing.Point(151, 45);
            this.La_nowtime.Name = "La_nowtime";
            this.La_nowtime.Size = new System.Drawing.Size(0, 21);
            this.La_nowtime.TabIndex = 2;
            this.La_nowtime.Click += new System.EventHandler(this.Label2_Click);
            // 
            // la_time
            // 
            this.la_time.AutoSize = true;
            this.la_time.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_time.Location = new System.Drawing.Point(152, 45);
            this.la_time.Name = "la_time";
            this.la_time.Size = new System.Drawing.Size(80, 21);
            this.la_time.TabIndex = 3;
            this.la_time.Text = "Nowtime";
            this.la_time.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "名称";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "生产厂商";
            this.Column3.Name = "Column3";
            this.Column3.Width = 160;
            // 
            // Column4
            // 
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "上次检查日期";
            this.Column4.Name = "Column4";
            this.Column4.Width = 180;
            // 
            // Column5
            // 
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "检查周期（日）";
            this.Column5.Name = "Column5";
            this.Column5.Width = 160;
            // 
            // Column6
            // 
            this.Column6.Frozen = true;
            this.Column6.HeaderText = "下一次检查日期";
            this.Column6.Name = "Column6";
            this.Column6.Width = 180;
            // 
            // Column7
            // 
            this.Column7.Frozen = true;
            this.Column7.HeaderText = "剩余检查时间（日）";
            this.Column7.Name = "Column7";
            this.Column7.Width = 160;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "操作";
            this.Column8.Name = "Column8";
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column8.Text = "修改检查时间";
            this.Column8.UseColumnTextForButtonValue = true;
            this.Column8.Width = 160;
            // 
            // La_day0
            // 
            this.La_day0.AutoSize = true;
            this.La_day0.BackColor = System.Drawing.Color.Crimson;
            this.La_day0.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.La_day0.Location = new System.Drawing.Point(331, 45);
            this.La_day0.Name = "La_day0";
            this.La_day0.Size = new System.Drawing.Size(122, 21);
            this.La_day0.TabIndex = 4;
            this.La_day0.Text = "已超过检查日期";
            // 
            // La_day30
            // 
            this.La_day30.AutoSize = true;
            this.La_day30.BackColor = System.Drawing.Color.Yellow;
            this.La_day30.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.La_day30.Location = new System.Drawing.Point(511, 45);
            this.La_day30.Name = "La_day30";
            this.La_day30.Size = new System.Drawing.Size(92, 21);
            this.La_day30.TabIndex = 5;
            this.La_day30.Text = "30天内到检";
            // 
            // La_day3060
            // 
            this.La_day3060.AutoSize = true;
            this.La_day3060.BackColor = System.Drawing.Color.DodgerBlue;
            this.La_day3060.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.La_day3060.Location = new System.Drawing.Point(654, 45);
            this.La_day3060.Name = "La_day3060";
            this.La_day3060.Size = new System.Drawing.Size(117, 21);
            this.La_day3060.TabIndex = 6;
            this.La_day3060.Text = "30-60天内到检";
            // 
            // La_day60
            // 
            this.La_day60.AutoSize = true;
            this.La_day60.BackColor = System.Drawing.Color.Lavender;
            this.La_day60.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.La_day60.Location = new System.Drawing.Point(838, 45);
            this.La_day60.Name = "La_day60";
            this.La_day60.Size = new System.Drawing.Size(92, 21);
            this.La_day60.TabIndex = 7;
            this.La_day60.Text = "60天后到检";
            // 
            // Due_to_remind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 840);
            this.Controls.Add(this.La_day60);
            this.Controls.Add(this.La_day3060);
            this.Controls.Add(this.La_day30);
            this.Controls.Add(this.La_day0);
            this.Controls.Add(this.la_time);
            this.Controls.Add(this.La_nowtime);
            this.Controls.Add(this.la_nowtxt);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Due_to_remind";
            this.Text = "due_to_remind";
            this.Load += new System.EventHandler(this.Due_to_remind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer Tr_nowtime;
        private System.Windows.Forms.Label la_nowtxt;
        private System.Windows.Forms.Label La_nowtime;
        private System.Windows.Forms.Label la_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
        private System.Windows.Forms.Label La_day0;
        private System.Windows.Forms.Label La_day30;
        private System.Windows.Forms.Label La_day3060;
        private System.Windows.Forms.Label La_day60;
    }
}