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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void работаСКлиентиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomers f1 = new frmCustomers();
            f1.ShowDialog();
        }

        private void стаиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRooms f2 = new frmRooms();
            f2.ShowDialog();
        }

        private void резервацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReservations f3 = new frmReservations();
            f3.ShowDialog();
        }

        private void справкаПоДатаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportByDate r1 = new ReportByDate();
            r1.ShowDialog();
        }
       
    }
}
