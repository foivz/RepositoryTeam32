﻿namespace ProdajaGreyMatter
{
    partial class frmLijekovi
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
            this.dgPopisLijekova = new System.Windows.Forms.DataGridView();
            this.idLijekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uputeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumProizvodnjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokUpotrebeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pakiranjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dozaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idJedinicnaMjeraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.jedinicnamjeraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTipLijekaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tiplijekaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicnamjeraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiplijekaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkenarudzbeniceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lijekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNatrag = new System.Windows.Forms.Button();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.txtPretragaLijekova = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPopisLijekova)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jedinicnamjeraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiplijekaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPopisLijekova
            // 
            this.dgPopisLijekova.AutoGenerateColumns = false;
            this.dgPopisLijekova.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPopisLijekova.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgPopisLijekova.DataSource = this.lijekBindingSource;
            this.dgPopisLijekova.Location = new System.Drawing.Point(0, 63);
            this.dgPopisLijekova.MultiSelect = false;
            this.dgPopisLijekova.Name = "dgPopisLijekova";
            this.dgPopisLijekova.ReadOnly = true;
            this.dgPopisLijekova.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPopisLijekova.Size = new System.Drawing.Size(883, 201);
            this.dgPopisLijekova.TabIndex = 0;
            // 
            // idLijekDataGridViewTextBoxColumn
            // 
            this.idLijekDataGridViewTextBoxColumn.DataPropertyName = "idLijek";
            this.idLijekDataGridViewTextBoxColumn.HeaderText = "idLijeka";
            this.idLijekDataGridViewTextBoxColumn.Name = "idLijekDataGridViewTextBoxColumn";
            this.idLijekDataGridViewTextBoxColumn.ReadOnly = true;
            this.idLijekDataGridViewTextBoxColumn.Width = 60;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uputeDataGridViewTextBoxColumn
            // 
            this.uputeDataGridViewTextBoxColumn.DataPropertyName = "upute";
            this.uputeDataGridViewTextBoxColumn.HeaderText = "upute";
            this.uputeDataGridViewTextBoxColumn.Name = "uputeDataGridViewTextBoxColumn";
            this.uputeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumProizvodnjeDataGridViewTextBoxColumn
            // 
            this.datumProizvodnjeDataGridViewTextBoxColumn.DataPropertyName = "datumProizvodnje";
            this.datumProizvodnjeDataGridViewTextBoxColumn.HeaderText = "datumProizvodnje";
            this.datumProizvodnjeDataGridViewTextBoxColumn.Name = "datumProizvodnjeDataGridViewTextBoxColumn";
            this.datumProizvodnjeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rokUpotrebeDataGridViewTextBoxColumn
            // 
            this.rokUpotrebeDataGridViewTextBoxColumn.DataPropertyName = "rokUpotrebe";
            this.rokUpotrebeDataGridViewTextBoxColumn.HeaderText = "rokUpotrebe";
            this.rokUpotrebeDataGridViewTextBoxColumn.Name = "rokUpotrebeDataGridViewTextBoxColumn";
            this.rokUpotrebeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pakiranjeDataGridViewTextBoxColumn
            // 
            this.pakiranjeDataGridViewTextBoxColumn.DataPropertyName = "pakiranje";
            this.pakiranjeDataGridViewTextBoxColumn.HeaderText = "pakiranje";
            this.pakiranjeDataGridViewTextBoxColumn.Name = "pakiranjeDataGridViewTextBoxColumn";
            this.pakiranjeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dozaDataGridViewTextBoxColumn
            // 
            this.dozaDataGridViewTextBoxColumn.DataPropertyName = "doza";
            this.dozaDataGridViewTextBoxColumn.HeaderText = "doza";
            this.dozaDataGridViewTextBoxColumn.Name = "dozaDataGridViewTextBoxColumn";
            this.dozaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idJedinicnaMjeraDataGridViewTextBoxColumn
            // 
            this.idJedinicnaMjeraDataGridViewTextBoxColumn.DataPropertyName = "idJedinicnaMjera";
            this.idJedinicnaMjeraDataGridViewTextBoxColumn.DataSource = this.jedinicnamjeraBindingSource;
            this.idJedinicnaMjeraDataGridViewTextBoxColumn.DisplayMember = "kratica";
            this.idJedinicnaMjeraDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idJedinicnaMjeraDataGridViewTextBoxColumn.HeaderText = "Jedinicna mjera";
            this.idJedinicnaMjeraDataGridViewTextBoxColumn.Name = "idJedinicnaMjeraDataGridViewTextBoxColumn";
            this.idJedinicnaMjeraDataGridViewTextBoxColumn.ReadOnly = true;
            this.idJedinicnaMjeraDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idJedinicnaMjeraDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idJedinicnaMjeraDataGridViewTextBoxColumn.ValueMember = "idJedinicnaMjera";
            // 
            // jedinicnamjeraBindingSource
            // 
            this.jedinicnamjeraBindingSource.DataSource = typeof(ProdajaGreyMatter.jedinicnamjera);
            // 
            // idTipLijekaDataGridViewTextBoxColumn
            // 
            this.idTipLijekaDataGridViewTextBoxColumn.DataPropertyName = "idTipLijeka";
            this.idTipLijekaDataGridViewTextBoxColumn.DataSource = this.tiplijekaBindingSource;
            this.idTipLijekaDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.idTipLijekaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idTipLijekaDataGridViewTextBoxColumn.HeaderText = "Tip lijeka";
            this.idTipLijekaDataGridViewTextBoxColumn.Name = "idTipLijekaDataGridViewTextBoxColumn";
            this.idTipLijekaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTipLijekaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idTipLijekaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idTipLijekaDataGridViewTextBoxColumn.ValueMember = "idTipLijeka";
            // 
            // tiplijekaBindingSource
            // 
            this.tiplijekaBindingSource.DataSource = typeof(ProdajaGreyMatter.tiplijeka);
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jedinicnamjeraDataGridViewTextBoxColumn
            // 
            this.jedinicnamjeraDataGridViewTextBoxColumn.DataPropertyName = "jedinicnamjera";
            this.jedinicnamjeraDataGridViewTextBoxColumn.HeaderText = "jedinicnamjera";
            this.jedinicnamjeraDataGridViewTextBoxColumn.Name = "jedinicnamjeraDataGridViewTextBoxColumn";
            this.jedinicnamjeraDataGridViewTextBoxColumn.ReadOnly = true;
            this.jedinicnamjeraDataGridViewTextBoxColumn.Visible = false;
            // 
            // tiplijekaDataGridViewTextBoxColumn
            // 
            this.tiplijekaDataGridViewTextBoxColumn.DataPropertyName = "tiplijeka";
            this.tiplijekaDataGridViewTextBoxColumn.HeaderText = "tiplijeka";
            this.tiplijekaDataGridViewTextBoxColumn.Name = "tiplijekaDataGridViewTextBoxColumn";
            this.tiplijekaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tiplijekaDataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkenarudzbeniceDataGridViewTextBoxColumn
            // 
            this.stavkenarudzbeniceDataGridViewTextBoxColumn.DataPropertyName = "stavkenarudzbenice";
            this.stavkenarudzbeniceDataGridViewTextBoxColumn.HeaderText = "stavkenarudzbenice";
            this.stavkenarudzbeniceDataGridViewTextBoxColumn.Name = "stavkenarudzbeniceDataGridViewTextBoxColumn";
            this.stavkenarudzbeniceDataGridViewTextBoxColumn.ReadOnly = true;
            this.stavkenarudzbeniceDataGridViewTextBoxColumn.Visible = false;
            // 
            // lijekBindingSource
            // 
            this.lijekBindingSource.DataSource = typeof(ProdajaGreyMatter.lijek);
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(636, 272);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(106, 39);
            this.btnNatrag.TabIndex = 1;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Location = new System.Drawing.Point(46, 15);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(143, 13);
            this.lblPretraga.TabIndex = 2;
            this.lblPretraga.Text = "Pretraga prema nazivu lijeka:";
            // 
            // txtPretragaLijekova
            // 
            this.txtPretragaLijekova.Location = new System.Drawing.Point(195, 12);
            this.txtPretragaLijekova.Name = "txtPretragaLijekova";
            this.txtPretragaLijekova.Size = new System.Drawing.Size(122, 20);
            this.txtPretragaLijekova.TabIndex = 3;
            this.txtPretragaLijekova.TextChanged += new System.EventHandler(this.txtPretragaLijekova_TextChanged);
            // 
            // frmLijekovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 323);
            this.Controls.Add(this.txtPretragaLijekova);
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.dgPopisLijekova);
            this.Name = "frmLijekovi";
            this.Text = "Lijekovi";
            this.Load += new System.EventHandler(this.frmLijekovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPopisLijekova)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jedinicnamjeraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiplijekaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPopisLijekova;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.BindingSource lijekBindingSource;
        private System.Windows.Forms.Label lblPretraga;
        private System.Windows.Forms.TextBox txtPretragaLijekova;
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
    }
}