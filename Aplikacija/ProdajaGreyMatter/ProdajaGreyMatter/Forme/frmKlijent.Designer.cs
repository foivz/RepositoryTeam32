namespace ProdajaGreyMatter
{
    partial class frmKlijent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgPopisKlijenata = new System.Windows.Forms.DataGridView();
            this.oibDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ziroRacunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narudzbenicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnUnosKlijenta = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.btnAzuriranjeKlijenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPretragaOib = new System.Windows.Forms.TextBox();
            this.txtPretragaNaziv = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPomoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPopisKlijenata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPopisKlijenata
            // 
            this.dgPopisKlijenata.AllowUserToAddRows = false;
            this.dgPopisKlijenata.AllowUserToDeleteRows = false;
            this.dgPopisKlijenata.AutoGenerateColumns = false;
            this.dgPopisKlijenata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPopisKlijenata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oibDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.ziroRacunDataGridViewTextBoxColumn,
            this.narudzbenicaDataGridViewTextBoxColumn});
            this.dgPopisKlijenata.DataSource = this.klijentBindingSource;
            this.dgPopisKlijenata.Location = new System.Drawing.Point(0, 93);
            this.dgPopisKlijenata.MultiSelect = false;
            this.dgPopisKlijenata.Name = "dgPopisKlijenata";
            this.dgPopisKlijenata.ReadOnly = true;
            this.dgPopisKlijenata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPopisKlijenata.Size = new System.Drawing.Size(641, 244);
            this.dgPopisKlijenata.TabIndex = 0;
            // 
            // oibDataGridViewTextBoxColumn
            // 
            this.oibDataGridViewTextBoxColumn.DataPropertyName = "oib";
            this.oibDataGridViewTextBoxColumn.HeaderText = "OIB klijenta";
            this.oibDataGridViewTextBoxColumn.Name = "oibDataGridViewTextBoxColumn";
            this.oibDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "e_mail";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ziroRacunDataGridViewTextBoxColumn
            // 
            this.ziroRacunDataGridViewTextBoxColumn.DataPropertyName = "ziroRacun";
            this.ziroRacunDataGridViewTextBoxColumn.HeaderText = "Žiro račun";
            this.ziroRacunDataGridViewTextBoxColumn.Name = "ziroRacunDataGridViewTextBoxColumn";
            this.ziroRacunDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // narudzbenicaDataGridViewTextBoxColumn
            // 
            this.narudzbenicaDataGridViewTextBoxColumn.DataPropertyName = "narudzbenica";
            this.narudzbenicaDataGridViewTextBoxColumn.HeaderText = "Narudžbenica";
            this.narudzbenicaDataGridViewTextBoxColumn.Name = "narudzbenicaDataGridViewTextBoxColumn";
            this.narudzbenicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.narudzbenicaDataGridViewTextBoxColumn.Visible = false;
            // 
            // klijentBindingSource
            // 
            this.klijentBindingSource.DataSource = typeof(ProdajaGreyMatter.klijent);
            // 
            // btnUnosKlijenta
            // 
            this.btnUnosKlijenta.Location = new System.Drawing.Point(414, 391);
            this.btnUnosKlijenta.Name = "btnUnosKlijenta";
            this.btnUnosKlijenta.Size = new System.Drawing.Size(119, 94);
            this.btnUnosKlijenta.TabIndex = 1;
            this.btnUnosKlijenta.Text = "Unos novog klijenta";
            this.btnUnosKlijenta.UseVisualStyleBackColor = true;
            this.btnUnosKlijenta.Click += new System.EventHandler(this.btnUnosKlijenta_Click);
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(576, 391);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(117, 94);
            this.btnNatrag.TabIndex = 2;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // btnAzuriranjeKlijenta
            // 
            this.btnAzuriranjeKlijenta.Location = new System.Drawing.Point(248, 391);
            this.btnAzuriranjeKlijenta.Name = "btnAzuriranjeKlijenta";
            this.btnAzuriranjeKlijenta.Size = new System.Drawing.Size(114, 94);
            this.btnAzuriranjeKlijenta.TabIndex = 3;
            this.btnAzuriranjeKlijenta.Text = "Ažuriranje Klijenta";
            this.btnAzuriranjeKlijenta.UseVisualStyleBackColor = true;
            this.btnAzuriranjeKlijenta.Click += new System.EventHandler(this.btnAzuriranjeKlijenta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pretraga prema OIB-u:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pretraga prema nazivu:";
            // 
            // txtPretragaOib
            // 
            this.txtPretragaOib.Location = new System.Drawing.Point(319, 38);
            this.txtPretragaOib.Name = "txtPretragaOib";
            this.txtPretragaOib.Size = new System.Drawing.Size(100, 20);
            this.txtPretragaOib.TabIndex = 6;
            this.txtPretragaOib.TextChanged += new System.EventHandler(this.txtPretragaOib_TextChanged_1);
            // 
            // txtPretragaNaziv
            // 
            this.txtPretragaNaziv.Location = new System.Drawing.Point(635, 38);
            this.txtPretragaNaziv.Name = "txtPretragaNaziv";
            this.txtPretragaNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtPretragaNaziv.TabIndex = 7;
            this.txtPretragaNaziv.TextChanged += new System.EventHandler(this.txtPretragaNaziv_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProdajaGreyMatter.Properties.Resources.samo_logo_fin;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 74);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblPomoc
            // 
            this.lblPomoc.AutoSize = true;
            this.lblPomoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPomoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPomoc.Location = new System.Drawing.Point(12, 499);
            this.lblPomoc.Name = "lblPomoc";
            this.lblPomoc.Size = new System.Drawing.Size(132, 15);
            this.lblPomoc.TabIndex = 9;
            this.lblPomoc.Text = "Za pomoć pritisnite f1";
            // 
            // frmKlijent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 523);
            this.Controls.Add(this.lblPomoc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPretragaNaziv);
            this.Controls.Add(this.txtPretragaOib);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAzuriranjeKlijenta);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnUnosKlijenta);
            this.Controls.Add(this.dgPopisKlijenata);
            this.Name = "frmKlijent";
            this.Text = "Klijenti";
            this.Load += new System.EventHandler(this.frmKlijent_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hlpPokazi);
            ((System.ComponentModel.ISupportInitialize)(this.dgPopisKlijenata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPopisKlijenata;
        private System.Windows.Forms.Button btnUnosKlijenta;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Button btnAzuriranjeKlijenta;
        private System.Windows.Forms.BindingSource klijentBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPretragaOib;
        private System.Windows.Forms.TextBox txtPretragaNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn oibDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ziroRacunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn narudzbenicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPomoc;
    }
}