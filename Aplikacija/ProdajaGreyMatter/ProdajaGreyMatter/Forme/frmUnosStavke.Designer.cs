namespace ProdajaGreyMatter
{
    partial class frmUnosStavke
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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.lblNazivLijeka = new System.Windows.Forms.Label();
            this.lblJedinicnaCijena = new System.Windows.Forms.Label();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.lblTipLijeka = new System.Windows.Forms.Label();
            this.txtTipLijeka = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.txtCijenaLijeka = new System.Windows.Forms.TextBox();
            this.lblDoza = new System.Windows.Forms.Label();
            this.lblPakiranje = new System.Windows.Forms.Label();
            this.txtDozaLijeka = new System.Windows.Forms.TextBox();
            this.txtNazivLijeka = new System.Windows.Forms.TextBox();
            this.txtPakiranjeLijeka = new System.Windows.Forms.TextBox();
            this.idLijeka = new System.Windows.Forms.Label();
            this.txtIdLijeka = new System.Windows.Forms.TextBox();
            this.btnDodajLijek = new System.Windows.Forms.Button();
            this.lblPomoc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(84, 271);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(102, 36);
            this.btnOdustani.TabIndex = 0;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(213, 271);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(106, 36);
            this.btnSpremi.TabIndex = 1;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // lblNazivLijeka
            // 
            this.lblNazivLijeka.AutoSize = true;
            this.lblNazivLijeka.Location = new System.Drawing.Point(34, 50);
            this.lblNazivLijeka.Name = "lblNazivLijeka";
            this.lblNazivLijeka.Size = new System.Drawing.Size(64, 13);
            this.lblNazivLijeka.TabIndex = 2;
            this.lblNazivLijeka.Text = "Naziv lijeka:";
            // 
            // lblJedinicnaCijena
            // 
            this.lblJedinicnaCijena.AutoSize = true;
            this.lblJedinicnaCijena.Location = new System.Drawing.Point(12, 192);
            this.lblJedinicnaCijena.Name = "lblJedinicnaCijena";
            this.lblJedinicnaCijena.Size = new System.Drawing.Size(86, 13);
            this.lblJedinicnaCijena.TabIndex = 4;
            this.lblJedinicnaCijena.Text = "Jedinična cijena:";
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(46, 230);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(47, 13);
            this.lblKolicina.TabIndex = 5;
            this.lblKolicina.Text = "Količina:";
            // 
            // lblTipLijeka
            // 
            this.lblTipLijeka.AutoSize = true;
            this.lblTipLijeka.Location = new System.Drawing.Point(46, 84);
            this.lblTipLijeka.Name = "lblTipLijeka";
            this.lblTipLijeka.Size = new System.Drawing.Size(52, 13);
            this.lblTipLijeka.TabIndex = 6;
            this.lblTipLijeka.Text = "Tip lijeka:";
            // 
            // txtTipLijeka
            // 
            this.txtTipLijeka.Location = new System.Drawing.Point(124, 81);
            this.txtTipLijeka.Name = "txtTipLijeka";
            this.txtTipLijeka.ReadOnly = true;
            this.txtTipLijeka.Size = new System.Drawing.Size(121, 20);
            this.txtTipLijeka.TabIndex = 7;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(126, 227);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(121, 20);
            this.txtKolicina.TabIndex = 8;
            // 
            // txtCijenaLijeka
            // 
            this.txtCijenaLijeka.Location = new System.Drawing.Point(126, 192);
            this.txtCijenaLijeka.Name = "txtCijenaLijeka";
            this.txtCijenaLijeka.ReadOnly = true;
            this.txtCijenaLijeka.Size = new System.Drawing.Size(121, 20);
            this.txtCijenaLijeka.TabIndex = 9;
            // 
            // lblDoza
            // 
            this.lblDoza.AutoSize = true;
            this.lblDoza.Location = new System.Drawing.Point(63, 121);
            this.lblDoza.Name = "lblDoza";
            this.lblDoza.Size = new System.Drawing.Size(35, 13);
            this.lblDoza.TabIndex = 12;
            this.lblDoza.Text = "Doza:";
            // 
            // lblPakiranje
            // 
            this.lblPakiranje.AutoSize = true;
            this.lblPakiranje.Location = new System.Drawing.Point(46, 156);
            this.lblPakiranje.Name = "lblPakiranje";
            this.lblPakiranje.Size = new System.Drawing.Size(54, 13);
            this.lblPakiranje.TabIndex = 13;
            this.lblPakiranje.Text = "Pakiranje:";
            // 
            // txtDozaLijeka
            // 
            this.txtDozaLijeka.Location = new System.Drawing.Point(124, 121);
            this.txtDozaLijeka.Name = "txtDozaLijeka";
            this.txtDozaLijeka.ReadOnly = true;
            this.txtDozaLijeka.Size = new System.Drawing.Size(121, 20);
            this.txtDozaLijeka.TabIndex = 14;
            // 
            // txtNazivLijeka
            // 
            this.txtNazivLijeka.Location = new System.Drawing.Point(124, 47);
            this.txtNazivLijeka.Name = "txtNazivLijeka";
            this.txtNazivLijeka.ReadOnly = true;
            this.txtNazivLijeka.Size = new System.Drawing.Size(121, 20);
            this.txtNazivLijeka.TabIndex = 15;
            // 
            // txtPakiranjeLijeka
            // 
            this.txtPakiranjeLijeka.Location = new System.Drawing.Point(126, 156);
            this.txtPakiranjeLijeka.Name = "txtPakiranjeLijeka";
            this.txtPakiranjeLijeka.ReadOnly = true;
            this.txtPakiranjeLijeka.Size = new System.Drawing.Size(119, 20);
            this.txtPakiranjeLijeka.TabIndex = 16;
            // 
            // idLijeka
            // 
            this.idLijeka.AutoSize = true;
            this.idLijeka.Location = new System.Drawing.Point(52, 19);
            this.idLijeka.Name = "idLijeka";
            this.idLijeka.Size = new System.Drawing.Size(46, 13);
            this.idLijeka.TabIndex = 17;
            this.idLijeka.Text = "Id lijeka:";
            // 
            // txtIdLijeka
            // 
            this.txtIdLijeka.Location = new System.Drawing.Point(124, 16);
            this.txtIdLijeka.Name = "txtIdLijeka";
            this.txtIdLijeka.ReadOnly = true;
            this.txtIdLijeka.Size = new System.Drawing.Size(121, 20);
            this.txtIdLijeka.TabIndex = 18;
            // 
            // btnDodajLijek
            // 
            this.btnDodajLijek.Location = new System.Drawing.Point(266, 12);
            this.btnDodajLijek.Name = "btnDodajLijek";
            this.btnDodajLijek.Size = new System.Drawing.Size(53, 38);
            this.btnDodajLijek.TabIndex = 19;
            this.btnDodajLijek.Text = "...";
            this.btnDodajLijek.UseVisualStyleBackColor = true;
            this.btnDodajLijek.Click += new System.EventHandler(this.btnDodajLijek_Click);
            // 
            // lblPomoc
            // 
            this.lblPomoc.AutoSize = true;
            this.lblPomoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPomoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPomoc.Location = new System.Drawing.Point(12, 328);
            this.lblPomoc.Name = "lblPomoc";
            this.lblPomoc.Size = new System.Drawing.Size(132, 15);
            this.lblPomoc.TabIndex = 20;
            this.lblPomoc.Text = "Za pomoć pritisnite f1";
            // 
            // frmUnosStavke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 352);
            this.Controls.Add(this.lblPomoc);
            this.Controls.Add(this.btnDodajLijek);
            this.Controls.Add(this.txtIdLijeka);
            this.Controls.Add(this.idLijeka);
            this.Controls.Add(this.txtPakiranjeLijeka);
            this.Controls.Add(this.txtNazivLijeka);
            this.Controls.Add(this.txtDozaLijeka);
            this.Controls.Add(this.lblPakiranje);
            this.Controls.Add(this.lblDoza);
            this.Controls.Add(this.txtCijenaLijeka);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.txtTipLijeka);
            this.Controls.Add(this.lblTipLijeka);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.lblJedinicnaCijena);
            this.Controls.Add(this.lblNazivLijeka);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOdustani);
            this.Name = "frmUnosStavke";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmUnosStavke_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hlpPokazi);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label lblNazivLijeka;
        private System.Windows.Forms.Label lblJedinicnaCijena;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Label lblTipLijeka;
        private System.Windows.Forms.TextBox txtTipLijeka;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.TextBox txtCijenaLijeka;
        private System.Windows.Forms.Label lblDoza;
        private System.Windows.Forms.Label lblPakiranje;
        private System.Windows.Forms.TextBox txtDozaLijeka;
        private System.Windows.Forms.TextBox txtNazivLijeka;
        private System.Windows.Forms.TextBox txtPakiranjeLijeka;
        private System.Windows.Forms.Label idLijeka;
        private System.Windows.Forms.TextBox txtIdLijeka;
        private System.Windows.Forms.Button btnDodajLijek;
        private System.Windows.Forms.Label lblPomoc;
    }
}