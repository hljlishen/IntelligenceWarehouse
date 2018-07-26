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

        //仪器出入库查询类，对应模式中的context类
        //public class query
        //{
        //    private querystate state;
        //    public query(querystate state)
        //    {
        //        this.state = state;
        //    }

        //    选择出入库查询状态
        //    public void choosequerystate()
        //    {
        //        state.choosequerystate(this);
        //    }
        //    public querystate state
        //    {
        //        get { return state; }
        //        set { state = value; }
        //    }
        //}
        //抽象状态类
        //public abstract class querystate
        //{
        //    public abstract void choosequerystate(query query);
        //}
        //具体状态类，出库查询
        //public class outinstrument : querystate
        //{
        //    在出库查询的状态下，切换到入库查询状态
        //    public override void choosequerystate(query query)
        //    {
        //        query.state = new ininstrument();

        //    }
        //}
        //具体状态类，入库查询
        //public class ininstrument : querystate
        //{
        //    在入库查询状态下，切换到出库查询状态
        //    public override void choosequerystate(query query)
        //    {
        //        query.state = new outinstrument();
        //    }
        //}
        //初始化状态，原始状态为出库查询
        //query query = new query(new outinstrument());
        


        interfaces.InstrumentQuery dao = new InstrumentQueryImp();
        String namehint = "请输入员工的姓名";
        String modelhint = "请输入仪器型号";
        instrument instrument = new instrument();

        public InstrumentQuery()
        {
            InitializeComponent();
          
            //将全部出入库仪器加载
            List<instrument> allwarehouse = dao.AllWarehouse();

            //循环遍历
            foreach (instrument wh in allwarehouse)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = dgvInstrumentOutQuery.Rows.Add(row);
                dgvInstrumentOutQuery.Rows[index].Cells[0].Value = wh.tagId;
                dgvInstrumentOutQuery.Rows[index].Cells[1].Value = wh.name;
                dgvInstrumentOutQuery.Rows[index].Cells[2].Value = wh.position;
                //dgvInstrumentOutQuery.Rows[index].Cells[3].Value = wh.outWarehouseNumber;
               // dgvInstrumentOutQuery.Rows[index].Cells[4].Value = wh.outWarehouseTime;
                dgvInstrumentOutQuery.Rows[index].Cells[5].Value = wh.instrumentNumber;
                dgvInstrumentOutQuery.Rows[index].Cells[6].Value = wh.model;
                dgvInstrumentOutQuery.Rows[index].Cells[7].Value = wh.manufactor;
                dgvInstrumentOutQuery.Rows[index].Cells[8].Value = wh.productionDate;
                //dgvInstrumentOutQuery.Rows[index].Cells[9].Value = wh.name;
                dgvInstrumentOutQuery.Rows[index].Cells[10].Value = wh.manager;

            }
        }
       
        private void Takeout_Warehouse_Load(object sender, EventArgs e)
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
        //搜索框
        private void bt_people_search_Click(object sender, EventArgs e)
        {
            //获取搜索框中的值
            String tb_name = tbname.Text;
            String tb_model = tbmodel.Text;
            //根据搜索框的内容查询对应的值
            dao.FindUserByName(tb_name);
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
