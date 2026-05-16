using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserLoginApp.Models;

namespace UserLoginApp.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            User user = Program.userService.AuthenticateUser(
                usernameLoginBox.Text,
                passwordLoginBox.Text
            );

            if (user != null)
            {
                MessageBox.Show("Success");
                UserInfoForm userInfoForm = new UserInfoForm(user);

                userInfoForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide();
        }
    }
}
