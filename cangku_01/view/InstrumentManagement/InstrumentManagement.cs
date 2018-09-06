using cangku_01.entity;
using cangku_01.interfaceImp;
using cangku_01.interfaces;
using cangku_01.UHFReader09;
using cangku_01.UHFReader09CSharp;
using System;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using static cangku_01.view.AdminPage.AutoCloseMassageBox;

//仪器管理

namespace cangku_01.view.InstrumentManagement
{
    public partial class InstrumentManagement : Form
    {   
        InstrumentInterface dao = new InstrumentDataManipulation();
        Instrument ins = new Instrument();
        private static UHFReader09Interface ReaderDrive = null;
        public delegate void InstrumentSelectedHandler(List<int> instrumentIds,List<string> insNameAndModel);
        public event InstrumentSelectedHandler InstrumentSelected;

        public InstrumentManagement()
        {
            InitializeComponent();
        }

        private void index_instrument_Load(object sender, EventArgs e)
        {
            cb_IsInWareHouse.Text = "全部";
            Left = 0;
            Top = 0;
            DataTable dt = dao.QueryAllInstrument();//将全部员工加载
            ShowDataGridView(dt);
        }

        //DataGridView显示数据
        public void ShowDataGridView(DataTable dt)
        {
            dgv_instrumentinformation.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                DataGridViewRow row2 = new DataGridViewRow();
                int index = dgv_instrumentinformation.Rows.Add(row2);
                dgv_instrumentinformation.Rows[index].Cells[0].Value = dr["in_tagid"];
                dgv_instrumentinformation.Rows[index].Cells[1].Value = dr["in_name"];
                dgv_instrumentinformation.Rows[index].Cells[2].Value = dr["in_model"];
                dgv_instrumentinformation.Rows[index].Cells[3].Value = dr["in_manufactor"];
                dgv_instrumentinformation.Rows[index].Cells[4].Value = dr["in_position"];
                dgv_instrumentinformation.Rows[index].Cells[5].Value = dr["in_isinwarehouse"];
                dgv_instrumentinformation.Rows[index].Cells[6].Value = SelectDuty((int)dr["in_duty"]);
                dgv_instrumentinformation.Rows[index].Cells[10].Value = dr["in_id"];
            }
        }

        //责任人查询
        public string SelectDuty(int id)
        {
            string dutyname;
            EmployeesInterface dao = new EmployeeDataManipulation();
            Employee em = new Employee();
            em.Id = id;
            DataTable dt = dao.IdQueryEmployee(em);
            DataRow myDr = dt.Rows[0];
            dutyname = myDr["em_name"].ToString();
            return dutyname;
        }

        //仪器添加
        private void button1_Click(object sender, EventArgs e)  
        {
            UHFReader reader = UHFReader.CreateInstance();
            AddOrUpdateInstrument add = new AddOrUpdateInstrument(this, reader);
            add.ShowDialog();
        }

        //仪器的修改删除
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {
            //删除
            if (e.ColumnIndex == 7)
            {
                if (MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ins.TagId = dgv_instrumentinformation.CurrentRow.Cells[0].Value.ToString();
                    dao.DeleteInstrument(ins);
                    AutoClosingMessageBox.Show("仪器信息删除成功", "仪器信息删除", 1000);
                    dgv_instrumentinformation.Rows.RemoveAt(e.RowIndex);//从DGV移除
                }
            }
            //修改
            if (e.ColumnIndex == 8)
            {
                if (MessageBox.Show("是否确认修改？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    UHFReader reader = UHFReader.CreateInstance();
                    //获取要修改属性
                    Instrument ins = new Instrument();
                    ins.TagId = dgv_instrumentinformation.CurrentRow.Cells[0].Value.ToString();
                    AddOrUpdateInstrument Update = new AddOrUpdateInstrument(this, ins, e.RowIndex,reader);
                    Update.ShowDialog();
                }
            }
            //修改
            if (e.ColumnIndex == 9)
            {
                UHFReader reader = UHFReader.CreateInstance();
                //获取要修改属性
                Instrument ins = new Instrument();
                 ins.TagId = dgv_instrumentinformation.CurrentRow.Cells[0].Value.ToString();
                 AddOrUpdateInstrument add = new AddOrUpdateInstrument(ins, reader);
                 add.ShowDialog(); 
            }
        }

        //搜索按钮
        private void button2_Click(object sender, EventArgs e)  
        {
            ins.Name = tb_instrumentname.Text;
            ins.Model = tb_model.Text;
            ins.IsInWareHouse = cb_IsInWareHouse.Text.Equals("全部") ?  null : cb_IsInWareHouse.Text;
            //ins.Duty = tb_duty.Text;
            ShowDataGridView(dao.QueryInstrument(ins));
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            UHFReader reader = UHFReader.CreateInstance();
            TagIdQuery(reader);
            ShowDataGridView(dao.TagIdQueryInstrument(ins));
        }

        private void TagIdQuery(UHFReader09Interface readerDrive)
        {
            ReaderDrive = readerDrive;
            ReaderDrive.OpenConnectReader();
            ReaderDrive.TagConnected += ReaderDrive_TagConnected;
        }

        private void ReaderDrive_TagConnected(string tagId)
        {
            ins.TagId = tagId;
        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ReaderDrive.TagConnected -= ReaderDrive_TagConnected;
        }

        private void dgv_instrumentinformation_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var selectedRows = dgv_instrumentinformation.SelectedRows;
            List<int> ids = new List<int>();
            List<string> name = new List<string>();
            foreach (var row in selectedRows)
            {
                int id = int.Parse(((DataGridViewRow)row).Cells[10].Value.ToString());
                string na = ((DataGridViewRow)row).Cells[1].Value.ToString();
                string mo = ((DataGridViewRow)row).Cells[2].Value.ToString();
                string ma = ((DataGridViewRow)row).Cells[3].Value.ToString();
                name.Add(na);
                name.Add(mo);
                name.Add(ma);
            }
            InstrumentSelected?.Invoke(ids,name);
        }
    }
}
