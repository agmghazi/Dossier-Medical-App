namespace dossier_medical
{
    partial class SELECT_R_analysee
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
            this.analyseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dossier_medical_alectroniqueDataSet1 = new dossier_medical.dossier_medical_alectroniqueDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.analyseTableAdapter = new dossier_medical.dossier_medical_alectroniqueDataSet1TableAdapters.analyseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.analyseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dossier_medical_alectroniqueDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // analyseBindingSource
            // 
            this.analyseBindingSource.DataMember = "analyse";
            this.analyseBindingSource.DataSource = this.dossier_medical_alectroniqueDataSet1;
            // 
            // dossier_medical_alectroniqueDataSet1
            // 
            this.dossier_medical_alectroniqueDataSet1.DataSetName = "dossier_medical_alectroniqueDataSet1";
            this.dossier_medical_alectroniqueDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.analyseBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "dossier_medical.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1155, 518);
            this.reportViewer1.TabIndex = 0;
            // 
            // analyseTableAdapter
            // 
            this.analyseTableAdapter.ClearBeforeFill = true;
            // 
            // SELECT_R_analysee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 518);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SELECT_R_analysee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SELECT_R_analysee";
            this.Load += new System.EventHandler(this.SELECT_R_analysee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.analyseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dossier_medical_alectroniqueDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource analyseBindingSource;
        private dossier_medical_alectroniqueDataSet1TableAdapters.analyseTableAdapter analyseTableAdapter;
        public dossier_medical_alectroniqueDataSet1 dossier_medical_alectroniqueDataSet1;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;

    }
}