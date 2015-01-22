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
    public partial class frmSalaryData : Form
    {
        public frmSalaryData()
        {
            InitializeComponent();
        }

        private void dataSalaryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dataSalaryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

        private void frmSalaryData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds.DataSalary' table. You can move, or remove it, as needed.
            this.dataSalaryTableAdapter.Fill(this.ds.DataSalary);

        }
    }
}
