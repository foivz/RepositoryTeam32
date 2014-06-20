namespace ProdajaGreyMatter
{
    partial class frmStatistika
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
            this.btnNajboljiKupci = new System.Windows.Forms.Button();
            this.btnNajprodavanijiLIjekovi = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNajboljiKupci
            // 
            this.btnNajboljiKupci.Location = new System.Drawing.Point(147, 110);
            this.btnNajboljiKupci.Name = "btnNajboljiKupci";
            this.btnNajboljiKupci.Size = new System.Drawing.Size(192, 56);
            this.btnNajboljiKupci.TabIndex = 0;
            this.btnNajboljiKupci.Text = "Najbolji kupci";
            this.btnNajboljiKupci.UseVisualStyleBackColor = true;
            this.btnNajboljiKupci.Click += new System.EventHandler(this.btnNajboljiKupci_Click);
            // 
            // btnNajprodavanijiLIjekovi
            // 
            this.btnNajprodavanijiLIjekovi.Location = new System.Drawing.Point(147, 208);
            this.btnNajprodavanijiLIjekovi.Name = "btnNajprodavanijiLIjekovi";
            this.btnNajprodavanijiLIjekovi.Size = new System.Drawing.Size(192, 56);
            this.btnNajprodavanijiLIjekovi.TabIndex = 1;
            this.btnNajprodavanijiLIjekovi.Text = "Najprodavaniji lijekovi";
            this.btnNajprodavanijiLIjekovi.UseVisualStyleBackColor = true;
            this.btnNajprodavanijiLIjekovi.Click += new System.EventHandler(this.btnNajprodavanijiLIjekovi_Click);
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(362, 346);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(75, 23);
            this.btnNatrag.TabIndex = 2;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // frmStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 431);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnNajprodavanijiLIjekovi);
            this.Controls.Add(this.btnNajboljiKupci);
            this.Name = "frmStatistika";
            this.Text = "Statistika";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNajboljiKupci;
        private System.Windows.Forms.Button btnNajprodavanijiLIjekovi;
        private System.Windows.Forms.Button btnNatrag;
    }
}