using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProdajaGreyMatter
{
    public partial class frmNajboljiKupci : Form
    {
        private int razdoblje = 0;
        public frmNajboljiKupci()
        {
            InitializeComponent();
            prikaziNajboljeKupce();
            this.BackColor = Color.FromArgb(228, 231, 236);
            foreach (Control gumb in this.Controls)
            {
                if (gumb.GetType() == typeof(Button))
                {
                    gumb.BackColor = Color.FromArgb(253, 160, 247);
                    gumb.ForeColor = Color.FromArgb(64, 64, 64);
                    gumb.Font = new Font(gumb.Font, FontStyle.Bold);
                    gumb.Font = new Font("Sans", 14);
                }
            }

            btnNatrag.FlatStyle = FlatStyle.Flat;
            btnNatrag.FlatAppearance.BorderColor = Color.FromArgb(255, 50, 241);
            btnNatrag.FlatAppearance.BorderSize = 3;
        }
        private void setRazdoblje(int razdoblje)
        {
            this.razdoblje = razdoblje;
        }
        private void prikaziNajboljeKupce()
        {
            if (rb3Mjeseca.Checked)
                this.razdoblje = 3;
            else if (rb6Mjeseci.Checked)
                this.razdoblje = 6;
            else
                this.razdoblje = 12;
            BindingList<narudzbenica> listaNarudzbenica = null;
            BindingList<zaposlenik> listaZaposlenika = null;
            BindingList<klijent> listaKlijenata = null;
            List<string> klijentNaziv = new List<string>();
            List<int> klijentKolicina = new List<int>();
            using (var db = new greymatterpiEntities())
            {
                listaNarudzbenica = new BindingList<narudzbenica>(db.narudzbenica.ToList());
                listaZaposlenika = new BindingList<zaposlenik>(db.zaposlenik.ToList());
                listaKlijenata = new BindingList<klijent>(db.klijent.ToList());
                DateTime od = DateTime.Now.AddMonths(-(razdoblje));
                DateTime sada = DateTime.Now;
                foreach (var klijentN in listaKlijenata)
                {
                    klijentNaziv.Add(klijentN.naziv);
                    var rezultat = from k in db.klijent
                                   join n in db.narudzbenica
                                   on k.oib equals n.oibKlijenta
                                   join sn in db.stavkenarudzbenice
                                   on n.idNarudzbenice equals sn.idNarudzbenice
                                   where k.naziv == klijentN.naziv && n.status == 1 && (n.datumIzdavanja >= od && n.datumIzdavanja <= sada)
                                   select sn.kolicina;
                    if (rezultat.Any())
                        klijentKolicina.Add(rezultat.Sum());
                    else
                        klijentKolicina.Add(0);
                }
            }
            var graf = new Chart();
            graf.Size = new Size(800, 400);
            var naslov = new Title();
            naslov.Text = "Najbolji klijenti";
            naslov.Font = new Font("Arial", 14);
            var grafPodrucje = new ChartArea();
            grafPodrucje.AxisX.MajorGrid.LineColor = Color.LightSkyBlue;
            grafPodrucje.AxisY.MajorGrid.LineColor = Color.LightSkyBlue;
            grafPodrucje.AxisX.LabelStyle.Font = new Font("Consolas", 8);
            grafPodrucje.AxisY.LabelStyle.Font = new Font("Consolas", 8);
            grafPodrucje.Area3DStyle.Enable3D = true;
            grafPodrucje.Area3DStyle.PointDepth = 100;
            grafPodrucje.Area3DStyle.LightStyle = LightStyle.Realistic;
            grafPodrucje.Area3DStyle.Rotation = 10;
            grafPodrucje.BackColor = Color.WhiteSmoke;
            grafPodrucje.BorderColor = Color.LightGray;
            graf.ChartAreas.Add(grafPodrucje);
            graf.Titles.Add(naslov);
            var podaci = new Series();
            podaci.Name = "podaci";
            graf.Series.Add(podaci);
            graf.Series["podaci"].Points.DataBindY(klijentKolicina);
            graf.Series["podaci"].Points[0].Color = Color.FromArgb(220, 65, 140, 255);
            graf.Series["podaci"].Points[0].BorderColor = Color.FromArgb(180, 26, 59, 105);
            graf.Series["podaci"].ChartType = SeriesChartType.Column;
            graf.Series["podaci"].IsValueShownAsLabel = true;
            int j = 0;
            foreach (var c in klijentNaziv)
            {
                graf.Series[0].Points[j].AxisLabel = klijentNaziv[j].ToString();
                graf.Series["podaci"].Points[j].Color = Color.FromArgb(220, 65, 140, 255);
                graf.Series["podaci"].Points[j].BorderColor = Color.FromArgb(180, 26, 59, 105);
                j++;
            }
            graf.Invalidate();
            graf.SaveImage("chart1.png", ChartImageFormat.Png);
            pictureBox1.ImageLocation = @"chart1.png";
        }

        private void rb3Mjeseca_CheckedChanged(object sender, EventArgs e)
        {
            if (rb3Mjeseca.Checked)
                this.razdoblje = 3;
            prikaziNajboljeKupce();
        }

        private void rb6Mjeseci_CheckedChanged(object sender, EventArgs e)
        {
            if (rb6Mjeseci.Checked)
                this.razdoblje = 6;
            prikaziNajboljeKupce();
        }

        private void rb1Godina_CheckedChanged(object sender, EventArgs e)
        {
            if (rb1Godina.Checked)
                this.razdoblje = 12;
            prikaziNajboljeKupce();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
