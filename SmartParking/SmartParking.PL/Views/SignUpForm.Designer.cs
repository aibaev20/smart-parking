namespace SmartParking.PL.Views
{
    partial class SignUpForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.inputGroup = new System.Windows.Forms.GroupBox();
            this.emailIcon = new System.Windows.Forms.PictureBox();
            this.email = new System.Windows.Forms.TextBox();
            this.passwordIcon = new System.Windows.Forms.PictureBox();
            this.usernameIcon = new System.Windows.Forms.PictureBox();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.signUpButton = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.incorrectEmailOrUsername = new System.Windows.Forms.Label();
            this.backToLoginButton = new System.Windows.Forms.Button();
            this.inputGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
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
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "X";
            this.exitButton.UseCompatibleTextRendering = true;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // inputGroup
            // 
            this.inputGroup.Controls.Add(this.emailIcon);
            this.inputGroup.Controls.Add(this.email);
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
            this.inputGroup.Size = new System.Drawing.Size(251, 181);
            this.inputGroup.TabIndex = 9;
            this.inputGroup.TabStop = false;
            this.inputGroup.Text = "Sign Up";
            // 
            // emailIcon
            // 
            this.emailIcon.Image = global::SmartParking.PL.Properties.Resources.at_sign;
            this.emailIcon.Location = new System.Drawing.Point(19, 47);
            this.emailIcon.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.emailIcon.Name = "emailIcon";
            this.emailIcon.Size = new System.Drawing.Size(23, 23);
            this.emailIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.emailIcon.TabIndex = 6;
            this.emailIcon.TabStop = false;
            // 
            // email
            // 
            this.email.Cursor = System.Windows.Forms.Cursors.Default;
            this.email.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.email.ForeColor = System.Drawing.Color.DimGray;
            this.email.Location = new System.Drawing.Point(47, 47);
            this.email.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(184, 25);
            this.email.TabIndex = 5;
            this.email.Text = "Email";
            this.email.Click += new System.EventHandler(this.email_Click);
            this.email.Leave += new System.EventHandler(this.email_Leave);
            // 
            // passwordIcon
            // 
            this.passwordIcon.Image = global::SmartParking.PL.Properties.Resources._lock;
            this.passwordIcon.Location = new System.Drawing.Point(19, 133);
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
            this.usernameIcon.Location = new System.Drawing.Point(19, 91);
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
            this.password.Location = new System.Drawing.Point(47, 133);
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
            this.username.Location = new System.Drawing.Point(47, 91);
            this.username.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(184, 25);
            this.username.TabIndex = 1;
            this.username.Text = "Username";
            this.username.Click += new System.EventHandler(this.username_Click);
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.signUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.ForeColor = System.Drawing.Color.White;
            this.signUpButton.Location = new System.Drawing.Point(167, 420);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(119, 35);
            this.signUpButton.TabIndex = 10;
            this.signUpButton.Text = "SIGN UP";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
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
            this.logo.TabIndex = 8;
            this.logo.TabStop = false;
            // 
            // incorrectEmailOrUsername
            // 
            this.incorrectEmailOrUsername.AutoSize = true;
            this.incorrectEmailOrUsername.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectEmailOrUsername.ForeColor = System.Drawing.Color.Red;
            this.incorrectEmailOrUsername.Location = new System.Drawing.Point(83, 367);
            this.incorrectEmailOrUsername.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.incorrectEmailOrUsername.Name = "incorrectEmailOrUsername";
            this.incorrectEmailOrUsername.Size = new System.Drawing.Size(293, 25);
            this.incorrectEmailOrUsername.TabIndex = 11;
            this.incorrectEmailOrUsername.Text = "Email or username already used";
            this.incorrectEmailOrUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.incorrectEmailOrUsername.Visible = false;
            // 
            // backToLoginButton
            // 
            this.backToLoginButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.backToLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToLoginButton.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.backToLoginButton.ForeColor = System.Drawing.Color.White;
            this.backToLoginButton.Location = new System.Drawing.Point(350, 8);
            this.backToLoginButton.Margin = new System.Windows.Forms.Padding(1);
            this.backToLoginButton.Name = "backToLoginButton";
            this.backToLoginButton.Size = new System.Drawing.Size(39, 39);
            this.backToLoginButton.TabIndex = 12;
            this.backToLoginButton.Text = "<";
            this.backToLoginButton.UseCompatibleTextRendering = true;
            this.backToLoginButton.UseVisualStyleBackColor = false;
            this.backToLoginButton.Click += new System.EventHandler(this.backToLoginButton_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(447, 520);
            this.Controls.Add(this.backToLoginButton);
            this.Controls.Add(this.incorrectEmailOrUsername);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.inputGroup);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.exitButton);
            this.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.inputGroup.ResumeLayout(false);
            this.inputGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.GroupBox inputGroup;
        private System.Windows.Forms.PictureBox emailIcon;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.PictureBox passwordIcon;
        private System.Windows.Forms.PictureBox usernameIcon;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Label incorrectEmailOrUsername;
        private System.Windows.Forms.Button backToLoginButton;
    }
}