using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//添加仪器，修改仪器界面      观察者模式
namespace cangku_01.LX
{
    public partial class AddOrModifyInstrument : Form 
    {
        Interface_instrument dao = new InterfaceImp_instrument();
        instrument ins = new instrument();

        public AddOrModifyInstrument()
        {
            InitializeComponent();
            title.Text = "添加仪器基本信息";
        }

        public AddOrModifyInstrument(string[] alter_instrumenta)       
        {
            InitializeComponent();
            title.Text = "修改仪器基本信息";
            tb_tagid.ReadOnly = Boolean.Parse("true");     
            tb_tagid.Text = alter_instrumenta[0];
            tb_name.Text = alter_instrumenta[1];
            tb_model.Text = alter_instrumenta[2];
            tb_manufactor.Text = alter_instrumenta[3];
            tb_serialNumber.Text = alter_instrumenta[4];
            time_productionDate.Text = alter_instrumenta[5];
            tb_position.Text = alter_instrumenta[6];
            tb_isInWareHouse.Text = alter_instrumenta[7];
            tb_checkCycle.Text = alter_instrumenta[8];
            time_lastCheckTimes.Text = alter_instrumenta[9];
            tb_instrumentNumber.Text = alter_instrumenta[10];
            tb_manager.Text = alter_instrumenta[11];
          
        }


        //取消按钮
        private void bt_no_Click_1(object sender, EventArgs e)     
        {
            this.Close();
        }

        //确定按钮
        private void bt_yes_Click(object sender, EventArgs e)    
        {
            instrument a = new instrument();
            a.tagId = int.Parse(tb_tagid.Text.ToString());
            a.name = tb_name.Text.ToString();
            a.model = tb_model.Text.ToString();
            a.manufactor = tb_manufactor.Text.ToString();
            a.serialNumber = tb_serialNumber.Text.ToString();
            a.productionDate = Convert.ToDateTime(time_productionDate.Text.ToString());
            a.position = tb_position.Text.ToString();
            a.isInWareHouse = Boolean.Parse(tb_isInWareHouse.Text.ToString());
            a.checkCycle = int.Parse(tb_checkCycle.Text.ToString());
            a.lastCheckTimes = Convert.ToDateTime(time_lastCheckTimes.Text.ToString());
            a.instrumentNumber = int.Parse(tb_instrumentNumber.Text.ToString());
            a.manager = tb_manager.Text.ToString();
            int i = dao.Modify_instrument(a);
            this.Close();
        }

        private void AddOrModifyInstrument_Load(object sender, EventArgs e)
        {

        }
    }


}
