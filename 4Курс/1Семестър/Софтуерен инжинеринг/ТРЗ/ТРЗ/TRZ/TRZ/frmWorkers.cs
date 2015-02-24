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
    public partial class frmWorkers : Form
    {
        public frmWorkers()
        {
            InitializeComponent();
        }

        private void workersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

        private void frmWorkers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds.Workers' table. You can move, or remove it, as needed.
            this.workersTableAdapter.Fill(this.ds.Workers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            workersBindingSource.Filter = "Names LIKE '%' + '" + textBox1.Text + "'+ '%'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            workersBindingSource.Filter = "PeopleID LIKE '%' + '" + textBox2.Text + "'+ '%'";
        }
    }
}
