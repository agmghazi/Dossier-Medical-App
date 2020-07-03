namespace dossier_medical
{
    partial class All_report_EXAMEN_GENERALE
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
            this.General_exameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dossier_medical_alectroniqueDataSet4 = new dossier_medical.dossier_medical_alectroniqueDataSet4();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.General_exameTableAdapter = new dossier_medical.dossier_medical_alectroniqueDataSet4TableAdapters.General_exameTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.General_exameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dossier_medical_alectroniqueDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // General_exameBindingSource
            // 
            this.General_exameBindingSource.DataMember = "General_exame";
            this.General_exameBindingSource.DataSource = this.dossier_medical_alectroniqueDataSet4;
            // 
            // dossier_medical_alectroniqueDataSet4
            // 
            this.dossier_medical_alectroniqueDataSet4.DataSetName = "dossier_medical_alectroniqueDataSet4";
            this.dossier_medical_alectroniqueDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "EXAMEN_GENERALE_DataSet";
            reportDataSource1.Value = this.General_exameBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "dossier_medical.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(284, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // General_exameTableAdapter
            // 
            this.General_exameTableAdapter.ClearBeforeFill = true;
            // 
            // All_report_EXAMEN_GENERALE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.reportViewer1);
            this.Name = "All_report_EXAMEN_GENERALE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All_report_EXAMEN_GENERALE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.All_report_EXAMEN_GENERALE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.General_exameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dossier_medical_alectroniqueDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource General_exameBindingSource;
        private dossier_medical_alectroniqueDataSet4TableAdapters.General_exameTableAdapter General_exameTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public dossier_medical_alectroniqueDataSet4 dossier_medical_alectroniqueDataSet4;
    }
}