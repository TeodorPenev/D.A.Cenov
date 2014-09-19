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
    public partial class MainForm : Form
    {
        public string connStringSPA = @"Data Source= ТHEONE\;Initial Catalog=SPA115013;Integrated Security = True";
        //string connServer = @"THEONE";
        //string connDB = "SPA115013";
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Изход от програмата?", "потвърждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) 
            e.Cancel = true;
        }

        private void машиниToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarsForm frmcars = new CarsForm(connStringSPA);
            frmcars.ShowDialog();
        }

        private void справкиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
