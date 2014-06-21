namespace ProdajaGreyMatter
{
    partial class frmUnosNarudzbenice
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
            this.dtvStavkeNarudzbenice = new System.Windows.Forms.DataGridView();
            this.idLijekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNarudzbeniceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lijekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narudzbenicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lijekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Ukupno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkenarudzbeniceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtIdNarudzbenice = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.lblIdNarudzbenice = new System.Windows.Forms.Label();
            this.lblNazivKlijenta = new System.Windows.Forms.Label();
            this.lblRokPlacanja = new System.Windows.Forms.Label();
            this.lblReferent = new System.Windows.Forms.Label();
            this.dtpDatumIzdavanjaNarudzbenice = new System.Windows.Forms.DateTimePicker();
            this.cmbNazivKlijenta = new System.Windows.Forms.ComboBox();
            this.dtpRokPlacanja = new System.Windows.Forms.DateTimePicker();
            this.cmbReferent = new System.Windows.Forms.ComboBox();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnIzmjeni = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.lblUkupniIznosNarudzbe = new System.Windows.Forms.Label();
            this.txtUkupniIznosNarudzbe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtvStavkeNarudzbenice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkenarudzbeniceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvStavkeNarudzbenice
            // 
            this.dtvStavkeNarudzbenice.AllowUserToAddRows = false;
            this.dtvStavkeNarudzbenice.AllowUserToDeleteRows = false;
            this.dtvStavkeNarudzbenice.AutoGenerateColumns = false;
            this.dtvStavkeNarudzbenice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvStavkeNarudzbenice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLijekDataGridViewTextBoxColumn,
            this.idNarudzbeniceDataGridViewTextBoxColumn,
            this.kolicina,
            this.lijekDataGridViewTextBoxColumn,
            this.narudzbenicaDataGridViewTextBoxColumn,
            this.Cijena,
            this.Ukupno});
            this.dtvStavkeNarudzbenice.DataSource = this.stavkenarudzbeniceBindingSource;
            this.dtvStavkeNarudzbenice.Location = new System.Drawing.Point(12, 136);
            this.dtvStavkeNarudzbenice.MultiSelect = false;
            this.dtvStavkeNarudzbenice.Name = "dtvStavkeNarudzbenice";
            this.dtvStavkeNarudzbenice.ReadOnly = true;
            this.dtvStavkeNarudzbenice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvStavkeNarudzbenice.Size = new System.Drawing.Size(511, 180);
            this.dtvStavkeNarudzbenice.TabIndex = 0;
            // 
            // idLijekDataGridViewTextBoxColumn
            // 
            this.idLijekDataGridViewTextBoxColumn.DataPropertyName = "idLijek";
            this.idLijekDataGridViewTextBoxColumn.HeaderText = "ID lijeka";
            this.idLijekDataGridViewTextBoxColumn.Name = "idLijekDataGridViewTextBoxColumn";
            this.idLijekDataGridViewTextBoxColumn.ReadOnly = true;
            this.idLijekDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // idNarudzbeniceDataGridViewTextBoxColumn
            // 
            this.idNarudzbeniceDataGridViewTextBoxColumn.DataPropertyName = "idNarudzbenice";
            this.idNarudzbeniceDataGridViewTextBoxColumn.HeaderText = "ID narudžbenice";
            this.idNarudzbeniceDataGridViewTextBoxColumn.Name = "idNarudzbeniceDataGridViewTextBoxColumn";
            this.idNarudzbeniceDataGridViewTextBoxColumn.ReadOnly = true;
            this.idNarudzbeniceDataGridViewTextBoxColumn.Visible = false;
            // 
            // kolicina
            // 
            this.kolicina.DataPropertyName = "kolicina";
            this.kolicina.HeaderText = "Količina";
            this.kolicina.Name = "kolicina";
            this.kolicina.ReadOnly = true;
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
            this.Cijena.DisplayMember = "cijena";
            this.Cijena.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            this.Cijena.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cijena.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Cijena.ValueMember = "idLijek";
            // 
            // lijekBindingSource
            // 
            this.lijekBindingSource.DataSource = typeof(ProdajaGreyMatter.lijek);
            // 
            // Ukupno
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Ukupno.DefaultCellStyle = dataGridViewCellStyle1;
            this.Ukupno.HeaderText = "Ukupno";
            this.Ukupno.Name = "Ukupno";
            this.Ukupno.ReadOnly = true;
            // 
            // stavkenarudzbeniceBindingSource
            // 
            this.stavkenarudzbeniceBindingSource.DataSource = typeof(ProdajaGreyMatter.stavkenarudzbenice);
            // 
            // txtIdNarudzbenice
            // 
            this.txtIdNarudzbenice.Location = new System.Drawing.Point(115, 25);
            this.txtIdNarudzbenice.Name = "txtIdNarudzbenice";
            this.txtIdNarudzbenice.ReadOnly = true;
            this.txtIdNarudzbenice.Size = new System.Drawing.Size(50, 20);
            this.txtIdNarudzbenice.TabIndex = 3;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(338, 374);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 37);
            this.btnOdustani.TabIndex = 4;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(446, 374);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 37);
            this.btnSpremi.TabIndex = 5;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.Location = new System.Drawing.Point(22, 374);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(97, 37);
            this.btnDodajStavku.TabIndex = 6;
            this.btnDodajStavku.Text = "Dodaj stavku";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click);
            // 
            // lblIdNarudzbenice
            // 
            this.lblIdNarudzbenice.AutoSize = true;
            this.lblIdNarudzbenice.Location = new System.Drawing.Point(21, 28);
            this.lblIdNarudzbenice.Name = "lblIdNarudzbenice";
            this.lblIdNarudzbenice.Size = new System.Drawing.Size(88, 13);
            this.lblIdNarudzbenice.TabIndex = 7;
            this.lblIdNarudzbenice.Text = "ID narudžbenice:";
            // 
            // lblNazivKlijenta
            // 
            this.lblNazivKlijenta.AutoSize = true;
            this.lblNazivKlijenta.Location = new System.Drawing.Point(21, 62);
            this.lblNazivKlijenta.Name = "lblNazivKlijenta";
            this.lblNazivKlijenta.Size = new System.Drawing.Size(73, 13);
            this.lblNazivKlijenta.TabIndex = 8;
            this.lblNazivKlijenta.Text = "Naziv klijenta:";
            // 
            // lblRokPlacanja
            // 
            this.lblRokPlacanja.AutoSize = true;
            this.lblRokPlacanja.Location = new System.Drawing.Point(21, 100);
            this.lblRokPlacanja.Name = "lblRokPlacanja";
            this.lblRokPlacanja.Size = new System.Drawing.Size(73, 13);
            this.lblRokPlacanja.TabIndex = 9;
            this.lblRokPlacanja.Text = "Rok plaćanja:";
            // 
            // lblReferent
            // 
            this.lblReferent.AutoSize = true;
            this.lblReferent.Location = new System.Drawing.Point(335, 57);
            this.lblReferent.Name = "lblReferent";
            this.lblReferent.Size = new System.Drawing.Size(51, 13);
            this.lblReferent.TabIndex = 10;
            this.lblReferent.Text = "Referent:";
            // 
            // dtpDatumIzdavanjaNarudzbenice
            // 
            this.dtpDatumIzdavanjaNarudzbenice.Enabled = false;
            this.dtpDatumIzdavanjaNarudzbenice.Location = new System.Drawing.Point(334, 12);
            this.dtpDatumIzdavanjaNarudzbenice.Name = "dtpDatumIzdavanjaNarudzbenice";
            this.dtpDatumIzdavanjaNarudzbenice.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumIzdavanjaNarudzbenice.TabIndex = 12;
            // 
            // cmbNazivKlijenta
            // 
            this.cmbNazivKlijenta.FormattingEnabled = true;
            this.cmbNazivKlijenta.Location = new System.Drawing.Point(115, 59);
            this.cmbNazivKlijenta.Name = "cmbNazivKlijenta";
            this.cmbNazivKlijenta.Size = new System.Drawing.Size(124, 21);
            this.cmbNazivKlijenta.TabIndex = 13;
            // 
            // dtpRokPlacanja
            // 
            this.dtpRokPlacanja.Location = new System.Drawing.Point(100, 100);
            this.dtpRokPlacanja.Name = "dtpRokPlacanja";
            this.dtpRokPlacanja.Size = new System.Drawing.Size(200, 20);
            this.dtpRokPlacanja.TabIndex = 15;
            // 
            // cmbReferent
            // 
            this.cmbReferent.DataSource = this.zaposlenikBindingSource;
            this.cmbReferent.DisplayMember = "prezime";
            this.cmbReferent.Enabled = false;
            this.cmbReferent.FormattingEnabled = true;
            this.cmbReferent.Location = new System.Drawing.Point(392, 54);
            this.cmbReferent.Name = "cmbReferent";
            this.cmbReferent.Size = new System.Drawing.Size(121, 21);
            this.cmbReferent.TabIndex = 16;
            this.cmbReferent.ValueMember = "oib";
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataSource = typeof(ProdajaGreyMatter.zaposlenik);
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.Location = new System.Drawing.Point(226, 374);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(75, 37);
            this.btnIzmjeni.TabIndex = 17;
            this.btnIzmjeni.Text = "Izmjeni";
            this.btnIzmjeni.UseVisualStyleBackColor = true;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(136, 374);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(75, 37);
            this.btnIzbrisi.TabIndex = 18;
            this.btnIzbrisi.Text = "Izbriši";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // lblUkupniIznosNarudzbe
            // 
            this.lblUkupniIznosNarudzbe.AutoSize = true;
            this.lblUkupniIznosNarudzbe.Location = new System.Drawing.Point(299, 331);
            this.lblUkupniIznosNarudzbe.Name = "lblUkupniIznosNarudzbe";
            this.lblUkupniIznosNarudzbe.Size = new System.Drawing.Size(118, 13);
            this.lblUkupniIznosNarudzbe.TabIndex = 19;
            this.lblUkupniIznosNarudzbe.Text = "Ukupni iznos narudzbe:";
            // 
            // txtUkupniIznosNarudzbe
            // 
            this.txtUkupniIznosNarudzbe.Location = new System.Drawing.Point(423, 328);
            this.txtUkupniIznosNarudzbe.Name = "txtUkupniIznosNarudzbe";
            this.txtUkupniIznosNarudzbe.ReadOnly = true;
            this.txtUkupniIznosNarudzbe.Size = new System.Drawing.Size(100, 20);
            this.txtUkupniIznosNarudzbe.TabIndex = 20;
            // 
            // frmUnosNarudzbenice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 423);
            this.Controls.Add(this.txtUkupniIznosNarudzbe);
            this.Controls.Add(this.lblUkupniIznosNarudzbe);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.cmbReferent);
            this.Controls.Add(this.dtpRokPlacanja);
            this.Controls.Add(this.cmbNazivKlijenta);
            this.Controls.Add(this.dtpDatumIzdavanjaNarudzbenice);
            this.Controls.Add(this.lblReferent);
            this.Controls.Add(this.lblRokPlacanja);
            this.Controls.Add(this.lblNazivKlijenta);
            this.Controls.Add(this.lblIdNarudzbenice);
            this.Controls.Add(this.btnDodajStavku);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.txtIdNarudzbenice);
            this.Controls.Add(this.dtvStavkeNarudzbenice);
            this.Name = "frmUnosNarudzbenice";
            this.Text = "Unos Narudžbenice";
            this.Load += new System.EventHandler(this.frmUnosNarudzbenice_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hlpPokazi);
            ((System.ComponentModel.ISupportInitialize)(this.dtvStavkeNarudzbenice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkenarudzbeniceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvStavkeNarudzbenice;
        private System.Windows.Forms.TextBox txtIdNarudzbenice;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.Label lblIdNarudzbenice;
        private System.Windows.Forms.Label lblNazivKlijenta;
        private System.Windows.Forms.Label lblRokPlacanja;
        private System.Windows.Forms.Label lblReferent;
        private System.Windows.Forms.DateTimePicker dtpDatumIzdavanjaNarudzbenice;
        private System.Windows.Forms.ComboBox cmbNazivKlijenta;
        private System.Windows.Forms.DateTimePicker dtpRokPlacanja;
        private System.Windows.Forms.ComboBox cmbReferent;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private System.Windows.Forms.BindingSource lijekBindingSource;
        private System.Windows.Forms.BindingSource stavkenarudzbeniceBindingSource;
        private System.Windows.Forms.Button btnIzmjeni;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLijekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNarudzbeniceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn lijekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn narudzbenicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ukupno;
        private System.Windows.Forms.Label lblUkupniIznosNarudzbe;
        private System.Windows.Forms.TextBox txtUkupniIznosNarudzbe;
    }
}