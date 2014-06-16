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
    public partial class frmPrijava : Form
    {
        public frmPrijava()
        {
            InitializeComponent();
            this.CenterToParent();
        }
        zaposlenik zaposlenik;

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            using (var db = new greymatterpiEntities())
            {
                foreach (var zapos in db.zaposlenik)
                {
                    if (zapos.korisnickoIme == txtKorisnickoIme.Text && zapos.lozinka == txtLozinka.Text)
                    {
                        zaposlenik = zapos;
                        break;
                    }
                }
            }
            if (zaposlenik != null)
            {
                MessageBox.Show("Uspješna prijava");
                this.Hide();
                frmIzbornik izbornik = new frmIzbornik(zaposlenik);
                izbornik.ShowDialog();
                frmPrijava prijava = new frmPrijava();
                prijava.Show();
            }
            else
            {
                MessageBox.Show("Neuspješna prijava!");
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
