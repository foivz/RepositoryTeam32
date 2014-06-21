using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reportRadi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'greymatterpiDataSet.narudzbenica' table. You can move, or remove it, as needed.
            this.narudzbenicaTableAdapter.Fill(this.greymatterpiDataSet.narudzbenica);
            this.DataTable1TableAdapter.FillByID(this.greymatterpiDataSet.DataTable1, 1);
            this.reportViewer1.RefreshReport();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            int id = 0;
            if (comboBox1.SelectedValue != null)
                id = int.Parse(comboBox1.SelectedValue.ToString());   
            if(id != 0)
                this.DataTable1TableAdapter.FillByID(this.greymatterpiDataSet.DataTable1, id);
            this.reportViewer1.RefreshReport();
        }
    }
}
