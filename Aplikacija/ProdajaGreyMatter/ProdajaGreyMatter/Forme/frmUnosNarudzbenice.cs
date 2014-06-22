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
            this.KeyPreview = true;
            referent = zaposlenik;

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

            btnDodajStavku.FlatStyle = FlatStyle.Flat;
            btnDodajStavku.FlatAppearance.BorderColor = Color.FromArgb(255, 50, 241);
            btnDodajStavku.FlatAppearance.BorderSize = 3;

            btnIzbrisi.FlatStyle = FlatStyle.Flat;
            btnIzbrisi.FlatAppearance.BorderColor = Color.FromArgb(255, 50, 241);
            btnIzbrisi.FlatAppearance.BorderSize = 3;

            btnIzmjeni.FlatStyle = FlatStyle.Flat;
            btnIzmjeni.FlatAppearance.BorderColor = Color.FromArgb(255, 50, 241);
            btnIzmjeni.FlatAppearance.BorderSize = 3;

            btnOdustani.FlatStyle = FlatStyle.Flat;
            btnOdustani.FlatAppearance.BorderColor = Color.FromArgb(255, 50, 241);
            btnOdustani.FlatAppearance.BorderSize = 3;

            btnSpremi.FlatStyle = FlatStyle.Flat;
            btnSpremi.FlatAppearance.BorderColor = Color.FromArgb(255, 50, 241);
            btnSpremi.FlatAppearance.BorderSize = 3;

            lblIdNarudzbenice.Font = new Font(lblIdNarudzbenice.Font, FontStyle.Bold);

            lblNazivKlijenta.Font = new Font(lblNazivKlijenta.Font, FontStyle.Bold);

            lblReferent.Font = new Font(lblReferent.Font, FontStyle.Bold);

            lblRokPlacanja.Font = new Font(lblRokPlacanja.Font, FontStyle.Bold);

            lblUkupniIznosNarudzbe.Font = new Font(lblUkupniIznosNarudzbe.Font, FontStyle.Bold);
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Dohvaća se proslijeđeni zaposlenik te se dodaje pripadajućem BindingSourcu.
        /// Također se i dohvaćaju svi klijentu u listuKlijenata iz kolekcije klijent te se combobox-u dodaju nazivi klijenata.
        /// Te se postavlja da Rok plaćanja ne može biti manji od trenutnog vremena.
        /// </summary>
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

        /// <summary>
        /// Rukuje događajem klika na gumb Spremi.
        /// Prvo se radi validacija unosa te ako je sve popunjeno,sprema se narudžbenica te njezine pripadajuće stavke.
        /// </summary>
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
        /// <summary>
        /// Rukuje događajem klika na gumb DodajStavku.
        /// Najprije se dolazi do id-a zadnje narudzbenice
        /// </summary>
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

        private void hlpPokazi(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string naslov = "POMOĆ UNOS NARUDŽBENICE";
                string poruka = " Na formi Unos narudžbenice možete upisati novu narudžbu. Kako bi se u tablici prikazali lijekovi koje ";
                poruka += "klijent naručuje, količina pojedinog lijeka itd. potrebno je kliknuti na tipku Dodaj stavku (za svaki lijek ";
                poruka += "koji želite u narudžbenici).\n\n Klikom na tipku izbriši možete izbrisati pojedinu stavku iz narudžbenice, a ";
                poruka += "klikom na tipku Izmjeni možete izmijeniti pojedinu stavku narudžbenice. \n\n Na ovoj formi nalaze se još ";
                poruka += "dvije opcije. Ukoliko ne želite spremiti narudžbenicu dovoljno je da kliknete na tipku Odustani.\n\n Želite ";
                poruka += "li spremiti narudžbenicu sa svim unesenim stavkama kliknite na tipku Spremi. ";
                
                frmHelp formaHelp = new frmHelp(naslov, poruka);
                formaHelp.ShowDialog();
            }
        }

        private void txtIdNarudzbenice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
