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
    public partial class frmUnosStavke : Form
    {
        public stavkenarudzbenice stavkaNarudzbenice { get; set; }
        public bool odustani = false;

        private BindingList<stavkenarudzbenice> trenutniPopisStavki = null;

        private stavkenarudzbenice selektiranaStavka = null;
       
        public frmUnosStavke(BindingList<stavkenarudzbenice> stavke)
        {
            InitializeComponent();
            this.CenterToParent();

            trenutniPopisStavki = stavke;
        }

        public frmUnosStavke(stavkenarudzbenice stavka)
        {
            InitializeComponent();
            this.CenterToParent();

            selektiranaStavka = stavka;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            odustani = true;
            this.Close();
        }

        private void frmUnosStavke_Load(object sender, EventArgs e)
        {
            if(selektiranaStavka != null)
            {
                using(var db = new greymatterpiEntities())
                {
                    
                    db.stavkenarudzbenice.Attach(selektiranaStavka);

                    lijek trazeniLijek = (from r in db.lijek
                                         where r.idLijek == selektiranaStavka.idLijek
                                         select r).First<lijek>();

                    txtIdLijeka.Text = trazeniLijek.idLijek.ToString();
                    txtNazivLijeka.Text = trazeniLijek.naziv;
                    txtTipLijeka.Text = trazeniLijek.tiplijeka.ToString();
                    txtDozaLijeka.Text = trazeniLijek.doza.ToString();
                    txtPakiranjeLijeka.Text = trazeniLijek.pakiranje.ToString();
                    txtCijenaLijeka.Text = trazeniLijek.cijena.ToString();
                    txtKolicina.Text = selektiranaStavka.kolicina.ToString();
                }
            }
        }

        private void btnDodajLijek_Click(object sender, EventArgs e)
        {
            frmDodajLijek popisLijekova = new frmDodajLijek();
            popisLijekova.ShowDialog();
            if (popisLijekova.idLijeka != 0)
            {
                txtIdLijeka.Text = popisLijekova.idLijeka.ToString();
                using (var db = new greymatterpiEntities())
                {
                    IEnumerable<string> tipLijeka = from p in db.tiplijeka
                                                    where p.idTipLijeka == popisLijekova.idTipLijeka
                                                    select p.naziv;
                    txtTipLijeka.Text = tipLijeka.First();
                }
            }
            else txtIdLijeka.Text = "";
            txtNazivLijeka.Text = popisLijekova.nazivLijeka;
            if (popisLijekova.cijenaLijeka != 0)
            {
                txtCijenaLijeka.Text = popisLijekova.cijenaLijeka.ToString();
            }
            else txtCijenaLijeka.Text = "";
            if (popisLijekova.pakiranje != 0)
            {
                txtPakiranjeLijeka.Text = popisLijekova.pakiranje.ToString();
            }
            else txtPakiranjeLijeka.Text = "";
            if (popisLijekova.doza != 0)
            {
                txtDozaLijeka.Text = popisLijekova.doza.ToString();
            }
           
        }
        
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            bool stavkaPostoji = false;
            
            //to tak da bi bilo moguće ažuriranje, inače ovaj foreach nebi bil u elseu i 
            //prikazal bi poruku da je taj lijek unesen pa nebi bilo moguće promijeniti količinu
            if (selektiranaStavka != null)
            {
                stavkaPostoji = false;
            }
            else
            {
                foreach (stavkenarudzbenice stavka in trenutniPopisStavki)
                {
                    if (stavka.idLijek == int.Parse(txtIdLijeka.Text))
                    {
                        stavkaPostoji = true;
                    }
                }
            }

            if (stavkaPostoji == true)
            {
                MessageBox.Show("Taj lijek je već unesen", "Greška");
            }
            else
            {
                try
                {
                    using (var db = new greymatterpiEntities())
                    {

                        stavkaNarudzbenice = new stavkenarudzbenice()
                        {
                            idLijek = int.Parse(txtIdLijeka.Text),
                            kolicina = int.Parse(txtKolicina.Text)
                        };
                    }
                    this.Close();
                }
                catch (FormatException)
                {
                    if (txtIdLijeka.Text == "")
                    {
                        MessageBox.Show("Niste unijeli lijek!", "Greška");
                    }
                    else if (txtIdLijeka.Text != "" && txtKolicina.Text == "")
                    {
                        MessageBox.Show("Niste unijeli kolicinu!", "Greška");
                    }
                    else
                    {
                        MessageBox.Show("Količina je krivo unesena", "Greška");
                    }
                }
            }
        }
    }
}
