namespace ProdajaGreyMatter
{
    partial class frmUnosKlijenta
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
            this.lblOib = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblZiroRacun = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtOib = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtZiroRacun = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.btnSpremiKlijent = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOib
            // 
            this.lblOib.AutoSize = true;
            this.lblOib.Location = new System.Drawing.Point(107, 52);
            this.lblOib.Name = "lblOib";
            this.lblOib.Size = new System.Drawing.Size(28, 13);
            this.lblOib.TabIndex = 0;
            this.lblOib.Text = "OIB:";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(96, 96);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(37, 13);
            this.lblNaziv.TabIndex = 1;
            this.lblNaziv.Text = "Naziv:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(96, 140);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(90, 226);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(43, 13);
            this.lblAdresa.TabIndex = 3;
            this.lblAdresa.Text = "Adresa:";
            // 
            // lblZiroRacun
            // 
            this.lblZiroRacun.AutoSize = true;
            this.lblZiroRacun.Location = new System.Drawing.Point(75, 267);
            this.lblZiroRacun.Name = "lblZiroRacun";
            this.lblZiroRacun.Size = new System.Drawing.Size(58, 13);
            this.lblZiroRacun.TabIndex = 4;
            this.lblZiroRacun.Text = "Žiro račun:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(87, 186);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(46, 13);
            this.lblTelefon.TabIndex = 5;
            this.lblTelefon.Text = "Telefon:";
            // 
            // txtOib
            // 
            this.txtOib.Location = new System.Drawing.Point(153, 49);
            this.txtOib.MaxLength = 11;
            this.txtOib.Name = "txtOib";
            this.txtOib.Size = new System.Drawing.Size(128, 20);
            this.txtOib.TabIndex = 6;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(153, 93);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(128, 20);
            this.txtNaziv.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(153, 137);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(128, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(153, 223);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(128, 20);
            this.txtAdresa.TabIndex = 9;
            // 
            // txtZiroRacun
            // 
            this.txtZiroRacun.Location = new System.Drawing.Point(153, 264);
            this.txtZiroRacun.Name = "txtZiroRacun";
            this.txtZiroRacun.Size = new System.Drawing.Size(128, 20);
            this.txtZiroRacun.TabIndex = 10;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(153, 183);
            this.txtTelefon.MaxLength = 30;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(128, 20);
            this.txtTelefon.TabIndex = 11;
            // 
            // btnSpremiKlijent
            // 
            this.btnSpremiKlijent.Location = new System.Drawing.Point(286, 351);
            this.btnSpremiKlijent.Name = "btnSpremiKlijent";
            this.btnSpremiKlijent.Size = new System.Drawing.Size(90, 38);
            this.btnSpremiKlijent.TabIndex = 12;
            this.btnSpremiKlijent.Text = "Spremi";
            this.btnSpremiKlijent.UseVisualStyleBackColor = true;
            this.btnSpremiKlijent.Click += new System.EventHandler(this.btnSpremiKlijent_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(170, 351);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(88, 38);
            this.btnOdustani.TabIndex = 13;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // frmUnosKlijenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 414);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremiKlijent);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtZiroRacun);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.txtOib);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblZiroRacun);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblOib);
            this.Name = "frmUnosKlijenta";
            this.Text = "Unos klijenta";
            this.Load += new System.EventHandler(this.frmUnosKlijenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOib;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblZiroRacun;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtOib;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtZiroRacun;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Button btnSpremiKlijent;
        private System.Windows.Forms.Button btnOdustani;
    }
}