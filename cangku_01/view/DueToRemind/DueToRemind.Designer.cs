namespace cangku_01.view.DueToRemind
{
    partial class DueToRemind
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
            this.dgv_duetoremind = new System.Windows.Forms.DataGridView();
            this.tr_nowtime = new System.Windows.Forms.Timer(this.components);
            this.la_nowtimetxt = new System.Windows.Forms.Label();
            this.La_nowtime = new System.Windows.Forms.Label();
            this.la_time = new System.Windows.Forms.Label();
            this.la_day0 = new System.Windows.Forms.Label();
            this.la_day30 = new System.Windows.Forms.Label();
            this.la_day3060 = new System.Windows.Forms.Label();
            this.la_day60 = new System.Windows.Forms.Label();
            this.Co_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Co_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Co_manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Co_lasttime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Co_cycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Co_nexttime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Co_surplustimr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Co_operation = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_duetoremind)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_duetoremind
            // 
            this.dgv_duetoremind.AllowUserToAddRows = false;
            this.dgv_duetoremind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_duetoremind.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Co_id,
            this.Co_name,
            this.Co_manufacturer,
            this.Co_lasttime,
            this.Co_cycle,
            this.Co_nexttime,
            this.Co_surplustimr,
            this.Co_operation});
            this.dgv_duetoremind.Location = new System.Drawing.Point(59, 89);
            this.dgv_duetoremind.Name = "dgv_duetoremind";
            this.dgv_duetoremind.ReadOnly = true;
            this.dgv_duetoremind.RowHeadersVisible = false;
            this.dgv_duetoremind.RowTemplate.Height = 23;
            this.dgv_duetoremind.Size = new System.Drawing.Size(1290, 700);
            this.dgv_duetoremind.TabIndex = 0;
            this.dgv_duetoremind.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tr_nowtime
            // 
            this.tr_nowtime.Enabled = true;
            this.tr_nowtime.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // la_nowtimetxt
            // 
            this.la_nowtimetxt.AutoSize = true;
            this.la_nowtimetxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_nowtimetxt.Location = new System.Drawing.Point(56, 45);
            this.la_nowtimetxt.Name = "la_nowtimetxt";
            this.la_nowtimetxt.Size = new System.Drawing.Size(90, 21);
            this.la_nowtimetxt.TabIndex = 1;
            this.la_nowtimetxt.Text = "当前时间：";
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
            // la_day0
            // 
            this.la_day0.AutoSize = true;
            this.la_day0.BackColor = System.Drawing.Color.Crimson;
            this.la_day0.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_day0.Location = new System.Drawing.Point(399, 45);
            this.la_day0.Name = "la_day0";
            this.la_day0.Size = new System.Drawing.Size(122, 21);
            this.la_day0.TabIndex = 4;
            this.la_day0.Text = "已超过检查日期";
            // 
            // la_day30
            // 
            this.la_day30.AutoSize = true;
            this.la_day30.BackColor = System.Drawing.Color.Yellow;
            this.la_day30.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_day30.Location = new System.Drawing.Point(553, 45);
            this.la_day30.Name = "la_day30";
            this.la_day30.Size = new System.Drawing.Size(92, 21);
            this.la_day30.TabIndex = 5;
            this.la_day30.Text = "30天内到检";
            // 
            // la_day3060
            // 
            this.la_day3060.AutoSize = true;
            this.la_day3060.BackColor = System.Drawing.Color.DodgerBlue;
            this.la_day3060.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_day3060.Location = new System.Drawing.Point(687, 45);
            this.la_day3060.Name = "la_day3060";
            this.la_day3060.Size = new System.Drawing.Size(117, 21);
            this.la_day3060.TabIndex = 6;
            this.la_day3060.Text = "30-60天内到检";
            // 
            // la_day60
            // 
            this.la_day60.AutoSize = true;
            this.la_day60.BackColor = System.Drawing.Color.Lavender;
            this.la_day60.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_day60.Location = new System.Drawing.Point(838, 45);
            this.la_day60.Name = "la_day60";
            this.la_day60.Size = new System.Drawing.Size(92, 21);
            this.la_day60.TabIndex = 7;
            this.la_day60.Text = "60天后到检";
            // 
            // Co_id
            // 
            this.Co_id.Frozen = true;
            this.Co_id.HeaderText = "编号";
            this.Co_id.Name = "Co_id";
            this.Co_id.ReadOnly = true;
            this.Co_id.Width = 200;
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
            this.Co_manufacturer.Width = 165;
            // 
            // Co_lasttime
            // 
            this.Co_lasttime.Frozen = true;
            this.Co_lasttime.HeaderText = "上次检查日期";
            this.Co_lasttime.Name = "Co_lasttime";
            this.Co_lasttime.ReadOnly = true;
            this.Co_lasttime.Width = 195;
            // 
            // Co_cycle
            // 
            this.Co_cycle.Frozen = true;
            this.Co_cycle.HeaderText = "检查周期（日）";
            this.Co_cycle.Name = "Co_cycle";
            this.Co_cycle.ReadOnly = true;
            this.Co_cycle.Width = 130;
            // 
            // Co_nexttime
            // 
            this.Co_nexttime.Frozen = true;
            this.Co_nexttime.HeaderText = "下一次检查日期";
            this.Co_nexttime.Name = "Co_nexttime";
            this.Co_nexttime.ReadOnly = true;
            this.Co_nexttime.Width = 195;
            // 
            // Co_surplustimr
            // 
            this.Co_surplustimr.Frozen = true;
            this.Co_surplustimr.HeaderText = "剩余检查时间（日）";
            this.Co_surplustimr.Name = "Co_surplustimr";
            this.Co_surplustimr.ReadOnly = true;
            this.Co_surplustimr.Width = 140;
            // 
            // Co_operation
            // 
            this.Co_operation.HeaderText = "操作";
            this.Co_operation.Name = "Co_operation";
            this.Co_operation.ReadOnly = true;
            this.Co_operation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Co_operation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Co_operation.Text = "修改检查时间";
            this.Co_operation.UseColumnTextForButtonValue = true;
            this.Co_operation.Width = 110;
            // 
            // DueToRemind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 840);
            this.Controls.Add(this.la_day60);
            this.Controls.Add(this.la_day3060);
            this.Controls.Add(this.la_day30);
            this.Controls.Add(this.la_day0);
            this.Controls.Add(this.la_time);
            this.Controls.Add(this.La_nowtime);
            this.Controls.Add(this.la_nowtimetxt);
            this.Controls.Add(this.dgv_duetoremind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DueToRemind";
            this.Text = "due_to_remind";
            this.Load += new System.EventHandler(this.Due_to_remind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_duetoremind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_duetoremind;
        private System.Windows.Forms.Timer tr_nowtime;
        private System.Windows.Forms.Label la_nowtimetxt;
        private System.Windows.Forms.Label La_nowtime;
        private System.Windows.Forms.Label la_time;
        private System.Windows.Forms.Label la_day0;
        private System.Windows.Forms.Label la_day30;
        private System.Windows.Forms.Label la_day3060;
        private System.Windows.Forms.Label la_day60;
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