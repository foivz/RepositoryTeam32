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
    }
}
