using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cangku_01.YT
{
    class window_style
    {
        public void Top_and_Left(Form fr)
        {
            fr.Top = 0;
            fr.Left = 0;
        }
        public void window(Form fr)
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
