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
        public frmNarudzbenicaReport()
        {
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

            label1.Font = new Font(label1.Font, FontStyle.Bold);
        }

        private void frmNarudzbenicaReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'greymatterpiDataSet.narudzbenica' table. You can move, or remove it, as needed.
            this.narudzbenicaTableAdapter.Fill(this.greymatterpiDataSet.narudzbenica); 
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            int id = 0;
            if (comboBox1.SelectedValue != null)
                id = int.Parse(comboBox1.SelectedValue.ToString());
            if (id != 0)
                this.reportTablicaTableAdapter.FillByIdNarudzbenice(this.greymatterpiDataSet.reportTablica, id);
            this.reportViewer1.RefreshReport();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
