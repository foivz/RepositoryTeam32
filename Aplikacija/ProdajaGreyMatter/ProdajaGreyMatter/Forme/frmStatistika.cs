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
    public partial class frmStatistika : Form
    {
        public frmStatistika()
        {
            InitializeComponent();
            this.KeyPreview = true;

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

            btnNajboljiKupci.FlatStyle = FlatStyle.Flat;
            btnNajboljiKupci.FlatAppearance.BorderColor = Color.FromArgb(255, 50, 241);
            btnNajboljiKupci.FlatAppearance.BorderSize = 3;

            btnNajprodavanijiLIjekovi.FlatStyle = FlatStyle.Flat;
            btnNajprodavanijiLIjekovi.FlatAppearance.BorderColor = Color.FromArgb(255, 50, 241);
            btnNajprodavanijiLIjekovi.FlatAppearance.BorderSize = 3;

            btnNatrag.FlatStyle = FlatStyle.Flat;
            btnNatrag.FlatAppearance.BorderColor = Color.FromArgb(255, 50, 241);
            btnNatrag.FlatAppearance.BorderSize = 3;
        }

        private void btnNajboljiKupci_Click(object sender, EventArgs e)
        {
            frmNajboljiKupci najboljiKupci = new frmNajboljiKupci();
            najboljiKupci.ShowDialog();
        }

        private void btnNajprodavanijiLIjekovi_Click(object sender, EventArgs e)
        {
            frmNajprodavanijiLijekovi najprodavanijiLijekovi = new frmNajprodavanijiLijekovi();
            najprodavanijiLijekovi.ShowDialog();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hlpPokazi(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string naslov = "POMOĆ STATISTIKA";
                string poruka = " Odabirom Statistika u glavnom izborniku otvara se forma sa tri tipke. \n\n Pritiskom na tipku Najbolji kupci ";
                poruka += "prikazuje se koji od klijenata najviše,a koji najmanje kupuje u poduzeću Gray Matter d.o.o. \n\n Pritiskom ";
                poruka += "na tipku Najprodavaniji lijekovi moći ćete vidjeti koji od lijekova poduzeća je najprodavaniji.\n\n Na ";
                poruka += "glavnu formu vraćate se tipkom Natrag.";
                frmHelp formaHelp = new frmHelp(naslov, poruka);
                formaHelp.Show();
            }
        }
    }
}
