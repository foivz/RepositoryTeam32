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
            this.CenterToParent();
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
    }
}
