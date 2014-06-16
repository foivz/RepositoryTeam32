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
            this.CenterToParent();
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
    }
}
