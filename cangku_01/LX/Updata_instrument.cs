using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//修改仪器页面        观察者模式！！！  卡片信息也修改！！

namespace cangku_01.LX
{
    public partial class Updata_instrument : Form
    {
        Interface_instrument dao = new InterfaceImp_instrument();

        instrument ins = new instrument();

        

        public Updata_instrument()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//确定按钮
        {
            List<instrument> s = Updata_Collection();
            foreach (instrument i in s)
            {
                MessageBox.Show("ID:" + i.tagId + "\r\n" + "name:" + i.name + i.model + i.manufactor +
                    i.serialNumber + i.productionDate + i.position + i.isInWareHouse + i.checkCycle +
                    i.previousCheckTimes + i.manager + "\r\n" + "获取到值，后期存到数据库中");

            }
            dao.Alter_instrument(s);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)//取消按钮
        {
            this.Close();
        }

        
        public List<instrument> Updata_Collection()        //输入的值放在数组中
        {
            List<instrument> list = new List<instrument>();
            instrument a = new instrument();
            a.tagId = -1;                        //   不能修改id   int.Parse(tb_tagid.Text.ToString());
            a.name = tb_name.Text.ToString();
            a.model = tb_model.Text.ToString();
            a.manufactor = tb_manufactor.Text.ToString();
            a.serialNumber = tb_serialNumber.Text.ToString();
            a.productionDate = Convert.ToDateTime(time_productionDate.Text.ToString());
            a.position = tb_position.Text.ToString();
            a.isInWareHouse = tb_isInWareHouse.Text.ToString();
            a.checkCycle = tb_checkCycle.Text.ToString();
            a.previousCheckTimes = tb_previousCheckTimes.Text.ToString();
            a.manager = tb_manager.Text.ToString();

            list.Add(a);
            return list;
        }
    }
}
