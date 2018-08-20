namespace cangku_01.view.DueToRemind
{
    partial class UpdateRemind
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateRemind));
            this.La_DueToRemindTitle = new System.Windows.Forms.Label();
            this.la_tageidtxt = new System.Windows.Forms.Label();
            this.la_nametxt = new System.Windows.Forms.Label();
            this.la_dateofexpirationtxt = new System.Windows.Forms.Label();
            this.la_manufacturertxt = new System.Windows.Forms.Label();
            this.la_tageid = new System.Windows.Forms.Label();
            this.la_name = new System.Windows.Forms.Label();
            this.la_manufacturer = new System.Windows.Forms.Label();
            this.bt_updateremind = new System.Windows.Forms.Button();
            this.dtp_lasttime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // La_DueToRemindTitle
            // 
            this.La_DueToRemindTitle.AutoSize = true;
            this.La_DueToRemindTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.La_DueToRemindTitle.Location = new System.Drawing.Point(184, 9);
            this.La_DueToRemindTitle.Name = "La_DueToRemindTitle";
            this.La_DueToRemindTitle.Size = new System.Drawing.Size(106, 21);
            this.La_DueToRemindTitle.TabIndex = 0;
            this.La_DueToRemindTitle.Text = "修改检查时间";
            // 
            // la_tageidtxt
            // 
            this.la_tageidtxt.AutoSize = true;
            this.la_tageidtxt.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_tageidtxt.Location = new System.Drawing.Point(80, 57);
            this.la_tageidtxt.Name = "la_tageidtxt";
            this.la_tageidtxt.Size = new System.Drawing.Size(68, 20);
            this.la_tageidtxt.TabIndex = 1;
            this.la_tageidtxt.Text = "仪器 id：";
            // 
            // la_nametxt
            // 
            this.la_nametxt.AutoSize = true;
            this.la_nametxt.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_nametxt.Location = new System.Drawing.Point(80, 107);
            this.la_nametxt.Name = "la_nametxt";
            this.la_nametxt.Size = new System.Drawing.Size(79, 20);
            this.la_nametxt.TabIndex = 2;
            this.la_nametxt.Text = "仪器名字：";
            // 
            // la_dateofexpirationtxt
            // 
            this.la_dateofexpirationtxt.AutoSize = true;
            this.la_dateofexpirationtxt.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_dateofexpirationtxt.Location = new System.Drawing.Point(80, 195);
            this.la_dateofexpirationtxt.Name = "la_dateofexpirationtxt";
            this.la_dateofexpirationtxt.Size = new System.Drawing.Size(79, 20);
            this.la_dateofexpirationtxt.TabIndex = 4;
            this.la_dateofexpirationtxt.Text = "检查日期：";
            // 
            // la_manufacturertxt
            // 
            this.la_manufacturertxt.AutoSize = true;
            this.la_manufacturertxt.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_manufacturertxt.Location = new System.Drawing.Point(82, 150);
            this.la_manufacturertxt.Name = "la_manufacturertxt";
            this.la_manufacturertxt.Size = new System.Drawing.Size(79, 20);
            this.la_manufacturertxt.TabIndex = 5;
            this.la_manufacturertxt.Text = "生产厂商：";
            // 
            // la_tageid
            // 
            this.la_tageid.AutoSize = true;
            this.la_tageid.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_tageid.Location = new System.Drawing.Point(167, 57);
            this.la_tageid.Name = "la_tageid";
            this.la_tageid.Size = new System.Drawing.Size(22, 20);
            this.la_tageid.TabIndex = 6;
            this.la_tageid.Text = "id";
            // 
            // la_name
            // 
            this.la_name.AutoSize = true;
            this.la_name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_name.Location = new System.Drawing.Point(167, 107);
            this.la_name.Name = "la_name";
            this.la_name.Size = new System.Drawing.Size(47, 20);
            this.la_name.TabIndex = 7;
            this.la_name.Text = "name";
            // 
            // la_manufacturer
            // 
            this.la_manufacturer.AutoSize = true;
            this.la_manufacturer.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_manufacturer.Location = new System.Drawing.Point(167, 150);
            this.la_manufacturer.Name = "la_manufacturer";
            this.la_manufacturer.Size = new System.Drawing.Size(100, 20);
            this.la_manufacturer.TabIndex = 8;
            this.la_manufacturer.Text = "manufacturer";
            // 
            // bt_updateremind
            // 
            this.bt_updateremind.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_updateremind.Location = new System.Drawing.Point(171, 282);
            this.bt_updateremind.Name = "bt_updateremind";
            this.bt_updateremind.Size = new System.Drawing.Size(119, 34);
            this.bt_updateremind.TabIndex = 10;
            this.bt_updateremind.Text = "确认修改";
            this.bt_updateremind.UseVisualStyleBackColor = true;
            this.bt_updateremind.Click += new System.EventHandler(this.bt_updateremind_Click);
            // 
            // dtp_lasttime
            // 
            this.dtp_lasttime.CalendarFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp_lasttime.Location = new System.Drawing.Point(171, 195);
            this.dtp_lasttime.Name = "dtp_lasttime";
            this.dtp_lasttime.Size = new System.Drawing.Size(214, 21);
            this.dtp_lasttime.TabIndex = 11;
            // 
            // UpdateRemind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.dtp_lasttime);
            this.Controls.Add(this.bt_updateremind);
            this.Controls.Add(this.la_manufacturer);
            this.Controls.Add(this.la_name);
            this.Controls.Add(this.la_tageid);
            this.Controls.Add(this.la_manufacturertxt);
            this.Controls.Add(this.la_dateofexpirationtxt);
            this.Controls.Add(this.la_nametxt);
            this.Controls.Add(this.la_tageidtxt);
            this.Controls.Add(this.La_DueToRemindTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateRemind";
            this.Text = "到期提醒";
            this.Load += new System.EventHandler(this.UpdateRemind_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label La_DueToRemindTitle;
        private System.Windows.Forms.Label la_tageidtxt;
        private System.Windows.Forms.Label la_nametxt;
        private System.Windows.Forms.Label la_dateofexpirationtxt;
        private System.Windows.Forms.Label la_manufacturertxt;
        private System.Windows.Forms.Label la_tageid;
        private System.Windows.Forms.Label la_name;
        private System.Windows.Forms.Label la_manufacturer;
        private System.Windows.Forms.Button bt_updateremind;
        private System.Windows.Forms.DateTimePicker dtp_lasttime;
    }
}