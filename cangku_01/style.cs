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
        public void a(Form fr)
        {
            fr.Top = 40;
            fr.Left = 50;
        }
        public void b(Form fr)
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
