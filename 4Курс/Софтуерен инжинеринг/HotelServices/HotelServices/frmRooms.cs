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
    public partial class frmRooms : Form
    {
        public frmRooms()
        {
            InitializeComponent();
        }

        private void roomsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roomsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

        private void frmRooms_Load(object sender, EventArgs e)
        {
            // Този реф зарежда данните в ds.Rooms. Можем да местим и изтриваме.
            this.roomsTableAdapter.Fill(this.ds.Rooms);

        }
    }
}
