namespace TRZ
{
    partial class frmReportSalary
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
            this.PaidWagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new TRZ.ds();
            this.rv1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PaidWagesTableAdapter = new TRZ.dsTableAdapters.PaidWagesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PaidWagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // PaidWagesBindingSource
            // 
            this.PaidWagesBindingSource.DataMember = "PaidWages";
            this.PaidWagesBindingSource.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rv1
            // 
            reportDataSource1.Name = "r1";
            reportDataSource1.Value = this.PaidWagesBindingSource;
            this.rv1.LocalReport.DataSources.Add(reportDataSource1);
            this.rv1.LocalReport.ReportEmbeddedResource = "TRZ.Report1.rdlc";
            this.rv1.Location = new System.Drawing.Point(12, 12);
            this.rv1.Name = "rv1";
            this.rv1.Size = new System.Drawing.Size(747, 425);
            this.rv1.TabIndex = 0;
            this.rv1.Load += new System.EventHandler(this.rv1_Load);
            // 
            // PaidWagesTableAdapter
            // 
            this.PaidWagesTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 449);
            this.Controls.Add(this.rv1);
            this.Name = "frmReportSalary";
            this.Text = "frmReportSalary";
            this.Load += new System.EventHandler(this.frmReportSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PaidWagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv1;
        private System.Windows.Forms.BindingSource PaidWagesBindingSource;
        private ds ds;
        private dsTableAdapters.PaidWagesTableAdapter PaidWagesTableAdapter;
    }
}