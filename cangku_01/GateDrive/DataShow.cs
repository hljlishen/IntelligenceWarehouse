using cangku_01.MysqlConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static cangku_01.view.AdminPage.AutoCloseMassageBox;

namespace cangku_01.GateDrive
{
    class DataShow : DataTransferInterface
    {
        ListViewItem listView = new ListViewItem();
        DataMysql dbo = DataMysql.GetDataMysqlGreateInstance(DataMysql.mysqldefaultconnection);

        public bool isonlistview = false;
        public void DataTransfer(GateData door, Form1 fr,string[] gatedata)
        {
            if (door.ThroughDoorDirection != null)
            {
                TagIDQueryInstrumentName(door);
                DataTable dt = TagIDQueryInstrumentName(door);
                if (dt.Rows.Count <= 0)
                {
                    AutoClosingMessageBox.Show("无匹配卡ID", "TagId为null", 1000);
                    return;
                }
                DataRow myDr = dt.Rows[0];
                door.Name = myDr["in_name"].ToString();
                fr.tb_ShowId.Text = door.TagId;
                fr.tb_ShowName.Text = door.Name;
                fr.tb_ShowState.Text = door.ThroughDoorDirection;
                fr.tb_ShowTime.Text = door.ThroughDoorTime;
                FileInfo f = new FileInfo(Application.StartupPath + @"\..\..\..\image\InstrumentPhoto\" + door.TagId + ".png");
                if (f.Exists)
                {
                    fr.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\..\..\..\image\InstrumentPhoto\" + door.TagId + ".png");
                }
                else
                {
                    fr.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\..\..\..\image\InstrumentPhoto\" + "仪器" + ".png");
                }
                
                for (int i = 0; i > fr.lv_instrumrntinformation.Items.Count; i++)     
                {
                    if (door.TagId == fr.lv_instrumrntinformation.Items[i].SubItems[1].Text)
                    {
                        listView = fr.lv_instrumrntinformation.Items[i];
                        ChangeSubItem(listView, 1, door.TagId);
                        isonlistview = true;

                        break;
                    }
                }

                if (!isonlistview)
                {
                    listView = fr.lv_instrumrntinformation.Items.Add((fr.lv_instrumrntinformation.Items.Count + 1).ToString());
                    listView.SubItems.Add(gatedata[0]);
                    listView.SubItems.Add("");
                    listView.SubItems.Add("");
                    listView.SubItems.Add("");
                    string s = door.TagId;
                    ChangeSubItem(listView, 1, s);
                    door.TagId = null;
                }    
               
               // BorrowInformation(door);
            }
            else
            {
                AutoClosingMessageBox.Show("未获取到过门信息", "为null", 1000);
            }
        }
       

        public void ChangeSubItem(ListViewItem ListItem, int subItemIndex, string ItemText)
        {
            if (subItemIndex == 1)
            {
                if (ItemText == "")
                {
                    ListItem.SubItems[subItemIndex].Text = ItemText;
                    if (ListItem.SubItems[subItemIndex + 2].Text == "")
                    {
                        return;
                    }
                    else
                    {
                        ListItem.SubItems[subItemIndex + 2].Text = Convert.ToString(Convert.ToInt32(ListItem.SubItems[subItemIndex + 3].Text) + 1);
                    }
                }
               
            }
        }
        //将探测到的借用信息存入到数据库
        public void BorrowInformation(GateData insborrow)
        {
            string sql = insborrow.BorrowInformationSql();

            dbo.WriteDB(sql);
        }
        //查询Tagid仪器名
        public DataTable TagIDQueryInstrumentName(GateData door)
        {
            string sql = door.TagIDQueryInstrumentNameSql();
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }
    }
}
