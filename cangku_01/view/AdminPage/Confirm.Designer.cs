namespace cangku_01.view.AdminPage
{
    partial class Confirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirm));
            this.La_text = new System.Windows.Forms.Label();
            this.Btn_yes = new System.Windows.Forms.Button();
            this.Btn_no = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // La_text
            // 
            this.La_text.AutoSize = true;
            this.La_text.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.La_text.Location = new System.Drawing.Point(86, 43);
            this.La_text.Name = "La_text";
            this.La_text.Size = new System.Drawing.Size(74, 21);
            this.La_text.TabIndex = 0;
            this.La_text.Text = "确认内容";
            // 
            // Btn_yes
            // 
            this.Btn_yes.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_yes.Location = new System.Drawing.Point(73, 98);
            this.Btn_yes.Name = "Btn_yes";
            this.Btn_yes.Size = new System.Drawing.Size(90, 30);
            this.Btn_yes.TabIndex = 1;
            this.Btn_yes.Text = "确认";
            this.Btn_yes.UseVisualStyleBackColor = true;
            this.Btn_yes.Click += new System.EventHandler(this.Btn_yes_Click);
            // 
            // Btn_no
            // 
            this.Btn_no.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_no.Location = new System.Drawing.Point(233, 98);
            this.Btn_no.Name = "Btn_no";
            this.Btn_no.Size = new System.Drawing.Size(90, 30);
            this.Btn_no.TabIndex = 2;
            this.Btn_no.Text = "取消";
            this.Btn_no.UseVisualStyleBackColor = true;
            this.Btn_no.Click += new System.EventHandler(this.Btn_no_Click);
            // 
            // Confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 162);
            this.Controls.Add(this.Btn_no);
            this.Controls.Add(this.Btn_yes);
            this.Controls.Add(this.La_text);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Confirm";
            this.Text = "确认";
            this.Load += new System.EventHandler(this.Confirm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label La_text;
        private System.Windows.Forms.Button Btn_yes;
        private System.Windows.Forms.Button Btn_no;
    }
}