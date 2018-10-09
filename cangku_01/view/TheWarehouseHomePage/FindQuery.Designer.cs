namespace cangku_01.view.TheWarehouseHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Find_Items));
            this.label1 = new System.Windows.Forms.Label();
            this.la_name = new System.Windows.Forms.Label();
            this.la_model = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_model = new System.Windows.Forms.TextBox();
            this.bt_findinstrument = new System.Windows.Forms.Button();
            this.tb_serialnumber = new System.Windows.Forms.TextBox();
            this.tb_manufactor = new System.Windows.Forms.TextBox();
            this.la_serialnumber = new System.Windows.Forms.Label();
            this.la_manufactor = new System.Windows.Forms.Label();
            this.dgv_instrumentplace = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.仪器tagid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.仪器id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_instrumentplace)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(341, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "仪器查询";
            // 
            // la_name
            // 
            this.la_name.AutoSize = true;
            this.la_name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_name.Location = new System.Drawing.Point(41, 122);
            this.la_name.Name = "la_name";
            this.la_name.Size = new System.Drawing.Size(79, 20);
            this.la_name.TabIndex = 1;
            this.la_name.Text = "仪器名称：";
            // 
            // la_model
            // 
            this.la_model.AutoSize = true;
            this.la_model.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_model.Location = new System.Drawing.Point(41, 179);
            this.la_model.Name = "la_model";
            this.la_model.Size = new System.Drawing.Size(79, 20);
            this.la_model.TabIndex = 2;
            this.la_model.Text = "仪器型号：";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_name.Location = new System.Drawing.Point(126, 119);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(180, 26);
            this.tb_name.TabIndex = 3;
            // 
            // tb_model
            // 
            this.tb_model.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_model.Location = new System.Drawing.Point(126, 176);
            this.tb_model.Name = "tb_model";
            this.tb_model.Size = new System.Drawing.Size(180, 26);
            this.tb_model.TabIndex = 4;
            // 
            // bt_findinstrument
            // 
            this.bt_findinstrument.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_findinstrument.Location = new System.Drawing.Point(231, 370);
            this.bt_findinstrument.Name = "bt_findinstrument";
            this.bt_findinstrument.Size = new System.Drawing.Size(75, 30);
            this.bt_findinstrument.TabIndex = 5;
            this.bt_findinstrument.Text = "查询";
            this.bt_findinstrument.UseVisualStyleBackColor = true;
            this.bt_findinstrument.Click += new System.EventHandler(this.bt_findinstrument_Click);
            // 
            // tb_serialnumber
            // 
            this.tb_serialnumber.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_serialnumber.Location = new System.Drawing.Point(126, 303);
            this.tb_serialnumber.Name = "tb_serialnumber";
            this.tb_serialnumber.Size = new System.Drawing.Size(180, 26);
            this.tb_serialnumber.TabIndex = 9;
            // 
            // tb_manufactor
            // 
            this.tb_manufactor.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_manufactor.Location = new System.Drawing.Point(126, 234);
            this.tb_manufactor.Name = "tb_manufactor";
            this.tb_manufactor.Size = new System.Drawing.Size(180, 26);
            this.tb_manufactor.TabIndex = 8;
            // 
            // la_serialnumber
            // 
            this.la_serialnumber.AutoSize = true;
            this.la_serialnumber.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_serialnumber.Location = new System.Drawing.Point(41, 306);
            this.la_serialnumber.Name = "la_serialnumber";
            this.la_serialnumber.Size = new System.Drawing.Size(79, 20);
            this.la_serialnumber.TabIndex = 7;
            this.la_serialnumber.Text = "出厂编号：";
            // 
            // la_manufactor
            // 
            this.la_manufactor.AutoSize = true;
            this.la_manufactor.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_manufactor.Location = new System.Drawing.Point(41, 237);
            this.la_manufactor.Name = "la_manufactor";
            this.la_manufactor.Size = new System.Drawing.Size(79, 20);
            this.la_manufactor.TabIndex = 6;
            this.la_manufactor.Text = "生产厂商：";
            // 
            // dgv_instrumentplace
            // 
            this.dgv_instrumentplace.AllowUserToAddRows = false;
            this.dgv_instrumentplace.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_instrumentplace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_instrumentplace.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.仪器tagid,
            this.仪器id});
            this.dgv_instrumentplace.Location = new System.Drawing.Point(356, 102);
            this.dgv_instrumentplace.Name = "dgv_instrumentplace";
            this.dgv_instrumentplace.ReadOnly = true;
            this.dgv_instrumentplace.RowHeadersVisible = false;
            this.dgv_instrumentplace.RowTemplate.Height = 23;
            this.dgv_instrumentplace.Size = new System.Drawing.Size(410, 298);
            this.dgv_instrumentplace.TabIndex = 10;
            this.dgv_instrumentplace.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_instrumentplace_CellMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "仪器名称";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 122;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "仪器型号";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 123;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "位置信息";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 160;
            // 
            // 仪器tagid
            // 
            this.仪器tagid.HeaderText = "仪器tagid";
            this.仪器tagid.Name = "仪器tagid";
            this.仪器tagid.ReadOnly = true;
            this.仪器tagid.Visible = false;
            // 
            // 仪器id
            // 
            this.仪器id.HeaderText = "仪器id";
            this.仪器id.Name = "仪器id";
            this.仪器id.ReadOnly = true;
            this.仪器id.Visible = false;
            // 
            // Find_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.dgv_instrumentplace);
            this.Controls.Add(this.tb_serialnumber);
            this.Controls.Add(this.tb_manufactor);
            this.Controls.Add(this.la_serialnumber);
            this.Controls.Add(this.la_manufactor);
            this.Controls.Add(this.bt_findinstrument);
            this.Controls.Add(this.tb_model);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.la_model);
            this.Controls.Add(this.la_name);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Find_Items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "位置查询";
            this.Load += new System.EventHandler(this.Find_Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_instrumentplace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label la_name;
        private System.Windows.Forms.Label la_model;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_model;
        private System.Windows.Forms.Button bt_findinstrument;
        private System.Windows.Forms.TextBox tb_serialnumber;
        private System.Windows.Forms.TextBox tb_manufactor;
        private System.Windows.Forms.Label la_serialnumber;
        private System.Windows.Forms.Label la_manufactor;
        private System.Windows.Forms.DataGridView dgv_instrumentplace;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 仪器tagid;
        private System.Windows.Forms.DataGridViewTextBoxColumn 仪器id;
    }
}