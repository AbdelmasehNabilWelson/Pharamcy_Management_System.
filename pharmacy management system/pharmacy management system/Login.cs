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
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Pharamcy.mdf;Integrated Security=True"))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT admin FROM users WHERE username = @Username AND password = @Password", connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            bool isAdmin = (bool)result;
                            this.Hide();

                            if (isAdmin)
                            {
                                // Open the admin panel
                                Admin_Panel adminPanel = new Admin_Panel();
                                adminPanel.FormClosed += (s, args) => this.Close();
                                adminPanel.ShowDialog();
                            }
                            else
                            {
                                // Open the user form
                                UserForm userForm = new UserForm();
                                userForm.FormClosed += (s, args) => this.Close();
                                userForm.ShowDialog();
                            }
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
