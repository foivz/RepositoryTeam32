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
    public partial class frmLijekovi : Form
    {
        public frmLijekovi()
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

        private void frmLijekovi_Load(object sender, EventArgs e)
        {
            pregledLijekova();
        }

        private void txtPretragaLijekova_TextChanged(object sender, EventArgs e)
        {
            if (txtPretragaLijekova.Text != null)
            {
                BindingList<lijek> listaLijekova = null;
                using (var db = new greymatterpiEntities())
                {
                    IEnumerable<lijek> lijekovi = from p in db.lijek
                                                    where p.naziv.Contains(txtPretragaLijekova.Text)
                                                    select p;
                    listaLijekova = new BindingList<lijek>(lijekovi.ToList());
                    
                }
                lijekBindingSource.DataSource = listaLijekova;
            }
            else if (txtPretragaLijekova.Text == "")
            {
                pregledLijekova();
            }
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
