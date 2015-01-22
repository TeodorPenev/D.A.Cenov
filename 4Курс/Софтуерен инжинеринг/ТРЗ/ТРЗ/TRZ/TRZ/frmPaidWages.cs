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
    public partial class frmPaidWages : Form
    {
        public frmPaidWages()
        {
            InitializeComponent();
        }

        private void paidWagesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paidWagesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

        private void frmPaidWages_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds.PaidWages' table. You can move, or remove it, as needed.
            this.paidWagesTableAdapter.Fill(this.ds.PaidWages);

        }
    }
}
