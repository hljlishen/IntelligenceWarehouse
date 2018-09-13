using System;
using System.Data;
using System.Windows.Forms;
using cangku_01.entity;
using cangku_01.interfaceImp;
using cangku_01.interfaces;
using cangku_01.GateDrive;
using System.IO;
using System.Drawing;
using cangku_01.view.TheWarehouseHomePage;
using System.ComponentModel;

namespace cangku_01
{
    public partial class Form1 : Form , IDataDisplayer
    {
        GateInterface gate = new GateInterfaceImp();
        ConnectFingerprint connectFingerprint = ConnectFingerprint.GetInstance();
        delegate void EmployeeDataHandler(Fingerprint fingerprint);
        ListViewItem listView = new ListViewItem();

        public Form1()
        {
            InitializeComponent();
            //添加皮肤
            skinEngine1.SkinFile = "Longhorn.ssk";
            //防止屏幕闪烁
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            gate.StartDetect(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //gate.Open();
            connectFingerprint.GetIPConnect();
            connectFingerprint.AddDisplayer(this);
            DueToRemind();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        //首页——到期提醒
        private void DueToRemind()
        {
            RemindInterface dao = new CheckTimeQueryAndUpdate();
            DataTable dt = dao.QueryRemindInstrument();
            Instrument ins = new Instrument();
            Dgv_DueToSee.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = Dgv_DueToSee.Rows.Add(row);
                ins.LastCheckTime = (DateTime)dr["in_lastchecktimes"];
                ins.CheckCycle = (int)dr["in_checkcycle"]; ;
                Dgv_DueToSee.Rows[index].Cells[0].Value = dr["in_name"];
                Dgv_DueToSee.Rows[index].Cells[1].Value = ins.NextCheckTimes();
                Dgv_DueToSee.Rows[index].Cells[2].Value = ins.TimeRemaining();
            }
            Dgv_DueToSee.Sort(Dgv_DueToSee.Columns[2], ListSortDirection.Ascending);
        }

        //跳转到登录界面
        private void 管理员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form login = new login();
            login.Show();

        }

        //线程触发
        public void FingerprintUpdate(Fingerprint fingerprint)
        {
            Invoke(new EmployeeDataHandler(UpdateEmployee), new object[] { fingerprint });
        }

        //展示指纹信息
        private void UpdateEmployee(Fingerprint fingerprint)
        {
            EmployeesInterface dao = new EmployeeDataManipulation();
            Employee em = new Employee();
            em.EmployeeNumber = fingerprint.fi_employeenumber;
            DataTable dt = dao.EmployeeNumberQueryEmployee(em);
            DataRow myDr = dt.Rows[0];
            tb_employeeunmber.Text = em.EmployeeNumber;
            tb_employeename.Text = myDr["em_name"].ToString();
            tb_temp.Text = myDr["em_department"].ToString();
            tb_employeepassdoor.Text = fingerprint.fi_passtime.ToString();
            ShowEmployeePhoto(em);

            listView = lv_employeepassdoor.Items.Add((lv_employeepassdoor.Items.Count + 1).ToString());
            listView.SubItems.Add(em.EmployeeNumber);
            listView.SubItems.Add(myDr["em_name"].ToString());
            listView.SubItems.Add(myDr["em_department"].ToString());
            listView.SubItems.Add(fingerprint.fi_passtime.ToString());
        }

        //展示员工照片
        private void ShowEmployeePhoto(Employee em)
        {
            FileInfo f = new FileInfo(Application.StartupPath + @"\..\..\..\image\EmployeePhoto\" + em.EmployeeNumber + ".png");
            if (f.Exists)
            {
                pb_employeephoto.Image = Image.FromFile(Application.StartupPath + @"\..\..\..\image\EmployeePhoto\" + em.EmployeeNumber + ".png");
            }
            else
            {
                pb_employeephoto.Image = Image.FromFile(Application.StartupPath + @"\..\..\..\image\EmployeePhoto\" + "人员相片" + ".png");
            }
        }

        //点击关闭按钮
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = MessageBox.Show("是否退出？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //点击查询按钮
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form login = new login();
            login.ShowDialog();
        }

        //清空仪器出入表
        private void bt_instrument_Click(object sender, EventArgs e)
        {
            lv_instrumrntinformation.Items.Clear();
        }

        //清空员工指纹表
        private void bt_emptyemployeepassdoor_Click(object sender, EventArgs e)
        {
            lv_employeepassdoor.Items.Clear();
        }

        //仪器位置查询
        private void 仪器位置查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Find_Items queryinstrument = new Find_Items();
            queryinstrument.ShowDialog();
        }
    }
}
