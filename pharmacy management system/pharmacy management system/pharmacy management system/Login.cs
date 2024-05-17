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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Button_Click(object sender, EventArgs e)
        {
            Registration form = new Registration();
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }

        private void Visable_Button_Click(object sender, EventArgs e)
        {
            if (Password_Entry.PasswordChar == '*')
                Password_Entry.PasswordChar = '\0';
            else
                Password_Entry.PasswordChar = '*';
        }
    }
}
