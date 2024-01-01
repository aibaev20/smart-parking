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
            this.logo = new System.Windows.Forms.PictureBox();
            this.inputGroup = new System.Windows.Forms.GroupBox();
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.incorrectCredentials = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.newAccountLabel = new System.Windows.Forms.Label();
            this.signUpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.inputGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.White;
            this.logo.Image = global::SmartParking.PL.Properties.Resources.logo_w_white_bg;
            this.logo.Location = new System.Drawing.Point(89, 75);
            this.logo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(502, 123);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // inputGroup
            // 
            this.inputGroup.Controls.Add(this.password);
            this.inputGroup.Controls.Add(this.email);
            this.inputGroup.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.inputGroup.ForeColor = System.Drawing.SystemColors.Highlight;
            this.inputGroup.Location = new System.Drawing.Point(153, 240);
            this.inputGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputGroup.Name = "inputGroup";
            this.inputGroup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputGroup.Size = new System.Drawing.Size(376, 194);
            this.inputGroup.TabIndex = 0;
            this.inputGroup.TabStop = false;
            this.inputGroup.Text = "Login";
            // 
            // password
            // 
            this.password.Cursor = System.Windows.Forms.Cursors.Default;
            this.password.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.password.ForeColor = System.Drawing.Color.DimGray;
            this.password.Location = new System.Drawing.Point(43, 131);
            this.password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(300, 34);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            // 
            // email
            // 
            this.email.Cursor = System.Windows.Forms.Cursors.Default;
            this.email.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.email.ForeColor = System.Drawing.Color.DimGray;
            this.email.Location = new System.Drawing.Point(43, 69);
            this.email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(300, 34);
            this.email.TabIndex = 1;
            this.email.Text = "E-mail";
            // 
            // incorrectCredentials
            // 
            this.incorrectCredentials.AutoSize = true;
            this.incorrectCredentials.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectCredentials.ForeColor = System.Drawing.Color.Red;
            this.incorrectCredentials.Location = new System.Drawing.Point(189, 473);
            this.incorrectCredentials.Name = "incorrectCredentials";
            this.incorrectCredentials.Size = new System.Drawing.Size(284, 38);
            this.incorrectCredentials.TabIndex = 1;
            this.incorrectCredentials.Text = "Incorrect credentials";
            this.incorrectCredentials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(262, 549);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(155, 53);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false;
            // 
            // newAccountLabel
            // 
            this.newAccountLabel.AutoSize = true;
            this.newAccountLabel.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAccountLabel.ForeColor = System.Drawing.Color.Black;
            this.newAccountLabel.Location = new System.Drawing.Point(257, 681);
            this.newAccountLabel.Name = "newAccountLabel";
            this.newAccountLabel.Size = new System.Drawing.Size(145, 28);
            this.newAccountLabel.TabIndex = 3;
            this.newAccountLabel.Text = "Only for users";
            // 
            // signUpLinkLabel
            // 
            this.signUpLinkLabel.ActiveLinkColor = System.Drawing.Color.MediumBlue;
            this.signUpLinkLabel.AutoSize = true;
            this.signUpLinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpLinkLabel.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLinkLabel.Location = new System.Drawing.Point(295, 640);
            this.signUpLinkLabel.Name = "signUpLinkLabel";
            this.signUpLinkLabel.Size = new System.Drawing.Size(83, 28);
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
            this.exitButton.Location = new System.Drawing.Point(599, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(59, 58);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "X";
            this.exitButton.UseCompatibleTextRendering = true;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(671, 780);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.signUpLinkLabel);
            this.Controls.Add(this.newAccountLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.incorrectCredentials);
            this.Controls.Add(this.inputGroup);
            this.Controls.Add(this.logo);
            this.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.inputGroup.ResumeLayout(false);
            this.inputGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox logo;
        private GroupBox inputGroup;
        private TextBox email;
        private TextBox password;
        private Label incorrectCredentials;
        private Button loginButton;
        private Label newAccountLabel;
        private LinkLabel signUpLinkLabel;
        private Button exitButton;
    }
}