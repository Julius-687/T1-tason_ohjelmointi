using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_laskuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            double paino = 0, pituus = 0, painoindeksi;
            paino = Convert.ToDouble(PainoTB.Text);
            pituus = Convert.ToDouble(PituusTB.Text);
            painoindeksi = Math.Round(paino / (pituus * pituus), 2);
            if (painoindeksi < 18.5)
            {
                VastausLB.Text = "painoindeksisi on: " + painoindeksi;
                VastausLB.ForeColor = Color.Blue;
                KuvausLB.Text = "Alipaino";
                KuvausLB.ForeColor = Color.Blue;
                VastausLB.Visible = true;
                KuvausLB.Visible = true;
            }
            else if (painoindeksi < 25)
            {
                VastausLB.Text = "painoindeksisi on: " + painoindeksi;
                VastausLB.ForeColor = Color.Green;
                KuvausLB.Text = "Normaalipaino";
                KuvausLB.ForeColor = Color.Green;
                VastausLB.Visible = true;
                KuvausLB.Visible = true;
            }
            else if (painoindeksi < 40)
            {
                VastausLB.Text = "painoindeksisi on: " + painoindeksi;
                VastausLB.ForeColor = Color.DarkOrange;
                KuvausLB.Text = "Ylipaino";
                KuvausLB.ForeColor = Color.DarkOrange;
                VastausLB.Visible = true;
                KuvausLB.Visible = true;
            }
            else
            {
                VastausLB.Text = "painoindeksisi on: " + painoindeksi;
                VastausLB.ForeColor = Color.Red;
                KuvausLB.Text = "Huomattava ylipaino";
                KuvausLB.ForeColor = Color.Red;
                VastausLB.Visible = true;
                KuvausLB.Visible = true;
            }
        }
    }
}
