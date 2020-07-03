namespace dossier_medical
{
    partial class ALL_R_evacuation
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
            this.evacuationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dossier_medical_alectroniqueDataSet3 = new dossier_medical.dossier_medical_alectroniqueDataSet3();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.evacuationTableAdapter = new dossier_medical.dossier_medical_alectroniqueDataSet3TableAdapters.evacuationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.evacuationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dossier_medical_alectroniqueDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // evacuationBindingSource
            // 
            this.evacuationBindingSource.DataMember = "evacuation";
            this.evacuationBindingSource.DataSource = this.dossier_medical_alectroniqueDataSet3;
            // 
            // dossier_medical_alectroniqueDataSet3
            // 
            this.dossier_medical_alectroniqueDataSet3.DataSetName = "dossier_medical_alectroniqueDataSet3";
            this.dossier_medical_alectroniqueDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.evacuationBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "dossier_medical.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1143, 609);
            this.reportViewer1.TabIndex = 0;
            // 
            // evacuationTableAdapter
            // 
            this.evacuationTableAdapter.ClearBeforeFill = true;
            // 
            // ALL_R_evacuation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 609);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ALL_R_evacuation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALL_R_evacuation";
            this.Load += new System.EventHandler(this.ALL_R_evacuation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.evacuationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dossier_medical_alectroniqueDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource evacuationBindingSource;
        private dossier_medical_alectroniqueDataSet3TableAdapters.evacuationTableAdapter evacuationTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public dossier_medical_alectroniqueDataSet3 dossier_medical_alectroniqueDataSet3;
    }
}