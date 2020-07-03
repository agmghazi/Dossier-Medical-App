namespace dossier_medical
{
    partial class All_report_EDmalade
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
            this.maladeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dossier_medical_alectroniqueDataSet5 = new dossier_medical.dossier_medical_alectroniqueDataSet5();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.maladeTableAdapter = new dossier_medical.dossier_medical_alectroniqueDataSet5TableAdapters.maladeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.maladeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dossier_medical_alectroniqueDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // maladeBindingSource
            // 
            this.maladeBindingSource.DataMember = "malade";
            this.maladeBindingSource.DataSource = this.dossier_medical_alectroniqueDataSet5;
            // 
            // dossier_medical_alectroniqueDataSet5
            // 
            this.dossier_medical_alectroniqueDataSet5.DataSetName = "dossier_medical_alectroniqueDataSet5";
            this.dossier_medical_alectroniqueDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.maladeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "dossier_medical.Report6.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(810, 408);
            this.reportViewer1.TabIndex = 0;
            // 
            // maladeTableAdapter
            // 
            this.maladeTableAdapter.ClearBeforeFill = true;
            // 
            // All_report_EDmalade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 408);
            this.Controls.Add(this.reportViewer1);
            this.Name = "All_report_EDmalade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All_report_EDmalade";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.All_report_EDmalade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maladeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dossier_medical_alectroniqueDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource maladeBindingSource;
        private dossier_medical_alectroniqueDataSet5TableAdapters.maladeTableAdapter maladeTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public dossier_medical_alectroniqueDataSet5 dossier_medical_alectroniqueDataSet5;
    }
}