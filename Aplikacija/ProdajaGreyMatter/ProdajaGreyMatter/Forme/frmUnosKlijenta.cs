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
