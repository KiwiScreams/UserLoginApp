using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserLoginApp.Services;
using UserLoginApp.Models;

namespace UserLoginApp.Forms
{
    public partial class RegistrationForm : Form
    {

        public RegistrationForm()
        {
            InitializeComponent();
        }
        private void registerButton_Click(object sender, EventArgs e)
        {
            bool success = Program.userService.RegisterUser(
                fnameBox.Text,
                lnameBox.Text,
                usernameBox.Text,
                emailBox.Text,
                phoneBox.Text,
                passwordBox.Text
            );

            if (success)
            {
                MessageBox.Show("Account created");
                LoginForm loginForm = new LoginForm();

                loginForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid data or user already exists");
            }
        }

        private void GoLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
