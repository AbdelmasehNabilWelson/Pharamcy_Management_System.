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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void LoginForm_Button_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {
            UserForm form = new UserForm();
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }

        private void Password_Entry_TextChanged(object sender, EventArgs e)
        {

        }

        private void Visable_Button_Click(object sender, EventArgs e)
        {
            if (Password_Entry.PasswordChar == '*' && ConfirmPassword_Entry.PasswordChar == '*')
            {
                Password_Entry.PasswordChar = '\0';
                ConfirmPassword_Entry.PasswordChar = '\0';
            }
            else
            {
                Password_Entry.PasswordChar = '*';
                ConfirmPassword_Entry.PasswordChar = '*';
            }
        }

        private void PhoneEmail_Entry_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
