using SmartParking.PL.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartParking.PL.Views
{
    public partial class SignUpForm : Form
    {
        private static SignUpForm instance;
        public static SignUpForm GetInstance()
        {
            if (instance == null)
            {
                instance = new SignUpForm();
            }
            return instance;
        }

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string username = this.username.Text;
            string password = this.password.Text;
            string email = this.email.Text;

            AccountController accountController = AccountController.GetInstance();

            if (accountController.IsAccountAlreadyRegistered(email, username))
            {
                incorrectEmailOrUsername.Visible = true;
                return;
            }

            accountController.AddAccount(username, email, password);

            LoginForm loginForm = LoginForm.GetInstance();
            loginForm.Show();
            Hide();
        }

        private void email_Click(object sender, EventArgs e)
        {
            if (email.Text == "Email")
            {
                email.Text = string.Empty;
            }
        }

        private void email_Leave(object sender, EventArgs e)
        {
            if (email.Text == string.Empty)
            {
                email.Text = "Email";
            }
        }

        private void username_Click(object sender, EventArgs e)
        {
            if (username.Text == "Username")
            {
                username.Text = string.Empty;
            }
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == string.Empty)
            {
                username.Text = "Username";
            }
        }

        private void password_Click(object sender, EventArgs e)
        {
            if (password.Text == "Password")
            {
                password.Text = string.Empty;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == string.Empty)
            {
                password.Text = "Password";
            }
        }
    }
}
