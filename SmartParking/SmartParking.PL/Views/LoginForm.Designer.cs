using System.Windows.Forms;
using System.Drawing;

namespace SmartParking.PL.Views
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputGroup = new System.Windows.Forms.GroupBox();
            this.passwordIcon = new System.Windows.Forms.PictureBox();
            this.usernameIcon = new System.Windows.Forms.PictureBox();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.incorrectCredentials = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.newAccountLabel = new System.Windows.Forms.Label();
            this.signUpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.exitButton = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.inputGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // inputGroup
            // 
            this.inputGroup.Controls.Add(this.passwordIcon);
            this.inputGroup.Controls.Add(this.usernameIcon);
            this.inputGroup.Controls.Add(this.password);
            this.inputGroup.Controls.Add(this.username);
            this.inputGroup.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.inputGroup.ForeColor = System.Drawing.SystemColors.Highlight;
            this.inputGroup.Location = new System.Drawing.Point(103, 160);
            this.inputGroup.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.inputGroup.Name = "inputGroup";
            this.inputGroup.Padding = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.inputGroup.Size = new System.Drawing.Size(251, 129);
            this.inputGroup.TabIndex = 0;
            this.inputGroup.TabStop = false;
            this.inputGroup.Text = "Login";
            // 
            // passwordIcon
            // 
            this.passwordIcon.Image = global::SmartParking.PL.Properties.Resources._lock;
            this.passwordIcon.Location = new System.Drawing.Point(19, 87);
            this.passwordIcon.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.passwordIcon.Name = "passwordIcon";
            this.passwordIcon.Size = new System.Drawing.Size(23, 23);
            this.passwordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.passwordIcon.TabIndex = 4;
            this.passwordIcon.TabStop = false;
            // 
            // usernameIcon
            // 
            this.usernameIcon.Image = global::SmartParking.PL.Properties.Resources.user;
            this.usernameIcon.Location = new System.Drawing.Point(19, 47);
            this.usernameIcon.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.usernameIcon.Name = "usernameIcon";
            this.usernameIcon.Size = new System.Drawing.Size(23, 23);
            this.usernameIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.usernameIcon.TabIndex = 3;
            this.usernameIcon.TabStop = false;
            // 
            // password
            // 
            this.password.Cursor = System.Windows.Forms.Cursors.Default;
            this.password.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.password.ForeColor = System.Drawing.Color.DimGray;
            this.password.Location = new System.Drawing.Point(47, 87);
            this.password.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(184, 25);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            this.password.Click += new System.EventHandler(this.password_Click);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // username
            // 
            this.username.Cursor = System.Windows.Forms.Cursors.Default;
            this.username.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.username.ForeColor = System.Drawing.Color.DimGray;
            this.username.Location = new System.Drawing.Point(47, 47);
            this.username.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(184, 25);
            this.username.TabIndex = 1;
            this.username.Text = "Username";
            this.username.Click += new System.EventHandler(this.username_Click);
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // incorrectCredentials
            // 
            this.incorrectCredentials.AutoSize = true;
            this.incorrectCredentials.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectCredentials.ForeColor = System.Drawing.Color.Red;
            this.incorrectCredentials.Location = new System.Drawing.Point(133, 315);
            this.incorrectCredentials.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.incorrectCredentials.Name = "incorrectCredentials";
            this.incorrectCredentials.Size = new System.Drawing.Size(194, 25);
            this.incorrectCredentials.TabIndex = 1;
            this.incorrectCredentials.Text = "Incorrect credentials";
            this.incorrectCredentials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.incorrectCredentials.Visible = false;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(175, 367);
            this.loginButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(103, 35);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // newAccountLabel
            // 
            this.newAccountLabel.AutoSize = true;
            this.newAccountLabel.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAccountLabel.ForeColor = System.Drawing.Color.Black;
            this.newAccountLabel.Location = new System.Drawing.Point(177, 455);
            this.newAccountLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.newAccountLabel.Name = "newAccountLabel";
            this.newAccountLabel.Size = new System.Drawing.Size(102, 19);
            this.newAccountLabel.TabIndex = 3;
            this.newAccountLabel.Text = "Only for users";
            // 
            // signUpLinkLabel
            // 
            this.signUpLinkLabel.ActiveLinkColor = System.Drawing.Color.MediumBlue;
            this.signUpLinkLabel.AutoSize = true;
            this.signUpLinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpLinkLabel.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLinkLabel.Location = new System.Drawing.Point(199, 427);
            this.signUpLinkLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.signUpLinkLabel.Name = "signUpLinkLabel";
            this.signUpLinkLabel.Size = new System.Drawing.Size(59, 19);
            this.signUpLinkLabel.TabIndex = 4;
            this.signUpLinkLabel.TabStop = true;
            this.signUpLinkLabel.Text = "Sign up";
            this.signUpLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signUpLinkLabel_LinkClicked);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DarkRed;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(399, 8);
            this.exitButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(39, 39);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "X";
            this.exitButton.UseCompatibleTextRendering = true;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.White;
            this.logo.Image = global::SmartParking.PL.Properties.Resources.logo_w_white_bg;
            this.logo.Location = new System.Drawing.Point(59, 49);
            this.logo.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(335, 81);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(447, 520);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.signUpLinkLabel);
            this.Controls.Add(this.newAccountLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.incorrectCredentials);
            this.Controls.Add(this.inputGroup);
            this.Controls.Add(this.logo);
            this.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.inputGroup.ResumeLayout(false);
            this.inputGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox logo;
        private GroupBox inputGroup;
        private TextBox username;
        private TextBox password;
        private Label incorrectCredentials;
        private Button loginButton;
        private Label newAccountLabel;
        private LinkLabel signUpLinkLabel;
        private Button exitButton;
        private PictureBox usernameIcon;
        private PictureBox passwordIcon;
    }
}