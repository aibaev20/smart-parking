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
            this.inputGroup.Location = new System.Drawing.Point(128, 200);
            this.inputGroup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.inputGroup.Name = "inputGroup";
            this.inputGroup.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.inputGroup.Size = new System.Drawing.Size(313, 162);
            this.inputGroup.TabIndex = 0;
            this.inputGroup.TabStop = false;
            this.inputGroup.Text = "Login";
            // 
            // passwordIcon
            // 
            this.passwordIcon.Image = global::SmartParking.PL.Properties.Resources._lock;
            this.passwordIcon.Location = new System.Drawing.Point(24, 109);
            this.passwordIcon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordIcon.Name = "passwordIcon";
            this.passwordIcon.Size = new System.Drawing.Size(28, 28);
            this.passwordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.passwordIcon.TabIndex = 4;
            this.passwordIcon.TabStop = false;
            // 
            // usernameIcon
            // 
            this.usernameIcon.Image = global::SmartParking.PL.Properties.Resources.user;
            this.usernameIcon.Location = new System.Drawing.Point(24, 58);
            this.usernameIcon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameIcon.Name = "usernameIcon";
            this.usernameIcon.Size = new System.Drawing.Size(28, 28);
            this.usernameIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.usernameIcon.TabIndex = 3;
            this.usernameIcon.TabStop = false;
            // 
            // password
            // 
            this.password.Cursor = System.Windows.Forms.Cursors.Default;
            this.password.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.password.ForeColor = System.Drawing.Color.DimGray;
            this.password.Location = new System.Drawing.Point(58, 109);
            this.password.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(229, 30);
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
            this.username.Location = new System.Drawing.Point(58, 58);
            this.username.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(229, 30);
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
            this.incorrectCredentials.Location = new System.Drawing.Point(158, 394);
            this.incorrectCredentials.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.incorrectCredentials.Name = "incorrectCredentials";
            this.incorrectCredentials.Size = new System.Drawing.Size(250, 32);
            this.incorrectCredentials.TabIndex = 1;
            this.incorrectCredentials.Text = "Incorrect credentials";
            this.incorrectCredentials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.incorrectCredentials.Visible = false;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(218, 458);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(129, 44);
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
            this.newAccountLabel.Location = new System.Drawing.Point(214, 568);
            this.newAccountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newAccountLabel.Name = "newAccountLabel";
            this.newAccountLabel.Size = new System.Drawing.Size(121, 23);
            this.newAccountLabel.TabIndex = 3;
            this.newAccountLabel.Text = "Only for users";
            // 
            // signUpLinkLabel
            // 
            this.signUpLinkLabel.ActiveLinkColor = System.Drawing.Color.MediumBlue;
            this.signUpLinkLabel.AutoSize = true;
            this.signUpLinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpLinkLabel.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLinkLabel.Location = new System.Drawing.Point(246, 533);
            this.signUpLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.signUpLinkLabel.Name = "signUpLinkLabel";
            this.signUpLinkLabel.Size = new System.Drawing.Size(72, 23);
            this.signUpLinkLabel.TabIndex = 4;
            this.signUpLinkLabel.TabStop = true;
            this.signUpLinkLabel.Text = "Sign up";
            this.signUpLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signUpLinkLabel_LinkClicked);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DarkRed;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(499, 10);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(49, 48);
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
            this.logo.Location = new System.Drawing.Point(74, 62);
            this.logo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(418, 102);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(559, 650);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.signUpLinkLabel);
            this.Controls.Add(this.newAccountLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.incorrectCredentials);
            this.Controls.Add(this.inputGroup);
            this.Controls.Add(this.logo);
            this.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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