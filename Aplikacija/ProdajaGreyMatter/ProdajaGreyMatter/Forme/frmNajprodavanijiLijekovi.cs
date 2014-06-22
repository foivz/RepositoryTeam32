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
            this.CenterToParent();

            prikaziNajprodavanijeLijekove();
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
        /// <summary>
        /// Dohvaća listu svih lijekova iz kolekcije lijek u kontekstu te zbraja količinu prodanih lijekova.
        /// Sortira lijekove i količinu prema najvećoj količini i prikazuje samo top 5 najprodavanijih lijekova na grafu.
        /// </summary>
        private void prikaziNajprodavanijeLijekove()
        {
            if (rb3Mjeseca.Checked)
                this.razdoblje = 3;
            else if (rb6Mjeseci.Checked)
                this.razdoblje = 6;
            else
                this.razdoblje = 12;
            BindingList<lijek> listaLijekova = null;
            List<string> lijekNaziv = new List<string>();
            List<int> lijekKolicina = new List<int>(); ;
            using (var db = new greymatterpiEntities())
            {
                listaLijekova = new BindingList<lijek>(db.lijek.ToList());
                DateTime od = DateTime.Now.AddMonths(-(razdoblje));
                DateTime sada = DateTime.Now;
                foreach (var lijekN in listaLijekova)
                {
                    lijekNaziv.Add(lijekN.naziv);
                    var rezultat = from l in db.lijek
                                   join sn in db.stavkenarudzbenice on l.idLijek equals sn.idLijek
                                   join n in db.narudzbenica on sn.idNarudzbenice equals n.idNarudzbenice
                                   where l.naziv == lijekN.naziv && n.status == 1 && (n.datumIzdavanja >= od && n.datumIzdavanja <= sada)
                                   select sn.kolicina;
                    if (rezultat.Any())
                        lijekKolicina.Add(rezultat.Sum());
                    else
                        lijekKolicina.Add(0);
                }
            }
            for (int i = 0; i < lijekNaziv.Count(); i++)
            {
                for (int j = 0; j < lijekNaziv.Count() - 1; j++)
                {
                    if (lijekKolicina[j] < lijekKolicina[j + 1])
                    {
                        int temp = lijekKolicina[j];
                        lijekKolicina[j] = lijekKolicina[j + 1];
                        lijekKolicina[j + 1] = temp;
                        string temp2 = lijekNaziv[j];
                        lijekNaziv[j] = lijekNaziv[j + 1];
                        lijekNaziv[j + 1] = temp2;
                    }
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
            graf.Legends.Add(new Legend("legenda"));
            var podaci = new Series();
            podaci.Name = "podaci";
            podaci.LegendText = "Količina(kom)";
            podaci.ChartType = SeriesChartType.Column;
            List<int> lijekKolicinaNova = new List<int>();
            for (int j = 0; j < 5; j++)
                lijekKolicinaNova.Add(lijekKolicina[j]); 
            podaci.Points.DataBindY(lijekKolicinaNova);
            podaci.IsValueShownAsLabel = true;  
            graf.Series.Add(podaci);
            for (int j = 0; j < 5; j++)
                graf.Series[0].Points[j].AxisLabel = lijekNaziv[j].ToString();
            string putanja = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            graf.SaveImage(putanja + @"\najboljiKupci.png", ChartImageFormat.Png);
            graf.SaveImage(putanja+@"\najprodavanijiLijekovi.png", ChartImageFormat.Png);
            pictureBox1.ImageLocation = putanja+@"\najprodavanijiLijekovi.png";  
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
