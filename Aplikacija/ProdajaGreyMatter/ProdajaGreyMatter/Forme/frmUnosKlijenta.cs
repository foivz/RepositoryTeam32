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
        }
        public frmUnosKlijenta(klijent klijent)
        {
            InitializeComponent();
            klijentZaIzmjenu = klijent;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
                                klijent noviKlijent = new klijent
                                {
                                    oib = txtOib.Text,
                                    naziv = txtNaziv.Text,
                                    adresa = txtAdresa.Text,
                                    telefon = txtTelefon.Text,
                                    e_mail = txtEmail.Text,
                                    ziroRacun = txtZiroRacun.Text
                                };
                                db.klijent.Add(noviKlijent);
                                db.SaveChanges();

                            }
                            else
                            {
                                db.klijent.Attach(klijentZaIzmjenu);
                                klijentZaIzmjenu.oib = txtOib.Text;
                                klijentZaIzmjenu.naziv = txtNaziv.Text;
                                klijentZaIzmjenu.telefon = txtTelefon.Text;
                                klijentZaIzmjenu.ziroRacun = txtZiroRacun.Text;
                                klijentZaIzmjenu.e_mail = txtEmail.Text;
                                klijentZaIzmjenu.adresa = txtAdresa.Text;
                                db.SaveChanges();
                            }
                        }

                        Close();
                    }
                    catch
                    {
                        greska = "Problem u vezi sa bazom podataka ili su uneseni postojeći OIB i/ili žiro račun!";
                    }
                    
                }

                /// Ispisuje se greška ako je do nje došlo prilikom validacije podataka forme
                /// Ako postoji više greški one će se, jedna po jedna, javljati svaki put nakon klika na gumb Spremi
                if (greska != "")
                {
                    MessageBox.Show(greska, "Greška");
                }
                
        }

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


    }
}
