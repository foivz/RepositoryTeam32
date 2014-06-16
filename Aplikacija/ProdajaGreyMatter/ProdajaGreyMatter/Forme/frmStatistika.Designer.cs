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
            this.rb3Mjeseca = new System.Windows.Forms.RadioButton();
            this.rb6Mjeseci = new System.Windows.Forms.RadioButton();
            this.rb1Godina = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnNajboljiKupci
            // 
            this.btnNajboljiKupci.Location = new System.Drawing.Point(38, 64);
            this.btnNajboljiKupci.Name = "btnNajboljiKupci";
            this.btnNajboljiKupci.Size = new System.Drawing.Size(95, 56);
            this.btnNajboljiKupci.TabIndex = 0;
            this.btnNajboljiKupci.Text = "Najbolji kupci";
            this.btnNajboljiKupci.UseVisualStyleBackColor = true;
            // 
            // btnNajprodavanijiLIjekovi
            // 
            this.btnNajprodavanijiLIjekovi.Location = new System.Drawing.Point(38, 146);
            this.btnNajprodavanijiLIjekovi.Name = "btnNajprodavanijiLIjekovi";
            this.btnNajprodavanijiLIjekovi.Size = new System.Drawing.Size(95, 56);
            this.btnNajprodavanijiLIjekovi.TabIndex = 1;
            this.btnNajprodavanijiLIjekovi.Text = "Najprodavaniji lijekovi";
            this.btnNajprodavanijiLIjekovi.UseVisualStyleBackColor = true;
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(236, 266);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(75, 23);
            this.btnNatrag.TabIndex = 2;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            // 
            // rb3Mjeseca
            // 
            this.rb3Mjeseca.AutoSize = true;
            this.rb3Mjeseca.Location = new System.Drawing.Point(205, 65);
            this.rb3Mjeseca.Name = "rb3Mjeseca";
            this.rb3Mjeseca.Size = new System.Drawing.Size(73, 17);
            this.rb3Mjeseca.TabIndex = 3;
            this.rb3Mjeseca.TabStop = true;
            this.rb3Mjeseca.Text = "3 mjeseca";
            this.rb3Mjeseca.UseVisualStyleBackColor = true;
            // 
            // rb6Mjeseci
            // 
            this.rb6Mjeseci.AutoSize = true;
            this.rb6Mjeseci.Location = new System.Drawing.Point(205, 108);
            this.rb6Mjeseci.Name = "rb6Mjeseci";
            this.rb6Mjeseci.Size = new System.Drawing.Size(69, 17);
            this.rb6Mjeseci.TabIndex = 4;
            this.rb6Mjeseci.TabStop = true;
            this.rb6Mjeseci.Text = "6 mjeseci";
            this.rb6Mjeseci.UseVisualStyleBackColor = true;
            // 
            // rb1Godina
            // 
            this.rb1Godina.AutoSize = true;
            this.rb1Godina.Location = new System.Drawing.Point(205, 146);
            this.rb1Godina.Name = "rb1Godina";
            this.rb1Godina.Size = new System.Drawing.Size(66, 17);
            this.rb1Godina.TabIndex = 5;
            this.rb1Godina.TabStop = true;
            this.rb1Godina.Text = "1 godina";
            this.rb1Godina.UseVisualStyleBackColor = true;
            // 
            // frmStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 312);
            this.Controls.Add(this.rb1Godina);
            this.Controls.Add(this.rb6Mjeseci);
            this.Controls.Add(this.rb3Mjeseca);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnNajprodavanijiLIjekovi);
            this.Controls.Add(this.btnNajboljiKupci);
            this.Name = "frmStatistika";
            this.Text = "Statistika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNajboljiKupci;
        private System.Windows.Forms.Button btnNajprodavanijiLIjekovi;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.RadioButton rb3Mjeseca;
        private System.Windows.Forms.RadioButton rb6Mjeseci;
        private System.Windows.Forms.RadioButton rb1Godina;
    }
}