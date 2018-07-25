using cangku_01.LX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//添加仪器页面      观察者模式！！！写进卡里！！！

namespace cangku_01
{
    public partial class add_instrument : Form
    {
        Interface_instrument dao = new InterfaceImp_instrument();

        instrument ins = new instrument();      

        public add_instrument()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)      //取消按钮
        {
            //关闭当前页面
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)      //确定按钮
        {
            //点击确定,弹出输入信息,可以获取到输入的值
            
             List<instrument> s = Collection();
            foreach (instrument i in s) {
                MessageBox.Show("ID:" + i.tagId + "\r\n" + "name:" + i.name + i.model + i.manufactor +
                    i.serialNumber + i.productionDate + i.position + i.isInWareHouse + i.checkCycle  +
                    i.lastCheckTimes + i.instrumentNumber+i.manager+ "\r\n" +"获取到值，后期存到数据库中");

            }
            dao.Add_instrument(s);
                this.Close();
            
        }


        public List<instrument> Collection()        //输入的值放在数组中
        {
            List<instrument> list = new List<instrument>();
            instrument a = new instrument();

            a.tagId = int.Parse(tb_tagid.Text.ToString()) ;
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

            list.Add(a);
            return list;
        }

       
    }
}
