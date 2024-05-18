using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy_management_system
{
    public partial class Admin_Panel : Form
    {
        public Admin_Panel()
        {
            InitializeComponent();
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {

        }

        private void Add_Button_Click(object sender, EventArgs e)
        {

        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharamcyDataSet);

        }

        private void Admin_Panel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharamcyDataSet.drugs' table. You can move, or remove it, as needed.
            this.drugsTableAdapter.Fill(this.pharamcyDataSet.drugs);
            // TODO: This line of code loads data into the 'pharamcyDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.pharamcyDataSet.users);

        }

        private void usersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
