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
            this.tb_temp = new System.Windows.Forms.TextBox();
            this.tb_employeename = new System.Windows.Forms.TextBox();
            this.tb_employeeunmber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pb_employeephoto = new System.Windows.Forms.PictureBox();
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_employeeinformation = new System.Windows.Forms.TabPage();
            this.tb_employeepassdoor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tp_allemployeeinformation = new System.Windows.Forms.TabPage();
            this.bt_emptyemployeepassdoor = new System.Windows.Forms.Button();
            this.lv_employeepassdoor = new System.Windows.Forms.ListView();
            this.ch_number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_employeenumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_temp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_passdoordatetime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tp_instrumrntinformation = new System.Windows.Forms.TabPage();
            this.tb_ShowTime = new System.Windows.Forms.TextBox();
            this.tb_ShowState = new System.Windows.Forms.TextBox();
            this.tb_ShowName = new System.Windows.Forms.TextBox();
            this.tb_ShowId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pb_instrumentphoto = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bt_instrument = new System.Windows.Forms.Button();
            this.lv_instrumrntinformation = new System.Windows.Forms.ListView();
            this.column_Insnumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Insid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Insname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Insstate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Instime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_postion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_employeephoto)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DueToSee)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tp_employeeinformation.SuspendLayout();
            this.tp_allemployeeinformation.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tp_instrumrntinformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_instrumentphoto)).BeginInit();
            this.tabPage1.SuspendLayout();
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
            this.仪器位置查询ToolStripMenuItem.Click += new System.EventHandler(this.仪器位置查询ToolStripMenuItem_Click);
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
            // tb_temp
            // 
            this.tb_temp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_temp.Location = new System.Drawing.Point(392, 144);
            this.tb_temp.Name = "tb_temp";
            this.tb_temp.ReadOnly = true;
            this.tb_temp.Size = new System.Drawing.Size(186, 21);
            this.tb_temp.TabIndex = 6;
            // 
            // tb_employeename
            // 
            this.tb_employeename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_employeename.Location = new System.Drawing.Point(392, 97);
            this.tb_employeename.Name = "tb_employeename";
            this.tb_employeename.ReadOnly = true;
            this.tb_employeename.Size = new System.Drawing.Size(186, 21);
            this.tb_employeename.TabIndex = 5;
            // 
            // tb_employeeunmber
            // 
            this.tb_employeeunmber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_employeeunmber.Location = new System.Drawing.Point(392, 54);
            this.tb_employeeunmber.Name = "tb_employeeunmber";
            this.tb_employeeunmber.ReadOnly = true;
            this.tb_employeeunmber.Size = new System.Drawing.Size(186, 21);
            this.tb_employeeunmber.TabIndex = 4;
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
            // pb_employeephoto
            // 
            this.pb_employeephoto.BackColor = System.Drawing.Color.Transparent;
            this.pb_employeephoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_employeephoto.BackgroundImage")));
            this.pb_employeephoto.Location = new System.Drawing.Point(86, 54);
            this.pb_employeephoto.Name = "pb_employeephoto";
            this.pb_employeephoto.Size = new System.Drawing.Size(123, 140);
            this.pb_employeephoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_employeephoto.TabIndex = 0;
            this.pb_employeephoto.TabStop = false;
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
            this.groupBox3.Size = new System.Drawing.Size(374, 436);
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
            this.Hum_num.Location = new System.Drawing.Point(258, 55);
            this.Hum_num.Name = "Hum_num";
            this.Hum_num.Size = new System.Drawing.Size(28, 26);
            this.Hum_num.TabIndex = 5;
            this.Hum_num.Text = "--";
            // 
            // Tem_num
            // 
            this.Tem_num.AutoSize = true;
            this.Tem_num.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tem_num.Location = new System.Drawing.Point(99, 55);
            this.Tem_num.Name = "Tem_num";
            this.Tem_num.Size = new System.Drawing.Size(28, 26);
            this.Tem_num.TabIndex = 4;
            this.Tem_num.Text = "--";
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_employeeinformation);
            this.tabControl1.Controls.Add(this.tp_allemployeeinformation);
            this.tabControl1.ItemSize = new System.Drawing.Size(321, 18);
            this.tabControl1.Location = new System.Drawing.Point(161, 107);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(648, 300);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 17;
            // 
            // tp_employeeinformation
            // 
            this.tp_employeeinformation.Controls.Add(this.tb_employeepassdoor);
            this.tp_employeeinformation.Controls.Add(this.label5);
            this.tp_employeeinformation.Controls.Add(this.pb_employeephoto);
            this.tp_employeeinformation.Controls.Add(this.label6);
            this.tp_employeeinformation.Controls.Add(this.tb_temp);
            this.tp_employeeinformation.Controls.Add(this.label7);
            this.tp_employeeinformation.Controls.Add(this.label8);
            this.tp_employeeinformation.Controls.Add(this.tb_employeename);
            this.tp_employeeinformation.Controls.Add(this.tb_employeeunmber);
            this.tp_employeeinformation.Location = new System.Drawing.Point(4, 22);
            this.tp_employeeinformation.Name = "tp_employeeinformation";
            this.tp_employeeinformation.Padding = new System.Windows.Forms.Padding(3);
            this.tp_employeeinformation.Size = new System.Drawing.Size(640, 274);
            this.tp_employeeinformation.TabIndex = 0;
            this.tp_employeeinformation.Text = "人员信息";
            this.tp_employeeinformation.UseVisualStyleBackColor = true;
            // 
            // tb_employeepassdoor
            // 
            this.tb_employeepassdoor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_employeepassdoor.Location = new System.Drawing.Point(392, 195);
            this.tb_employeepassdoor.Name = "tb_employeepassdoor";
            this.tb_employeepassdoor.ReadOnly = true;
            this.tb_employeepassdoor.Size = new System.Drawing.Size(186, 21);
            this.tb_employeepassdoor.TabIndex = 8;
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
            this.tp_allemployeeinformation.Controls.Add(this.bt_emptyemployeepassdoor);
            this.tp_allemployeeinformation.Controls.Add(this.lv_employeepassdoor);
            this.tp_allemployeeinformation.Location = new System.Drawing.Point(4, 22);
            this.tp_allemployeeinformation.Name = "tp_allemployeeinformation";
            this.tp_allemployeeinformation.Padding = new System.Windows.Forms.Padding(3);
            this.tp_allemployeeinformation.Size = new System.Drawing.Size(640, 274);
            this.tp_allemployeeinformation.TabIndex = 1;
            this.tp_allemployeeinformation.Text = "人员通行记录";
            this.tp_allemployeeinformation.UseVisualStyleBackColor = true;
            // 
            // bt_emptyemployeepassdoor
            // 
            this.bt_emptyemployeepassdoor.Location = new System.Drawing.Point(559, 245);
            this.bt_emptyemployeepassdoor.Name = "bt_emptyemployeepassdoor";
            this.bt_emptyemployeepassdoor.Size = new System.Drawing.Size(75, 23);
            this.bt_emptyemployeepassdoor.TabIndex = 2;
            this.bt_emptyemployeepassdoor.Text = "清空";
            this.bt_emptyemployeepassdoor.UseVisualStyleBackColor = true;
            this.bt_emptyemployeepassdoor.Click += new System.EventHandler(this.bt_emptyemployeepassdoor_Click);
            // 
            // lv_employeepassdoor
            // 
            this.lv_employeepassdoor.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.lv_employeepassdoor.AutoArrange = false;
            this.lv_employeepassdoor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_employeepassdoor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_number,
            this.ch_employeenumber,
            this.ch_name,
            this.ch_temp,
            this.ch_passdoordatetime});
            this.lv_employeepassdoor.FullRowSelect = true;
            this.lv_employeepassdoor.GridLines = true;
            this.lv_employeepassdoor.Location = new System.Drawing.Point(6, 6);
            this.lv_employeepassdoor.Name = "lv_employeepassdoor";
            this.lv_employeepassdoor.Size = new System.Drawing.Size(628, 233);
            this.lv_employeepassdoor.TabIndex = 2;
            this.lv_employeepassdoor.UseCompatibleStateImageBehavior = false;
            this.lv_employeepassdoor.View = System.Windows.Forms.View.Details;
            // 
            // ch_number
            // 
            this.ch_number.Text = "序号";
            // 
            // ch_employeenumber
            // 
            this.ch_employeenumber.Text = "编号";
            this.ch_employeenumber.Width = 120;
            // 
            // ch_name
            // 
            this.ch_name.Text = "名字";
            this.ch_name.Width = 130;
            // 
            // ch_temp
            // 
            this.ch_temp.Text = "部门";
            this.ch_temp.Width = 125;
            // 
            // ch_passdoordatetime
            // 
            this.ch_passdoordatetime.Text = "通过时间";
            this.ch_passdoordatetime.Width = 190;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tp_instrumrntinformation);
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.ItemSize = new System.Drawing.Size(321, 18);
            this.tabControl2.Location = new System.Drawing.Point(165, 442);
            this.tabControl2.Multiline = true;
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(648, 300);
            this.tabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl2.TabIndex = 18;
            // 
            // tp_instrumrntinformation
            // 
            this.tp_instrumrntinformation.Controls.Add(this.tb_ShowTime);
            this.tp_instrumrntinformation.Controls.Add(this.tb_ShowState);
            this.tp_instrumrntinformation.Controls.Add(this.tb_ShowName);
            this.tp_instrumrntinformation.Controls.Add(this.tb_ShowId);
            this.tp_instrumrntinformation.Controls.Add(this.label12);
            this.tp_instrumrntinformation.Controls.Add(this.label11);
            this.tp_instrumrntinformation.Controls.Add(this.label10);
            this.tp_instrumrntinformation.Controls.Add(this.label9);
            this.tp_instrumrntinformation.Controls.Add(this.pb_instrumentphoto);
            this.tp_instrumrntinformation.Location = new System.Drawing.Point(4, 22);
            this.tp_instrumrntinformation.Name = "tp_instrumrntinformation";
            this.tp_instrumrntinformation.Padding = new System.Windows.Forms.Padding(3);
            this.tp_instrumrntinformation.Size = new System.Drawing.Size(640, 274);
            this.tp_instrumrntinformation.TabIndex = 0;
            this.tp_instrumrntinformation.Text = "仪器信息";
            this.tp_instrumrntinformation.UseVisualStyleBackColor = true;
            // 
            // tb_ShowTime
            // 
            this.tb_ShowTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ShowTime.Location = new System.Drawing.Point(388, 210);
            this.tb_ShowTime.Name = "tb_ShowTime";
            this.tb_ShowTime.ReadOnly = true;
            this.tb_ShowTime.Size = new System.Drawing.Size(186, 21);
            this.tb_ShowTime.TabIndex = 15;
            // 
            // tb_ShowState
            // 
            this.tb_ShowState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ShowState.Location = new System.Drawing.Point(388, 163);
            this.tb_ShowState.Name = "tb_ShowState";
            this.tb_ShowState.ReadOnly = true;
            this.tb_ShowState.Size = new System.Drawing.Size(186, 21);
            this.tb_ShowState.TabIndex = 14;
            // 
            // tb_ShowName
            // 
            this.tb_ShowName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ShowName.Location = new System.Drawing.Point(388, 115);
            this.tb_ShowName.Name = "tb_ShowName";
            this.tb_ShowName.ReadOnly = true;
            this.tb_ShowName.Size = new System.Drawing.Size(186, 21);
            this.tb_ShowName.TabIndex = 13;
            // 
            // tb_ShowId
            // 
            this.tb_ShowId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ShowId.Location = new System.Drawing.Point(388, 65);
            this.tb_ShowId.Name = "tb_ShowId";
            this.tb_ShowId.ReadOnly = true;
            this.tb_ShowId.Size = new System.Drawing.Size(186, 21);
            this.tb_ShowId.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(281, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 21);
            this.label12.TabIndex = 11;
            this.label12.Text = "仪器编号：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(281, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 21);
            this.label11.TabIndex = 10;
            this.label11.Text = "仪器名称：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(281, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 21);
            this.label10.TabIndex = 9;
            this.label10.Text = "通过时间：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(281, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "通过状态：";
            // 
            // pb_instrumentphoto
            // 
            this.pb_instrumentphoto.BackColor = System.Drawing.Color.Transparent;
            this.pb_instrumentphoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_instrumentphoto.BackgroundImage")));
            this.pb_instrumentphoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_instrumentphoto.Location = new System.Drawing.Point(82, 65);
            this.pb_instrumentphoto.Name = "pb_instrumentphoto";
            this.pb_instrumentphoto.Size = new System.Drawing.Size(123, 140);
            this.pb_instrumentphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_instrumentphoto.TabIndex = 1;
            this.pb_instrumentphoto.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bt_instrument);
            this.tabPage1.Controls.Add(this.lv_instrumrntinformation);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(640, 274);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "仪器通过记录";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bt_instrument
            // 
            this.bt_instrument.Location = new System.Drawing.Point(555, 245);
            this.bt_instrument.Name = "bt_instrument";
            this.bt_instrument.Size = new System.Drawing.Size(75, 23);
            this.bt_instrument.TabIndex = 1;
            this.bt_instrument.Text = "清空";
            this.bt_instrument.UseVisualStyleBackColor = true;
            this.bt_instrument.Click += new System.EventHandler(this.bt_instrument_Click);
            // 
            // lv_instrumrntinformation
            // 
            this.lv_instrumrntinformation.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.lv_instrumrntinformation.AutoArrange = false;
            this.lv_instrumrntinformation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lv_instrumrntinformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_instrumrntinformation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_Insnumber,
            this.column_Insid,
            this.column_Insname,
            this.column_Insstate,
            this.column_Instime,
            this.column_postion});
            this.lv_instrumrntinformation.FullRowSelect = true;
            this.lv_instrumrntinformation.GridLines = true;
            this.lv_instrumrntinformation.Location = new System.Drawing.Point(8, 6);
            this.lv_instrumrntinformation.Name = "lv_instrumrntinformation";
            this.lv_instrumrntinformation.Size = new System.Drawing.Size(622, 231);
            this.lv_instrumrntinformation.TabIndex = 0;
            this.lv_instrumrntinformation.UseCompatibleStateImageBehavior = false;
            this.lv_instrumrntinformation.View = System.Windows.Forms.View.Details;
            // 
            // column_Insnumber
            // 
            this.column_Insnumber.Text = "序号";
            this.column_Insnumber.Width = 49;
            // 
            // column_Insid
            // 
            this.column_Insid.Text = "仪器编号";
            this.column_Insid.Width = 183;
            // 
            // column_Insname
            // 
            this.column_Insname.Text = " 仪器名称";
            this.column_Insname.Width = 82;
            // 
            // column_Insstate
            // 
            this.column_Insstate.Text = "通过状态";
            // 
            // column_Instime
            // 
            this.column_Instime.Text = "通过时间";
            this.column_Instime.Width = 121;
            // 
            // column_postion
            // 
            this.column_postion.Text = "货架位置";
            this.column_postion.Width = 155;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "通行时间";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "所属部门";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "人员编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1424, 862);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "仓库管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_employeephoto)).EndInit();
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
            this.tabControl2.ResumeLayout(false);
            this.tp_instrumrntinformation.ResumeLayout(false);
            this.tp_instrumrntinformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_instrumentphoto)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private Button button1;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.TextBox tb_temp;
        private System.Windows.Forms.TextBox tb_employeename;
        private System.Windows.Forms.TextBox tb_employeeunmber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
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
        private NotifyIcon notifyIcon1;
        private PictureBox pictureBox3;
        private DataGridView Dgv_DueToSee;
        private DataGridViewTextBoxColumn DueName;
        private DataGridViewTextBoxColumn DueTime;
        private DataGridViewTextBoxColumn DaysRemaining;
        private ToolStripMenuItem 归还ToolStripMenuItem;
        private Timer timer2;
        public PictureBox pb_employeephoto;
        private TabControl tabControl1;
        private TabPage tp_employeeinformation;
        private TabPage tp_allemployeeinformation;
        private TextBox tb_employeepassdoor;
        private Label label5;
        private ToolStripMenuItem 仪器位置查询ToolStripMenuItem;
        private ToolStripMenuItem 元器件位置查询ToolStripMenuItem;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private TabControl tabControl2;
        private TabPage tp_instrumrntinformation;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        public PictureBox pb_instrumentphoto;
        private TabPage tabPage1;
        private ColumnHeader column_Insid;
        private ColumnHeader column_Insname;
        private ColumnHeader column_Insstate;
        private ColumnHeader column_Instime;
        public ListView lv_instrumrntinformation;
        private ColumnHeader column_Insnumber;
        public TextBox tb_ShowTime;
        public TextBox tb_ShowState;
        public TextBox tb_ShowName;
        public TextBox tb_ShowId;
        private Button bt_instrument;
        private ListView lv_employeepassdoor;
        private ColumnHeader ch_employeenumber;
        private ColumnHeader ch_name;
        private ColumnHeader ch_temp;
        private ColumnHeader ch_passdoordatetime;
        private ColumnHeader ch_number;
        private Button bt_emptyemployeepassdoor;
        private ColumnHeader column_postion;
    }
}

