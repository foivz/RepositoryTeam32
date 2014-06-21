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
    public partial class frmDodajLijek : Form
    {
        public int idLijeka { get; set; }
        public string nazivLijeka { get; set; }
        public float cijenaLijeka { get; set; }
        public float doza { get; set; }
        public float pakiranje { get; set; }
        public int idTipLijeka { get; set; }
        public frmDodajLijek()
        {
            InitializeComponent();
        }
        private void pregledLijekova()
        {
            BindingList<lijek> listaLijekova = null;
            BindingList<tiplijeka> listaTipLijeka = null;
            BindingList<jedinicnamjera> listaJedinicnaMjera = null;
            using (var db = new greymatterpiEntities())
            {
                listaLijekova = new BindingList<lijek>(db.lijek.ToList());
                listaTipLijeka = new BindingList<tiplijeka>(db.tiplijeka.ToList());
                listaJedinicnaMjera = new BindingList<jedinicnamjera>(db.jedinicnamjera.ToList());
                lijekBindingSource.DataSource = listaLijekova;
                tiplijekaBindingSource.DataSource = listaTipLijeka;
                jedinicnamjeraBindingSource.DataSource = listaJedinicnaMjera;
            }

        }

        private void frmDodajLijek_Load(object sender, EventArgs e)
        {
            pregledLijekova();
        }

        private void txtPretragaPremaNazivu_TextChanged(object sender, EventArgs e)
        {
            if (txtPretragaPremaNazivu.Text != null)
            {
                BindingList<lijek> listaLijekova = null;
                using (var db = new greymatterpiEntities())
                {
                    IEnumerable<lijek> lijekovi = from p in db.lijek
                                                  where p.naziv.Contains(txtPretragaPremaNazivu.Text)
                                                  select p;
                    listaLijekova = new BindingList<lijek>(lijekovi.ToList());

                }
                lijekBindingSource.DataSource = listaLijekova;
            }
            else if (txtPretragaPremaNazivu.Text == "")
            {
                pregledLijekova();
            }
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodajLijek_Click(object sender, EventArgs e)
        {
            lijek selektiraniLijek = lijekBindingSource.Current as lijek;
            idLijeka = selektiraniLijek.idLijek;
            nazivLijeka = selektiraniLijek.naziv;
            cijenaLijeka = selektiraniLijek.cijena;
            doza = selektiraniLijek.doza;
            pakiranje = selektiraniLijek.pakiranje;
            idTipLijeka = selektiraniLijek.idTipLijeka;
            this.Close();
        }

        private void pomoc_Load(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F1)
            {
                frmHelpDodajLijek pomoc = new frmHelpDodajLijek();
                pomoc.Show();
            }
        }
    }
}
