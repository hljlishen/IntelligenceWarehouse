using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using cangku_01.entity;
using cangku_01.interfaceImp;
using cangku_01.interfaces;
using cangku_01.UHFReader09;
using cangku_01.UHFReader09CSharp;
using static cangku_01.view.AdminPage.AutoCloseMassageBox;

//添加仪器  观察者模式

namespace cangku_01.view.InstrumentManagement
{
    public partial class AddOrUpdateInstrument : Form 
    {
        private InstrumentManagement fr;
        Instrument ins = new Instrument();
        private int index;
        private static UHFReader09Interface ReaderDrive;

        //仪器信息添加构造方法
        public AddOrUpdateInstrument(InstrumentManagement fr, UHFReader09Interface readerDrive)
        {
            InitializeComponent();
            this.fr = fr;
            title.Text = "添加仪器基本信息";
            cb_isInWareHouse.Text = "在库";
            ReaderDrive = readerDrive;
            ReaderDrive.OpenConnectReader();
            ReaderDrive.TagConnected += ReaderAddDrive_TagConnected;
            tb_tagid.ReadOnly = true;
            bt_alterinstrument.Visible = false;
            tb_isInWareHouse.Visible = false;
            tb_productionDate.Visible = false;
            tb_lastCheckTimes.Visible = false;
            cb_allcheckdate.Visible = false;
            la_allcheckdate.Visible = false;
            pb_instrumentphoto.Image = Image.FromFile(Application.StartupPath + @"\..\..\..\image\InstrumentPhoto\" + "仪器" + ".png");
        }

        private void ReaderAddDrive_TagConnected(string tagId)
        {
            tb_tagid.Text = tagId;
        }

        //仪器信息修改构造方法
        public AddOrUpdateInstrument(InstrumentManagement fr, Instrument ins ,int index, UHFReader09Interface readerDrive)
        {
            InitializeComponent();
            this.fr = fr;
            this.index = index;
            title.Text = "修改仪器基本信息";
            ReaderDrive = readerDrive;
            ReaderDrive.OpenConnectReader();
            ReaderDrive.TagConnected += ReaderUpdateDrive_TagConnected;
            tb_tagid.ReadOnly = true;
            this.ins = ins;
            bt_addinstrument.Visible = false;
            tb_isInWareHouse.Visible = false;
            tb_productionDate.Visible = false;
            tb_lastCheckTimes.Visible = false;
            cb_allcheckdate.Visible = false;
            la_allcheckdate.Visible = false;
            ShowInstrumentPhoto();
            InstrumentMessageDataTableShowTextBox();
        }

        private void ReaderUpdateDrive_TagConnected(string tagId)
        {
            if (tb_tagid.Text != tagId)
            {
                bt_alterinstrument.Enabled = false;
            }
            else
            {
                bt_alterinstrument.Enabled = true;
            }
        }

        //仪器信息详情构造方法
        public AddOrUpdateInstrument(Instrument ins)
        {
            InitializeComponent();
            title.Text = "查看仪器基本信息";
            bt_addinstrument.Visible = false;
            bt_alterinstrument.Visible = false;
            time_lastCheckTimes.Visible = false;
            time_productionDate.Visible = false;
            cb_isInWareHouse.Visible = false;
            this.ins = ins;
            RemindInterface dao = new CheckTimeQueryAndUpdate();
            DataSet ds = dao.QueryInstrumentAllCheckDate(ins);
            cb_allcheckdate.DataSource = ds.Tables[0];
            cb_allcheckdate.DisplayMember = "ch_date";
            cb_allcheckdate.ValueMember = "ch_date";
            SettingAllTextBoxReadOnly();
            ShowInstrumentPhoto();
            InstrumentMessageDataTableShowTextBox();
        }

        //设置页面信息为只读
        public void SettingAllTextBoxReadOnly()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox).ReadOnly = true;
                }
            }
        }

        //仪器信息展示在页面组件中
        public void InstrumentMessageDataTableShowTextBox()
        {
            InstrumentInterface dao = new InstrumentDataManipulation();
           
            DataTable dt = dao.TagIdQueryInstrument(ins);
            tb_tagid.Text = ins.TagId;
            DataRow myDr = dt.Rows[0];
            tb_name.Text = myDr["in_name"].ToString();
            tb_model.Text = myDr["in_model"].ToString();
            tb_manufactor.Text = myDr["in_manufactor"].ToString();
            tb_serialNumber.Text = myDr["in_serialnumber"].ToString();
            tb_position.Text = myDr["in_position"].ToString();
            tb_checkCycle.Text = myDr["in_checkcycle"].ToString();
            tb_duty.Text = myDr["in_duty"].ToString();
            if (title.Text.Equals("查看仪器基本信息"))
            {
                tb_productionDate.Text = ins.DateFormatConversion((DateTime)myDr["in_productiondate"]);
                tb_lastCheckTimes.Text = ins.DateFormatConversion((DateTime)myDr["in_lastchecktimes"]);
                tb_isInWareHouse.Text = myDr["in_isinwarehouse"].ToString();
                return;
            }
            time_productionDate.Text = myDr["in_productiondate"].ToString();
            time_lastCheckTimes.Text = myDr["in_lastchecktimes"].ToString();
            cb_isInWareHouse.Text = myDr["in_isinwarehouse"].ToString();
        }

        private void AddOrModifyInstrument_Load(object sender, EventArgs e)
        {
           
        }

        //获取仪器照片地址
        public void ShowInstrumentPhoto()
        {
            FileInfo f = new FileInfo(Application.StartupPath + @"\..\..\..\image\InstrumentPhoto\" + ins.TagId + ".png");
            if (f.Exists)
            {
                this.pb_instrumentphoto.Image = Image.FromFile(Application.StartupPath + @"\..\..\..\image\InstrumentPhoto\" + ins.TagId + ".png");
            }
            else
            {
                this.pb_instrumentphoto.Image = Image.FromFile(Application.StartupPath + @"\..\..\..\image\InstrumentPhoto\" + "仪器" + ".png");
            }
        }

        //取消按钮
        private void bt_close_Click_1(object sender, EventArgs e)     
        {
            this.Close();
        }

        //仪器信息添加
        private void bt_addinstrument_Click(object sender, EventArgs e)    
        {
            InstrumentInterface dao = new InstrumentDataManipulation();
            dao.AddInstrument(GetInstrumentInformation());
            AutoClosingMessageBox.Show("仪器信息保存成功", "仪器信息添加", 1000);
            GetWriteCardInformation();
            index = fr.dgv_instrumentinformation.Rows.Add();
            AddOneEmployeeToTheDataGridView();
            ResetPageInformation();
        }

        //重置页面信息
        public void ResetPageInformation()
        {
            foreach (Control ctr in Controls)
            {
                if (ctr is TextBox)//考虑是文本框的话
                {
                    ((TextBox)ctr).Text = String.Empty;
                }
            }
            cb_isInWareHouse.Text = "入库";
        }

        //获取仪器信息
        public Instrument GetInstrumentInformation()
        {
            ins.TagId = tb_tagid.Text;
            ins.Name = tb_name.Text;
            ins.Model = tb_model.Text;
            ins.Manufactor = tb_manufactor.Text;
            ins.SerialNumber = tb_serialNumber.Text;
            ins.ProductionDate = Convert.ToDateTime(time_productionDate.Text);
            ins.Position = tb_position.Text;
            ins.IsInWareHouse = cb_isInWareHouse.Text;
            ins.CheckCycle = int.Parse(tb_checkCycle.Text);
            ins.LastCheckTime = Convert.ToDateTime(time_lastCheckTimes.Text);
            ins.Duty = tb_duty.Text;
            return ins;
        }

        //给DataGridView添加一行数据
        public void AddOneEmployeeToTheDataGridView()
        {
            fr.dgv_instrumentinformation.Rows[index].Cells[0].Value = ins.TagId;
            fr.dgv_instrumentinformation.Rows[index].Cells[1].Value = ins.Name;
            fr.dgv_instrumentinformation.Rows[index].Cells[2].Value = ins.Model;
            fr.dgv_instrumentinformation.Rows[index].Cells[3].Value = ins.Manufactor;
            fr.dgv_instrumentinformation.Rows[index].Cells[4].Value = ins.Position;
            fr.dgv_instrumentinformation.Rows[index].Cells[5].Value = ins.IsInWareHouse;
            fr.dgv_instrumentinformation.Rows[index].Cells[6].Value = ins.Duty;
        }

        //仪器信息修改
        private void bt_alterinstrument_Click(object sender, EventArgs e)
        {
            InstrumentInterface dao = new InstrumentDataManipulation();
            dao.UpdateInstrument(GetInstrumentInformation());
            AutoClosingMessageBox.Show("仪器信息修改成功", "仪器信息修改", 1000);
            GetWriteCardInformation();
            fr.dgv_instrumentinformation.Rows.RemoveAt(index);
            index = fr.dgv_instrumentinformation.Rows.Add();
            this.AddOneEmployeeToTheDataGridView();
            Close();
        }

        //获取到写入卡的信息
        private void GetWriteCardInformation()
        {
            string name="";
            string model = "";
            string position = "";
            string duty = "";
            foreach (char letter in ins.Name.ToCharArray())
            {
                name = String.Format("{0:X}", Convert.ToInt32(letter));
            }
            foreach (char letter in ins.Model.ToCharArray())
            {
                model = String.Format("{0:X}", Convert.ToInt32(letter));
            }
            foreach (char letter in ins.Position.ToCharArray())
            {
                position = String.Format("{0:X}", Convert.ToInt32(letter));
            }
            string a = ins.CheckCycle.ToString("x4");//十进制转十六进制
            string checkcycle = a.ToString();//十六进制转ascii
            foreach (char letter in ins.Duty.ToCharArray())
            {
                duty = String.Format("{0:X}", Convert.ToInt32(letter));
            }
            string writedata = name + model + position + checkcycle + duty;
            ReaderDrive.WriteCardInformation(writedata);
        }

        //注销事件
        private void AddOrUpdateInstrument_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReaderDrive.TagConnected -= ReaderAddDrive_TagConnected;
            ReaderDrive.TagConnected -= ReaderUpdateDrive_TagConnected;
        }
    }
}
