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
    public partial class RoleSelection : Form
    {
        private static RoleSelection instance;
        public static RoleSelection GetInstance()
        {
            if (instance == null)
            {
                instance = new RoleSelection();
            }
            return instance;
        }
        public RoleSelection()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adminChoice_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = LoginForm.GetInstance();
            loginForm.Show();
            Hide();
        }

        private void userChoice_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = LoginForm.GetInstance();
            loginForm.Show();
            Hide();
        }
    }
}
