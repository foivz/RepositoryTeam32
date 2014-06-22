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

            btnPrijava.FlatStyle = FlatStyle.Flat;
            btnPrijava.FlatAppearance.BorderColor = Color.FromArgb(255, 50, 241);
            btnPrijava.FlatAppearance.BorderSize = 3;

            btnIzlaz.FlatStyle = FlatStyle.Flat;
            btnIzlaz.FlatAppearance.BorderColor = Color.FromArgb(255, 50, 241);
            btnIzlaz.FlatAppearance.BorderSize = 3;

            lblKorisnickoIme.Font = new Font(lblKorisnickoIme.Font, FontStyle.Bold);
            lblLozinka.Font = new Font(lblLozinka.Font, FontStyle.Bold);
        }
        zaposlenik zaposlenik;

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            //Provjerava da li postoji zaposlenik u bazi podataka koji ima unešeno korisničko ime i lozinku
            //Ako je prijava uspješna podaci o zaposleniku se spremaju u objekt zaposlenik koji se proslijeđuje u glavnu formu
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
                this.Hide();
                frmIzbornik izbornik = new frmIzbornik(zaposlenik);
                izbornik.ShowDialog();
                frmPrijava prijava = new frmPrijava();
                prijava.Show();
            }
            else
            {
                MessageBox.Show("Neuspješna prijava!", "Greška");
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
