using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelServices.dsTableAdapters;

namespace HotelServices
{
    public partial class ReportByName : Form
    {
        public ReportByName()
        {
            InitializeComponent();
        }

        private void ReportByName_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void ReportByName_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds.Customers' table. You can move, or remove it, as needed.
            this.CustomersTableAdapter.Fill(this.ds.Customers);

            this.reportViewer2.RefreshReport();
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            CustomersTableAdapter.FindByName(ds.Customers, textBox2.Text);
            reportViewer2.RefreshReport();
        }

    }
}
