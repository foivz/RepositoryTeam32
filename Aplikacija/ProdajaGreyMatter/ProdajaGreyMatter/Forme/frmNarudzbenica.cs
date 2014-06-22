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
    public partial class frmNarudzbenica : Form
    {
        private zaposlenik referent;
        public frmNarudzbenica(zaposlenik zaposlenik)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.CenterToParent();
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

            btnNatrag.FlatStyle = FlatStyle.Flat;
            btnNatrag.FlatAppearance.BorderColor = Color.FromArgb(255, 50, 241);
            btnNatrag.FlatAppearance.BorderSize = 3;

            btnNatrag.FlatStyle = FlatStyle.Flat;
            btnNatrag.FlatAppearance.BorderColor = Color.FromArgb(255, 50, 241);
            btnNatrag.FlatAppearance.BorderSize = 3;

            btnStorno.FlatStyle = FlatStyle.Flat;
            btnStorno.FlatAppearance.BorderColor = Color.FromArgb(255, 50, 241);
            btnStorno.FlatAppearance.BorderSize = 3;

            btnUnosNarudzbenice.FlatStyle = FlatStyle.Flat;
            btnUnosNarudzbenice.FlatAppearance.BorderColor = Color.FromArgb(255, 50, 241);
            btnUnosNarudzbenice.FlatAppearance.BorderSize = 3;

            btnIzvjestaj.FlatStyle = FlatStyle.Flat;
            btnIzvjestaj.FlatAppearance.BorderColor = Color.FromArgb(255, 50, 241);
            btnIzvjestaj.FlatAppearance.BorderSize = 3;

            lblPretragaPremaKlijentu.Font = new Font(lblPretragaPremaKlijentu.Font, FontStyle.Bold);
            lblUkupniIznosNarudzbe.Font = new Font(lblUkupniIznosNarudzbe.Font, FontStyle.Bold);
        }
        /// <summary>
        /// Metoda prikaziNarudzbe dohvaća listu svih narudžbenica iz kolekcije lijekovi u kontekstu te ih prikazuje i DataGrid-u.
        /// Također dohvaća listu zaposlenika i klijenata iz kolekcija zaposlenik i klijent.
        /// To omogućuje prikazivanje naziva zaposlenika i klijenata na temelju dohvaćenog id-a zapsolenika te klijenta.
        /// Nakon toga provjerava za svaku narudzbenicu kakav joj je status te ako je narudzbenica stornirana pozadinu toga reda postavlja na crveno.
        /// </summary>
        private void prikaziNarudzbe()
        {
            BindingList<narudzbenica> listaNarudzbenica = null;
            BindingList<zaposlenik> listaZaposlenika = null;
            BindingList<klijent> listaKlijenata = null;
            using (var db = new greymatterpiEntities())
            {
                listaNarudzbenica = new BindingList<narudzbenica>(db.narudzbenica.ToList());
                listaZaposlenika = new BindingList<zaposlenik>(db.zaposlenik.ToList());
                listaKlijenata = new BindingList<klijent>(db.klijent.ToList());
                
            }
            narudzbenicaBindingSource.DataSource = listaNarudzbenica;
            zaposlenikBindingSource.DataSource = listaZaposlenika;
            klijentBindingSource.DataSource = listaKlijenata;
            
            int broj = dgPopisNarudžbenica.Rows.Count;

            for (int i = 0; i < broj; i++)
			{
			  if (Convert.ToInt32(dgPopisNarudžbenica.Rows[i].Cells[1].Value) == 0)
                {
                    dgPopisNarudžbenica.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
			}
        }
        /// <summary>
        /// Metoda prikaziStavkeNarudzbenice dohvaća listu stavaka narudbenice proslijeđene narudzbenice iz kolekcije stavkenarudzbenice u kontekstu te ih prikazuje u DataGrid-u.
        /// Također dohvaća listu lijekova iz kolekcije lijekova.
        /// To omogućuje prikazivanje naziva i cijene lijeka na temelju dohvaćenog id-a lijeka.
        /// Računa se i ukupan iznos svih stavaka narudžbenice koja je "registrirana" te ako je narudzbenica stornirana pozadinska boja stavaka se postavlja na crveno.
        /// </summary>
        /// <param name="narudzbenica">Narudzbenica čije stavke želimo prikazati</param>
        private void prikaziStavkeNarudzbenice(narudzbenica narudzbenica)
        {
            BindingList<stavkenarudzbenice> listaStavakaNarudzbenica = null;
            BindingList<lijek> listaLijekova = null;
            using (var db = new greymatterpiEntities())
            {
                db.narudzbenica.Attach(narudzbenica);
                listaStavakaNarudzbenica = new BindingList<stavkenarudzbenice>(narudzbenica.stavkenarudzbenice.ToList());
                listaLijekova = new BindingList<lijek>(db.lijek.ToList());
            }
            stavkenarudzbeniceBindingSource.DataSource = listaStavakaNarudzbenica;
            lijekBindingSource.DataSource = listaLijekova;
            using (var db = new greymatterpiEntities())
            {
                db.narudzbenica.Attach(narudzbenica);
                listaStavakaNarudzbenica = new BindingList<stavkenarudzbenice>(narudzbenica.stavkenarudzbenice.ToList());
                listaLijekova = new BindingList<lijek>(db.lijek.ToList());
                
                int brojRedova = dtvStavkeNarudzbenice.Rows.Count;
                for (int j = 0; j < brojRedova; j++)
                {
                    int kolicina = 0;
                    kolicina = int.Parse(dtvStavkeNarudzbenice.Rows[j].Cells[2].Value.ToString());
                    int id = int.Parse(dtvStavkeNarudzbenice.Rows[j].Cells[1].Value.ToString());
                    var rezultat = (from k in db.lijek
                                    where k.idLijek == id
                                    select k.cijena).First();
                    double cijena = double.Parse(rezultat.ToString());
                    dtvStavkeNarudzbenice.Rows[j].Cells["Ukupno"].Value = kolicina * cijena;
                   
                }
            }
            if (narudzbenica.status == 0)
            {
                int broj = dtvStavkeNarudzbenice.Rows.Count;
                for (int i = 0; i < broj; i++)
                {
                        dtvStavkeNarudzbenice.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void frmNarudzbenica_Load(object sender, EventArgs e)
        {
            prikaziNarudzbe();
            prikaziStavkeNarudzbenice(narudzbenicaBindingSource.Current as narudzbenica);
            
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUnosNarudzbenice_Click(object sender, EventArgs e)
        {
            frmUnosNarudzbenice novaNarudzbenica = new frmUnosNarudzbenice(referent);
            novaNarudzbenica.ShowDialog();
            prikaziNarudzbe();
        }
        /// <summary>
        /// Rukuje događajem promjene teksta,tj. upisa teksta u textbox txtPretragaKlijenta.
        /// Prilikom svakog upisa se provjerava pomoću linq upita da li postoji narudzbenica koja pripada unešenom nazivu klijenta.
        /// Pretražuju se narudžbenice prema nazovu klijenta. Ako postoje takve narudzbenice one se dodaju u Bindinglistu tipa narudzbenice te se prikazuju na DataGridu.
        /// </summary>
        private void txtPretragaKlijenta_TextChanged(object sender, EventArgs e)
        {
            if (txtPretragaKlijenta.Text != null)
            {
                BindingList<narudzbenica> listaNarudzbenica = null;
                using (var db = new greymatterpiEntities())
                {
                    IEnumerable<narudzbenica> narudzbenice = from p in db.narudzbenica
                                                             join c in db.klijent
                                                             on p.oibKlijenta equals c.oib
                                                             where c.naziv.Contains(txtPretragaKlijenta.Text)
                                                             select p;
                    listaNarudzbenica = new BindingList<narudzbenica>(narudzbenice.ToList());
                }
                narudzbenicaBindingSource.DataSource = listaNarudzbenica;
                int broj = dgPopisNarudžbenica.Rows.Count;

                for (int i = 0; i < broj; i++)
                {
                    if (Convert.ToInt32(dgPopisNarudžbenica.Rows[i].Cells[1].Value) == 0)
                    {
                        dgPopisNarudžbenica.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
            else if (txtPretragaKlijenta.Text == "")
            {
                prikaziNarudzbe();
            }
        }
        /// <summary>
        /// Metoda dgPopisNarudžbenica_SelectionChanged se pokreće na događaj promjene selektirane narudžbenice na DataGrid-u.
        /// Trenutno označena narudžbenica se sprema objekt selektiranaNarudzbenica tipa narudzbenica te se poziva metoda koja prikazuje stavke narudžbenice proslijeđenom narudzbenicom.
        /// Također se izračunava ukupni iznos selektirane narudžbenice.
        /// Ako je selektirana narudžbenica stornirana textboxu txtUkupniIznosStavke se mijenja pozadina u crveno
        /// </summary>
        private void dgPopisNarudžbenica_SelectionChanged(object sender, EventArgs e)
        {
            narudzbenica selektiranaNarudzbenica = narudzbenicaBindingSource.Current as narudzbenica;
            if (selektiranaNarudzbenica != null)
            {
                prikaziStavkeNarudzbenice(selektiranaNarudzbenica);
                int brojRedova = dtvStavkeNarudzbenice.Rows.Count;
                double ukupno = 0.0d;
                for (int j = 0; j < brojRedova; j++)
                {
                    double ukupniIznosStavke = double.Parse(dtvStavkeNarudzbenice.Rows[j].Cells["Ukupno"].Value.ToString());
                    ukupno += ukupniIznosStavke;
                }
                Color boja = txtUkupniIznosNarudžbe.BackColor;
                if (selektiranaNarudzbenica.status == 0)
                {
                    txtUkupniIznosNarudžbe.BackColor = Color.Red;
                }
                else txtUkupniIznosNarudžbe.BackColor = DefaultBackColor;
                txtUkupniIznosNarudžbe.Text = ukupno.ToString("C");
            }
        }
        /// <summary>
        /// Metoda btnStorno_Click se pokreće na klik gumba btnStorno i njezina funkcija je da označenu narudžbenicu stornira
        /// U objekt oznaceNarudzbenica tipa narudzbenica se sprema označena narudžbenica te se provjerava da li je status 
        /// narudžbenice jednak 1,ako referent odabere da želi stornirati narudžbenicu njezin status se stavlja na 0.
        /// Također ne mogu se stornirati narudžbenice napravljene više od tjedan dana od današnjeg datuma.
        /// </summary>
        private void btnStorno_Click(object sender, EventArgs e)
        {
            DateTime datum = DateTime.Now.AddDays(-7);
            narudzbenica oznacenaNarudzbenica = narudzbenicaBindingSource.Current as narudzbenica;
            if (oznacenaNarudzbenica.datumIzdavanja > datum)
            {
                if (oznacenaNarudzbenica.status == 1)
                {
                    if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        using (var db = new greymatterpiEntities())
                        {
                            db.narudzbenica.Attach(oznacenaNarudzbenica);
                            oznacenaNarudzbenica.status = 0;
                            db.SaveChanges();

                            /// Dohvaćanje stavki koje se odnose na narudžbenicu koja se stornira
                            IEnumerable<stavkenarudzbenice> stavkeNarudzbenice = from s in db.stavkenarudzbenice
                                                                                 join n in db.narudzbenica
                                                                                 on s.idNarudzbenice equals n.idNarudzbenice
                                                                                 where s.idNarudzbenice == oznacenaNarudzbenica.idNarudzbenice
                                                                                 select s;

                            List<stavkenarudzbenice> stavkeNarudzbeniceLista = stavkeNarudzbenice.ToList();

                            /// Dohvaćanje lijekova koji čine stavke narudžbenice koja se stornira kako bi se količina 
                            /// odgovarajućih lijekova vratila na stanje prije kreiranja narudžbenice koja se stornira
                            IEnumerable<lijek> lijekovi = from l in db.lijek
                                                          join s in db.stavkenarudzbenice
                                                          on l.idLijek equals s.idLijek
                                                          where s.idNarudzbenice == oznacenaNarudzbenica.idNarudzbenice
                                                          select l;

                            /// Potrebna pretvorba kako bi se podaci o lijeku mogli upisivati u BP
                            List<lijek> lijekoviLista = lijekovi.ToList();

                            /// Vraćanje količina lijekova na stanje prije kreiranja narudžbenice koja se stornira
                            foreach (lijek lijekic in lijekoviLista)
                            {
                                foreach (stavkenarudzbenice stavka in stavkeNarudzbeniceLista)
                                {
                                    if (lijekic.idLijek == stavka.idLijek)
                                    {
                                        lijekic.kolicina += stavka.kolicina;
                                        db.SaveChanges();
                                    }
                                }
                            }
                        }

                        prikaziNarudzbe();
                    }
                }

                else
                {
                    MessageBox.Show("Ova narudžbenica je već stornirana!", "Upozorenje");
                }
            }
            else { MessageBox.Show("Mogu se stornirati narudžbenice napravljene samo zadnjih tjedan dana", "Upozorenje!"); }

        }

        private void hlpPokazi(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string naslov = "POMOĆ NARUDŽBENICE";
                string poruka = " Odabirom Narudžbenice u glavnom izborniku otvara se forma na kojoj možemo vidjeti popis svih";
                poruka += " narudžba.\n\n Isto tako prikazani je obrazac narudžbenice koji će se popuniti nakon što unesemo novu";
                poruka += " narudžbu te će se ispod tog obrasca  prikazati ukupan iznos narudžbe.\n\n Novu narudžbu unosimo ";
                poruka += " popunjavanjem narudžbenice klikom na tipku Unos nove narudžbenice.\n\n Ukoliko unesete narudžbu i ";
                poruka += " spremite je, a klijent odustane od narudžbe ili ste unesli krivu narudžbu možete je stonirati klikom na ";
                poruka += " tipku Storno.\n\n Za ispis računa pritisnite tipku Izvještaj.\n\n Na glavnu formu vraćate se tipkom Natrag.";
                frmHelp formaHelp = new frmHelp(naslov, poruka);
                formaHelp.ShowDialog();
            }
        }

        private void txtUkupniIznosNarudžbe_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            narudzbenica selektiranaNarudzbenica = narudzbenicaBindingSource.Current as narudzbenica;
            int id = selektiranaNarudzbenica.idNarudzbenice;
            frmNarudzbenicaReport formaReport = new frmNarudzbenicaReport(id);
            formaReport.ShowDialog();
        }
    }
}
