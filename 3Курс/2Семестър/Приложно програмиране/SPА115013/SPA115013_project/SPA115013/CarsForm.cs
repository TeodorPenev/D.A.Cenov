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
        SqlCommandBuilder cbCars;
        BindingSource _bindscr = new BindingSource(); 
        

        private void Cars_Load(object sender, EventArgs e)
        {
            SPA115013 = new SqlConnection(connStringSPA1);

            SPA115013.Open();
            daCustomers = new SqlDataAdapter("SELECT * from Cars", SPA115013);
            ds = new DataSet();
            cbCars = new SqlCommandBuilder(daCustomers);
            daCustomers.Fill(ds, "Cars");
            BindingNavigator _bindnav = new BindingNavigator(true);
            _bindscr.DataSource = ds.Tables["Cars"];
            _bindnav.BindingSource = _bindscr;
            dataGridView1.DataSource = _bindscr;
            bindingNavigator1.BindingSource = _bindscr;
            SPA115013.Close();
            dataGridView1.Columns[0].HeaderText = "ИД код";
            dataGridView1.Columns[1].HeaderText = "Модел автмобил";
            dataGridView1.Columns[2].HeaderText = "Година на излизане";
            dataGridView1.Columns[3].HeaderText = "Брой еърбега";
            dataGridView1.Columns[4].HeaderText = "Цена (лв.)";
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].DefaultCellStyle.Format = "n2";
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
    
        

        private void bindingNavigatorLoadItem_Click(object sender, EventArgs e)
        {
            SPA115013.Open();
            daCustomers = new SqlDataAdapter("Select * from Cars", SPA115013);
            ds = new DataSet();
            cbCars = new SqlCommandBuilder(daCustomers);
            daCustomers.Fill(ds, "Cars");
            _bindscr.DataSource = ds.Tables["Cars"];
            dataGridView1.DataSource = _bindscr;
            SPA115013.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SPA115013.Open();
            daCustomers.Update(ds, "Cars");
            daCustomers = new SqlDataAdapter("SELECT * from Cars", SPA115013);
            ds = new DataSet();
            cbCars = new SqlCommandBuilder(daCustomers);
            daCustomers.Fill(ds, "Cars");
            _bindscr.DataSource = ds.Tables["Cars"];
            dataGridView1.DataSource = _bindscr;
            SPA115013.Close();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }


    }
    }

