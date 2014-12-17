namespace HotelServices
{
    partial class ReportByName
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
            this.CustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new HotelServices.ds();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bt4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CustomersTableAdapter = new HotelServices.dsTableAdapters.CustomersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomersBindingSource
            // 
            this.CustomersBindingSource.DataMember = "Customers";
            this.CustomersBindingSource.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer2
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CustomersBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "HotelServices.Report3.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(115, 142);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(694, 290);
            this.reportViewer2.TabIndex = 0;
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(115, 85);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(219, 23);
            this.bt4.TabIndex = 1;
            this.bt4.Text = "Покажи по имената на клиент:";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(368, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // CustomersTableAdapter
            // 
            this.CustomersTableAdapter.ClearBeforeFill = true;
            // 
            // ReportByName
            // 
            this.ClientSize = new System.Drawing.Size(840, 491);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.reportViewer2);
            this.Name = "ReportByName";
            this.Load += new System.EventHandler(this.ReportByName_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingSource CustomersBindingSource;
        private ds ds;
        private dsTableAdapters.CustomersTableAdapter CustomersTableAdapter;
    }
}