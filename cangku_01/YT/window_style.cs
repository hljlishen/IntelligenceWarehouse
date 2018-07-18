using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cangku_01.YT
{
    class Window_style
    {
        //在父类页面固定刷新在（0，0）位置
        public void Top_and_Left(Form fr)
        {
            fr.Top = 0;
            fr.Left = 0;
        }
        //在父类窗口刷新单个页面
        public void Window(Form fr)
        {
            foreach (Form f in fr.MdiChildren)
            {
                if (!f.IsDisposed)
                {
                    f.Close();
                }
            }
        }
    }
}
