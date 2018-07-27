using cangku_01.LX;
using cangku_01.MH.interfaceImp;
using cangku_01.MH.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace cangku_01.MH
{
    //仪器出入库查询页面
    public partial class InstrumentQuery : Form
    {
        interfaces.InstrumentQuery dao = new InstrumentQueryImp();
        String namehint = "请输入员工的姓名";
        String modelhint = "请输入仪器型号";
        instrument instrument = new instrument();

        public InstrumentQuery()
        {
            InitializeComponent();
        }


        private void InstrumentQuery_Load(object sender, EventArgs e)
        {
            //员工搜索提示
            this.tbname.Text = namehint;
            this.tbname.MouseClick += tbName_MouseClick;
            this.tbname.Leave += tbName_Leave;
            //型号搜索提示
            this.tbmodel.Text = modelhint;
            this.tbmodel.MouseClick += tbModel_MouseClick;
            this.tbmodel.Leave += tbModel_Leave;
            //调用方法固定页面
            Top = 0;
            Left = 0;
        }
        private void tbName_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.tbname.Text.Trim() == namehint)
            {
                this.tbname.Text = "";
            }
        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            if (this.tbname.Text.Trim() == "")
            {
                this.tbname.Text = namehint;
            }
        }

        private void tbModel_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.tbmodel.Text.Trim() == modelhint)
            {
                this.tbmodel.Text = "";
            }
        }

        private void tbModel_Leave(object sender, EventArgs e)
        {
            if (this.tbmodel.Text.Trim() == "")
            {
                this.tbmodel.Text = modelhint;
            }
        }

        private void btnquery_Click(object sender, EventArgs e)
        {
            //获取搜索框中的值
            String tb_name = tbname.Text;
            String tb_model = tbmodel.Text;

            DateTime dt1 = Convert.ToDateTime(dtpstartdate.Value.Date.ToString());  //获取的日期1
            DateTime dt2 = Convert.ToDateTime(dtpenddate.Value.Date.ToString());   //获取的日期2,需增加部分代码使dt2大于dt1
            if (DateTime.Compare(dt1, dt2) > 0) //判断日期大小
            {

                MessageBox.Show("dateTimePicker1的日期大于dateTimePicker2的日期");
            }
            //根据搜索框的内容查询对应的值
            dao.FindUserByName(tb_name);
            //根据搜索框的内容查询对应的值
            dao.FindDate(dt1, dt2);
        }




        public class Query
        {
            public State state { get; set; }

            //出库
            public void Queryout()
            {

            }
            //入库
            public void Queryin()
            {

            }
            //出入库
            public void Queryoutandin()
            {

            }
            //抽象状态类
            public abstract class State
            {
                public abstract void Queryout();//出库
                public abstract void Queryin(); //入库
                public abstract void Queryoutandin(); //出入库
            }
            //在出库状态下切换到入库和出入库
            public class QueryoutState : State
            {
                //入库
                public override void Queryin()
                {
                    Console.WriteLine("切换到入库");
                }
                //不变
                public override void Queryout()
                {
                    Console.WriteLine("不变");
                }
                //出入库
                public override void Queryoutandin()
                {
                    Console.WriteLine("切换到出入库");
                }
            }

            //在入库状态下切换到出库和出入库
            public class QueryinState : State
            {
                //不变
                public override void Queryin()
                {
                    Console.WriteLine("不变");
                }
                //出库
                public override void Queryout()
                {
                    Console.WriteLine("切换到出库");
                }
                //出入库
                public override void Queryoutandin()
                {
                    Console.WriteLine("切换到出入库");
                }
            }
            //在出入库状态下切换到出库和入库
            public class QueryoutandinState : State
            {
                //入库
                public override void Queryin()
                {
                    Console.WriteLine("切换到入库");
                }
                //出库
                public override void Queryout()
                {
                    Console.WriteLine("切换到出入库");
                }
                //不变
                public override void Queryoutandin()
                {
                    Console.WriteLine("不变");
                }
            }

        }
    }
}
