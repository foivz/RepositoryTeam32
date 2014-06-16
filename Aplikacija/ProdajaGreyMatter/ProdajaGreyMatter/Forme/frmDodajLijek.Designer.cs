namespace ProdajaGreyMatter
{
    partial class frmDodajLijek
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
            this.dgvPopisLijekova = new System.Windows.Forms.DataGridView();
            this.btnDodajLijek = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.lblPretragaPremaNazivuLijeka = new System.Windows.Forms.Label();
            this.txtPretragaPremaNazivu = new System.Windows.Forms.TextBox();
            this.lijekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiplijekaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jedinicnamjeraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idLijekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uputeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumProizvodnjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokUpotrebeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pakiranjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dozaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idJedinicnaMjeraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idTipLijekaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicnamjeraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiplijekaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkenarudzbeniceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisLijekova)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiplijekaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jedinicnamjeraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPopisLijekova
            // 
            this.dgvPopisLijekova.AutoGenerateColumns = false;
            this.dgvPopisLijekova.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisLijekova.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLijekDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.uputeDataGridViewTextBoxColumn,
            this.datumProizvodnjeDataGridViewTextBoxColumn,
            this.rokUpotrebeDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.pakiranjeDataGridViewTextBoxColumn,
            this.dozaDataGridViewTextBoxColumn,
            this.idJedinicnaMjeraDataGridViewTextBoxColumn,
            this.idTipLijekaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.jedinicnamjeraDataGridViewTextBoxColumn,
            this.tiplijekaDataGridViewTextBoxColumn,
            this.stavkenarudzbeniceDataGridViewTextBoxColumn});
            this.dgvPopisLijekova.DataSource = this.lijekBindingSource;
            this.dgvPopisLijekova.Location = new System.Drawing.Point(2, 43);
            this.dgvPopisLijekova.MultiSelect = false;
            this.dgvPopisLijekova.Name = "dgvPopisLijekova";
            this.dgvPopisLijekova.ReadOnly = true;
            this.dgvPopisLijekova.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisLijekova.Size = new System.Drawing.Size(799, 169);
            this.dgvPopisLijekova.TabIndex = 0;
            // 
            // btnDodajLijek
            // 
            this.btnDodajLijek.Location = new System.Drawing.Point(672, 227);
            this.btnDodajLijek.Name = "btnDodajLijek";
            this.btnDodajLijek.Size = new System.Drawing.Size(109, 31);
            this.btnDodajLijek.TabIndex = 1;
            this.btnDodajLijek.Text = "Dodaj";
            this.btnDodajLijek.UseVisualStyleBackColor = true;
            this.btnDodajLijek.Click += new System.EventHandler(this.btnDodajLijek_Click);
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(550, 227);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(95, 31);
            this.btnNatrag.TabIndex = 2;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // lblPretragaPremaNazivuLijeka
            // 
            this.lblPretragaPremaNazivuLijeka.AutoSize = true;
            this.lblPretragaPremaNazivuLijeka.Location = new System.Drawing.Point(30, 15);
            this.lblPretragaPremaNazivuLijeka.Name = "lblPretragaPremaNazivuLijeka";
            this.lblPretragaPremaNazivuLijeka.Size = new System.Drawing.Size(143, 13);
            this.lblPretragaPremaNazivuLijeka.TabIndex = 3;
            this.lblPretragaPremaNazivuLijeka.Text = "Pretraga prema nazivu lijeka:";
            // 
            // txtPretragaPremaNazivu
            // 
            this.txtPretragaPremaNazivu.Location = new System.Drawing.Point(179, 12);
            this.txtPretragaPremaNazivu.Name = "txtPretragaPremaNazivu";
            this.txtPretragaPremaNazivu.Size = new System.Drawing.Size(131, 20);
            this.txtPretragaPremaNazivu.TabIndex = 5;
            this.txtPretragaPremaNazivu.TextChanged += new System.EventHandler(this.txtPretragaPremaNazivu_TextChanged);
            // 
            // lijekBindingSource
            // 
            this.lijekBindingSource.DataSource = typeof(ProdajaGreyMatter.lijek);
            // 
            // tiplijekaBindingSource
            // 
            this.tiplijekaBindingSource.DataSource = typeof(ProdajaGreyMatter.tiplijeka);
            // 
            // jedinicnamjeraBindingSource
            // 
            this.jedinicnamjeraBindingSource.DataSource = typeof(ProdajaGreyMatter.jedinicnamjera);
            // 
            // idLijekDataGridViewTextBoxColumn
            // 
            this.idLijekDataGridViewTextBoxColumn.DataPropertyName = "idLijek";
            this.idLijekDataGridViewTextBoxColumn.HeaderText = "idLijek";
            this.idLijekDataGridViewTextBoxColumn.Name = "idLijekDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // uputeDataGridViewTextBoxColumn
            // 
            this.uputeDataGridViewTextBoxColumn.DataPropertyName = "upute";
            this.uputeDataGridViewTextBoxColumn.HeaderText = "upute";
            this.uputeDataGridViewTextBoxColumn.Name = "uputeDataGridViewTextBoxColumn";
            // 
            // datumProizvodnjeDataGridViewTextBoxColumn
            // 
            this.datumProizvodnjeDataGridViewTextBoxColumn.DataPropertyName = "datumProizvodnje";
            this.datumProizvodnjeDataGridViewTextBoxColumn.HeaderText = "datumProizvodnje";
            this.datumProizvodnjeDataGridViewTextBoxColumn.Name = "datumProizvodnjeDataGridViewTextBoxColumn";
            // 
            // rokUpotrebeDataGridViewTextBoxColumn
            // 
            this.rokUpotrebeDataGridViewTextBoxColumn.DataPropertyName = "rokUpotrebe";
            this.rokUpotrebeDataGridViewTextBoxColumn.HeaderText = "rokUpotrebe";
            this.rokUpotrebeDataGridViewTextBoxColumn.Name = "rokUpotrebeDataGridViewTextBoxColumn";
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            // 
            // pakiranjeDataGridViewTextBoxColumn
            // 
            this.pakiranjeDataGridViewTextBoxColumn.DataPropertyName = "pakiranje";
            this.pakiranjeDataGridViewTextBoxColumn.HeaderText = "pakiranje";
            this.pakiranjeDataGridViewTextBoxColumn.Name = "pakiranjeDataGridViewTextBoxColumn";
            // 
            // dozaDataGridViewTextBoxColumn
            // 
            this.dozaDataGridViewTextBoxColumn.DataPropertyName = "doza";
            this.dozaDataGridViewTextBoxColumn.HeaderText = "doza";
            this.dozaDataGridViewTextBoxColumn.Name = "dozaDataGridViewTextBoxColumn";
            // 
            // idJedinicnaMjeraDataGridViewTextBoxColumn
            // 
            this.idJedinicnaMjeraDataGridViewTextBoxColumn.DataPropertyName = "idJedinicnaMjera";
            this.idJedinicnaMjeraDataGridViewTextBoxColumn.DataSource = this.jedinicnamjeraBindingSource;
            this.idJedinicnaMjeraDataGridViewTextBoxColumn.DisplayMember = "kratica";
            this.idJedinicnaMjeraDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idJedinicnaMjeraDataGridViewTextBoxColumn.HeaderText = "Jedinična mjera";
            this.idJedinicnaMjeraDataGridViewTextBoxColumn.Name = "idJedinicnaMjeraDataGridViewTextBoxColumn";
            this.idJedinicnaMjeraDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idJedinicnaMjeraDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idJedinicnaMjeraDataGridViewTextBoxColumn.ValueMember = "idJedinicnaMjera";
            // 
            // idTipLijekaDataGridViewTextBoxColumn
            // 
            this.idTipLijekaDataGridViewTextBoxColumn.DataPropertyName = "idTipLijeka";
            this.idTipLijekaDataGridViewTextBoxColumn.DataSource = this.tiplijekaBindingSource;
            this.idTipLijekaDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.idTipLijekaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idTipLijekaDataGridViewTextBoxColumn.HeaderText = "Tip lijeka";
            this.idTipLijekaDataGridViewTextBoxColumn.Name = "idTipLijekaDataGridViewTextBoxColumn";
            this.idTipLijekaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idTipLijekaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idTipLijekaDataGridViewTextBoxColumn.ValueMember = "idTipLijeka";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // jedinicnamjeraDataGridViewTextBoxColumn
            // 
            this.jedinicnamjeraDataGridViewTextBoxColumn.DataPropertyName = "jedinicnamjera";
            this.jedinicnamjeraDataGridViewTextBoxColumn.HeaderText = "jedinicnamjera";
            this.jedinicnamjeraDataGridViewTextBoxColumn.Name = "jedinicnamjeraDataGridViewTextBoxColumn";
            this.jedinicnamjeraDataGridViewTextBoxColumn.Visible = false;
            // 
            // tiplijekaDataGridViewTextBoxColumn
            // 
            this.tiplijekaDataGridViewTextBoxColumn.DataPropertyName = "tiplijeka";
            this.tiplijekaDataGridViewTextBoxColumn.HeaderText = "tiplijeka";
            this.tiplijekaDataGridViewTextBoxColumn.Name = "tiplijekaDataGridViewTextBoxColumn";
            this.tiplijekaDataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkenarudzbeniceDataGridViewTextBoxColumn
            // 
            this.stavkenarudzbeniceDataGridViewTextBoxColumn.DataPropertyName = "stavkenarudzbenice";
            this.stavkenarudzbeniceDataGridViewTextBoxColumn.HeaderText = "stavkenarudzbenice";
            this.stavkenarudzbeniceDataGridViewTextBoxColumn.Name = "stavkenarudzbeniceDataGridViewTextBoxColumn";
            this.stavkenarudzbeniceDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmDodajLijek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 270);
            this.Controls.Add(this.txtPretragaPremaNazivu);
            this.Controls.Add(this.lblPretragaPremaNazivuLijeka);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnDodajLijek);
            this.Controls.Add(this.dgvPopisLijekova);
            this.Name = "frmDodajLijek";
            this.Text = "frmDodajLijek";
            this.Load += new System.EventHandler(this.frmDodajLijek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisLijekova)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiplijekaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jedinicnamjeraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPopisLijekova;
        private System.Windows.Forms.Button btnDodajLijek;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Label lblPretragaPremaNazivuLijeka;
        private System.Windows.Forms.TextBox txtPretragaPremaNazivu;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLijekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uputeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumProizvodnjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokUpotrebeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pakiranjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dozaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idJedinicnaMjeraDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource jedinicnamjeraBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn idTipLijekaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tiplijekaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicnamjeraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiplijekaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkenarudzbeniceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource lijekBindingSource;
    }
}