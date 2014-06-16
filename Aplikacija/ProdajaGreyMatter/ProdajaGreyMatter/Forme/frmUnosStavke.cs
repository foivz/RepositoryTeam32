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
       
        public frmUnosStavke()
        {
            InitializeComponent();
            this.CenterToParent();
            
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            odustani = true;
            this.Close();
        }

        private void frmUnosStavke_Load(object sender, EventArgs e)
        {
            
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
                    MessageBox.Show("Niste unijeli kolicinu!","Greška");
                }
                else
                {
                    MessageBox.Show("Količina je krivo unesena","Greška");
                }
            }
            
        }
    }
}
