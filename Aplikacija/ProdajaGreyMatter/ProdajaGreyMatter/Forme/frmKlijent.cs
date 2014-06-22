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
    public partial class frmKlijent : Form
    {
        public frmKlijent()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.CenterToParent();

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

            btnAzuriranjeKlijenta.FlatStyle = FlatStyle.Flat;
            btnAzuriranjeKlijenta.FlatAppearance.BorderColor = Color.FromArgb(255, 50, 241);
            btnAzuriranjeKlijenta.FlatAppearance.BorderSize = 3;

            btnNatrag.FlatStyle = FlatStyle.Flat;
            btnNatrag.FlatAppearance.BorderColor = Color.FromArgb(255, 50, 241);
            btnNatrag.FlatAppearance.BorderSize = 3;

            btnUnosKlijenta.FlatStyle = FlatStyle.Flat;
            btnUnosKlijenta.FlatAppearance.BorderColor = Color.FromArgb(255, 50, 241);
            btnUnosKlijenta.FlatAppearance.BorderSize = 3;

            label1.Font = new Font(label1.Font, FontStyle.Bold);
            label2.Font = new Font(label2.Font, FontStyle.Bold);
        }

        private void prikaziKlijente()
        {
            BindingList<klijent> listaKlijenta = null;
            using (var db = new greymatterpiEntities())
            {
                listaKlijenta = new BindingList<klijent>(db.klijent.ToList());
                klijentBindingSource.DataSource = listaKlijenta;
            }
        }

        private void frmKlijent_Load(object sender, EventArgs e)
        {
            prikaziKlijente();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPretragaOib_TextChanged_1(object sender, EventArgs e)
        {
            if (txtPretragaOib.Text != null)
            {
                BindingList<klijent> listaKlijenata = null;
                using (var db = new greymatterpiEntities())
                {
                    IEnumerable<klijent> klijenti = from p in db.klijent
                                                    where p.oib.StartsWith(txtPretragaOib.Text)
                                                    select p;
                    listaKlijenata = new BindingList<klijent>(klijenti.ToList());
                }
                klijentBindingSource.DataSource = listaKlijenata;
            }
            else if (txtPretragaOib.Text == "")
            {
                prikaziKlijente();
            }
        }

        private void txtPretragaNaziv_TextChanged(object sender, EventArgs e)
        {
            if (txtPretragaNaziv.Text != null)
            {
                BindingList<klijent> listaKlijenata = null;
                using (var db = new greymatterpiEntities())
                {
                    IEnumerable<klijent> klijenti = from p in db.klijent
                                                    where p.naziv.Contains(txtPretragaNaziv.Text)
                                                    select p;
                    listaKlijenata = new BindingList<klijent>(klijenti.ToList());
                }
                klijentBindingSource.DataSource = listaKlijenata;
            }
            else if (txtPretragaNaziv.Text == "")
            {
                prikaziKlijente();
            }
        }

        private void btnUnosKlijenta_Click(object sender, EventArgs e)
        {
            frmUnosKlijenta unosKlijenta = new frmUnosKlijenta();
            unosKlijenta.ShowDialog();
            prikaziKlijente();
        }

        private void btnAzuriranjeKlijenta_Click(object sender, EventArgs e)
        {
            klijent selektiraniKlijent = klijentBindingSource.Current as klijent;
            if (selektiraniKlijent != null)
            {
                frmUnosKlijenta azuriranjeKlijenta = new frmUnosKlijenta(selektiraniKlijent);
                azuriranjeKlijenta.ShowDialog();
                prikaziKlijente();
            }
        }

        private void hlpPokazi(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string naslov = "POMOĆ KLIJENTI";
                string poruka = " U glavnom izborniku odabirom Klijenti prikazuje Vam se forma na kojoj se nalazi popis svih klijenata";
                poruka += "sa kojima poduzeće trenutno posluje. Kako bi brže i jednostavnije pronašli željenog klijenta možete ";
                poruka += "unijeti OIB klijenta ili naslov (naziv tvrtke).\n\n Možete ažurirati podatke o postojećem klijentu pritiskom ";
                poruka += "na tipku Ažuriranje Klijenta. \n\n Zaprimamo li narudžbu od poduzeća sa kojim nismo ranije poslovali ";
                poruka += "potrebno ga je unijeti u sustav,a to činimo pritiskom na tipku Unos novog klijenta. \n\n Možete kliknuti na ";
                poruka += "tipku Natrag sa kojom ćete se vratiti na glavni izbornik.";
                frmHelp formaHelp = new frmHelp(naslov, poruka);
                formaHelp.ShowDialog();
            }
        }
    }
}
