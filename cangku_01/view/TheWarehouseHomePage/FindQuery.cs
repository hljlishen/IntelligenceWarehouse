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
        Instrument ins = new Instrument();
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
                ins.Position = dr["in_position"].ToString();
                dgv_instrumentplace.Rows[index].Cells[2].Value = ins.PlaceUnscramble();
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
    }
}
