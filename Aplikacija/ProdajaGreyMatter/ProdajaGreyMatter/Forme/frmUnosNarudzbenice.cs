using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdajaGreyMatter
{
    public partial class frmUnosNarudzbenice : Form
    {
        private zaposlenik referent;
        private BindingList<stavkenarudzbenice> stavkeNar = new BindingList<stavkenarudzbenice>();
        public frmUnosNarudzbenice(zaposlenik zaposlenik)
        {
            InitializeComponent();
            this.CenterToParent();
            referent = zaposlenik;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmUnosNarudzbenice_Load(object sender, EventArgs e)
        {
                zaposlenikBindingSource.DataSource = referent;
                BindingList<klijent> listaKlijenata = null;
                using (var db = new greymatterpiEntities())
                {
                    listaKlijenata = new BindingList<klijent>(db.klijent.ToList());
                }
                foreach (var klijent in listaKlijenata)
                {
                    cmbNazivKlijenta.Items.Add(klijent.naziv);
                }

                dtpRokPlacanja.MinDate = DateTime.Now;
          
        }
    
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (cmbNazivKlijenta.Text == "")
            {
                MessageBox.Show("Klijent nije odabran!", "Greška");
            }
            else if (stavkeNar.Count == 0)
            {
                MessageBox.Show("Nije dodana ni jedna stavka!", "Greška");
            }

            using (var db = new greymatterpiEntities())
            {
                var klijent = from p in db.klijent
                              where p.naziv == cmbNazivKlijenta.Text
                              select p.oib;
                string oib = klijent.First();

                narudzbenica narudzba = new narudzbenica()
                {
                    oibKlijenta = oib,
                    oibZaposlenika = referent.oib,
                    datumIzdavanja = dtpDatumIzdavanjaNarudzbenice.Value,
                    rokPlacanja = dtpRokPlacanja.Value,
                    status = 1
                };
                db.narudzbenica.Add(narudzba);
                db.SaveChanges();
                var b = from n in db.narudzbenica orderby n.idNarudzbenice descending select n.idNarudzbenice;
                int id = b.First();
                foreach(var a in stavkeNar)
                {
                    stavkenarudzbenice stavke = new stavkenarudzbenice()
                    {
                        idLijek = a.idLijek,
                        kolicina = a.kolicina,
                        idNarudzbenice = id
                    };
                    db.stavkenarudzbenice.Add(stavke);
                    db.SaveChanges();
                }
               
            }
            this.Close();
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            int ID = 0;
            using(var db = new greymatterpiEntities())
            {
                IEnumerable<int> ideviNarudzbenica = from p in db.narudzbenica
                             select p.idNarudzbenice;
                ID = ideviNarudzbenica.Last();

            }
            frmUnosStavke unosStavke = new frmUnosStavke(stavkeNar);
            unosStavke.ShowDialog();

            if (unosStavke.odustani != true)
            {
                stavkenarudzbeniceBindingSource.Add(unosStavke.stavkaNarudzbenice);
                BindingList<lijek> listaLijekova = null;
                using (var db = new greymatterpiEntities())
                {

                    listaLijekova = new BindingList<lijek>(db.lijek.ToList());
                }
                lijekBindingSource.DataSource = listaLijekova;
                stavkeNar.Add(unosStavke.stavkaNarudzbenice);

                ukupnoStavkaIzracun();
                ukupniIznosNarudzbe();
            }
       
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            stavkenarudzbenice selektiranaStavka = stavkenarudzbeniceBindingSource.Current as stavkenarudzbenice;
            if (selektiranaStavka != null)
            {
                frmUnosStavke unosStavke = new frmUnosStavke(selektiranaStavka);
                unosStavke.ShowDialog();

                if (unosStavke.odustani != true)
                {

                    stavkenarudzbeniceBindingSource.RemoveCurrent();
                    stavkenarudzbeniceBindingSource.Add(unosStavke.stavkaNarudzbenice);

                    stavkeNar.Remove(selektiranaStavka);
                    stavkeNar.Add(unosStavke.stavkaNarudzbenice);
                    int brojRedova = dtvStavkeNarudzbenice.Rows.Count;
                    ukupnoStavkaIzracun();
                    ukupniIznosNarudzbe();
                }
            }
            else
            {
                MessageBox.Show("Ne postoje stavke za izmjenu", "Greška");
            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            stavkenarudzbenice selektiranaStavka = stavkenarudzbeniceBindingSource.Current as stavkenarudzbenice;
            if (selektiranaStavka != null)
            {
                stavkenarudzbeniceBindingSource.RemoveCurrent();
                stavkeNar.Remove(selektiranaStavka);
                ukupniIznosNarudzbe();
            }
            else
            {
                MessageBox.Show("Ne postoje stavke za brisanje", "Greška");
            }
        }
        private void ukupnoStavkaIzracun()
        {
            int brojRedova = dtvStavkeNarudzbenice.Rows.Count;
            using (var db = new greymatterpiEntities())
            {
                for (int j = 0; j < brojRedova; j++)
                {
                    int kolicina = 0;
                    kolicina = int.Parse(dtvStavkeNarudzbenice.Rows[j].Cells["kolicina"].Value.ToString());
                    int id = int.Parse(dtvStavkeNarudzbenice.Rows[j].Cells[0].Value.ToString());
                    double rezultat = (from k in db.lijek
                                       where k.idLijek == id
                                       select k.cijena).First();
                    double cijena = double.Parse(rezultat.ToString());
                    dtvStavkeNarudzbenice.Rows[j].Cells["Ukupno"].Value = kolicina * cijena;

                }
            }
        }

        private void ukupniIznosNarudzbe()
        {
            int brojRedova = dtvStavkeNarudzbenice.Rows.Count;
            double ukupno = 0.0d;
            for (int j = 0; j < brojRedova; j++)
            {
                double ukupniIznosStavke = double.Parse(dtvStavkeNarudzbenice.Rows[j].Cells["Ukupno"].Value.ToString());
                ukupno += ukupniIznosStavke;
            }
            txtUkupniIznosNarudzbe.Text = ukupno.ToString("C");
        }
    }
}
