using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void операцииСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWorkers f1 = new frmWorkers();
            f1.ShowDialog();
        }

        private void операцииСФишовеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalaryData f2 = new frmSalaryData();
            f2.ShowDialog();
        }

        private void операцииСToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPaidWages f3 = new frmPaidWages();
            f3.ShowDialog();
        }

        private void справкаНаЗаплатиПоМесецToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportSalary r1 = new frmReportSalary();
            r1.ShowDialog();

        }

        private void справкаНаЗаплатиПоДаденРаботникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportWorkers r2 = new frmReportWorkers();
            r2.ShowDialog();
        }
    }
}
