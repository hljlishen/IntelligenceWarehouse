﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cangku_01.MH
{
    //控制页面不动
    class Take_Window_style
    {
        public void Top_and_Left_(Form fr)
        {
            //固定页面上左边框的距离
            fr.Top = 0;
            fr.Left = 0;
        }
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
