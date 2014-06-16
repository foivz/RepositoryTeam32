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
          
             }
    
        private void btnSpremi_Click(object sender, EventArgs e)
        {
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
                    rokPlacanja = dtpRokPlacanja.Value
                };
                db.narudzbenica.Add(narudzba);
                db.SaveChanges();
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
            frmUnosStavke unosStavke = new frmUnosStavke();
            unosStavke.ShowDialog();
            BindingList<stavkenarudzbenice> listaStavaka = new BindingList<stavkenarudzbenice>();
            BindingList<lijek> popisLijekova = null;
            if (unosStavke.odustani != true)
            {
                using (var db = new greymatterpiEntities())
                {
                    popisLijekova = new BindingList<lijek>(db.lijek.ToList());
                }
                stavkenarudzbeniceBindingSource.Add(unosStavke.stavkaNarudzbenice);
                lijekBindingSource.DataSource = popisLijekova;
            }
       
        }
    }
}
