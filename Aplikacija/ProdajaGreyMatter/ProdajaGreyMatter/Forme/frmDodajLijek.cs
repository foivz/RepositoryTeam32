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
            this.CenterToParent();

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

            btnDodajLijek.FlatStyle = FlatStyle.Flat;
            btnDodajLijek.FlatAppearance.BorderColor = Color.FromArgb(255, 50, 241);
            btnDodajLijek.FlatAppearance.BorderSize = 3;

            btnNatrag.FlatStyle = FlatStyle.Flat;
            btnNatrag.FlatAppearance.BorderColor = Color.FromArgb(255, 50, 241);
            btnNatrag.FlatAppearance.BorderSize = 3;

            lblPretragaPremaNazivuLijeka.Font = new Font(lblPretragaPremaNazivuLijeka.Font, FontStyle.Bold);
        }
        /// Dohvaća listu svih lijekova iz kolekcije lijekovi u kontekstu, te ih prikazuje u DataGridView-u.
        /// Također dohvaća liste tipova lijeka i jedenicnih mjera iz kolekcija tiplijeka i jedinicnamjera.
        /// To omogućuje prikazivanje naziva tipova lijekova i kratice jedinicne mjere na temelju dohvaćenog id-a tipa lijeka te id-a jedinicne mjere.
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
        ///Događaj koji se pokreće prilikom unosa ili promjene teksta u txtPretragaLijekova. 
        ///Ukoliko unesemo neki tekst u textbox txtPretragaLijekova tada se provjerava dali naziv 
        ///lijeka koji se nalazi u tablici sadrži tekst unešeni u textbox
        ///Ako postoje lijekovi čiji naziv sadrži uneseni tekst tada se ti lijekovi stavljaju u listu lijekova
        ///te se prikazuju u DataGridView-u. 
        ///U slučaju da je textbox txtPretragaLijekova prazan (prazan string) tada se poziva metoda pregledLijekova();
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
        /// <summary>
        /// Rukuje događajem klika na gumb DodajLijek.
        /// Selektirani lijek se dodaje objektu selektiraniLijek tipa lijek te se podaci označenog lijeka spremaju u atribute klase frmDodajLijek.
        /// </summary>
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

        private void hlpPokazi(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string naslov = "POMOĆ DODAJ LIJEK";
                string poruka = "Na formi Dodaj Lijek nalazi se popis svih lijekova sa njihovim atributima. Kako bi lakše pronašli željeni ";
                poruka += "lijek možete pretražiti popis lijekova prema nazivu lijeka. \n\n Ukoliko želite dodatni neki lijek sa popisa ";
                poruka += "lijekova kliknite na tipku Dodaj. \n\n Na prethodnu formu vraćate se tipkom Natrag.";
                frmHelp formaHelp = new frmHelp(naslov, poruka);
                formaHelp.ShowDialog();
            }
        }
    }
}
