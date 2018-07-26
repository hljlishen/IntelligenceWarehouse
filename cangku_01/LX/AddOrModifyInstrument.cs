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

        int addormodify;

        public AddOrModifyInstrument()
        {
            InitializeComponent();
        }



        public AddOrModifyInstrument(int a)        //赋值判断什么操作
        {
            this.addormodify = a;
            InitializeComponent();
            if(addormodify == 0)
            {
                title.Text = "添加仪器基本信息";
            }
            if (addormodify == 1)
            {
                title.Text = "修改仪器基本信息";
                tb_tagid.ReadOnly = Boolean.Parse("true");     //id不可编辑
                tb_tagid.Text = "1";
                tb_name.Text = "仪器";
               tb_model.Text = "规格";
                tb_manufactor.Text = "生产厂商";
                tb_serialNumber.Text = "出厂编号";
                time_productionDate.Text = "2008-07-12";
                tb_position.Text = "货架位置";
                tb_isInWareHouse.Text = "true";
                tb_checkCycle.Text = "2";
                time_lastCheckTimes.Text = "2010-07-12";
                tb_instrumentNumber.Text = "123";
                tb_manager.Text = "负责人";
            }
        }



        private void bt_no_Click_1(object sender, EventArgs e)      //取消按钮
        {
            //关闭当前页面
            this.Close();
        }


        private void bt_yes_Click(object sender, EventArgs e)      //确定按钮
        {
            if (addormodify == 0) {             //添加  0
               
                List<instrument> s = Collection();
                foreach (instrument i in s)
                {   //点击确定,弹出输入信息,可以获取到输入的值
                    MessageBox.Show("添加"+"\r\n"+"ID:" + i.tagId +  "name:" + i.name + i.model + i.manufactor +
                        i.serialNumber + i.productionDate + i.position + i.isInWareHouse + i.checkCycle +
                        i.lastCheckTimes + i.instrumentNumber + i.manager + "\r\n" + "获取到值，后期存到数据库中");
                }
                dao.Add_instrument(s);
                this.Close();
            }
            if (addormodify == 1)           //修改
            {
              
                List<instrument> s = Collection();
                foreach (instrument i in s)
                {   //点击确定,弹出输入信息,可以获取到输入的值
                    MessageBox.Show("修改" + "\r\n" + "ID:" + i.tagId + "name:" + i.name + i.model + i.manufactor +
                        i.serialNumber + i.productionDate + i.position + i.isInWareHouse + i.checkCycle +
                        i.lastCheckTimes + i.instrumentNumber + i.manager + "\r\n" + "获取到值，后期存到数据库中");
                }
                dao.Modify_instrument(s);
                this.Close();
               
            }
            

            

        }


        public List<instrument> Collection()        //输入的值放在数组中
        {
            List<instrument> list = new List<instrument>();
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

            list.Add(a);
            return list;
        }

       
    }
}
