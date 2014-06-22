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
    public partial class frmUnosKlijenta : Form
    {
        private klijent klijentZaIzmjenu;
        public frmUnosKlijenta()
        {
            InitializeComponent();
            this.CenterToParent();

            this.KeyPreview = true;

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

            btnOdustani.FlatStyle = FlatStyle.Flat;
            btnOdustani.FlatAppearance.BorderColor = Color.FromArgb(255, 50, 241);
            btnOdustani.FlatAppearance.BorderSize = 3;

            btnSpremiKlijent.FlatStyle = FlatStyle.Flat;
            btnSpremiKlijent.FlatAppearance.BorderColor = Color.FromArgb(255, 50, 241);
            btnSpremiKlijent.FlatAppearance.BorderSize = 3;

            lblAdresa.Font = new Font(lblAdresa.Font, FontStyle.Bold);
            lblEmail.Font = new Font(lblEmail.Font, FontStyle.Bold);
            lblNaziv.Font = new Font(lblNaziv.Font, FontStyle.Bold);
            lblOib.Font = new Font(lblOib.Font, FontStyle.Bold);
            lblTelefon.Font = new Font(lblTelefon.Font, FontStyle.Bold);
            lblZiroRacun.Font = new Font(lblZiroRacun.Font, FontStyle.Bold);
        }
        public frmUnosKlijenta(klijent klijent)
        {
            InitializeComponent();
            this.CenterToParent();

            //proslijeđuje se klijent tipa klijenta da se zna da li se želu unositi novi klijent ili ažurirati postojeći
            klijentZaIzmjenu = klijent;
            this.KeyPreview = true;

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

            btnOdustani.FlatStyle = FlatStyle.Flat;
            btnOdustani.FlatAppearance.BorderColor = Color.FromArgb(255, 50, 241);
            btnOdustani.FlatAppearance.BorderSize = 3;

            btnSpremiKlijent.FlatStyle = FlatStyle.Flat;
            btnSpremiKlijent.FlatAppearance.BorderColor = Color.FromArgb(255, 50, 241);
            btnSpremiKlijent.FlatAppearance.BorderSize = 3;

            lblAdresa.Font = new Font(lblAdresa.Font, FontStyle.Bold);
            lblEmail.Font = new Font(lblEmail.Font, FontStyle.Bold);
            lblNaziv.Font = new Font(lblNaziv.Font, FontStyle.Bold);
            lblOib.Font = new Font(lblOib.Font, FontStyle.Bold);
            lblTelefon.Font = new Font(lblTelefon.Font, FontStyle.Bold);
            lblZiroRacun.Font = new Font(lblZiroRacun.Font, FontStyle.Bold);

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Rukuje događajem klika na tipku Spremi.
        /// Najprije pravi validaciju unešenih podataka. Ako je sve dobro sprema se novi klijent u kolekciju klint te se sprema u bazu podataka.
        /// Ako se ažurira selektirani klinet ažuriraju se njegovi podaci.
        /// </summary>
        private void btnSpremiKlijent_Click(object sender, EventArgs e)
        { 
                string oib = txtOib.Text;
                string naziv = txtNaziv.Text;
                string adresa = txtAdresa.Text;
                string telefon = txtTelefon.Text;
                string e_mail = txtEmail.Text;
                string ziroRacun = txtZiroRacun.Text;
                
                /// Poruka o greški koja se javile prilikom validacije podataka frome
                string greska = "";

                /// Početna pretpostavka je da se OIB sastoji od znamenki raspona 0-9
                bool oibZnamenkast = true;

                /// Provjera sadrži li OIB znamenke raspona 0-9
                foreach (char znak in oib)
                {
                    if (Char.IsNumber(znak) == false)
                    {
                        oibZnamenkast = false;
                    }
                }

                /// Početna pretpostavka je da se OIB sastoji od znamenki raspona 0-9
                bool telefonZnamenkast = true;

                /// Provjera sadrži li broj telefona išta osim znamenki
                foreach (char znak in telefon)
                {
                    if (Char.IsNumber(znak) == false)
                    {
                        telefonZnamenkast = false;
                    }
                }

                /// Početna pretpostavka je da se OIB sastoji od znamenki raspona 0-9
                bool formatZiroRacuna = true;

                /// Provjera sadrži li broj telefona išta osim znamenki i znaka -
                foreach (char znak in ziroRacun)
                {
                    if (Char.IsNumber(znak) == false && znak != '-')
                    {
                        formatZiroRacuna = false;
                    }
                }
                if (txtOib.Text != "" && txtNaziv.Text != "" && txtEmail.Text != "" && txtAdresa.Text != "" && txtZiroRacun.Text != "" && txtTelefon.Text != "")
                {
                    if (oib.Length != 11 || oibZnamenkast == false)
                    {
                        greska = "OIB se mora sastojati od 11 znamenki!";
                    }
                    else if (Char.IsUpper(naziv[0]) == false)
                    {
                        greska = "Naziv mora početi velikim slovom";
                    }
                    else if (e_mail.Contains("@") == false)
                    {
                        greska = "email adresa nije ispravnog formata";
                    }
                    else if (telefon.Length < 6 || telefonZnamenkast == false)
                    {
                        greska = "Broj telefona se mora sastojati od barem 6 znamenki";
                    }
                    else if (Char.IsUpper(adresa[0]) == false)
                    {
                        greska = "Adresa mora početi velikim slovom";
                    }
                    else if (formatZiroRacuna == false || ziroRacun.Contains("-") == false)
                    {
                        greska = "Žiro račun mora sadržavati znamenke i znak -!";
                    }
                    else
                    {
                        try
                        {
                            using (var db = new greymatterpiEntities())
                            {
                                if (klijentZaIzmjenu == null)
                                {
                                    //Kreiramo novi objekt klase klijent i popunjavamo ga podacima sa forme.
                                    klijent noviKlijent = new klijent
                                    {
                                        oib = txtOib.Text,
                                        naziv = txtNaziv.Text,
                                        adresa = txtAdresa.Text,
                                        telefon = txtTelefon.Text,
                                        e_mail = txtEmail.Text,
                                        ziroRacun = txtZiroRacun.Text
                                    };
                                    db.klijent.Add(noviKlijent); //Dodajemo klijent u odgovarajuću kolekciju u kontekstu.
                                    db.SaveChanges(); //Spremamo napravljene promjene u bazu podataka.

                                }
                                else
                                {
                                    //Mijenjamo postojećeg klijenta
                                    db.klijent.Attach(klijentZaIzmjenu); //registriramo prosljeđenog klijenta.
                                    klijentZaIzmjenu.oib = txtOib.Text;
                                    klijentZaIzmjenu.naziv = txtNaziv.Text;
                                    klijentZaIzmjenu.telefon = txtTelefon.Text;
                                    klijentZaIzmjenu.ziroRacun = txtZiroRacun.Text;
                                    klijentZaIzmjenu.e_mail = txtEmail.Text;
                                    klijentZaIzmjenu.adresa = txtAdresa.Text;
                                    db.SaveChanges(); //Spremamo promjene u bazu.
                                }
                            }

                            Close();
                        }
                        catch
                        {
                            greska = "Problem u vezi sa bazom podataka ili su uneseni postojeći OIB i/ili žiro račun!";
                        }
                    }

                }
                else { MessageBox.Show("Morate popuniti sva polja!", "Upozorenje"); }
                

                /// Ispisuje se greška ako je do nje došlo prilikom validacije podataka forme
                /// Ako postoji više greški one će se, jedna po jedna, javljati svaki put nakon klika na gumb Spremi
                if (greska != "")
                {
                    MessageBox.Show(greska, "Greška");
                }
        
                
        }
        /// <summary>
        /// Ako postoji klijent kojeg želimo ažurirati njegovi podaci se prikazaju u textboxevima.
        /// </summary>
        private void frmUnosKlijenta_Load(object sender, EventArgs e)
        {

            if (klijentZaIzmjenu != null)
            {
                txtOib.Text = klijentZaIzmjenu.oib;
                txtNaziv.Text = klijentZaIzmjenu.naziv;
                txtAdresa.Text = klijentZaIzmjenu.adresa;
                txtEmail.Text = klijentZaIzmjenu.e_mail;
                txtTelefon.Text = klijentZaIzmjenu.telefon;
                txtZiroRacun.Text = klijentZaIzmjenu.ziroRacun;
            }
        }

        private void hlpPokazi(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string naslov = "POMOĆ AŽURIRANJE/UNOS KLIJENATA";
                string poruka = " Na formi Unos klijenta unosite novo poduzeće sa kojim još poduzeće nije poslovalo. Potrebno je ";
                poruka += "unijeti podatke o klijentu te možete odabrati dvije opcije. \n\n Klikom na tipku Spremi unijeti ćete novog ";
                poruka += "klijenta u bazu. \n\n U slučaju da ne želite spremiti unijete podatke to ćete učiniti pritiskom na tipku ";
                poruka += "Odustani.\n\n Na formi Ažuriranje klijenta unose se podaci o klijentu koji su se promijenili (npr. novi broj telefona klijenta).";
                poruka += "\n\n Klikom na tipku Spremi unijeti ćete izmijenjene podatke o klijentu. \n\n Ukoliko ne želite spremiti izmijenjene podatke kliknite";
                poruka += "na tipku Odustani.";
                frmHelp formaHelp = new frmHelp(naslov, poruka);
                formaHelp.ShowDialog();
            }
        }


    }
}
