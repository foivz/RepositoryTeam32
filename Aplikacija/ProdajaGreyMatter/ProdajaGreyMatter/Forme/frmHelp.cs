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

            this.BackColor = Color.FromArgb(228, 231, 236);

            txtNaslov.TextAlign = HorizontalAlignment.Center;
            txtNaslov.Font = new Font("Arial", 14);
            txtNaslov.Font = new Font(txtNaslov.Font, FontStyle.Bold);

            txtOpis.Font = new Font("Arial", 12);
            txtOpis.ForeColor = Color.FromArgb(64, 64, 64);
        }
    }
}
