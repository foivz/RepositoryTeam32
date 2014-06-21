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
            this.KeyPreview = true;
        }
        private void pregledLijekova()
        {
            /// Dohvaća listu svih lijekova iz kolekcije lijekovi u kontekstu, te ih prikazuje u DataGridView-u.
            /// Također dohvaća liste tipova lijeka i jedenicnih mjera iz kolekcija tiplijeka i jedinicnamjera.
            /// To omogućuje prikazivanje naziva tipova lijekova i kratice jedinicne mjere na temelju dohvaćenog id-a tipa lijeka te id-a jedinicne mjere.
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
            ///Događaj koji se pokreće prilikom unosa ili promjene teksta u txtPretragaLijekova. 
            ///Ukoliko unesemo neki tekst u textbox txtPretragaLijekova tada se provjerava dali naziv 
            ///lijeka koji se nalazi u tablici sadrži tekst unešeni u textbox
            ///Ako postoje lijekovi čiji naziv sadrži uneseni tekst tada se ti lijekovi stavljaju u listu lijekova
            ///te se prikazuju u DataGridView-u. 
            ///U slučaju da je textbox txtPretragaLijekova prazan (prazan string) tada se poziva metoda pregledLijekova();
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

        private void hlpPokazi(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string naslov = "POMOĆ LIJEKOVI";
                string poruka = "U glavnom izborniku odabirom Lijekovi prikazuje se forma na kojoj se nalazi popis svih lijekova sa ";
                poruka += "njihovim atributima.\n\n Kako bi lakše pronašli željeni lijek možete pretražiti popis lijekova prema nazivu ";
                poruka += "lijeka.\n\n Na glavnu formu vraćate se tipkom Natrag.";
                
                frmHelp formaHelp = new frmHelp(naslov, poruka);
                formaHelp.ShowDialog();
            }
        }
    }
}
