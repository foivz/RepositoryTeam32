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
            this.KeyPreview = true;

            trenutniPopisStavki = stavke;

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

            btnDodajLijek.FlatStyle = FlatStyle.Flat;
            btnDodajLijek.FlatAppearance.BorderColor = Color.FromArgb(255, 50, 241);
            btnDodajLijek.FlatAppearance.BorderSize = 3;

            btnSpremi.FlatStyle = FlatStyle.Flat;
            btnSpremi.FlatAppearance.BorderColor = Color.FromArgb(255, 50, 241);
            btnSpremi.FlatAppearance.BorderSize = 3;

            lblDoza.Font = new Font(lblDoza.Font, FontStyle.Bold);
            lblJedinicnaCijena.Font = new Font(lblJedinicnaCijena.Font, FontStyle.Bold);
            lblKolicina.Font = new Font(lblKolicina.Font, FontStyle.Bold);
            lblNazivLijeka.Font = new Font(lblNazivLijeka.Font, FontStyle.Bold);
            lblPakiranje.Font = new Font(lblPakiranje.Font, FontStyle.Bold);
            lblTipLijeka.Font = new Font(lblTipLijeka.Font, FontStyle.Bold);
            idLijeka.Font = new Font(idLijeka.Font, FontStyle.Bold);
        }

        public frmUnosStavke(stavkenarudzbenice stavka)
        {
            InitializeComponent();
            this.CenterToParent();
            this.KeyPreview = true;

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
                    IEnumerable<string> tipLijeka = from p in db.tiplijeka
                                                    where p.idTipLijeka == trazeniLijek.idTipLijeka
                                                    select p.naziv;
                    txtTipLijeka.Text = tipLijeka.First();
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
            
            if (popisLijekova.nazivLijeka != null)
            {
                 txtNazivLijeka.Text = popisLijekova.nazivLijeka;
            }
           
            if (popisLijekova.cijenaLijeka != 0)
            {
                txtCijenaLijeka.Text = popisLijekova.cijenaLijeka.ToString();
            }
            
            if (popisLijekova.pakiranje != 0)
            {
                txtPakiranjeLijeka.Text = popisLijekova.pakiranje.ToString();
            }
            
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
                    int idLijeka = int.Parse(txtIdLijeka.Text);
                    int kolicinaLijeka;
                    using(var db = new greymatterpiEntities())
                    {
                        kolicinaLijeka = (from p in db.lijek
                                          where p.idLijek == idLijeka
                                          select p.kolicina).First();
                    }
                    if (int.Parse(txtKolicina.Text) <= kolicinaLijeka)
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
                    else
                    {
                        MessageBox.Show("Unijeli ste previše lijekova! Na skladištu još ima "+kolicinaLijeka.ToString()+" lijekova.","Upozorenje");
                    }
                }
                catch (FormatException)
                {
                    if (txtIdLijeka.Text == "")
                    {
                        MessageBox.Show("Niste unijeli lijek!", "Greška");
                    }
                    else if (txtIdLijeka.Text != "" && txtKolicina.Text == "")
                    {
                        MessageBox.Show("Niste unijeli količinu!", "Greška");
                    }
                    else
                    {
                        MessageBox.Show("Količina je krivo unesena", "Greška");
                    }
                }
            }
        }

        private void hlpPokazi(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string naslov = "POMOĆ UNOS STAVKE";
                string poruka = " Na formi Unos stavke potrebno je da unesete lijek koji želite unijeti u narudžbenicu te ostale atribute";
                poruka += "tog lijeka. ID lijeka nije potrebno ručno unositi. Dovoljno je kliknuti na tipku (...) te odabrati željeni ";
                poruka += "lijek. \n\n Ukoliko ne želite spremiti stavku dovoljno je da kliknete na tipku Odustani. \n\n Želite li spremiti ";
                poruka += "stavku sa svim unesenim atributima kliknite na tipku Spremi.";
               
                frmHelp formaHelp = new frmHelp(naslov, poruka);
                formaHelp.ShowDialog();
            }
        }
    }
}
