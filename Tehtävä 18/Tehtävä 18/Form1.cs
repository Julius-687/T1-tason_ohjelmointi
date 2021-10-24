using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tehtävä_18
{
    public partial class AvainhenkilotForm : Form
    {
        DataTable oppilaitos = new DataTable();
        DataTable vastuuhenkilot = new DataTable();
        DataTable yhteys = new DataTable();
        public AvainhenkilotForm()
        {
            InitializeComponent();
        }

        private void AvainhenkilotForm_Load(object sender, EventArgs e)
        {
            taytaoppilaitostaulukko();
            OppilaitosCB.DataSource = oppilaitos;
            OppilaitosCB.DisplayMember = "ONimi";
            taytavastuuhenkilotTaulukko();
        }
        private void OppilaitosCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string viite = oppilaitos.Rows[OppilaitosCB.SelectedIndex]["OID"].ToString();
            OsoiteLB.Text = oppilaitos.Rows[OppilaitosCB.SelectedIndex]["OKatuosoite"].ToString();
            PostinumeroLB.Text = oppilaitos.Rows[OppilaitosCB.SelectedIndex]["Opostinumero"].ToString();
            PostitoimipaikkaLB.Text = oppilaitos.Rows[OppilaitosCB.SelectedIndex]["OPostitoimipaikka"].ToString();
            PuhelinLB.Text = oppilaitos.Rows[OppilaitosCB.SelectedIndex]["OPuhelin"].ToString();

            yhteys = vastuuhenkilot.Select("OID =" + viite).CopyToDataTable();
        }
        private void taytaoppilaitostaulukko()
        {
            oppilaitos.Columns.Add("OID", typeof(int));
            oppilaitos.Columns.Add("ONimi");
            oppilaitos.Columns.Add("OKatuosoite");
            oppilaitos.Columns.Add("OPostinumero");
            oppilaitos.Columns.Add("OOPostitoimipaikka");
            oppilaitos.Columns.Add("OPuhelin");

            oppilaitos.Rows.Add(1, "StadinAO", "Hattulantie 2", "00550", "Helsinki", "09 310 8600");
            oppilaitos.Rows.Add(2, "Omnia", "Armas Launiksen Katu 9", "02650", "Espoo", "046 877 1371");
            oppilaitos.Rows.Add(3, "Varia", "Rälssitie 13", "01530", "Vantaa", "030 182 4668");
            oppilaitos.Rows.Add(4, "Keuda", "Sibeliuksenväylä 55 A", "03300", "Järvenpää", "09 27 381");
        }

        private void taytavastuuhenkilotTaulukko()
        {
            vastuuhenkilot.Columns.Add("OID", typeof(int));
            vastuuhenkilot.Columns.Add("VNimi");
            vastuuhenkilot.Columns.Add("VTitteli");
            vastuuhenkilot.Columns.Add("VSijainti");
            vastuuhenkilot.Columns.Add("VSähköposti");
            vastuuhenkilot.Columns.Add("VPuhelin");

            vastuuhenkilot.Rows.Add(1, "Sirpa Lindroos", "Rehtori", "Kampus 1", "sirpa.lindroos@hel.fi", "050 540 4434");
            vastuuhenkilot.Rows.Add(1, "Hanna Laurila", "Rehtori", "Kampus 2", "hanna.laurila@hel.fi", "030 676 5583");
            vastuuhenkilot.Rows.Add(1, "Annele Ranta", "Rehtori", "Kampus 3", "annele.ranta@hel.fi", "040 631 5667");
            vastuuhenkilot.Rows.Add(1, "Eeva Sahlman", "Rehtori", "Kampus 4", "eeva.sahlman@hel.fi", "040 336 1017");
            vastuuhenkilot.Rows.Add(1, "Marko Aaltonen", "Rehtori", "Kampus5", "marko.aaltonen@hel.fi", "050 511 0115");
            vastuuhenkilot.Rows.Add(2, "Tuula Antola", "Koulutuskuntayhytmän johtaja", "", "tuula.antola@omnia.fi", "");
            vastuuhenkilot.Rows.Add(2, "Tapio Siukonen", "Hallintojohtaja", "", "yleishallinto", "tapio.siukonen@omnia.fi", "044 369 6600");
            vastuuhenkilot.Rows.Add(2, "Tuukko Soini", "Kehittämisjohtaja", "yleishallinto", "tuukka.soini@omnia.fi", "045 877 2952");
            vastuuhenkilot.Rows.Add(2, "Riikka-Maria Yli-Suomu", "Liiketoimintajohtaja", "Elinvoima- ja työllisyyspalvelut", "riikka-maria.yli-suomu@omnia.fi", "", "050 348 6544");
            vastuuhenkilot.Rows.Add(2, "Maija Aaltola", "Rehtori", "Koulutus- jaopiskelijapalvelut", "maija-aaltola@omnia.fi", "", "050 384 9354");
            vastuuhenkilot.Rows.Add(2, "Kai Iivari", "", "Talousjohtaja", "Talous- ja hankintapalvelut", "kai.iivari@omnia.fi", "0400 306 691");
            vastuuhenkilot.Rows.Add(3, "Päivi Korhonen", "Viestintäjohtaja", "Viestinrä- ja markkinointipalvelut", "paivi.korhonen@omnia.fi", "040 126 7599");
            vastuuhenkilot.Rows.Add(3, "Pekka Tauriainen", "Rehtori", "", "pekka.tauriainen@vantaa.fi", "050 312 4514");
            vastuuhenkilot.Rows.Add(3, "Anne Heinonen", "Rehtori", "", "anne.heinonen@vantaa.fi", "040 524 1242");
            vastuuhenkilot.Rows.Add(3, "Tuula Kiistinen", "Johtaja", "Yhteisten palveluiden päällikkö", "tuula.kiiskinen@vantaa.fi", "040 1939 048");
            vastuuhenkilot.Rows.Add(4, "Tiina Halmevuo", "Kuntayhtymän johtaja", "Hallinto- ja johtamispalvelut", "tiina.halmevuo@keuda.fi", "050 336 9709");
            vastuuhenkilot.Rows.Add(4, "Anna Mari Leinonen", "Rehtori", "Hallinto", "annamari.leinonen@keuda.fi", "040 174 4523");
            vastuuhenkilot.Rows.Add(4, "Anne Vuorinen", "Johtaja", "Yritys ja elinvoimapalvelut", "anne.vuorinen@keuda.fi", "", "050 415 0974");
            vastuuhenkilot.Rows.Add(4, "Hanna Nyrönen", "Viestintä- ja markkinointipäällikkö", "Viestintäpalvelut", "hanna.nyronen@keuda.fi", "040 521 8428");
            vastuuhenkilot.Rows.Add(4, "Maarit Flinck", "Asianhallintapäällikö", "Hallinto- ja johtamispalvelut", "maarit.flinck@keuda.fi", "0500 837 357");
        }

        private void VastuuhenkiloCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            TitteliLB.Text = yhteys.Rows[VastuuhenkiloCB.SelectedIndex]["VTitteli"].ToString();
            OsastoLB.Text = yhteys.Rows[VastuuhenkiloCB.SelectedIndex]["VOsasto"].ToString();
            OsastoLB.Text = yhteys.Rows[VastuuhenkiloCB.SelectedIndex]["VSähkoposti"].ToString();
            PuhelinLB.Text = yhteys.Rows[VastuuhenkiloCB.SelectedIndex]["VPhuhelin"].ToString();
        }
    }
}
