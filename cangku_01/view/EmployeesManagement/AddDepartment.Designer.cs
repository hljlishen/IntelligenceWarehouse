namespace cangku_01.view.EmployeesManagement
{
    partial class AddDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDepartment));
            this.La_adddepartment = new System.Windows.Forms.Label();
            this.La_departmentname = new System.Windows.Forms.Label();
            this.Tb_departmentname = new System.Windows.Forms.TextBox();
            this.Bt_confirm = new System.Windows.Forms.Button();
            this.Bt_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // La_adddepartment
            // 
            this.La_adddepartment.AutoSize = true;
            this.La_adddepartment.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.La_adddepartment.Location = new System.Drawing.Point(180, 18);
            this.La_adddepartment.Name = "La_adddepartment";
            this.La_adddepartment.Size = new System.Drawing.Size(74, 21);
            this.La_adddepartment.TabIndex = 0;
            this.La_adddepartment.Text = "添加公司";
            // 
            // La_departmentname
            // 
            this.La_departmentname.AutoSize = true;
            this.La_departmentname.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.La_departmentname.Location = new System.Drawing.Point(122, 62);
            this.La_departmentname.Name = "La_departmentname";
            this.La_departmentname.Size = new System.Drawing.Size(51, 20);
            this.La_departmentname.TabIndex = 1;
            this.La_departmentname.Text = "名字：";
            // 
            // Tb_departmentname
            // 
            this.Tb_departmentname.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tb_departmentname.Location = new System.Drawing.Point(196, 56);
            this.Tb_departmentname.Name = "Tb_departmentname";
            this.Tb_departmentname.Size = new System.Drawing.Size(131, 26);
            this.Tb_departmentname.TabIndex = 2;
            // 
            // Bt_confirm
            // 
            this.Bt_confirm.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Bt_confirm.Location = new System.Drawing.Point(108, 117);
            this.Bt_confirm.Name = "Bt_confirm";
            this.Bt_confirm.Size = new System.Drawing.Size(75, 23);
            this.Bt_confirm.TabIndex = 3;
            this.Bt_confirm.Text = "确认";
            this.Bt_confirm.UseVisualStyleBackColor = true;
            this.Bt_confirm.Click += new System.EventHandler(this.Bt_confirm_Click);
            // 
            // Bt_cancel
            // 
            this.Bt_cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Bt_cancel.Location = new System.Drawing.Point(266, 117);
            this.Bt_cancel.Name = "Bt_cancel";
            this.Bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.Bt_cancel.TabIndex = 4;
            this.Bt_cancel.Text = "取消";
            this.Bt_cancel.UseVisualStyleBackColor = true;
            this.Bt_cancel.Click += new System.EventHandler(this.Bt_cancel_Click);
            // 
            // AddDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 165);
            this.Controls.Add(this.Bt_cancel);
            this.Controls.Add(this.Bt_confirm);
            this.Controls.Add(this.Tb_departmentname);
            this.Controls.Add(this.La_departmentname);
            this.Controls.Add(this.La_adddepartment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddDepartment";
            this.Text = "添加公司";
            this.Load += new System.EventHandler(this.AddDepartment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label La_adddepartment;
        private System.Windows.Forms.Label La_departmentname;
        private System.Windows.Forms.TextBox Tb_departmentname;
        private System.Windows.Forms.Button Bt_confirm;
        private System.Windows.Forms.Button Bt_cancel;
    }
}