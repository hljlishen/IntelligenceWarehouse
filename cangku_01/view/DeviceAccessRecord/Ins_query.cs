using cangku_01.interfaceImp;
using cangku_01.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace cangku_01.MH
{
    //仪器出入库查询页面
    public partial class Ins_query : Form
    {
        QueryInstrumen dao = new QueryInstrumentImp();
        String borrowhint = "请输入借用人的姓名";
        String dutyhint = "请输入责任人的姓名";
        String modelhint = "请输入仪器的型号";
        String manufacturerhint = "请输入生产厂商";
        String taghint = "请输入标签ID";
        String cbquery = "出入库";

        public Ins_query()
        {
            InitializeComponent();
        }

        private void InstrumentQuery_Load(object sender, EventArgs e)
        {
            //借用人搜索提示
            this.tb_borrow.Text = borrowhint;
            this.tb_borrow.MouseClick += tbBorrow_MouseClick;
            //责任人搜索提示
            this.tb_duty.Text = dutyhint;
            this.tb_duty.MouseClick += tbDuty_MouseClick;
            //this.Tb_duty.Leave += tbDuty_Leave;
            //仪器型号搜索提示
            this.tb_model.Text = modelhint;
            this.tb_model.MouseClick += tbModel_MouseClick;
            //生产厂商搜索提示
            this.tb_manufacturer.Text = manufacturerhint;
            this.tb_manufacturer.MouseClick += tbManufacturer_MouseClick;
            //标签Id搜索提示
            this.tb_tag.Text = taghint;
            this.tb_tag.MouseClick += tbTag_MouseClick;
            //是否选择时间查询
            this.cb_choicetime.MouseClick += cb_openchoicetime_MouseClick;
            this.cb_choicetime.MouseClick+= cb_closechoicetime_MouseClick;
            //出入库下拉框中固定的值
            this.cb_query.Text = cbquery;
            //调用方法固定页面
            Top = 0;
            Left = 0;
        }

  

        //
        private void tbBorrow_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.tb_borrow.Text.Trim() == borrowhint)
            {
                this.tb_borrow.Text = "";
                this.tb_borrow.ForeColor = Color.FromName("#000000");
            }
        }

        //
        private void tbDuty_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.tb_duty.Text.Trim() == dutyhint)
            {
                this.tb_duty.Text = "";
                this.tb_duty.ForeColor = Color.FromName("#000000");
            }
        }
        //private void tbDuty_Leave(object sender, EventArgs e)
        //{
        //    if (this.Tb_duty.Text.Trim() == "")
        //    {
        //        this.Tb_duty.Text = dutyhint;
        //    }
        //}
        //
        private void tbModel_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.tb_model.Text.Trim() == modelhint)
            {
                this.tb_model.Text = "";
                this.tb_model.ForeColor = Color.FromName("#000000");
            }
        }
        //
        private void tbManufacturer_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.tb_manufacturer.Text.Trim() == manufacturerhint)
            {
                this.tb_manufacturer.Text = "";
                this.tb_manufacturer.ForeColor = Color.FromName("#000000");
            }
        }
        //
        private void tbTag_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.tb_tag.Text.Trim() == taghint)
            {
                this.tb_tag.Text = "";
                this.tb_tag.ForeColor = Color.FromName("#000000");
            }
        }

        private void Btnquery_Click(object sender, EventArgs e)
        {
            //获取搜索框中的值
            String tb_Borrow = tb_borrow.Text;
            //借用人姓名校验
            //中文名字，不能是数字或英文
            //if (!Regex.IsMatch(tb_borrow.ToString(), @"[\u4e00-\u9fbb]"))
            //{
            //    tt_checkborrow.Show("借用人姓名输入错误 ", this.tb_borrow);

            //}
            //else
            //{
            //    this.tt_checkborrow.Hide(this.tb_borrow);
            //}
 
             //根据搜索框的内容查询
             dao.FindInstrumentByBorrow(tb_Borrow);

            //获取搜索框中的值
            String tb_Duty = tb_duty.Text;
            //责任人姓名校验
            //中文名字，不能是数字或英文
            //if (!Regex.IsMatch(tb_duty.ToString(), @"[\u4e00-\u9fbb]"))
            //{
            //    tt_checkduty.Show("责任人姓名输入错误 ",this.tb_duty);
            //}
            //else
            //{
            //    this.tt_checkduty.Hide(this.tb_duty);
            //}
            //根据搜索框的内容查询
            dao.FindInstrumentByDuty(tb_Duty);

            //获取搜索框中的值
            string tb_model = this.tb_model.Text;
            //仪器型号校验
            //可以是数字英文或中文
            //if (!Regex.IsMatch(tb_model.ToString(), @"^[\u4e00-\u9fa5_a-za-z0-9]+$"))
            //{
            //    tt_checkmodel.Show("仪器型号输入错误 ",this.tb_model);
            //}
            //else
            //{
            //    this.tt_checkmodel.Hide(this.tb_model);
            //}
            //根据搜索框的内容查询
            dao.FindInstrumentByModel(tb_model);

            //获取搜索框中的值
            String tb_Manufacturer = tb_manufacturer.Text;
            //生产厂商校验
            //英文或中文
            //if (!Regex.IsMatch(tb_manufacturer.ToString(), @"^[\u4e00-\u9fa5_a-za-z0-9]+$"))
            //{
            //    tt_checkmanufacturer.Show("生产厂商输入错误 ",this.tb_manufacturer);
            //}
            //else
            //{
            //    this.tt_checkmanufacturer.Hide(this.tb_manufacturer);
            //}
            //根据搜索框的内容查询
            dao.FindInstrumentByManufacturer(tb_Manufacturer);

            //获取时间
            DateTime begin = Convert.ToDateTime(dtp_begin.Value.Date.ToString());  //获取开始日期
            DateTime end = Convert.ToDateTime(dtp_end.Value.Date.ToString());   //获取结束日期
            //日期校验
            if (DateTime.Compare(begin, end) > 0)
            {
                tt_checktime.Show("开始时间大于结束时间 ", this.dtp_end);
            }
            else
            {
                this.tt_checktime.Hide(this.dtp_end);
            }
            //根据搜索框的内容查询
            dao.FindInstrumentBetween(begin, end);
        }

        private void cb_openchoicetime_MouseClick(object sender, MouseEventArgs e)
        {
            if (cb_choicetime.Checked.Equals(true))
            {
                dtp_begin.Enabled = true;
                dtp_end.Enabled = true;
                
            }
        }
        private void cb_closechoicetime_MouseClick(object sender, MouseEventArgs e)
        {
            if (cb_choicetime.Checked.Equals(false))
            {
                dtp_begin.Enabled = false;
                dtp_end.Enabled = false;
            }
        }

    }
}
