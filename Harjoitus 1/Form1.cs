using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus_1
{
    public partial class harjoitus1 : Form
    {
        public harjoitus1()
        {
            InitializeComponent();
        }

        private void VaihdaBT_Click(object sender, EventArgs e)
        {
            OtsikkoLB.Text = "Heippa maailma";
        }
    }
}
