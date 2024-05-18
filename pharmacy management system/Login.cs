using pharmacy_management_system.PharamcyDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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



        private void Login_Button_Click(object sender, EventArgs e)
        {
            String username = this.UserName_Entry.Text;
            String password = this.Password_Entry.Text;

            if (username.Equals("") || password.Equals(""))
            {
                MessageBox.Show("Username and password should not be empty");
            }
            else
            {
                // Corrected connection string with escaped backslashes
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Pharamcy.mdf;Integrated Security=True"))
                {
                    connection.Open();

                    // Using parameterized query to prevent SQL injection
                    using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM users WHERE username = @Username AND password = @Password", connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        int result = Convert.ToInt32(command.ExecuteScalar());

                        if (result > 0)
                        {
                            //MessageBox.Show("Login successful.");
                            // Proceed with opening the next form or user interface
                            UserForm userForm = new UserForm();
                            this.Hide();

                            // assign close action to the userForm
                            userForm.FormClosed += (s, args) => this.Close();
                            userForm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Login failed. Please check your username and password.");
                        }
                    }
                }
            }
        }

    }
}
