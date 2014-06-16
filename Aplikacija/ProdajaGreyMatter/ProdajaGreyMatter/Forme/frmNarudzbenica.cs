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
            this.CenterToParent();
            referent = zaposlenik;
        }
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
        }
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
            }
            else if (txtPretragaKlijenta.Text == "")
            {
                prikaziNarudzbe();
            }
        }

        private void dgPopisNarudžbenica_SelectionChanged(object sender, EventArgs e)
        {
            narudzbenica selektiranaNarudzbenica = narudzbenicaBindingSource.Current as narudzbenica;
            if (selektiranaNarudzbenica != null)
            {
                prikaziStavkeNarudzbenice(selektiranaNarudzbenica);
            }
        }
    }
}
