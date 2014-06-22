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
    
    public partial class frmIzbornik : Form
    {
        private zaposlenik referent;

        public frmIzbornik(zaposlenik zaposlenik)
        {
            InitializeComponent();
            referent = zaposlenik;
            lblZaposlenik.Text = referent.ime + " " + referent.prezime;
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

            btnKlijenti.FlatStyle = FlatStyle.Flat;
            btnKlijenti.FlatAppearance.BorderColor = Color.FromArgb(255, 50, 241);
            btnKlijenti.FlatAppearance.BorderSize = 3;

            btnLijekovi.FlatStyle = FlatStyle.Flat;
            btnLijekovi.FlatAppearance.BorderColor = Color.FromArgb(255, 50, 241);
            btnLijekovi.FlatAppearance.BorderSize = 3;

            btnNarudzbenica.FlatStyle = FlatStyle.Flat;
            btnNarudzbenica.FlatAppearance.BorderColor = Color.FromArgb(255, 50, 241);
            btnNarudzbenica.FlatAppearance.BorderSize = 3;

            btnStatistika.FlatStyle = FlatStyle.Flat;
            btnStatistika.FlatAppearance.BorderColor = Color.FromArgb(255, 50, 241);
            btnStatistika.FlatAppearance.BorderSize = 3;

            btnOdjava.FlatStyle = FlatStyle.Flat;
            btnOdjava.FlatAppearance.BorderColor = Color.FromArgb(255, 50, 241);
            btnOdjava.FlatAppearance.BorderSize = 3;

            lblZaposlenik.Font = new Font(lblZaposlenik.Font, FontStyle.Bold);
            lblZaposlenik.Font = new Font("Arial", 14);
        }

        private void hlpPokazi(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string naslov = "POMOĆ IZBORNIK";
                string poruka = "  Kada ste uspješno ulogirani može odabrati pet opcija.\n\n Ukoliko pritisnete tipku Lijekovi prikazati će Vam se popis svih lijekova koje poduzeće";
                poruka += "Gray Matter d.o.o.\n\n  Pritiskom na tipku Kijenti dobiti ćete popis svih klijenata sa kojima poduzeće trenutno posluje.\n\n  Ako zaprimate narudžbu klijenta ";
                poruka += "tada je potrebno da kliknete na tipku Narudzbenica u kojoj ćete moći izraditi novu narudžbenicu.\n\n  Želite li vidjeti koji je trenutno najprodavaniji";
                poruka += "lijek ili koji klijent najviše kupuje kod Vas odaberite Statistika.\n\n Zadnja opcija je da se odjavite klikom na tipku Odjava. ";
                frmHelp formaHelp = new frmHelp(naslov, poruka);
                formaHelp.ShowDialog();
            }
        }

        private void btnKlijenti_Click(object sender, EventArgs e)
        {
            frmKlijent formaKlijent = new frmKlijent();
            formaKlijent.ShowDialog();
        }

        private void btnLijekovi_Click(object sender, EventArgs e)
        {
            frmLijekovi formaLijek = new frmLijekovi();
            formaLijek.ShowDialog();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNarudzbenica_Click(object sender, EventArgs e)
        {
            frmNarudzbenica narudzbenica = new frmNarudzbenica(referent);
            narudzbenica.ShowDialog();
        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            frmStatistika statistika = new frmStatistika();
            statistika.ShowDialog();
        }

    }
}
