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
            this.Dgv_DueToRemind = new System.Windows.Forms.DataGridView();
            this.Co_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Co_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Co_manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Co_lasttime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Co_cycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Co_nexttime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Co_surplustimr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Co_operation = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Tr_nowtime = new System.Windows.Forms.Timer(this.components);
            this.La_NowTimeTxt = new System.Windows.Forms.Label();
            this.La_nowtime = new System.Windows.Forms.Label();
            this.la_time = new System.Windows.Forms.Label();
            this.La_day0 = new System.Windows.Forms.Label();
            this.La_day30 = new System.Windows.Forms.Label();
            this.La_day3060 = new System.Windows.Forms.Label();
            this.La_day60 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DueToRemind)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_DueToRemind
            // 
            this.Dgv_DueToRemind.AllowUserToAddRows = false;
            this.Dgv_DueToRemind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_DueToRemind.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Co_id,
            this.Co_name,
            this.Co_manufacturer,
            this.Co_lasttime,
            this.Co_cycle,
            this.Co_nexttime,
            this.Co_surplustimr,
            this.Co_operation});
            this.Dgv_DueToRemind.Location = new System.Drawing.Point(59, 89);
            this.Dgv_DueToRemind.Name = "Dgv_DueToRemind";
            this.Dgv_DueToRemind.RowTemplate.Height = 23;
            this.Dgv_DueToRemind.Size = new System.Drawing.Size(1294, 700);
            this.Dgv_DueToRemind.TabIndex = 0;
            this.Dgv_DueToRemind.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Co_id
            // 
            this.Co_id.Frozen = true;
            this.Co_id.HeaderText = "编号";
            this.Co_id.Name = "Co_id";
            this.Co_id.ReadOnly = true;
            // 
            // Co_name
            // 
            this.Co_name.Frozen = true;
            this.Co_name.HeaderText = "名称";
            this.Co_name.Name = "Co_name";
            this.Co_name.ReadOnly = true;
            this.Co_name.Width = 150;
            // 
            // Co_manufacturer
            // 
            this.Co_manufacturer.Frozen = true;
            this.Co_manufacturer.HeaderText = "生产厂商";
            this.Co_manufacturer.Name = "Co_manufacturer";
            this.Co_manufacturer.ReadOnly = true;
            this.Co_manufacturer.Width = 160;
            // 
            // Co_lasttime
            // 
            this.Co_lasttime.Frozen = true;
            this.Co_lasttime.HeaderText = "上次检查日期";
            this.Co_lasttime.Name = "Co_lasttime";
            this.Co_lasttime.ReadOnly = true;
            this.Co_lasttime.Width = 180;
            // 
            // Co_cycle
            // 
            this.Co_cycle.Frozen = true;
            this.Co_cycle.HeaderText = "检查周期（日）";
            this.Co_cycle.Name = "Co_cycle";
            this.Co_cycle.ReadOnly = true;
            this.Co_cycle.Width = 160;
            // 
            // Co_nexttime
            // 
            this.Co_nexttime.Frozen = true;
            this.Co_nexttime.HeaderText = "下一次检查日期";
            this.Co_nexttime.Name = "Co_nexttime";
            this.Co_nexttime.ReadOnly = true;
            this.Co_nexttime.Width = 180;
            // 
            // Co_surplustimr
            // 
            this.Co_surplustimr.Frozen = true;
            this.Co_surplustimr.HeaderText = "剩余检查时间（日）";
            this.Co_surplustimr.Name = "Co_surplustimr";
            this.Co_surplustimr.ReadOnly = true;
            this.Co_surplustimr.Width = 160;
            // 
            // Co_operation
            // 
            this.Co_operation.HeaderText = "操作";
            this.Co_operation.Name = "Co_operation";
            this.Co_operation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Co_operation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Co_operation.Text = "修改检查时间";
            this.Co_operation.UseColumnTextForButtonValue = true;
            this.Co_operation.Width = 160;
            // 
            // Tr_nowtime
            // 
            this.Tr_nowtime.Enabled = true;
            this.Tr_nowtime.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // La_NowTimeTxt
            // 
            this.La_NowTimeTxt.AutoSize = true;
            this.La_NowTimeTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.La_NowTimeTxt.Location = new System.Drawing.Point(56, 45);
            this.La_NowTimeTxt.Name = "La_NowTimeTxt";
            this.La_NowTimeTxt.Size = new System.Drawing.Size(90, 21);
            this.La_NowTimeTxt.TabIndex = 1;
            this.La_NowTimeTxt.Text = "当前时间：";
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
            this.la_time.Size = new System.Drawing.Size(0, 21);
            this.la_time.TabIndex = 3;
            this.la_time.Click += new System.EventHandler(this.Label1_Click);
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
            this.Controls.Add(this.La_NowTimeTxt);
            this.Controls.Add(this.Dgv_DueToRemind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Due_to_remind";
            this.Text = "due_to_remind";
            this.Load += new System.EventHandler(this.Due_to_remind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DueToRemind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_DueToRemind;
        private System.Windows.Forms.Timer Tr_nowtime;
        private System.Windows.Forms.Label La_NowTimeTxt;
        private System.Windows.Forms.Label La_nowtime;
        private System.Windows.Forms.Label la_time;
        private System.Windows.Forms.Label La_day0;
        private System.Windows.Forms.Label La_day30;
        private System.Windows.Forms.Label La_day3060;
        private System.Windows.Forms.Label La_day60;
        private System.Windows.Forms.DataGridViewTextBoxColumn Co_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Co_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Co_manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Co_lasttime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Co_cycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Co_nexttime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Co_surplustimr;
        private System.Windows.Forms.DataGridViewButtonColumn Co_operation;
    }
}