using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ajastin
{
    public partial class LaskuriForm : Form
    {
        private int kokonaisaika;
        public LaskuriForm()
        {
            InitializeComponent();
        }

        private void LaskuriForm_Load(object sender, EventArgs e)
        {
            StopBT.Enabled = false;
            for(int i = 0; i < 60; i++)
            {
                minuutitCB.Items.Add(i.ToString());
                sekunnitCB.Items.Add(i.ToString());
            }
            minuutitCB.SelectedIndex = 30;
            sekunnitCB.SelectedIndex = 0;
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = false;
            StopBT.Enabled = true;
            int minuutit = int.Parse(minuutitCB.SelectedItem.ToString());
            int sekunnit = int.Parse(sekunnitCB.SelectedItem.ToString());
            kokonaisaika = (minuutit * 60) + sekunnit;
            AjastinTM.Enabled = true;
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = true;
            StopBT.Enabled = false;
            kokonaisaika = 0;
            AikaLB.Text = "00:00";
        }

        private void AjastinTM_Tick(object sender, EventArgs e)
        {
            if(kokonaisaika >0)
            {
                kokonaisaika--;
                int minuutit = kokonaisaika / 60;
                int sekunnit = kokonaisaika - (minuutit * 60);
                AikaLB.Text = minuutit.ToString() + ":" + sekunnit.ToString();
            }
            else
            {
                AjastinTM.Stop();
                MessageBox.Show("Aikasi loppui");
            }
        }
    }
}
