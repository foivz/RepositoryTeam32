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
    public partial class frmHelp : Form
    {
        public frmHelp(string naslov, string opis)
        {
            InitializeComponent();

            txtNaslov.Text = naslov;
            txtOpis.Text = opis;

            BackColor = Color.FromArgb(204, 229, 255);
            txtNaslov.ForeColor = Color.FromArgb(0, 25, 51);
            txtNaslov.TextAlign = HorizontalAlignment.Center;
            txtNaslov.Font = new Font("Arial Black", 16);

            txtOpis.Font = new Font("Arial", 12);
            txtOpis.ForeColor = Color.FromArgb(0, 25, 51);
            txtOpis.SelectionAlignment = HorizontalAlignment.Center;
        }
    }
}
