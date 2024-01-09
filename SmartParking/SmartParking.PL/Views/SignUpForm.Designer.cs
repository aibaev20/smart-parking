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
            this.incorrectEmail = new System.Windows.Forms.Label();
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
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(599, 12);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(59, 58);
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
            this.inputGroup.Location = new System.Drawing.Point(154, 240);
            this.inputGroup.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.inputGroup.Name = "inputGroup";
            this.inputGroup.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.inputGroup.Size = new System.Drawing.Size(376, 271);
            this.inputGroup.TabIndex = 9;
            this.inputGroup.TabStop = false;
            this.inputGroup.Text = "Sign Up";
            // 
            // emailIcon
            // 
            this.emailIcon.Image = global::SmartParking.PL.Properties.Resources.at_sign;
            this.emailIcon.Location = new System.Drawing.Point(29, 70);
            this.emailIcon.Margin = new System.Windows.Forms.Padding(2);
            this.emailIcon.Name = "emailIcon";
            this.emailIcon.Size = new System.Drawing.Size(34, 34);
            this.emailIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.emailIcon.TabIndex = 6;
            this.emailIcon.TabStop = false;
            // 
            // email
            // 
            this.email.Cursor = System.Windows.Forms.Cursors.Default;
            this.email.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.email.ForeColor = System.Drawing.Color.DimGray;
            this.email.Location = new System.Drawing.Point(70, 70);
            this.email.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(274, 34);
            this.email.TabIndex = 5;
            this.email.Text = "Email";
            this.email.Click += new System.EventHandler(this.email_Click);
            this.email.Leave += new System.EventHandler(this.email_Leave);
            // 
            // passwordIcon
            // 
            this.passwordIcon.Image = global::SmartParking.PL.Properties.Resources._lock;
            this.passwordIcon.Location = new System.Drawing.Point(29, 199);
            this.passwordIcon.Margin = new System.Windows.Forms.Padding(2);
            this.passwordIcon.Name = "passwordIcon";
            this.passwordIcon.Size = new System.Drawing.Size(34, 34);
            this.passwordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.passwordIcon.TabIndex = 4;
            this.passwordIcon.TabStop = false;
            // 
            // usernameIcon
            // 
            this.usernameIcon.Image = global::SmartParking.PL.Properties.Resources.user;
            this.usernameIcon.Location = new System.Drawing.Point(29, 136);
            this.usernameIcon.Margin = new System.Windows.Forms.Padding(2);
            this.usernameIcon.Name = "usernameIcon";
            this.usernameIcon.Size = new System.Drawing.Size(34, 34);
            this.usernameIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.usernameIcon.TabIndex = 3;
            this.usernameIcon.TabStop = false;
            // 
            // password
            // 
            this.password.Cursor = System.Windows.Forms.Cursors.Default;
            this.password.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.password.ForeColor = System.Drawing.Color.DimGray;
            this.password.Location = new System.Drawing.Point(70, 199);
            this.password.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(274, 34);
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
            this.username.Location = new System.Drawing.Point(70, 136);
            this.username.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(274, 34);
            this.username.TabIndex = 1;
            this.username.Text = "Username";
            this.username.Click += new System.EventHandler(this.username_Click);
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.ForeColor = System.Drawing.Color.White;
            this.signUpButton.Location = new System.Drawing.Point(250, 660);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(2);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(179, 53);
            this.signUpButton.TabIndex = 10;
            this.signUpButton.Text = "SIGN UP";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.White;
            this.logo.Image = global::SmartParking.PL.Properties.Resources.logo_w_white_bg;
            this.logo.Location = new System.Drawing.Point(89, 74);
            this.logo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(502, 122);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 8;
            this.logo.TabStop = false;
            // 
            // incorrectEmail
            // 
            this.incorrectEmail.AutoSize = true;
            this.incorrectEmail.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectEmail.ForeColor = System.Drawing.Color.Red;
            this.incorrectEmail.Location = new System.Drawing.Point(195, 565);
            this.incorrectEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.incorrectEmail.Name = "incorrectEmail";
            this.incorrectEmail.Size = new System.Drawing.Size(290, 38);
            this.incorrectEmail.TabIndex = 11;
            this.incorrectEmail.Text = "Email is already used";
            this.incorrectEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.incorrectEmail.Visible = false;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(671, 780);
            this.Controls.Add(this.incorrectEmail);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.inputGroup);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.exitButton);
            this.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
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
        private System.Windows.Forms.Label incorrectEmail;
    }
}