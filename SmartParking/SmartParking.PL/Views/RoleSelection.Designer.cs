using System.Windows.Forms;

namespace SmartParking.PL.Views
{
    partial class RoleSelection
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
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(399, 8);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(39, 39);
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
            this.logo.Location = new System.Drawing.Point(59, 50);
            this.logo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(335, 82);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 7;
            this.logo.TabStop = false;
            // 
            // adminChoice
            // 
            this.adminChoice.BackColor = System.Drawing.SystemColors.Highlight;
            this.adminChoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminChoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminChoice.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.adminChoice.ForeColor = System.Drawing.Color.White;
            this.adminChoice.Location = new System.Drawing.Point(138, 249);
            this.adminChoice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adminChoice.Name = "adminChoice";
            this.adminChoice.Size = new System.Drawing.Size(168, 67);
            this.adminChoice.TabIndex = 8;
            this.adminChoice.Text = "Admin";
            this.adminChoice.UseVisualStyleBackColor = false;
            this.adminChoice.Click += new System.EventHandler(this.adminChoice_Click);
            // 
            // userChoice
            // 
            this.userChoice.BackColor = System.Drawing.SystemColors.Highlight;
            this.userChoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userChoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userChoice.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.userChoice.ForeColor = System.Drawing.Color.White;
            this.userChoice.Location = new System.Drawing.Point(138, 365);
            this.userChoice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userChoice.Name = "userChoice";
            this.userChoice.Size = new System.Drawing.Size(168, 67);
            this.userChoice.TabIndex = 9;
            this.userChoice.Text = "User";
            this.userChoice.UseVisualStyleBackColor = false;
            this.userChoice.Click += new System.EventHandler(this.userChoice_Click);
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Nirmala UI", 18F);
            this.roleLabel.Location = new System.Drawing.Point(151, 173);
            this.roleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(147, 32);
            this.roleLabel.TabIndex = 10;
            this.roleLabel.Text = "Choose Role";
            this.roleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoleSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(447, 520);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.userChoice);
            this.Controls.Add(this.adminChoice);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.exitButton);
            this.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "RoleSelection";
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