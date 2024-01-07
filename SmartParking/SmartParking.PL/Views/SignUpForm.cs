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
    }
}
