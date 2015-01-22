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
    public partial class frmReportSalary : Form
    {
        public frmReportSalary()
        {
            InitializeComponent();
        }

        private void frmReportSalary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds.PaidWages' table. You can move, or remove it, as needed.
            this.PaidWagesTableAdapter.Fill(this.ds.PaidWages);

            this.rv1.RefreshReport();
        }
    }
}
