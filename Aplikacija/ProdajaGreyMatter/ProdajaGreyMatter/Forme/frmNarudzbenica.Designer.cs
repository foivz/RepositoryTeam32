namespace ProdajaGreyMatter
{
    partial class frmNarudzbenica
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgPopisNarudžbenica = new System.Windows.Forms.DataGridView();
            this.idNarudzbeniceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oibKlijentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.klijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datumIzdavanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oibZaposlenikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rokPlacanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klijentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkenarudzbeniceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narudzbenicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnUnosNarudzbenice = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.lblPretragaPremaKlijentu = new System.Windows.Forms.Label();
            this.txtPretragaKlijenta = new System.Windows.Forms.TextBox();
            this.dtvStavkeNarudzbenice = new System.Windows.Forms.DataGridView();
            this.idNarudzbeniceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLijekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lijekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lijekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narudzbenicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Ukupno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkenarudzbeniceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnStorno = new System.Windows.Forms.Button();
            this.lblUkupniIznosNarudzbe = new System.Windows.Forms.Label();
            this.txtUkupniIznosNarudžbe = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIzvjestaj = new System.Windows.Forms.Button();
            this.lblPomoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPopisNarudžbenica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvStavkeNarudzbenice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkenarudzbeniceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPopisNarudžbenica
            // 
            this.dgPopisNarudžbenica.AllowUserToAddRows = false;
            this.dgPopisNarudžbenica.AllowUserToDeleteRows = false;
            this.dgPopisNarudžbenica.AutoGenerateColumns = false;
            this.dgPopisNarudžbenica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPopisNarudžbenica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idNarudzbeniceDataGridViewTextBoxColumn,
            this.status,
            this.oibKlijentaDataGridViewTextBoxColumn,
            this.datumIzdavanjaDataGridViewTextBoxColumn,
            this.oibZaposlenikaDataGridViewTextBoxColumn,
            this.rokPlacanjaDataGridViewTextBoxColumn,
            this.klijentDataGridViewTextBoxColumn,
            this.zaposlenikDataGridViewTextBoxColumn,
            this.stavkenarudzbeniceDataGridViewTextBoxColumn});
            this.dgPopisNarudžbenica.DataSource = this.narudzbenicaBindingSource;
            this.dgPopisNarudžbenica.Location = new System.Drawing.Point(2, 115);
            this.dgPopisNarudžbenica.MultiSelect = false;
            this.dgPopisNarudžbenica.Name = "dgPopisNarudžbenica";
            this.dgPopisNarudžbenica.ReadOnly = true;
            this.dgPopisNarudžbenica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPopisNarudžbenica.Size = new System.Drawing.Size(643, 191);
            this.dgPopisNarudžbenica.TabIndex = 0;
            this.dgPopisNarudžbenica.SelectionChanged += new System.EventHandler(this.dgPopisNarudžbenica_SelectionChanged);
            // 
            // idNarudzbeniceDataGridViewTextBoxColumn
            // 
            this.idNarudzbeniceDataGridViewTextBoxColumn.DataPropertyName = "idNarudzbenice";
            this.idNarudzbeniceDataGridViewTextBoxColumn.HeaderText = "ID narudžbenice";
            this.idNarudzbeniceDataGridViewTextBoxColumn.Name = "idNarudzbeniceDataGridViewTextBoxColumn";
            this.idNarudzbeniceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // oibKlijentaDataGridViewTextBoxColumn
            // 
            this.oibKlijentaDataGridViewTextBoxColumn.DataPropertyName = "oibKlijenta";
            this.oibKlijentaDataGridViewTextBoxColumn.DataSource = this.klijentBindingSource;
            this.oibKlijentaDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.oibKlijentaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.oibKlijentaDataGridViewTextBoxColumn.HeaderText = "Klijent";
            this.oibKlijentaDataGridViewTextBoxColumn.Name = "oibKlijentaDataGridViewTextBoxColumn";
            this.oibKlijentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.oibKlijentaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.oibKlijentaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.oibKlijentaDataGridViewTextBoxColumn.ValueMember = "oib";
            // 
            // klijentBindingSource
            // 
            this.klijentBindingSource.DataSource = typeof(ProdajaGreyMatter.klijent);
            // 
            // datumIzdavanjaDataGridViewTextBoxColumn
            // 
            this.datumIzdavanjaDataGridViewTextBoxColumn.DataPropertyName = "datumIzdavanja";
            this.datumIzdavanjaDataGridViewTextBoxColumn.HeaderText = "Datum izdavanja";
            this.datumIzdavanjaDataGridViewTextBoxColumn.Name = "datumIzdavanjaDataGridViewTextBoxColumn";
            this.datumIzdavanjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oibZaposlenikaDataGridViewTextBoxColumn
            // 
            this.oibZaposlenikaDataGridViewTextBoxColumn.DataPropertyName = "oibZaposlenika";
            this.oibZaposlenikaDataGridViewTextBoxColumn.DataSource = this.zaposlenikBindingSource;
            this.oibZaposlenikaDataGridViewTextBoxColumn.DisplayMember = "prezime";
            this.oibZaposlenikaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.oibZaposlenikaDataGridViewTextBoxColumn.HeaderText = "Zaposlenik";
            this.oibZaposlenikaDataGridViewTextBoxColumn.Name = "oibZaposlenikaDataGridViewTextBoxColumn";
            this.oibZaposlenikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.oibZaposlenikaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.oibZaposlenikaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.oibZaposlenikaDataGridViewTextBoxColumn.ValueMember = "oib";
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataSource = typeof(ProdajaGreyMatter.zaposlenik);
            // 
            // rokPlacanjaDataGridViewTextBoxColumn
            // 
            this.rokPlacanjaDataGridViewTextBoxColumn.DataPropertyName = "rokPlacanja";
            this.rokPlacanjaDataGridViewTextBoxColumn.HeaderText = "Rok plaćanja";
            this.rokPlacanjaDataGridViewTextBoxColumn.Name = "rokPlacanjaDataGridViewTextBoxColumn";
            this.rokPlacanjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // klijentDataGridViewTextBoxColumn
            // 
            this.klijentDataGridViewTextBoxColumn.DataPropertyName = "klijent";
            this.klijentDataGridViewTextBoxColumn.HeaderText = "Klijent";
            this.klijentDataGridViewTextBoxColumn.Name = "klijentDataGridViewTextBoxColumn";
            this.klijentDataGridViewTextBoxColumn.ReadOnly = true;
            this.klijentDataGridViewTextBoxColumn.Visible = false;
            // 
            // zaposlenikDataGridViewTextBoxColumn
            // 
            this.zaposlenikDataGridViewTextBoxColumn.DataPropertyName = "zaposlenik";
            this.zaposlenikDataGridViewTextBoxColumn.HeaderText = "Zaposlenik";
            this.zaposlenikDataGridViewTextBoxColumn.Name = "zaposlenikDataGridViewTextBoxColumn";
            this.zaposlenikDataGridViewTextBoxColumn.ReadOnly = true;
            this.zaposlenikDataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkenarudzbeniceDataGridViewTextBoxColumn
            // 
            this.stavkenarudzbeniceDataGridViewTextBoxColumn.DataPropertyName = "stavkenarudzbenice";
            this.stavkenarudzbeniceDataGridViewTextBoxColumn.HeaderText = "Stavke Narudžbenice";
            this.stavkenarudzbeniceDataGridViewTextBoxColumn.Name = "stavkenarudzbeniceDataGridViewTextBoxColumn";
            this.stavkenarudzbeniceDataGridViewTextBoxColumn.ReadOnly = true;
            this.stavkenarudzbeniceDataGridViewTextBoxColumn.Visible = false;
            // 
            // narudzbenicaBindingSource
            // 
            this.narudzbenicaBindingSource.DataSource = typeof(ProdajaGreyMatter.narudzbenica);
            // 
            // btnUnosNarudzbenice
            // 
            this.btnUnosNarudzbenice.Location = new System.Drawing.Point(675, 83);
            this.btnUnosNarudzbenice.Name = "btnUnosNarudzbenice";
            this.btnUnosNarudzbenice.Size = new System.Drawing.Size(105, 103);
            this.btnUnosNarudzbenice.TabIndex = 1;
            this.btnUnosNarudzbenice.Text = "Unos nove narudžbenice";
            this.btnUnosNarudzbenice.UseVisualStyleBackColor = true;
            this.btnUnosNarudzbenice.Click += new System.EventHandler(this.btnUnosNarudzbenice_Click);
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(675, 400);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(105, 65);
            this.btnNatrag.TabIndex = 2;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // lblPretragaPremaKlijentu
            // 
            this.lblPretragaPremaKlijentu.AutoSize = true;
            this.lblPretragaPremaKlijentu.Location = new System.Drawing.Point(204, 22);
            this.lblPretragaPremaKlijentu.Name = "lblPretragaPremaKlijentu";
            this.lblPretragaPremaKlijentu.Size = new System.Drawing.Size(152, 13);
            this.lblPretragaPremaKlijentu.TabIndex = 3;
            this.lblPretragaPremaKlijentu.Text = "Pretraga prema nazivu klijenta:";
            // 
            // txtPretragaKlijenta
            // 
            this.txtPretragaKlijenta.Location = new System.Drawing.Point(395, 19);
            this.txtPretragaKlijenta.Name = "txtPretragaKlijenta";
            this.txtPretragaKlijenta.Size = new System.Drawing.Size(119, 20);
            this.txtPretragaKlijenta.TabIndex = 4;
            this.txtPretragaKlijenta.TextChanged += new System.EventHandler(this.txtPretragaKlijenta_TextChanged);
            // 
            // dtvStavkeNarudzbenice
            // 
            this.dtvStavkeNarudzbenice.AllowUserToAddRows = false;
            this.dtvStavkeNarudzbenice.AllowUserToDeleteRows = false;
            this.dtvStavkeNarudzbenice.AutoGenerateColumns = false;
            this.dtvStavkeNarudzbenice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvStavkeNarudzbenice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idNarudzbeniceDataGridViewTextBoxColumn1,
            this.idLijekDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.lijekDataGridViewTextBoxColumn,
            this.narudzbenicaDataGridViewTextBoxColumn,
            this.Cijena,
            this.Ukupno});
            this.dtvStavkeNarudzbenice.DataSource = this.stavkenarudzbeniceBindingSource;
            this.dtvStavkeNarudzbenice.Location = new System.Drawing.Point(2, 324);
            this.dtvStavkeNarudzbenice.MultiSelect = false;
            this.dtvStavkeNarudzbenice.Name = "dtvStavkeNarudzbenice";
            this.dtvStavkeNarudzbenice.ReadOnly = true;
            this.dtvStavkeNarudzbenice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvStavkeNarudzbenice.Size = new System.Drawing.Size(544, 166);
            this.dtvStavkeNarudzbenice.TabIndex = 5;
            // 
            // idNarudzbeniceDataGridViewTextBoxColumn1
            // 
            this.idNarudzbeniceDataGridViewTextBoxColumn1.DataPropertyName = "idNarudzbenice";
            this.idNarudzbeniceDataGridViewTextBoxColumn1.HeaderText = "ID narudžbenice";
            this.idNarudzbeniceDataGridViewTextBoxColumn1.Name = "idNarudzbeniceDataGridViewTextBoxColumn1";
            this.idNarudzbeniceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idLijekDataGridViewTextBoxColumn
            // 
            this.idLijekDataGridViewTextBoxColumn.DataPropertyName = "idLijek";
            this.idLijekDataGridViewTextBoxColumn.DataSource = this.lijekBindingSource;
            this.idLijekDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.idLijekDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idLijekDataGridViewTextBoxColumn.HeaderText = "Naziv lijeka";
            this.idLijekDataGridViewTextBoxColumn.Name = "idLijekDataGridViewTextBoxColumn";
            this.idLijekDataGridViewTextBoxColumn.ReadOnly = true;
            this.idLijekDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idLijekDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idLijekDataGridViewTextBoxColumn.ValueMember = "idLijek";
            // 
            // lijekBindingSource
            // 
            this.lijekBindingSource.DataSource = typeof(ProdajaGreyMatter.lijek);
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lijekDataGridViewTextBoxColumn
            // 
            this.lijekDataGridViewTextBoxColumn.DataPropertyName = "lijek";
            this.lijekDataGridViewTextBoxColumn.HeaderText = "Lijek";
            this.lijekDataGridViewTextBoxColumn.Name = "lijekDataGridViewTextBoxColumn";
            this.lijekDataGridViewTextBoxColumn.ReadOnly = true;
            this.lijekDataGridViewTextBoxColumn.Visible = false;
            // 
            // narudzbenicaDataGridViewTextBoxColumn
            // 
            this.narudzbenicaDataGridViewTextBoxColumn.DataPropertyName = "narudzbenica";
            this.narudzbenicaDataGridViewTextBoxColumn.HeaderText = "Narudžbenica";
            this.narudzbenicaDataGridViewTextBoxColumn.Name = "narudzbenicaDataGridViewTextBoxColumn";
            this.narudzbenicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.narudzbenicaDataGridViewTextBoxColumn.Visible = false;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "idLijek";
            this.Cijena.DataSource = this.lijekBindingSource;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Cijena.DefaultCellStyle = dataGridViewCellStyle1;
            this.Cijena.DisplayMember = "cijena";
            this.Cijena.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            this.Cijena.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cijena.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Cijena.ValueMember = "idLijek";
            // 
            // Ukupno
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Ukupno.DefaultCellStyle = dataGridViewCellStyle2;
            this.Ukupno.HeaderText = "Ukupno";
            this.Ukupno.Name = "Ukupno";
            this.Ukupno.ReadOnly = true;
            // 
            // stavkenarudzbeniceBindingSource
            // 
            this.stavkenarudzbeniceBindingSource.DataSource = typeof(ProdajaGreyMatter.stavkenarudzbenice);
            // 
            // btnStorno
            // 
            this.btnStorno.Location = new System.Drawing.Point(675, 304);
            this.btnStorno.Name = "btnStorno";
            this.btnStorno.Size = new System.Drawing.Size(105, 65);
            this.btnStorno.TabIndex = 6;
            this.btnStorno.Text = "Storno";
            this.btnStorno.UseVisualStyleBackColor = true;
            this.btnStorno.Click += new System.EventHandler(this.btnStorno_Click);
            // 
            // lblUkupniIznosNarudzbe
            // 
            this.lblUkupniIznosNarudzbe.AutoSize = true;
            this.lblUkupniIznosNarudzbe.Location = new System.Drawing.Point(310, 511);
            this.lblUkupniIznosNarudzbe.Name = "lblUkupniIznosNarudzbe";
            this.lblUkupniIznosNarudzbe.Size = new System.Drawing.Size(118, 13);
            this.lblUkupniIznosNarudzbe.TabIndex = 7;
            this.lblUkupniIznosNarudzbe.Text = "Ukupni iznos narudžbe:";
            // 
            // txtUkupniIznosNarudžbe
            // 
            this.txtUkupniIznosNarudžbe.Location = new System.Drawing.Point(480, 508);
            this.txtUkupniIznosNarudžbe.Name = "txtUkupniIznosNarudžbe";
            this.txtUkupniIznosNarudžbe.ReadOnly = true;
            this.txtUkupniIznosNarudžbe.Size = new System.Drawing.Size(100, 20);
            this.txtUkupniIznosNarudžbe.TabIndex = 8;
            this.txtUkupniIznosNarudžbe.TextChanged += new System.EventHandler(this.txtUkupniIznosNarudžbe_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProdajaGreyMatter.Properties.Resources.samo_logo_fin;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 74);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnIzvjestaj
            // 
            this.btnIzvjestaj.Location = new System.Drawing.Point(158, 511);
            this.btnIzvjestaj.Name = "btnIzvjestaj";
            this.btnIzvjestaj.Size = new System.Drawing.Size(105, 65);
            this.btnIzvjestaj.TabIndex = 10;
            this.btnIzvjestaj.Text = "Izvještaj";
            this.btnIzvjestaj.UseVisualStyleBackColor = true;
            this.btnIzvjestaj.Click += new System.EventHandler(this.btnIzvjestaj_Click);
            // 
            // lblPomoc
            // 
            this.lblPomoc.AutoSize = true;
            this.lblPomoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPomoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPomoc.Location = new System.Drawing.Point(4, 573);
            this.lblPomoc.Name = "lblPomoc";
            this.lblPomoc.Size = new System.Drawing.Size(132, 15);
            this.lblPomoc.TabIndex = 11;
            this.lblPomoc.Text = "Za pomoć pritisnite f1";
            // 
            // frmNarudzbenica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 597);
            this.Controls.Add(this.lblPomoc);
            this.Controls.Add(this.btnIzvjestaj);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtUkupniIznosNarudžbe);
            this.Controls.Add(this.lblUkupniIznosNarudzbe);
            this.Controls.Add(this.btnStorno);
            this.Controls.Add(this.dtvStavkeNarudzbenice);
            this.Controls.Add(this.txtPretragaKlijenta);
            this.Controls.Add(this.lblPretragaPremaKlijentu);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnUnosNarudzbenice);
            this.Controls.Add(this.dgPopisNarudžbenica);
            this.Name = "frmNarudzbenica";
            this.Text = "Narudžbenice";
            this.Load += new System.EventHandler(this.frmNarudzbenica_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hlpPokazi);
            ((System.ComponentModel.ISupportInitialize)(this.dgPopisNarudžbenica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvStavkeNarudzbenice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkenarudzbeniceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPopisNarudžbenica;
        private System.Windows.Forms.Button btnUnosNarudzbenice;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.BindingSource narudzbenicaBindingSource;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private System.Windows.Forms.BindingSource klijentBindingSource;
        private System.Windows.Forms.Label lblPretragaPremaKlijentu;
        private System.Windows.Forms.TextBox txtPretragaKlijenta;
        private System.Windows.Forms.DataGridView dtvStavkeNarudzbenice;
        private System.Windows.Forms.BindingSource lijekBindingSource;
        private System.Windows.Forms.BindingSource stavkenarudzbeniceBindingSource;
        private System.Windows.Forms.Button btnStorno;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNarudzbeniceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewComboBoxColumn oibKlijentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumIzdavanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn oibZaposlenikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokPlacanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klijentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposlenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkenarudzbeniceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNarudzbeniceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn idLijekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lijekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn narudzbenicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ukupno;
        private System.Windows.Forms.Label lblUkupniIznosNarudzbe;
        private System.Windows.Forms.TextBox txtUkupniIznosNarudžbe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIzvjestaj;
        private System.Windows.Forms.Label lblPomoc;
    }
}