using System;
using System.Drawing;
using System.Windows.Forms;
using cangku_01.entity;
using cangku_01.interfaceImp;
using cangku_01.interfaces;

//添加仪器  观察者模式

namespace cangku_01.view.InstrumentManagement
{
    public partial class AddOrAlterInstrument : Form 
    {
        private InstrumentManagement fr;
        Instrument ins = new Instrument();
        private int index;

        //仪器信息添加构造方法
        public AddOrAlterInstrument(InstrumentManagement fr)
        {
            InitializeComponent();
            this.fr = fr;
            title.Text = "添加仪器基本信息";
            this.pb_instrumentphoto.Image = Image.FromFile(Application.StartupPath + @"\..\..\..\image\InstrumentPhoto\" + "仪器" + ".png");
            bt_alterinstrument.Visible = false;
        }

        //仪器信息修改构造方法
        public AddOrAlterInstrument(InstrumentManagement fr, Instrument ins ,int index)
        {
            InitializeComponent();
            this.fr = fr;
            this.index = index;
            title.Text = "修改仪器基本信息";
            this.pb_instrumentphoto.Image = Image.FromFile(Application.StartupPath + @"\..\..\..\image\InstrumentPhoto\" + ins.TagId + ".png");
            bt_addinstrument.Visible = false;
            tb_tagid.Text = ins.TagId;
            tb_name.Text = ins.Name;
            tb_model.Text = ins.Model;
            tb_manufactor.Text = ins.Manufactor;
            tb_serialNumber.Text = ins.SerialNumber;
            time_productionDate.Text = ins.ProductionDate.ToString();
            tb_position.Text = ins.Position;
            cb_isInWareHouse.Text = ins.IsInWareHouse;
            tb_checkCycle.Text = ins.CheckCycle.ToString();
            time_lastCheckTimes.Text = ins.LastCheckTimes.ToString();
            tb_duty.Text = ins.Duty;
        }

        private void AddOrModifyInstrument_Load(object sender, EventArgs e)
        {
            this.cb_isInWareHouse.Text = "在库";
        }

        //取消按钮
        private void bt_close_Click_1(object sender, EventArgs e)     
        {
            this.Close();
        }

        //仪器信息添加
        private void bt_addinstrument_Click(object sender, EventArgs e)    
        {
            InstrumentInterface dao = new InstrumentInterfaceImp();
            dao.AddInstrument(GetInstrumentInformation());
            index = fr.dgv_instrumentinformation.Rows.Add();
            this.AddOneEmployeeToTheDataGridView();
        }

        //获取仪器信息
        public Instrument GetInstrumentInformation()
        {
            ins.TagId = tb_tagid.Text;
            ins.Name = tb_name.Text;
            ins.Model = tb_model.Text;
            ins.Manufactor = tb_manufactor.Text;
            ins.SerialNumber = tb_serialNumber.Text;
            ins.ProductionDate = Convert.ToDateTime(time_lastCheckTimes.Text);
            ins.Position = tb_position.Text;
            ins.IsInWareHouse = cb_isInWareHouse.Text;
            ins.CheckCycle = int.Parse(tb_checkCycle.Text);
            ins.LastCheckTimes = Convert.ToDateTime(time_lastCheckTimes.Text);
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
            fr.dgv_instrumentinformation.Rows[index].Cells[4].Value = ins.SerialNumber;
            fr.dgv_instrumentinformation.Rows[index].Cells[5].Value = ins.ProductionDate.ToShortDateString();
            fr.dgv_instrumentinformation.Rows[index].Cells[6].Value = ins.Position;
            fr.dgv_instrumentinformation.Rows[index].Cells[7].Value = ins.IsInWareHouse;
            fr.dgv_instrumentinformation.Rows[index].Cells[8].Value = ins.CheckCycle;
            fr.dgv_instrumentinformation.Rows[index].Cells[9].Value = ins.LastCheckTimes.ToShortDateString();
            fr.dgv_instrumentinformation.Rows[index].Cells[10].Value = ins.Duty;
        }

        //仪器信息修改
        private void bt_alterinstrument_Click(object sender, EventArgs e)
        {
            InstrumentInterface dao = new InstrumentInterfaceImp();
            dao.UpdateInstrument(GetInstrumentInformation());
            fr.dgv_instrumentinformation.Rows.RemoveAt(index);
            index = fr.dgv_instrumentinformation.Rows.Add();
            this.AddOneEmployeeToTheDataGridView();

        }
    }


}
