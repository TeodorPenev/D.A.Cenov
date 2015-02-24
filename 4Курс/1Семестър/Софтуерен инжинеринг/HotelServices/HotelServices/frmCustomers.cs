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
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.ds.Customers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            customersBindingSource.Filter = "Names LIKE '%'+'" + textBox1.Text + "'+'%'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customersTableAdapter.FilterByCustomerID(ds.Customers, textBox2.Text);
        }
    }
}
