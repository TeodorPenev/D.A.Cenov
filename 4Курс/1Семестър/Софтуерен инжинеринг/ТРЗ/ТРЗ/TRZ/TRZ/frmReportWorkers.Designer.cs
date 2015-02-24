namespace TRZ
{
    partial class frmReportWorkers
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
            this.rv2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ds = new TRZ.ds();
            this.PaidWagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PaidWagesTableAdapter = new TRZ.dsTableAdapters.PaidWagesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaidWagesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rv2
            // 
            reportDataSource1.Name = "r2";
            reportDataSource1.Value = this.PaidWagesBindingSource;
            this.rv2.LocalReport.DataSources.Add(reportDataSource1);
            this.rv2.LocalReport.ReportEmbeddedResource = "TRZ.Report2.rdlc";
            this.rv2.Location = new System.Drawing.Point(12, 12);
            this.rv2.Name = "rv2";
            this.rv2.Size = new System.Drawing.Size(934, 405);
            this.rv2.TabIndex = 0;
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PaidWagesBindingSource
            // 
            this.PaidWagesBindingSource.DataMember = "PaidWages";
            this.PaidWagesBindingSource.DataSource = this.ds;
            // 
            // PaidWagesTableAdapter
            // 
            this.PaidWagesTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 429);
            this.Controls.Add(this.rv2);
            this.Name = "frmReportWorkers";
            this.Text = "frmReportWorkers";
            this.Load += new System.EventHandler(this.frmReportWorkers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaidWagesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv2;
        private System.Windows.Forms.BindingSource PaidWagesBindingSource;
        private ds ds;
        private dsTableAdapters.PaidWagesTableAdapter PaidWagesTableAdapter;
    }
}