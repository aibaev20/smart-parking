using System.Windows.Forms;

namespace SmartParking.PL.Views
{
    partial class ChooseRole
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
            this.logo = new System.Windows.Forms.PictureBox();
            this.adminChoice = new System.Windows.Forms.Button();
            this.userChoice = new System.Windows.Forms.Button();
            this.roleLabel = new System.Windows.Forms.Label();
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
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(59, 58);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "X";
            this.exitButton.UseCompatibleTextRendering = true;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
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
            this.logo.TabIndex = 7;
            this.logo.TabStop = false;
            // 
            // adminChoice
            // 
            this.adminChoice.BackColor = System.Drawing.SystemColors.Highlight;
            this.adminChoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminChoice.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.adminChoice.ForeColor = System.Drawing.Color.White;
            this.adminChoice.Location = new System.Drawing.Point(207, 373);
            this.adminChoice.Name = "adminChoice";
            this.adminChoice.Size = new System.Drawing.Size(252, 100);
            this.adminChoice.TabIndex = 8;
            this.adminChoice.Text = "Admin";
            this.adminChoice.UseVisualStyleBackColor = false;
            this.adminChoice.Click += new System.EventHandler(this.adminChoice_Click);
            // 
            // userChoice
            // 
            this.userChoice.BackColor = System.Drawing.SystemColors.Highlight;
            this.userChoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userChoice.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.userChoice.ForeColor = System.Drawing.Color.White;
            this.userChoice.Location = new System.Drawing.Point(207, 547);
            this.userChoice.Name = "userChoice";
            this.userChoice.Size = new System.Drawing.Size(252, 100);
            this.userChoice.TabIndex = 9;
            this.userChoice.Text = "User";
            this.userChoice.UseVisualStyleBackColor = false;
            this.userChoice.Click += new System.EventHandler(this.userChoice_Click);
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Nirmala UI", 18F);
            this.roleLabel.Location = new System.Drawing.Point(226, 260);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(218, 48);
            this.roleLabel.TabIndex = 10;
            this.roleLabel.Text = "Choose Role";
            this.roleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChooseRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(671, 780);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.userChoice);
            this.Controls.Add(this.adminChoice);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.exitButton);
            this.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ChooseRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Role";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox logo;
        private Button adminChoice;
        private Button userChoice;
        private Label roleLabel;
    }
}