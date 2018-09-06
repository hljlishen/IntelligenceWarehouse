using System;
using System.Data;
using System.Windows.Forms;
using cangku_01.entity;
using cangku_01.interfaceImp;
using cangku_01.interfaces;
using static cangku_01.view.AdminPage.AutoCloseMassageBox;

//仪器查询

namespace cangku_01.view.TheWarehouseHomePage
{
    public partial class Find_Items : Form
    {
        public Find_Items()
        {
            InitializeComponent();
        }

        private void Find_Items_Load(object sender, EventArgs e)
        {
            

        }

        //搜索
        private void bt_findinstrument_Click(object sender, EventArgs e)
        {
            if (!FormValidation()) return;
            Instrument ins = new Instrument();
            InstrumentInterface dao = new InstrumentDataManipulation();
            ins.Name = tb_name.Text;
            ins.Model = tb_model.Text;
            ins.Manufactor = tb_manufactor.Text;
            ins.SerialNumber = tb_serialnumber.Text;
            ShowDataGridView(dao.QueryInstrument(ins));

        }

        //DataGridView显示数据
        public void ShowDataGridView(DataTable dt)
        {
            foreach (DataRow dr in dt.Rows)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = dgv_instrumentplace.Rows.Add(row);
                dgv_instrumentplace.Rows[index].Cells[0].Value = dr["in_name"];
                dgv_instrumentplace.Rows[index].Cells[1].Value = dr["in_model"];
                dgv_instrumentplace.Rows[index].Cells[2].Value = PlaceUnscramble(dr["in_position"].ToString());
            }
        }

        //表单验证
        private bool FormValidation()
        {
            bool validation = true;
            if (tb_name.Text.Trim().Equals("")&& tb_model.Text.Trim().Equals("") && tb_manufactor.Text.Trim().Equals("") && tb_serialnumber.Text.Trim().Equals(""))
            {
                AutoClosingMessageBox.Show("您未输入任何查询信息", "无查询信息", 1000);
                validation = false;
            }
            return validation;
        }

        //位置编码解读
        private string PlaceUnscramble(string position)
        {
            string place = "";
            WarehouseLocation wa = new WarehouseLocation();
            string[] sArray = position.Split(new char[1] { '-' });
            for (int i = 0; i <= 3; i++)
            {
                wa.id = int.Parse(sArray[i]);
                DataTable dt = wa.SqlIdQueryWarehouseInformation();
                DataRow myDr = dt.Rows[0];
                place += myDr["wa_name"].ToString()+"-";
            }
            place = place.Substring(0, place.Length - 1);
            return place;
        }
    }
}
