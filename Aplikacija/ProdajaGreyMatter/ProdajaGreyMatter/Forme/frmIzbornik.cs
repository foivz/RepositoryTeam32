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
        }

        private void hlpPokazi(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string naslov = "GLAVNI IZBORNIK";
                string poruka = "Kada ste uspješno ulogirani može odabrati pet opcija.\nUkoliko pritisnete tipku Lijekovi prikazati će Vam se popis svih lijekova koje poduzeće";
                poruka += "Gray Matter d.o.o.\nPritiskom na tipku Kijenti dobiti ćete popis svih klijenata sa kojima poduzeće trenutno posluje.\nAko zaprimate narudžbu klijenta ";
                poruka += "tada je potrebno da kliknete na tipku Narudzbenica u kojoj ćete moći izraditi novu narudžbenicu.\nŽelite li vidjeti koji je trenutno najprodavaniji";
                poruka += "lijek ili koji klijent najviše kupuje kod Vas odaberite Statistika.";
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
