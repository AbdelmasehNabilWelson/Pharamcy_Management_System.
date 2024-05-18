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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharamcyDataSet.drugsIdAndName' table. You can move, or remove it, as needed.
            this.drugsIdAndNameTableAdapter.Fill(this.pharamcyDataSet.drugsIdAndName);
            // TODO: This line of code loads data into the 'pharamcyDataSet.UserDrugSales' table. You can move, or remove it, as needed.
            this.userDrugSalesTableAdapter.Fill(this.pharamcyDataSet.UserDrugSales);

        }
    }
}
