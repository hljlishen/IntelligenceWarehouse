using System.Windows.Forms;

namespace cangku_01
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.仪器位置查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.元器件位置查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.归还ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.Tb_temp = new System.Windows.Forms.TextBox();
            this.Tb_name = new System.Windows.Forms.TextBox();
            this.Tb_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Tb_ShowTime = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Tb_ShowState = new System.Windows.Forms.TextBox();
            this.Tb_ShowName = new System.Windows.Forms.TextBox();
            this.Tb_ShowId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Dgv_DueToSee = new System.Windows.Forms.DataGridView();
            this.DueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Hum_num = new System.Windows.Forms.Label();
            this.Tem_num = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_employeeinformation = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tp_allemployeeinformation = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.人员编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.所属部门 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.通行时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DueToSee)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tp_employeeinformation.SuspendLayout();
            this.tp_allemployeeinformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(285, 756);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(172, 756);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "当前时间：";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1424, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(91, 24);
            this.toolStripMenuItem1.Text = "管理员登录";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.仪器位置查询ToolStripMenuItem,
            this.元器件位置查询ToolStripMenuItem});
            this.toolStripMenuItem3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(77, 24);
            this.toolStripMenuItem3.Text = "位置查询";
            // 
            // 仪器位置查询ToolStripMenuItem
            // 
            this.仪器位置查询ToolStripMenuItem.Name = "仪器位置查询ToolStripMenuItem";
            this.仪器位置查询ToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.仪器位置查询ToolStripMenuItem.Text = "仪器位置查询";
            // 
            // 元器件位置查询ToolStripMenuItem
            // 
            this.元器件位置查询ToolStripMenuItem.Name = "元器件位置查询ToolStripMenuItem";
            this.元器件位置查询ToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.元器件位置查询ToolStripMenuItem.Text = "元器件位置查询";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.归还ToolStripMenuItem});
            this.toolStripMenuItem4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(119, 24);
            this.toolStripMenuItem4.Text = "元器件出入登记";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(106, 24);
            this.toolStripMenuItem6.Text = "借用";
            // 
            // 归还ToolStripMenuItem
            // 
            this.归还ToolStripMenuItem.Name = "归还ToolStripMenuItem";
            this.归还ToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.归还ToolStripMenuItem.Text = "归还";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(1079, 635);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tb_temp
            // 
            this.Tb_temp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_temp.Location = new System.Drawing.Point(392, 144);
            this.Tb_temp.Name = "Tb_temp";
            this.Tb_temp.ReadOnly = true;
            this.Tb_temp.Size = new System.Drawing.Size(129, 21);
            this.Tb_temp.TabIndex = 6;
            // 
            // Tb_name
            // 
            this.Tb_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_name.Location = new System.Drawing.Point(392, 97);
            this.Tb_name.Name = "Tb_name";
            this.Tb_name.ReadOnly = true;
            this.Tb_name.Size = new System.Drawing.Size(129, 21);
            this.Tb_name.TabIndex = 5;
            // 
            // Tb_id
            // 
            this.Tb_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_id.Location = new System.Drawing.Point(392, 54);
            this.Tb_id.Name = "Tb_id";
            this.Tb_id.ReadOnly = true;
            this.Tb_id.Size = new System.Drawing.Size(129, 21);
            this.Tb_id.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(285, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "所属部门：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(285, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "员工姓名：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(285, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "员工编号：";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Location = new System.Drawing.Point(86, 54);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(123, 140);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.Tb_ShowTime);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.Tb_ShowState);
            this.groupBox2.Controls.Add(this.Tb_ShowName);
            this.groupBox2.Controls.Add(this.Tb_ShowId);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(161, 431);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(648, 300);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "物品信息";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(90, 59);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(123, 140);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // Tb_ShowTime
            // 
            this.Tb_ShowTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tb_ShowTime.Location = new System.Drawing.Point(375, 195);
            this.Tb_ShowTime.Name = "Tb_ShowTime";
            this.Tb_ShowTime.ReadOnly = true;
            this.Tb_ShowTime.Size = new System.Drawing.Size(211, 19);
            this.Tb_ShowTime.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(289, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "时间：";
            // 
            // Tb_ShowState
            // 
            this.Tb_ShowState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tb_ShowState.Location = new System.Drawing.Point(375, 151);
            this.Tb_ShowState.Name = "Tb_ShowState";
            this.Tb_ShowState.ReadOnly = true;
            this.Tb_ShowState.Size = new System.Drawing.Size(211, 19);
            this.Tb_ShowState.TabIndex = 5;
            // 
            // Tb_ShowName
            // 
            this.Tb_ShowName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tb_ShowName.Location = new System.Drawing.Point(375, 106);
            this.Tb_ShowName.Name = "Tb_ShowName";
            this.Tb_ShowName.ReadOnly = true;
            this.Tb_ShowName.Size = new System.Drawing.Size(211, 19);
            this.Tb_ShowName.TabIndex = 4;
            // 
            // Tb_ShowId
            // 
            this.Tb_ShowId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tb_ShowId.Location = new System.Drawing.Point(375, 57);
            this.Tb_ShowId.Name = "Tb_ShowId";
            this.Tb_ShowId.ReadOnly = true;
            this.Tb_ShowId.Size = new System.Drawing.Size(211, 19);
            this.Tb_ShowId.TabIndex = 3;
            this.Tb_ShowId.TextChanged += new System.EventHandler(this.Tb_ShowId_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(289, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "状态：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(289, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "仪器名称：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(289, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "仪器编号：";
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(651, 840);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "陕西物理化学研究所国防重点实验室";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Dgv_DueToSee);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(884, 306);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 425);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "物品到期提醒";
            // 
            // Dgv_DueToSee
            // 
            this.Dgv_DueToSee.AllowUserToAddRows = false;
            this.Dgv_DueToSee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_DueToSee.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Dgv_DueToSee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_DueToSee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DueName,
            this.DueTime,
            this.DaysRemaining});
            this.Dgv_DueToSee.GridColor = System.Drawing.Color.Black;
            this.Dgv_DueToSee.Location = new System.Drawing.Point(12, 28);
            this.Dgv_DueToSee.Name = "Dgv_DueToSee";
            this.Dgv_DueToSee.ReadOnly = true;
            this.Dgv_DueToSee.RowHeadersVisible = false;
            this.Dgv_DueToSee.RowTemplate.Height = 23;
            this.Dgv_DueToSee.Size = new System.Drawing.Size(353, 383);
            this.Dgv_DueToSee.TabIndex = 0;
            // 
            // DueName
            // 
            this.DueName.HeaderText = "名称";
            this.DueName.Name = "DueName";
            this.DueName.ReadOnly = true;
            // 
            // DueTime
            // 
            this.DueTime.HeaderText = "到期时间";
            this.DueTime.Name = "DueTime";
            this.DueTime.ReadOnly = true;
            // 
            // DaysRemaining
            // 
            this.DaysRemaining.HeaderText = "剩余天数";
            this.DaysRemaining.Name = "DaysRemaining";
            this.DaysRemaining.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.Hum_num);
            this.groupBox4.Controls.Add(this.Tem_num);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.pictureBox2);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(884, 110);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(374, 147);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "温湿度实时监测";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(251, 92);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 25);
            this.label17.TabIndex = 7;
            this.label17.Text = "仓库湿度";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(91, 90);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 28);
            this.label16.TabIndex = 6;
            this.label16.Text = "仓库温度";
            // 
            // Hum_num
            // 
            this.Hum_num.AutoSize = true;
            this.Hum_num.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Hum_num.Location = new System.Drawing.Point(261, 55);
            this.Hum_num.Name = "Hum_num";
            this.Hum_num.Size = new System.Drawing.Size(36, 26);
            this.Hum_num.TabIndex = 5;
            this.Hum_num.Text = "60";
            // 
            // Tem_num
            // 
            this.Tem_num.AutoSize = true;
            this.Tem_num.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tem_num.Location = new System.Drawing.Point(101, 55);
            this.Tem_num.Name = "Tem_num";
            this.Tem_num.Size = new System.Drawing.Size(36, 26);
            this.Tem_num.TabIndex = 4;
            this.Tem_num.Text = "15";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(303, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 26);
            this.label13.TabIndex = 3;
            this.label13.Text = "％";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(143, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "℃";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(193, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(621, 838);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 15);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_employeeinformation);
            this.tabControl1.Controls.Add(this.tp_allemployeeinformation);
            this.tabControl1.ItemSize = new System.Drawing.Size(321, 18);
            this.tabControl1.Location = new System.Drawing.Point(161, 89);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(648, 300);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 17;
            // 
            // tp_employeeinformation
            // 
            this.tp_employeeinformation.Controls.Add(this.textBox1);
            this.tp_employeeinformation.Controls.Add(this.label5);
            this.tp_employeeinformation.Controls.Add(this.pictureBox5);
            this.tp_employeeinformation.Controls.Add(this.label6);
            this.tp_employeeinformation.Controls.Add(this.Tb_temp);
            this.tp_employeeinformation.Controls.Add(this.label7);
            this.tp_employeeinformation.Controls.Add(this.label8);
            this.tp_employeeinformation.Controls.Add(this.Tb_name);
            this.tp_employeeinformation.Controls.Add(this.Tb_id);
            this.tp_employeeinformation.Location = new System.Drawing.Point(4, 22);
            this.tp_employeeinformation.Name = "tp_employeeinformation";
            this.tp_employeeinformation.Padding = new System.Windows.Forms.Padding(3);
            this.tp_employeeinformation.Size = new System.Drawing.Size(640, 274);
            this.tp_employeeinformation.TabIndex = 0;
            this.tp_employeeinformation.Text = "人员信息";
            this.tp_employeeinformation.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(392, 195);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(129, 21);
            this.textBox1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(285, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "通行时间：";
            // 
            // tp_allemployeeinformation
            // 
            this.tp_allemployeeinformation.Controls.Add(this.dataGridView1);
            this.tp_allemployeeinformation.Location = new System.Drawing.Point(4, 22);
            this.tp_allemployeeinformation.Name = "tp_allemployeeinformation";
            this.tp_allemployeeinformation.Padding = new System.Windows.Forms.Padding(3);
            this.tp_allemployeeinformation.Size = new System.Drawing.Size(640, 274);
            this.tp_allemployeeinformation.TabIndex = 1;
            this.tp_allemployeeinformation.Text = "人员通行记录";
            this.tp_allemployeeinformation.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.人员编号,
            this.姓名,
            this.所属部门,
            this.通行时间});
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(628, 262);
            this.dataGridView1.TabIndex = 0;
            // 
            // 人员编号
            // 
            this.人员编号.HeaderText = "人员编号";
            this.人员编号.Name = "人员编号";
            this.人员编号.ReadOnly = true;
            // 
            // 姓名
            // 
            this.姓名.HeaderText = "姓名";
            this.姓名.Name = "姓名";
            this.姓名.ReadOnly = true;
            // 
            // 所属部门
            // 
            this.所属部门.HeaderText = "所属部门";
            this.所属部门.Name = "所属部门";
            this.所属部门.ReadOnly = true;
            // 
            // 通行时间
            // 
            this.通行时间.HeaderText = "通行时间";
            this.通行时间.Name = "通行时间";
            this.通行时间.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1424, 862);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "仓库管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DueToSee)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tp_employeeinformation.ResumeLayout(false);
            this.tp_employeeinformation.PerformLayout();
            this.tp_allemployeeinformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.TextBox Tb_temp;
        private System.Windows.Forms.TextBox Tb_name;
        private System.Windows.Forms.TextBox Tb_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label12;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem6;
        private Label label3;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label17;
        private Label label16;
        private Label Hum_num;
        private Label Tem_num;
        private Label label13;
        private Label label4;
        private NotifyIcon notifyIcon1;
        private PictureBox pictureBox3;
        private DataGridView Dgv_DueToSee;
        private DataGridViewTextBoxColumn DueName;
        private DataGridViewTextBoxColumn DueTime;
        private DataGridViewTextBoxColumn DaysRemaining;
        private ToolStripMenuItem 归还ToolStripMenuItem;
        public TextBox Tb_ShowState;
        public TextBox Tb_ShowName;
        public TextBox Tb_ShowId;
        public TextBox Tb_ShowTime;
        private Timer timer2;
        public PictureBox pictureBox4;
        public PictureBox pictureBox5;
        private TabControl tabControl1;
        private TabPage tp_employeeinformation;
        private TabPage tp_allemployeeinformation;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn 人员编号;
        private DataGridViewTextBoxColumn 姓名;
        private DataGridViewTextBoxColumn 所属部门;
        private DataGridViewTextBoxColumn 通行时间;
        private TextBox textBox1;
        private Label label5;
        private ToolStripMenuItem 仪器位置查询ToolStripMenuItem;
        private ToolStripMenuItem 元器件位置查询ToolStripMenuItem;
    }
}

