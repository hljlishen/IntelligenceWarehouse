namespace cangku_01.view.InstrumentManagement
{
    partial class ShelvesTreeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShelvesTreeView));
            this.tv_shelves = new System.Windows.Forms.TreeView();
            this.bt_affirm = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.la_location = new System.Windows.Forms.Label();
            this.tb_location = new System.Windows.Forms.TextBox();
            this.la_errornamenull = new System.Windows.Forms.Label();
            this.la_errorexistcargo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tv_shelves
            // 
            this.tv_shelves.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tv_shelves.Location = new System.Drawing.Point(13, 13);
            this.tv_shelves.Name = "tv_shelves";
            this.tv_shelves.Size = new System.Drawing.Size(381, 362);
            this.tv_shelves.TabIndex = 0;
            this.tv_shelves.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_shelves_AfterSelect);
            // 
            // bt_affirm
            // 
            this.bt_affirm.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_affirm.Location = new System.Drawing.Point(67, 447);
            this.bt_affirm.Name = "bt_affirm";
            this.bt_affirm.Size = new System.Drawing.Size(75, 30);
            this.bt_affirm.TabIndex = 1;
            this.bt_affirm.Text = "确认";
            this.bt_affirm.UseVisualStyleBackColor = true;
            this.bt_affirm.Click += new System.EventHandler(this.bt_affirm_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_cancel.Location = new System.Drawing.Point(273, 447);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 30);
            this.bt_cancel.TabIndex = 2;
            this.bt_cancel.Text = "取消";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // la_location
            // 
            this.la_location.AutoSize = true;
            this.la_location.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_location.Location = new System.Drawing.Point(77, 390);
            this.la_location.Name = "la_location";
            this.la_location.Size = new System.Drawing.Size(79, 20);
            this.la_location.TabIndex = 3;
            this.la_location.Text = "仓库位置：";
            // 
            // tb_location
            // 
            this.tb_location.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_location.Location = new System.Drawing.Point(162, 387);
            this.tb_location.Name = "tb_location";
            this.tb_location.ReadOnly = true;
            this.tb_location.Size = new System.Drawing.Size(157, 26);
            this.tb_location.TabIndex = 4;
            // 
            // la_errornamenull
            // 
            this.la_errornamenull.AutoSize = true;
            this.la_errornamenull.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_errornamenull.ForeColor = System.Drawing.Color.Red;
            this.la_errornamenull.Location = new System.Drawing.Point(159, 416);
            this.la_errornamenull.Name = "la_errornamenull";
            this.la_errornamenull.Size = new System.Drawing.Size(97, 17);
            this.la_errornamenull.TabIndex = 53;
            this.la_errornamenull.Text = "*未进行位置选择";
            // 
            // la_errorexistcargo
            // 
            this.la_errorexistcargo.AutoSize = true;
            this.la_errorexistcargo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_errorexistcargo.ForeColor = System.Drawing.Color.Red;
            this.la_errorexistcargo.Location = new System.Drawing.Point(159, 416);
            this.la_errorexistcargo.Name = "la_errorexistcargo";
            this.la_errorexistcargo.Size = new System.Drawing.Size(109, 17);
            this.la_errorexistcargo.TabIndex = 54;
            this.la_errorexistcargo.Text = "*该位置以存在货物";
            // 
            // ShelvesTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 489);
            this.Controls.Add(this.la_errorexistcargo);
            this.Controls.Add(this.la_errornamenull);
            this.Controls.Add(this.tb_location);
            this.Controls.Add(this.la_location);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_affirm);
            this.Controls.Add(this.tv_shelves);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShelvesTreeView";
            this.Text = "选择货架位置";
            this.Load += new System.EventHandler(this.ShelvesTreeView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tv_shelves;
        private System.Windows.Forms.Button bt_affirm;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Label la_location;
        private System.Windows.Forms.TextBox tb_location;
        private System.Windows.Forms.Label la_errornamenull;
        private System.Windows.Forms.Label la_errorexistcargo;
    }
}