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

        private void signUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Map map = Map.GetInstance();
            map.Show();
            Hide();
        }
    }
}
