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
    public partial class frmNajprodavanijiLijekovi : Form
    {
        private int razdoblje = 0;
        public frmNajprodavanijiLijekovi()
        {
            InitializeComponent();
            prikaziNajprodavanijeLijekove();
        }
        private void prikaziNajprodavanijeLijekove()
        {
            if (rb3Mjeseca.Checked)
                this.razdoblje = 3;
            else if (rb6Mjeseci.Checked)
                this.razdoblje = 6;
            else
                this.razdoblje = 12;
            BindingList<narudzbenica> listaNarudzbenica = null;
            BindingList<zaposlenik> listaZaposlenika = null;
            BindingList<lijek> listaLijekova = null;
            List<string> lijekNaziv = new List<string>();
            List<int> lijekKolicina = new List<int>(); ;
            using (var db = new greymatterpiEntities())
            {
                listaNarudzbenica = new BindingList<narudzbenica>(db.narudzbenica.ToList());
                listaZaposlenika = new BindingList<zaposlenik>(db.zaposlenik.ToList());
                listaLijekova = new BindingList<lijek>(db.lijek.ToList());
                DateTime od = DateTime.Now.AddMonths(-(razdoblje));
                DateTime sada = DateTime.Now;
                foreach (var lijekN in listaLijekova)
                {
                    lijekNaziv.Add(lijekN.naziv);
                    var rezultat = (from l in db.lijek
                                   join sn in db.stavkenarudzbenice on l.idLijek equals sn.idLijek
                                   join n in db.narudzbenica on sn.idNarudzbenice equals n.idNarudzbenice
                                   where l.naziv == lijekN.naziv && n.status == 1 && (n.datumIzdavanja >= od && n.datumIzdavanja <= sada)
                                   select sn.kolicina).Sum();
                    lijekKolicina.Add(rezultat);
                }
            } 
            var graf = new Chart();
            graf.Size = new Size(800, 400);
            var naslov = new Title();
            naslov.Text = "Najprodavaniji lijekovi";
            naslov.Font = new Font("Arial", 14);
            var grafPodrucje = new ChartArea();
            grafPodrucje.AxisX.MajorGrid.LineColor = Color.LightGray;
            grafPodrucje.AxisY.MajorGrid.LineColor = Color.LightGray;
            grafPodrucje.AxisX.LabelStyle.Font = new Font("Consolas", 8);
            grafPodrucje.AxisY.LabelStyle.Font = new Font("Consolas", 8);
            graf.ChartAreas.Add(grafPodrucje);
            graf.Titles.Add(naslov);
            var podaci = new Series();
            podaci.Name = "podaci";
            podaci.ChartType = SeriesChartType.Column;
            podaci.Points.DataBindY(lijekKolicina);
            podaci.IsValueShownAsLabel = true;  
            graf.Series.Add(podaci);    
            int j = 0;
            foreach (var c in lijekNaziv)
            {
                graf.Series[0].Points[j].AxisLabel = lijekNaziv[j].ToString();
                j++;
            }                
            graf.Invalidate();
            graf.SaveImage("chart1.png", ChartImageFormat.Png);
            pictureBox1.ImageLocation = @"chart1.png";      
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rb3Mjeseca_CheckedChanged(object sender, EventArgs e)
        {
            if (rb3Mjeseca.Checked)
                this.razdoblje = 3;
            prikaziNajprodavanijeLijekove();
        }

        private void rb6Mjeseci_CheckedChanged(object sender, EventArgs e)
        {
            if (rb6Mjeseci.Checked)
                this.razdoblje = 6;
            prikaziNajprodavanijeLijekove();
        }

        private void rb1Godina_CheckedChanged(object sender, EventArgs e)
        {
            if (rb1Godina.Checked)
                this.razdoblje = 12;
            prikaziNajprodavanijeLijekove();
        }
    }
}
