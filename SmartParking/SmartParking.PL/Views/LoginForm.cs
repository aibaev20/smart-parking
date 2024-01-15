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
    public partial class LoginForm : Form
    {
        // Instance of the LoginForm
        private static LoginForm instance;
        // Instance of the AccountController to manage user accounts
        private static AccountController accountController = AccountController.GetInstance();

        // Method to get the single instance of the LoginForm
        public static LoginForm GetInstance()
        {
            if (instance == null)
            {
                instance = new LoginForm();
            }
            return instance;
        }

        // Constructor for the LoginForm
        public LoginForm()
        {
            InitializeComponent();

        }

        // Event handler for the exitButton Click event
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Event handler for the loginButton Click event
        private void loginButton_Click(object sender, EventArgs e)
        {
            // Get the entered username and password
            string username = this.username.Text;
            string password = this.password.Text;

            // Verify the account using the AccountController
            if (accountController.VerifyAccount(username, password))
            {
                // If account is verified, create and show the Map form
                Map map = Map.GetInstance(username);
                map.Show();
                Hide();
                
            }
            else
            {
                // If verification fails, show incorrect credentials label
                incorrectCredentials.Visible = true;
            }
        }

        // Event handler for the signUpLinkLabel LinkClicked event
        private void signUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Show the SignUpForm and hide the current LoginForm
            SignUpForm signUp = SignUpForm.GetInstance();
            signUp.Show();
            Hide();
        }

        // Event handler for the username Click event
        private void username_Click(object sender, EventArgs e)
        {
            // Clear the default "Username" text when clicked
            if (username.Text == "Username")
            { 
                username.Text = string.Empty;
            }
        }

        // Event handler for the username Leave event
        private void username_Leave(object sender, EventArgs e)
        {
            // Restore the default "Username" text if no input provided
            if (username.Text == string.Empty)
            {
                username.Text = "Username";
            }
        }

        // Event handler for the password Click event
        private void password_Click(object sender, EventArgs e)
        {
            // Clear the default "Password" text when clicked
            if (password.Text == "Password")
            {
                password.Text = string.Empty;
            }
        }

        // Event handler for the password Leave event
        private void password_Leave(object sender, EventArgs e)
        {
            // Restore the default "Password" text if no input provided
            if (password.Text == string.Empty) 
            {
                password.Text = "Password";
            }
        }
    }
}
