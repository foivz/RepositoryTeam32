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
