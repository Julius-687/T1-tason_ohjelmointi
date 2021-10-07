using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roomalaiset_numerot
{
    public partial class RoomalaisiksiForm : Form
    {
        public RoomalaisiksiForm()
        {
            InitializeComponent();
        }

        private void MuutaBT_Click(object sender, EventArgs e)
        {
            int luku1, luku2, luku3, luku4;
            string vastaus = "";
            if(TekstiTB.Text.Length > 3)
            {
                luku1 = Convert.ToInt32(TekstiTB.Text.Substring(0, 1));
                luku2 = Convert.ToInt32(TekstiTB.Text.Substring(1, 1));
                luku3 = Convert.ToInt32(TekstiTB.Text.Substring(2, 1));
                luku4 = Convert.ToInt32(TekstiTB.Text.Substring(3, 1));
                if(luku1 % 3 == 0)
                {
                    vastaus += "MMM";
                }
                else if(luku1 % 2 == 0)
                {
                    vastaus += "MM";
                }
                else if(luku1 % 1 == 0)
                {
                    vastaus += "M";
                }
                else
                {
                    vastaus += "";
                }
                vastaus += sataset(luku2, vastaus);
                vastaus += kympit(luku3, vastaus);
                vastaus += ykkoset(luku4, vastaus);
            }
            else if(TekstiTB.Text.Length > 2)
            {
                luku2 = Convert.ToInt32(TekstiTB.Text.Substring(0, 1));
                luku3 = Convert.ToInt32(TekstiTB.Text.Substring(1, 1));
                luku4 = Convert.ToInt32(TekstiTB.Text.Substring(2, 1));
                vastaus += sataset(luku2, vastaus);
                vastaus += kympit(luku3, vastaus);
                vastaus += ykkoset(luku4, vastaus);
            }
            else if(TekstiTB.Text.Length > 1)
            {
                luku3 = Convert.ToInt32(TekstiTB.Text.Substring(0, 1));
                luku4 = Convert.ToInt32(TekstiTB.Text.Substring(1, 1));
                vastaus += kympit(luku3, vastaus);
                vastaus += ykkoset(luku4, vastaus);
            }
            else if (TekstiTB.Text.Length > 0)
            {
                luku4 = Convert.ToInt32(TekstiTB.Text.Substring(0, 1));
                vastaus += ykkoset(luku4, vastaus);
            }
            VastausLB.Text = vastaus;
            VastausLB.Visible = true;
        }
    }
}
