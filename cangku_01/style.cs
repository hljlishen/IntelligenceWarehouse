using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cangku_01
{
    public class style
    {
        //子窗口在父类中的位置
        public void Location(Form fr)
        {
            fr.Top = 0;
            fr.Left = 0;
        }
        //在父窗口中刷新，关闭子窗口
        public void Mdi_close(Form fr)
        {
            foreach(Form f in fr.MdiChildren)
            {
                if (!f.IsDisposed)
                {
                    f.Close();
                }
            }
        }
    }
}
