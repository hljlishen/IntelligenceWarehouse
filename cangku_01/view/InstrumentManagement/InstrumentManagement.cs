using cangku_01.entity;
using cangku_01.interfaceImp;
using cangku_01.interfaces;
using cangku_01.UHFReader09;
using cangku_01.UHFReader09CSharp;
using cangku_01.view.EmployeesManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using USBReader;
using static cangku_01.view.AdminPage.AutoCloseMassageBox;

//仪器管理

namespace cangku_01.view.InstrumentManagement
{
    public partial class InstrumentManagement : Form
    {
        EmployeeManagement selectEmployees;
        InstrumentInterface dao = new InstrumentDataManipulation();
        Instrument ins = new Instrument();
        private static UHFReader09Interface ReaderDrive = null;
        public delegate void InstrumentSelectedHandler(List<int> instrumentIds,List<string> insTagids);
        public event InstrumentSelectedHandler InstrumentSelected;
        private int dutyid;
        UHFReader reader = UHFReader.CreateInstance();

        public InstrumentManagement()
        {
            InitializeComponent();
        }

        private void index_instrument_Load(object sender, EventArgs e)
        {
            cb_IsInWareHouse.Text = "全部";
            Left = 0;
            Top = 0;
            DataTable dt = dao.QueryAllInstrument();
            TagIdQuery(reader);
            ShowDataGridView(dt);
        }

        //DataGridView显示数据
        public void ShowDataGridView(DataTable dt)
        {
            dgv_instrumentinformation.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = dgv_instrumentinformation.Rows.Add(row);
                dgv_instrumentinformation.Rows[index].Cells[0].Value = dr["in_tagid"];
                dgv_instrumentinformation.Rows[index].Cells[1].Value = dr["in_name"];
                dgv_instrumentinformation.Rows[index].Cells[2].Value = dr["in_model"];
                dgv_instrumentinformation.Rows[index].Cells[3].Value = dr["in_manufactor"];
                ins.Position = dr["in_position"].ToString();
                dgv_instrumentinformation.Rows[index].Cells[4].Value = ins.PlaceUnscramble();
                dgv_instrumentinformation.Rows[index].Cells[5].Value = dr["in_isinwarehouse"];
                dgv_instrumentinformation.Rows[index].Cells[6].Value = dr["in_state"];
                dgv_instrumentinformation.Rows[index].Cells[7].Value = dr["in_usedmode"];
                dgv_instrumentinformation.Rows[index].Cells[8].Value = SelectDuty((int)dr["in_duty"]);
                dgv_instrumentinformation.Rows[index].Cells[12].Value = dr["in_id"];
            }
        }

        //责任人查询
        public string SelectDuty(int employeeId)
        {
            string dutyname;
            Employee employee = new Employee();
            employee.Id = employeeId;
            DataTable dt = employee.IdQueryEmployee();
            DataRow myDr = dt.Rows[0];
            dutyname = myDr["em_name"].ToString();
            return dutyname;
        }

        //仪器添加
        private void button1_Click(object sender, EventArgs e)  
        {
            AddOrUpdateInstrument add = new AddOrUpdateInstrument(this, reader);
            add.ShowDialog();
        }

        //搜索按钮
        private void button2_Click(object sender, EventArgs e)  
        {
            ins.TagId = tb_tagid.Text;
            ins.Name = tb_instrumentname.Text;
            ins.Model = tb_model.Text;
            ins.IsInWareHouse = cb_IsInWareHouse.Text.Equals("全部") ?  null : cb_IsInWareHouse.Text;
            ins.Duty = dutyid;
            ShowDataGridView(dao.QueryInstrument(ins));
            tb_duty.Text = "";
            dutyid = 0;
        }

        private void TagIdQuery(UHFReader09Interface readerDrive)
        {
            ReaderDrive = readerDrive;
            ReaderDrive.OpenConnectReader();
            ReaderDrive.TagConnected += ReaderDrive_TagConnected;
        }

        private void ReaderDrive_TagConnected(string tagId)
        {
            tb_tagid.Text = tagId;
        }

        //选择责任人
        private void bt_selectduty_Click(object sender, EventArgs e)
        {
            selectEmployees = new EmployeeManagement();
            selectEmployees.FormBorderStyle = FormBorderStyle.FixedSingle;
            selectEmployees.EmployeesSelected += EmployeesSelected;
            selectEmployees.ShowDialog();
            selectEmployees.EmployeesSelected -= EmployeesSelected;
        }

        //显示责任人信息
        private void EmployeesSelected(List<int> employeesIds, List<string> emNameAndId)
        {
            Employee employee = new Employee();
            foreach (var id in employeesIds)
            {
                dutyid = id;
                employee.Id = id;
                DataTable dt = employee.IdQueryEmployee();
                DataRow myDr = dt.Rows[0];
                tb_duty.Text = myDr["em_name"].ToString();
            }
            tb_duty.Text = tb_duty.Text.Substring(0, tb_duty.Text.Length);
        }

        //双击
        private void dgv_instrumentinformation_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FormBorderStyle == FormBorderStyle.FixedSingle)
            {
                var selectedRows = dgv_instrumentinformation.SelectedRows;
                List<int> ids = new List<int>();
                List<string> tagids = new List<string>();
                List<string> names = new List<string>();
                foreach (var row in selectedRows)
                {
                    int id = int.Parse(((DataGridViewRow)row).Cells[12].Value.ToString());
                    string tagid = ((DataGridViewRow)row).Cells[0].Value.ToString();
                    string name = ((DataGridViewRow)row).Cells[1].Value.ToString();
                    ids.Add(id);
                    tagids.Add(tagid);
                    names.Add(name);
                }
                InstrumentSelected?.Invoke(ids, tagids);
                Close();
            }
        }

        //仪器的修改删除
        private void dgv_instrumentinformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //删除
            if (e.ColumnIndex == 9)
            {
                if (MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ins.TagId = dgv_instrumentinformation.CurrentRow.Cells[0].Value.ToString();
                    WarehouseLocation wa = new WarehouseLocation();
                    wa.instrumenttagid = ins.TagId;
                    wa.TagidAlterInstrument();
                    dao.DeleteInstrument(ins);
                    AutoClosingMessageBox.Show("仪器信息删除成功", "仪器信息删除", 1000);
                    dgv_instrumentinformation.Rows.RemoveAt(e.RowIndex);//从DGV移除
                }
            }
            //修改
            if (e.ColumnIndex == 10)
            {
                if (MessageBox.Show("是否确认修改？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //获取要修改属性
                    Instrument ins = new Instrument();
                    ins.TagId = dgv_instrumentinformation.CurrentRow.Cells[0].Value.ToString();
                    AddOrUpdateInstrument Update = new AddOrUpdateInstrument(this, ins, e.RowIndex, reader);
                    Update.ShowDialog();
                }
            }
            //查看
            if (e.ColumnIndex == 11)
            {
                //获取要修改属性
                Instrument ins = new Instrument();
                ins.TagId = dgv_instrumentinformation.CurrentRow.Cells[0].Value.ToString();
                AddOrUpdateInstrument add = new AddOrUpdateInstrument(ins);
                add.ShowDialog();
            }
        }

        private void bt_queryinstrument_KeyPress(object sender, KeyPressEventArgs e)
        {
            ReaderDrive.TagConnected -= ReaderDrive_TagConnected;
        }

        #region dgv导出Excel
        //dgv导出Excel
        private void bt_dgvchangeexcel_Click(object sender, EventArgs e)
        {
            ExcelOperator.DataGridViewToExcel(dgv_instrumentinformation, true);
        }
        #endregion
    }
}
