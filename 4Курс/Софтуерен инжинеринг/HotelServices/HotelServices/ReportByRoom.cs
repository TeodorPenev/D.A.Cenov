using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace HotelServices
{
    public partial class ReportByRoom : Form
    {
        public ReportByRoom()
        {
            InitializeComponent();
        }

        private void ReportByRoom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds.Rooms' table. You can move, or remove it, as needed.
            this.RoomsTableAdapter.Fill(this.ds.Rooms);

            this.rv2.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            short roomNum = Convert.ToInt16(textBox1.Text);
            RoomsTableAdapter.FindByRoom(ds.Rooms,roomNum);
            rv2.Refresh();
        }

    }
}
