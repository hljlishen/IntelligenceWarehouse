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

        //仪器出入库查询类，对应模式中的Context类
        public class Query
        {
            private QueryState state;
            public Query(QueryState state)
            {
                this.state = state;
            }

            //选择出入库查询状态
            public void ChooseQueryState()
            {
                state.ChooseQueryState(this);
            }
            public QueryState State
            {
                get { return state; }
                set { state = value; }
            }
        }
        //抽象状态类
        public abstract class QueryState
        {
            public abstract void ChooseQueryState(Query query );
        }
        //具体状态类，出库查询
        public class OutInstrument : QueryState
        {
            //在出库查询的状态下，切换到入库查询状态
            public override void ChooseQueryState(Query query)
            {
                query.State = new InInstrument();
                
            }
        }
        //具体状态类，入库查询
        public class InInstrument : QueryState
        {
            //在入库查询状态下，切换到出库查询状态
            public override void ChooseQueryState(Query query)
            {
                query.State = new OutInstrument();
            }
        }
        //初始化状态，原始状态为出库查询
        Query query = new Query(new OutInstrument());
        private void tsmOutQuery_Click(object sender, EventArgs e)
        {

        }

        private void tsmInQuery_Click(object sender, EventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }






























        interfaces.InstrumentQuery dao = new InstrumentQueryImp();
        style sty = new style();
        String s = "请输入员工的姓名";
        instrument warehouse = new instrument();

        public InstrumentQuery()
        {
            InitializeComponent();
          
            //将全部出入库仪器加载
            List<instrument> allwarehouse = dao.AllWarehouse();

            //循环遍历
            foreach (instrument wh in allwarehouse)
            {
                //DataGridViewRow row = new DataGridViewRow();
                //int index = dataGridView1.Rows.Add(row);
                //dataGridView1.Rows[index].Cells[0].Value = wh.Warehouse_id;
                //dataGridView1.Rows[index].Cells[1].Value = wh.Warehouse_name;
                //dataGridView1.Rows[index].Cells[2].Value = wh.Location;
                //dataGridView1.Rows[index].Cells[3].Value = wh.Outbound_number;
                //dataGridView1.Rows[index].Cells[4].Value = wh.OutboundDate;
                //dataGridView1.Rows[index].Cells[5].Value = wh.Remaining_number;
                //dataGridView1.Rows[index].Cells[6].Value = wh.Model;
                //dataGridView1.Rows[index].Cells[7].Value = wh.Manufacturers;
                //dataGridView1.Rows[index].Cells[8].Value = wh.ProductionDate;
                //dataGridView1.Rows[index].Cells[9].Value = wh.Name;
                //dataGridView1.Rows[index].Cells[10].Value = wh.Principal;
                
            }
        }
        //调用方法固定页面
        private void Takeout_Warehouse_Load(object sender, EventArgs e)
        {
            this.tbname.Text = s;
            this.tbname.MouseClick += textBox1_MouseClick;
            this.tbname.Leave += textBox1_Leave;
            Top = 0;
            Left = 0;
            //初始化状态，原始状态为出库查询
        
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.tbname.Text.Trim() == s)
            {
                this.tbname.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (this.tbname.Text.Trim() == "")
            {
                this.tbname.Text = s;
            }
        }

        //搜索框
        private void bt_people_search_Click(object sender, EventArgs e)
        {
            //获取搜索框中的值
            String tb_text = tbname.Text;
            //根据搜索框的内容查询对应的值
            dao.FindUserByName(tb_text);
        }

        private void bt_time_search_Click(object sender, EventArgs e)
        {

            DateTime dt1 = Convert.ToDateTime(dtpstartdate.Value.Date.ToString("yyyy-MM-dd"));  //获取的日期1
            DateTime dt2 = Convert.ToDateTime(dtpenddate.Value.Date.ToString("yyyy-MM-dd"));   //获取的日期2,需增加部分代码使dt2大于dt1
            if (DateTime.Compare(dt1, dt2) > 0) //判断日期大小
            {

                MessageBox.Show("dateTimePicker1的日期大于dateTimePicker2的日期");
            }

            //根据搜索框的内容查询对应的值
            dao.FindDate(dt1,dt2);
        }
    }
}
