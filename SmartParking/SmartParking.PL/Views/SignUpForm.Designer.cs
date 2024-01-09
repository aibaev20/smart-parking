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
            this.keyIcon = new System.Windows.Forms.PictureBox();
            this.id = new System.Windows.Forms.TextBox();
            this.emailIcon = new System.Windows.Forms.PictureBox();
            this.email = new System.Windows.Forms.TextBox();
            this.passwordIcon = new System.Windows.Forms.PictureBox();
            this.usernameIcon = new System.Windows.Forms.PictureBox();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.signUpButton = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.inputGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyIcon)).BeginInit();
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
            this.exitButton.Location = new System.Drawing.Point(499, 10);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(49, 48);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "X";
            this.exitButton.UseCompatibleTextRendering = true;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // inputGroup
            // 
            this.inputGroup.Controls.Add(this.keyIcon);
            this.inputGroup.Controls.Add(this.id);
            this.inputGroup.Controls.Add(this.emailIcon);
            this.inputGroup.Controls.Add(this.email);
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
            this.inputGroup.Size = new System.Drawing.Size(313, 277);
            this.inputGroup.TabIndex = 9;
            this.inputGroup.TabStop = false;
            this.inputGroup.Text = "Sign Up";
            // 
            // keyIcon
            // 
            this.keyIcon.Image = global::SmartParking.PL.Properties.Resources.key;
            this.keyIcon.Location = new System.Drawing.Point(25, 59);
            this.keyIcon.Margin = new System.Windows.Forms.Padding(2);
            this.keyIcon.Name = "keyIcon";
            this.keyIcon.Size = new System.Drawing.Size(28, 28);
            this.keyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.keyIcon.TabIndex = 8;
            this.keyIcon.TabStop = false;
            // 
            // id
            // 
            this.id.Cursor = System.Windows.Forms.Cursors.Default;
            this.id.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.id.ForeColor = System.Drawing.Color.DimGray;
            this.id.Location = new System.Drawing.Point(59, 59);
            this.id.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(229, 30);
            this.id.TabIndex = 7;
            this.id.Text = "Id";
            this.id.Click += new System.EventHandler(this.id_Click);
            this.id.Leave += new System.EventHandler(this.id_Leave);
            // 
            // emailIcon
            // 
            this.emailIcon.Image = global::SmartParking.PL.Properties.Resources.at_sign;
            this.emailIcon.Location = new System.Drawing.Point(25, 112);
            this.emailIcon.Margin = new System.Windows.Forms.Padding(2);
            this.emailIcon.Name = "emailIcon";
            this.emailIcon.Size = new System.Drawing.Size(28, 28);
            this.emailIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.emailIcon.TabIndex = 6;
            this.emailIcon.TabStop = false;
            // 
            // email
            // 
            this.email.Cursor = System.Windows.Forms.Cursors.Default;
            this.email.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.email.ForeColor = System.Drawing.Color.DimGray;
            this.email.Location = new System.Drawing.Point(59, 112);
            this.email.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(229, 30);
            this.email.TabIndex = 5;
            this.email.Text = "Email";
            this.email.Click += new System.EventHandler(this.email_Click);
            this.email.Leave += new System.EventHandler(this.email_Leave);
            // 
            // passwordIcon
            // 
            this.passwordIcon.Image = global::SmartParking.PL.Properties.Resources._lock;
            this.passwordIcon.Location = new System.Drawing.Point(25, 219);
            this.passwordIcon.Margin = new System.Windows.Forms.Padding(2);
            this.passwordIcon.Name = "passwordIcon";
            this.passwordIcon.Size = new System.Drawing.Size(28, 28);
            this.passwordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.passwordIcon.TabIndex = 4;
            this.passwordIcon.TabStop = false;
            // 
            // usernameIcon
            // 
            this.usernameIcon.Image = global::SmartParking.PL.Properties.Resources.user;
            this.usernameIcon.Location = new System.Drawing.Point(25, 167);
            this.usernameIcon.Margin = new System.Windows.Forms.Padding(2);
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
            this.password.Location = new System.Drawing.Point(59, 219);
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
            this.username.Location = new System.Drawing.Point(59, 167);
            this.username.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(229, 30);
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
            this.signUpButton.Location = new System.Drawing.Point(208, 537);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(2);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(149, 44);
            this.signUpButton.TabIndex = 10;
            this.signUpButton.Text = "SIGN UP";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
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
            this.logo.TabIndex = 8;
            this.logo.TabStop = false;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(559, 650);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.inputGroup);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.exitButton);
            this.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.inputGroup.ResumeLayout(false);
            this.inputGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.PictureBox keyIcon;
    }
}