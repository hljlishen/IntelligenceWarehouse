namespace cangku_01.SQQ
{
    partial class Find_Items
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
            this.label1 = new System.Windows.Forms.Label();
            this.instrument_query = new System.Windows.Forms.Label();
            this.Component_query = new System.Windows.Forms.Label();
            this.Instrument = new System.Windows.Forms.TextBox();
            this.Component = new System.Windows.Forms.TextBox();
            this.Bt_find_ins = new System.Windows.Forms.Button();
            this.Bt_find_com = new System.Windows.Forms.Button();
            this.Info_title = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tb_Name = new System.Windows.Forms.TextBox();
            this.Tb_Location = new System.Windows.Forms.TextBox();
            this.Info_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(321, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "物品查询";
            // 
            // instrument_query
            // 
            this.instrument_query.AutoSize = true;
            this.instrument_query.Location = new System.Drawing.Point(60, 118);
            this.instrument_query.Name = "instrument_query";
            this.instrument_query.Size = new System.Drawing.Size(65, 12);
            this.instrument_query.TabIndex = 1;
            this.instrument_query.Text = "仪器查询：";
            // 
            // Component_query
            // 
            this.Component_query.AutoSize = true;
            this.Component_query.Location = new System.Drawing.Point(60, 215);
            this.Component_query.Name = "Component_query";
            this.Component_query.Size = new System.Drawing.Size(77, 12);
            this.Component_query.TabIndex = 2;
            this.Component_query.Text = "元器件查询：";
            // 
            // Instrument
            // 
            this.Instrument.Location = new System.Drawing.Point(143, 109);
            this.Instrument.Name = "Instrument";
            this.Instrument.Size = new System.Drawing.Size(190, 21);
            this.Instrument.TabIndex = 3;
            this.Instrument.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Instrument_MouseClick);
            this.Instrument.Leave += new System.EventHandler(this.Instrument_Leave);
            // 
            // Component
            // 
            this.Component.Location = new System.Drawing.Point(143, 206);
            this.Component.Name = "Component";
            this.Component.Size = new System.Drawing.Size(190, 21);
            this.Component.TabIndex = 4;
            this.Component.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Component_MouseClick);
            this.Component.Leave += new System.EventHandler(this.Component_Leave);
            // 
            // Bt_find_ins
            // 
            this.Bt_find_ins.Location = new System.Drawing.Point(363, 107);
            this.Bt_find_ins.Name = "Bt_find_ins";
            this.Bt_find_ins.Size = new System.Drawing.Size(75, 23);
            this.Bt_find_ins.TabIndex = 5;
            this.Bt_find_ins.Text = "查询";
            this.Bt_find_ins.UseVisualStyleBackColor = true;
            // 
            // Bt_find_com
            // 
            this.Bt_find_com.Location = new System.Drawing.Point(363, 203);
            this.Bt_find_com.Name = "Bt_find_com";
            this.Bt_find_com.Size = new System.Drawing.Size(75, 23);
            this.Bt_find_com.TabIndex = 6;
            this.Bt_find_com.Text = "查询";
            this.Bt_find_com.UseVisualStyleBackColor = true;
            // 
            // Info_title
            // 
            this.Info_title.Controls.Add(this.Tb_Location);
            this.Info_title.Controls.Add(this.Tb_Name);
            this.Info_title.Controls.Add(this.label3);
            this.Info_title.Controls.Add(this.label2);
            this.Info_title.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Info_title.Location = new System.Drawing.Point(465, 65);
            this.Info_title.Name = "Info_title";
            this.Info_title.Size = new System.Drawing.Size(323, 236);
            this.Info_title.TabIndex = 7;
            this.Info_title.TabStop = false;
            this.Info_title.Text = "位置信息";
            this.Info_title.Enter += new System.EventHandler(this.Info_title_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "仪器/元器件名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "仪器/元器件位置：";
            // 
            // Tb_Name
            // 
            this.Tb_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tb_Name.Location = new System.Drawing.Point(138, 42);
            this.Tb_Name.Multiline = true;
            this.Tb_Name.Name = "Tb_Name";
            this.Tb_Name.ReadOnly = true;
            this.Tb_Name.Size = new System.Drawing.Size(167, 48);
            this.Tb_Name.TabIndex = 2;
            // 
            // Tb_Location
            // 
            this.Tb_Location.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tb_Location.Location = new System.Drawing.Point(138, 123);
            this.Tb_Location.Multiline = true;
            this.Tb_Location.Name = "Tb_Location";
            this.Tb_Location.ReadOnly = true;
            this.Tb_Location.Size = new System.Drawing.Size(167, 55);
            this.Tb_Location.TabIndex = 3;
            // 
            // Find_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Info_title);
            this.Controls.Add(this.Bt_find_com);
            this.Controls.Add(this.Bt_find_ins);
            this.Controls.Add(this.Component);
            this.Controls.Add(this.Instrument);
            this.Controls.Add(this.Component_query);
            this.Controls.Add(this.instrument_query);
            this.Controls.Add(this.label1);
            this.Name = "Find_Items";
            this.Text = "Find_Items";
            this.Load += new System.EventHandler(this.Find_Items_Load);
            this.Info_title.ResumeLayout(false);
            this.Info_title.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label instrument_query;
        private System.Windows.Forms.Label Component_query;
        private System.Windows.Forms.TextBox Instrument;
        private System.Windows.Forms.TextBox Component;
        private System.Windows.Forms.Button Bt_find_ins;
        private System.Windows.Forms.Button Bt_find_com;
        private System.Windows.Forms.GroupBox Info_title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_Location;
        private System.Windows.Forms.TextBox Tb_Name;
    }
}