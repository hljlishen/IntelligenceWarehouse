using cangku_01.entity;
using cangku_01.interfaceImp;
using cangku_01.interfaces;
using cangku_01.MysqlConnection;
using cangku_01.view.TheWarehouseHomePage;
using DbLink;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static cangku_01.view.AdminPage.AutoCloseMassageBox;

namespace cangku_01.GateDrive
{
    class DataShow
    {
        ListViewItem listView = new ListViewItem();

        //显示仪器图片
        public void ShowInstrumentPhoto(GateData door,Form1 fr)
        {
            FileInfo f = new FileInfo(Application.StartupPath + @"\..\..\..\image\InstrumentPhoto\" + door.TagId + ".png");
            if (f.Exists)
            {
                fr.pb_instrumentphoto.Image = Image.FromFile(Application.StartupPath + @"\..\..\..\image\InstrumentPhoto\" + door.TagId + ".png");
            }
            else
            {
                fr.pb_instrumentphoto.Image = Image.FromFile(Application.StartupPath + @"\..\..\..\image\InstrumentPhoto\" + "仪器" + ".png");
            }
        }

        //仪器通过记录显示在text和ListView列表中
        public void TextAndListViewShow(GateData door,Form1 fr)
        {
            if (door.TagId != null && door.ThroughDoorDirection !=  null)
            {
                InstrumentInterface dao = new InstrumentDataManipulation();
                Instrument ins = new Instrument();
                ins.TagId = door.TagId;
                DataTable dt = dao.TagIdQueryInstrument(ins);
                DataRow myDr = dt.Rows[0];
                fr.tb_ShowId.Text = door.TagId;
                fr.tb_ShowName.Text = myDr["in_name"].ToString();
                fr.tb_ShowState.Text = door.ThroughDoorDirection;
                fr.tb_ShowTime.Text = door.ThroughDoorTime.ToString();
                ShowInstrumentPhoto(door,fr);

                listView = fr.lv_instrumrntinformation.Items.Add((fr.lv_instrumrntinformation.Items.Count + 1).ToString());
                listView.SubItems.Add(door.TagId);
                listView.SubItems.Add(myDr["in_name"].ToString());
                listView.SubItems.Add(door.ThroughDoorDirection);
                listView.SubItems.Add(door.ThroughDoorTime.ToString());
                listView.SubItems.Add(myDr["in_position"].ToString());
            }
        }


    }
}
