﻿namespace dossier_medical
{
    partial class ALL_R_RADIO
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
            this.radioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dossier_medical_alectroniqueDataSet2 = new dossier_medical.dossier_medical_alectroniqueDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.radioTableAdapter = new dossier_medical.dossier_medical_alectroniqueDataSet2TableAdapters.radioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.radioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dossier_medical_alectroniqueDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // radioBindingSource
            // 
            this.radioBindingSource.DataMember = "radio";
            this.radioBindingSource.DataSource = this.dossier_medical_alectroniqueDataSet2;
            // 
            // dossier_medical_alectroniqueDataSet2
            // 
            this.dossier_medical_alectroniqueDataSet2.DataSetName = "dossier_medical_alectroniqueDataSet2";
            this.dossier_medical_alectroniqueDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.radioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "dossier_medical.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(951, 541);
            this.reportViewer1.TabIndex = 0;
            // 
            // radioTableAdapter
            // 
            this.radioTableAdapter.ClearBeforeFill = true;
            // 
            // ALL_R_RADIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 541);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ALL_R_RADIO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALL_R_RADIO";
            this.Load += new System.EventHandler(this.ALL_R_RADIO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dossier_medical_alectroniqueDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource radioBindingSource;
        private dossier_medical_alectroniqueDataSet2TableAdapters.radioTableAdapter radioTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public dossier_medical_alectroniqueDataSet2 dossier_medical_alectroniqueDataSet2;
    }
}