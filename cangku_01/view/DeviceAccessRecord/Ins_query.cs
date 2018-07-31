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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace cangku_01.MH
{
    //仪器出入库查询页面
    public partial class Ins_query : Form
    {
        Instrumen_query dao = new InstrumentImp_query();
        String borrowhint = "请输入借用人的姓名";
        String dutyhint = "请输入责任人的姓名";
        String modelhint = "请输入仪器的型号";
        String manufacturerhint = "请输入生产厂商";
        String cbquery = "出入库";

        public Ins_query()
        {
            InitializeComponent();
        }

        private void InstrumentQuery_Load(object sender, EventArgs e)
        {
            //借用人搜索提示
            this.Tb_borrow.Text = borrowhint;
            this.Tb_borrow.MouseClick += tbBorrow_MouseClick;
            this.Tb_borrow.Leave += tbBorrow_Leave;
            //责任人搜索提示
            this.Tb_duty.Text = dutyhint;
            this.Tb_duty.MouseClick += tbDuty_MouseClick;
            this.Tb_duty.Leave += tbDuty_Leave;
            //仪器型号搜索提示
            this.Tb_model.Text = modelhint;
            this.Tb_model.MouseClick += tbModel_MouseClick;
            this.Tb_model.Leave += tbModel_Leave;
            //生产厂商搜索提示
            this.Tb_manufacturer.Text = manufacturerhint;
            this.Tb_manufacturer.MouseClick += tbManufacturer_MouseClick;
            this.Tb_manufacturer.Leave += tbManufacturer_Leave;
            //出入库下拉框中固定的值
            this.Cb_query.Text = cbquery;
            //调用方法固定页面
            Top = 0;
            Left = 0;
        }
        //
        private void tbBorrow_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.Tb_borrow.Text.Trim() == borrowhint)
            {
                this.Tb_borrow.Text = "";
            }
        }
        private void tbBorrow_Leave(object sender, EventArgs e)
        {
            if (this.Tb_borrow.Text.Trim() == "")
            {
                this.Tb_borrow.Text = borrowhint;
            }
        }
        //
        private void tbDuty_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.Tb_duty.Text.Trim() == dutyhint)
            {
                this.Tb_duty.Text = "";
            }
        }
        private void tbDuty_Leave(object sender, EventArgs e)
        {
            if (this.Tb_duty.Text.Trim() == "")
            {
                this.Tb_duty.Text = dutyhint;
            }
        }
        //
        private void tbModel_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.Tb_model.Text.Trim() == modelhint)
            {
                this.Tb_model.Text = "";
            }
        }
        private void tbModel_Leave(object sender, EventArgs e)
        {
            if (this.Tb_model.Text.Trim() == "")
            {
                this.Tb_model.Text = modelhint;
            }
        }
        //
        private void tbManufacturer_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.Tb_manufacturer.Text.Trim() == manufacturerhint)
            {
                this.Tb_manufacturer.Text = "";
            }
        }
        private void tbManufacturer_Leave(object sender, EventArgs e)
        {
            if (this.Tb_manufacturer.Text.Trim() == "")
            {
                this.Tb_manufacturer.Text = manufacturerhint;
            }
        }

        private void Btnquery_Click(object sender, EventArgs e)
        {
            //获取搜索框中的值
            String tb_borrow = Tb_borrow.Text;
            //借用人姓名校验
            //中文名字，不能是数字或英文
            if (!Regex.IsMatch(tb_borrow.ToString(), @"[\u4e00-\u9fbb]"))
            {
                Tt_checkborrow.Show("借用人姓名输入错误 ", this.Tb_borrow);

            }
            else
            {
                this.Tt_checkborrow.Hide(this.Tb_borrow);
            }
 
             //根据搜索框的内容查询
             dao.FindInstrumentByBorrow(tb_borrow);

            //获取搜索框中的值
            String tb_duty = Tb_duty.Text;
            //责任人姓名校验
            //中文名字，不能是数字或英文
            if (!Regex.IsMatch(tb_duty.ToString(), @"[\u4e00-\u9fbb]"))
            {
                Tt_checkduty.Show("责任人姓名输入错误 ",this.Tb_duty);
            }
            else
            {
                this.Tt_checkduty.Hide(this.Tb_duty);
            }
            //根据搜索框的内容查询
            dao.FindInstrumentByDuty(tb_duty);

            //获取搜索框中的值
            string tb_model = Tb_model.Text;
            //仪器型号校验
            //可以是数字英文或中文
            if (!Regex.IsMatch(tb_model.ToString(), @"^[\u4e00-\u9fa5_a-za-z0-9]+$"))
            {
                Tt_checkmodel.Show("仪器型号输入错误 ",this.Tb_model);
            }
            else
            {
                this.Tt_checkmodel.Hide(this.Tb_model);
            }
            //根据搜索框的内容查询
            dao.FindInstrumentByModel(tb_model);

            //获取搜索框中的值
            String tb_manufacturer = Tb_manufacturer.Text;
            //生产厂商校验
            //英文或中文
            if (!Regex.IsMatch(tb_manufacturer.ToString(), @"^[\u4e00-\u9fa5_a-za-z0-9]+$"))
            {
                Tt_checkmanufacturer.Show("生产厂商输入错误 ",this.Tb_manufacturer);
            }
            else
            {
                this.Tt_checkmanufacturer.Hide(this.Tb_manufacturer);
            }
            //根据搜索框的内容查询
            dao.FindInstrumentByManufacturer(tb_manufacturer);

            //获取时间
            DateTime begin = Convert.ToDateTime(Dtp_begin.Value.Date.ToString());  //获取开始日期
            DateTime end = Convert.ToDateTime(Dtp_end.Value.Date.ToString());   //获取结束日期
            //日期校验
            if (DateTime.Compare(begin, end) > 0)
            {
                Tt_checktime.Show("开始时间大于结束时间 ", this.Dtp_end);
            }
            else
            {
                this.Tt_checktime.Hide(this.Dtp_end);
            }
            //根据搜索框的内容查询
            dao.FindInstrumentBetween(begin, end);
        }
    }
}
