using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelServices
{
    public partial class ReportByDate : Form
    {
        public ReportByDate()
        {
            InitializeComponent();
        }

        private void ReportByDate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds.Reservation' table. You can move, or remove it, as needed.
            this.ReservationTableAdapter.Fill(this.ds.Reservation);

            this.reportViewer1.RefreshReport();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            ReservationTableAdapter.FindByDate(ds.Reservation, dateTimePicker1.Value.Date.ToString());
            reportViewer1.RefreshReport();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            ReservationTableAdapter.FilterByDateDiff(ds.Reservation, dateTimePicker1.Value.Date.ToString(),dateTimePicker2.Value.ToString());
            reportViewer1.RefreshReport();
        }
    }
}
