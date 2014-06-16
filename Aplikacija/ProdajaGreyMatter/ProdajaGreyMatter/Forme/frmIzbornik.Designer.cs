namespace ProdajaGreyMatter
{
    partial class frmIzbornik
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
            this.btnLijekovi = new System.Windows.Forms.Button();
            this.btnKlijenti = new System.Windows.Forms.Button();
            this.btnNarudzbenica = new System.Windows.Forms.Button();
            this.btnStatistika = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.lblZaposlenik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLijekovi
            // 
            this.btnLijekovi.Location = new System.Drawing.Point(123, 161);
            this.btnLijekovi.Name = "btnLijekovi";
            this.btnLijekovi.Size = new System.Drawing.Size(182, 110);
            this.btnLijekovi.TabIndex = 0;
            this.btnLijekovi.Text = "Lijekovi";
            this.btnLijekovi.UseVisualStyleBackColor = true;
            this.btnLijekovi.Click += new System.EventHandler(this.btnLijekovi_Click);
            // 
            // btnKlijenti
            // 
            this.btnKlijenti.Location = new System.Drawing.Point(472, 161);
            this.btnKlijenti.Name = "btnKlijenti";
            this.btnKlijenti.Size = new System.Drawing.Size(182, 110);
            this.btnKlijenti.TabIndex = 1;
            this.btnKlijenti.Text = "Klijenti";
            this.btnKlijenti.UseVisualStyleBackColor = true;
            this.btnKlijenti.Click += new System.EventHandler(this.btnKlijenti_Click);
            // 
            // btnNarudzbenica
            // 
            this.btnNarudzbenica.Location = new System.Drawing.Point(123, 366);
            this.btnNarudzbenica.Name = "btnNarudzbenica";
            this.btnNarudzbenica.Size = new System.Drawing.Size(182, 110);
            this.btnNarudzbenica.TabIndex = 2;
            this.btnNarudzbenica.Text = "Narudžbenica";
            this.btnNarudzbenica.UseVisualStyleBackColor = true;
            this.btnNarudzbenica.Click += new System.EventHandler(this.btnNarudzbenica_Click);
            // 
            // btnStatistika
            // 
            this.btnStatistika.Location = new System.Drawing.Point(472, 366);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Size = new System.Drawing.Size(182, 110);
            this.btnStatistika.TabIndex = 3;
            this.btnStatistika.Text = "Statistika";
            this.btnStatistika.UseVisualStyleBackColor = true;
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.SystemColors.Control;
            this.btnOdjava.Location = new System.Drawing.Point(731, 34);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(107, 23);
            this.btnOdjava.TabIndex = 4;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // lblZaposlenik
            // 
            this.lblZaposlenik.AutoSize = true;
            this.lblZaposlenik.Location = new System.Drawing.Point(635, 39);
            this.lblZaposlenik.Name = "lblZaposlenik";
            this.lblZaposlenik.Size = new System.Drawing.Size(35, 13);
            this.lblZaposlenik.TabIndex = 5;
            this.lblZaposlenik.Text = "label1";
            // 
            // frmIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 631);
            this.Controls.Add(this.lblZaposlenik);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnStatistika);
            this.Controls.Add(this.btnNarudzbenica);
            this.Controls.Add(this.btnKlijenti);
            this.Controls.Add(this.btnLijekovi);
            this.Name = "frmIzbornik";
            this.Text = "Prodaja Grey Matter d.o.o";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLijekovi;
        private System.Windows.Forms.Button btnKlijenti;
        private System.Windows.Forms.Button btnNarudzbenica;
        private System.Windows.Forms.Button btnStatistika;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Label lblZaposlenik;

    }
}

