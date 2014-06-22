namespace ProdajaGreyMatter
{
    partial class frmNarudzbenicaReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportTablicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.greymatterpiDataSet = new ProdajaGreyMatter.greymatterpiDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportTablicaTableAdapter = new ProdajaGreyMatter.greymatterpiDataSetTableAdapters.reportTablicaTableAdapter();
            this.narudzbenicaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.narudzbenicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.narudzbenicaTableAdapter = new ProdajaGreyMatter.greymatterpiDataSetTableAdapters.narudzbenicaTableAdapter();
            this.btnNatrag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reportTablicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greymatterpiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportTablicaBindingSource
            // 
            this.reportTablicaBindingSource.DataMember = "reportTablica";
            this.reportTablicaBindingSource.DataSource = this.greymatterpiDataSet;
            // 
            // greymatterpiDataSet
            // 
            this.greymatterpiDataSet.DataSetName = "greymatterpiDataSet";
            this.greymatterpiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reportTablicaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProdajaGreyMatter.izvjestaj.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1091, 690);
            this.reportViewer1.TabIndex = 2;
            // 
            // reportTablicaTableAdapter
            // 
            this.reportTablicaTableAdapter.ClearBeforeFill = true;
            // 
            // narudzbenicaBindingSource1
            // 
            this.narudzbenicaBindingSource1.DataMember = "narudzbenica";
            this.narudzbenicaBindingSource1.DataSource = this.greymatterpiDataSet;
            // 
            // narudzbenicaBindingSource
            // 
            this.narudzbenicaBindingSource.DataSource = typeof(ProdajaGreyMatter.narudzbenica);
            // 
            // narudzbenicaTableAdapter
            // 
            this.narudzbenicaTableAdapter.ClearBeforeFill = true;
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(947, 616);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(100, 39);
            this.btnNatrag.TabIndex = 4;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // frmNarudzbenicaReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 690);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmNarudzbenicaReport";
            this.Text = "frmNarudzbenicaReport";
            this.Load += new System.EventHandler(this.frmNarudzbenicaReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportTablicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greymatterpiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reportTablicaBindingSource;
        private greymatterpiDataSet greymatterpiDataSet;
        private greymatterpiDataSetTableAdapters.reportTablicaTableAdapter reportTablicaTableAdapter;
        private System.Windows.Forms.BindingSource narudzbenicaBindingSource;
        private System.Windows.Forms.BindingSource narudzbenicaBindingSource1;
        private greymatterpiDataSetTableAdapters.narudzbenicaTableAdapter narudzbenicaTableAdapter;
        private System.Windows.Forms.Button btnNatrag;
    }
}