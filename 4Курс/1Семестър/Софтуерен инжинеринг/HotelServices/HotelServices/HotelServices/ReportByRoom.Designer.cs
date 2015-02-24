namespace HotelServices
{
    partial class ReportByRoom
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
            this.RoomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new HotelServices.ds();
            this.rv2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.RoomsTableAdapter = new HotelServices.dsTableAdapters.RoomsTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // RoomsBindingSource
            // 
            this.RoomsBindingSource.DataMember = "Rooms";
            this.RoomsBindingSource.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rv2
            // 
            reportDataSource1.Name = "r2";
            reportDataSource1.Value = this.RoomsBindingSource;
            this.rv2.LocalReport.DataSources.Add(reportDataSource1);
            this.rv2.LocalReport.ReportEmbeddedResource = "HotelServices.Report2.rdlc";
            this.rv2.Location = new System.Drawing.Point(12, 68);
            this.rv2.Name = "rv2";
            this.rv2.Size = new System.Drawing.Size(835, 379);
            this.rv2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Покажи историята за стая номер: ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RoomsTableAdapter
            // 
            this.RoomsTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(349, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // ReportByRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 608);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rv2);
            this.Name = "ReportByRoom";
            this.Text = "ReportByRoom";
            this.Load += new System.EventHandler(this.ReportByRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv2;
        private System.Windows.Forms.BindingSource RoomsBindingSource;
        private ds ds;
        private dsTableAdapters.RoomsTableAdapter RoomsTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}