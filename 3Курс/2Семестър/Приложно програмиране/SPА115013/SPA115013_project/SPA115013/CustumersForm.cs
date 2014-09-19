using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SPA115013_project
{
    public partial class CarsForm : Form
    {
        public string connStringSPA1;
        public CarsForm(string strParam1)
        {
            InitializeComponent();
            connStringSPA1 = strParam1;
        }
        SqlConnection SPA115013;
        DataSet ds;
        SqlDataAdapter daCustomers;
        SqlCommandBuilder cbCustomers;
        BindingSource _bindscr = new BindingSource();


        private void Customers_Load(object sender, EventArgs e)
        {
            SPA115013 = new SqlConnection(connStringSPA1);

            SPA115013.Open();
            daCustomers = new SqlDataAdapter("SELECT * from Customers", SPA115013);
            ds = new DataSet();
            cbCars = new SqlCommandBuilder(daCustomers);
            daCustomers.Fill(ds, "Customers");
            BindingNavigator _bindnav = new BindingNavigator(true);
            _bindscr.DataSource = ds.Tables["Customers"];
            _bindnav.BindingSource = _bindscr;
            dataGridView1.DataSource = _bindscr;
            bindingNavigator1.BindingSource = _bindscr;
            SPA115013.Close();
        }
    }
}

