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
        private static LoginForm instance;
        public static LoginForm GetInstance()
        {
            if (instance == null)
            {
                instance = new LoginForm();
            }
            return instance;
        }

        public LoginForm()
        {
            InitializeComponent();

        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = this.username.Text;
            string password = this.password.Text;

            AccountController accountController = AccountController.GetInstance();

            if (accountController.VerifyAccount(username, password))
            {
                Map map = Map.GetInstance();
                map.Show();
                Hide();
            }
            else
            {
                incorrectCredentials.Visible = true;
            }
        }

        private void signUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUp = SignUpForm.GetInstance();
            signUp.Show();
            Hide();
        }

    }
}
