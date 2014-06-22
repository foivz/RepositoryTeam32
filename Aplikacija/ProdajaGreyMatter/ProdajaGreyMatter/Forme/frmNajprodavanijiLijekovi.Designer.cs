namespace ProdajaGreyMatter
{
    partial class frmNajprodavanijiLijekovi
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.rb1Godina = new System.Windows.Forms.RadioButton();
            this.rb6Mjeseci = new System.Windows.Forms.RadioButton();
            this.rb3Mjeseca = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(47, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 573);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(742, 627);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(125, 49);
            this.btnNatrag.TabIndex = 1;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // rb1Godina
            // 
            this.rb1Godina.AutoSize = true;
            this.rb1Godina.Location = new System.Drawing.Point(936, 269);
            this.rb1Godina.Name = "rb1Godina";
            this.rb1Godina.Size = new System.Drawing.Size(66, 17);
            this.rb1Godina.TabIndex = 11;
            this.rb1Godina.Text = "1 godina";
            this.rb1Godina.UseVisualStyleBackColor = true;
            this.rb1Godina.CheckedChanged += new System.EventHandler(this.rb1Godina_CheckedChanged);
            // 
            // rb6Mjeseci
            // 
            this.rb6Mjeseci.AutoSize = true;
            this.rb6Mjeseci.Location = new System.Drawing.Point(936, 231);
            this.rb6Mjeseci.Name = "rb6Mjeseci";
            this.rb6Mjeseci.Size = new System.Drawing.Size(69, 17);
            this.rb6Mjeseci.TabIndex = 10;
            this.rb6Mjeseci.Text = "6 mjeseci";
            this.rb6Mjeseci.UseVisualStyleBackColor = true;
            this.rb6Mjeseci.CheckedChanged += new System.EventHandler(this.rb6Mjeseci_CheckedChanged);
            // 
            // rb3Mjeseca
            // 
            this.rb3Mjeseca.AutoSize = true;
            this.rb3Mjeseca.Checked = true;
            this.rb3Mjeseca.Location = new System.Drawing.Point(936, 188);
            this.rb3Mjeseca.Name = "rb3Mjeseca";
            this.rb3Mjeseca.Size = new System.Drawing.Size(73, 17);
            this.rb3Mjeseca.TabIndex = 9;
            this.rb3Mjeseca.TabStop = true;
            this.rb3Mjeseca.Text = "3 mjeseca";
            this.rb3Mjeseca.UseVisualStyleBackColor = true;
            this.rb3Mjeseca.CheckedChanged += new System.EventHandler(this.rb3Mjeseca_CheckedChanged);
            // 
            // frmNajprodavanijiLijekovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 688);
            this.Controls.Add(this.rb1Godina);
            this.Controls.Add(this.rb6Mjeseci);
            this.Controls.Add(this.rb3Mjeseca);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmNajprodavanijiLijekovi";
            this.Text = "frmNajprodavanijiLijekovi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.RadioButton rb1Godina;
        private System.Windows.Forms.RadioButton rb6Mjeseci;
        private System.Windows.Forms.RadioButton rb3Mjeseca;
    }
}