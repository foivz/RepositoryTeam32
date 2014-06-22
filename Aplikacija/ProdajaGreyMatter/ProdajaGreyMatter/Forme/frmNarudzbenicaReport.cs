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
    public partial class frmNarudzbenicaReport : Form
    {
        private int idNarudzbenice = 0;
        public frmNarudzbenicaReport(int id)
        {
            idNarudzbenice = id;
            InitializeComponent();

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

            btnNatrag.FlatStyle = FlatStyle.Flat;
            btnNatrag.FlatAppearance.BorderColor = Color.FromArgb(255, 50, 241);
            btnNatrag.FlatAppearance.BorderSize = 3;

        }

        private void frmNarudzbenicaReport_Load(object sender, EventArgs e)
        {
            this.narudzbenicaTableAdapter.Fill(this.greymatterpiDataSet.narudzbenica);
            this.reportTablicaTableAdapter.FillByIdNarudzbenice(this.greymatterpiDataSet.reportTablica, idNarudzbenice);
            this.reportViewer1.RefreshReport();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
