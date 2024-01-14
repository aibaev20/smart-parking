using GMap.NET.WindowsForms;
using System;
using System.Windows.Forms;

namespace SmartParking.PL.Views
{
    partial class Map
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
            this.burgasGMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.infoContainer = new System.Windows.Forms.Panel();
            this.longitudeLabel = new System.Windows.Forms.Label();
            this.latitudeLabel = new System.Windows.Forms.Label();
            this.latitude = new System.Windows.Forms.Label();
            this.longitude = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.column1Label = new System.Windows.Forms.Label();
            this.column2Label = new System.Windows.Forms.Label();
            this.column3Label = new System.Windows.Forms.Label();
            this.column4Label = new System.Windows.Forms.Label();
            this.column1 = new System.Windows.Forms.Label();
            this.column2 = new System.Windows.Forms.Label();
            this.column3 = new System.Windows.Forms.Label();
            this.column4 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.infoContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // burgasGMapControl
            // 
            this.burgasGMapControl.Bearing = 0F;
            this.burgasGMapControl.CanDragMap = true;
            this.burgasGMapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.burgasGMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.burgasGMapControl.GrayScaleMode = false;
            this.burgasGMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.burgasGMapControl.LevelsKeepInMemory = 5;
            this.burgasGMapControl.Location = new System.Drawing.Point(0, 0);
            this.burgasGMapControl.Margin = new System.Windows.Forms.Padding(2);
            this.burgasGMapControl.MarkersEnabled = true;
            this.burgasGMapControl.MaxZoom = 2;
            this.burgasGMapControl.MinZoom = 2;
            this.burgasGMapControl.MouseWheelZoomEnabled = true;
            this.burgasGMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.burgasGMapControl.Name = "burgasGMapControl";
            this.burgasGMapControl.NegativeMode = false;
            this.burgasGMapControl.PolygonsEnabled = true;
            this.burgasGMapControl.RetryLoadTile = 0;
            this.burgasGMapControl.RoutesEnabled = true;
            this.burgasGMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.burgasGMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.burgasGMapControl.ShowTileGridLines = false;
            this.burgasGMapControl.Size = new System.Drawing.Size(1189, 649);
            this.burgasGMapControl.TabIndex = 0;
            this.burgasGMapControl.Zoom = 0D;
            this.burgasGMapControl.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.burgasGMapControl_OnMarkerClick);
            // 
            // infoContainer
            // 
            this.infoContainer.BackColor = System.Drawing.Color.LightSlateGray;
            this.infoContainer.Controls.Add(this.updateButton);
            this.infoContainer.Controls.Add(this.exitButton);
            this.infoContainer.Controls.Add(this.column4);
            this.infoContainer.Controls.Add(this.column3);
            this.infoContainer.Controls.Add(this.column2);
            this.infoContainer.Controls.Add(this.column1);
            this.infoContainer.Controls.Add(this.column4Label);
            this.infoContainer.Controls.Add(this.column3Label);
            this.infoContainer.Controls.Add(this.column2Label);
            this.infoContainer.Controls.Add(this.column1Label);
            this.infoContainer.Controls.Add(this.longitudeLabel);
            this.infoContainer.Controls.Add(this.latitudeLabel);
            this.infoContainer.Controls.Add(this.latitude);
            this.infoContainer.Controls.Add(this.longitude);
            this.infoContainer.Controls.Add(this.name);
            this.infoContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.infoContainer.Location = new System.Drawing.Point(776, 0);
            this.infoContainer.Name = "infoContainer";
            this.infoContainer.Size = new System.Drawing.Size(413, 649);
            this.infoContainer.TabIndex = 1;
            this.infoContainer.Visible = false;
            // 
            // longitudeLabel
            // 
            this.longitudeLabel.AutoSize = true;
            this.longitudeLabel.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.longitudeLabel.ForeColor = System.Drawing.Color.White;
            this.longitudeLabel.Location = new System.Drawing.Point(34, 326);
            this.longitudeLabel.Name = "longitudeLabel";
            this.longitudeLabel.Size = new System.Drawing.Size(105, 28);
            this.longitudeLabel.TabIndex = 7;
            this.longitudeLabel.Text = "Longitude:";
            // 
            // latitudeLabel
            // 
            this.latitudeLabel.AutoSize = true;
            this.latitudeLabel.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.latitudeLabel.ForeColor = System.Drawing.Color.White;
            this.latitudeLabel.Location = new System.Drawing.Point(34, 245);
            this.latitudeLabel.Name = "latitudeLabel";
            this.latitudeLabel.Size = new System.Drawing.Size(87, 28);
            this.latitudeLabel.TabIndex = 6;
            this.latitudeLabel.Text = "Latitude:";
            // 
            // latitude
            // 
            this.latitude.AutoSize = true;
            this.latitude.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.latitude.ForeColor = System.Drawing.Color.White;
            this.latitude.Location = new System.Drawing.Point(175, 245);
            this.latitude.Name = "latitude";
            this.latitude.Size = new System.Drawing.Size(79, 28);
            this.latitude.TabIndex = 5;
            this.latitude.Text = "latitude";
            // 
            // longitude
            // 
            this.longitude.AutoSize = true;
            this.longitude.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.longitude.ForeColor = System.Drawing.Color.White;
            this.longitude.Location = new System.Drawing.Point(175, 326);
            this.longitude.Name = "longitude";
            this.longitude.Size = new System.Drawing.Size(97, 28);
            this.longitude.TabIndex = 4;
            this.longitude.Text = "longitude";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(34, 150);
            this.name.MaximumSize = new System.Drawing.Size(300, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(70, 30);
            this.name.TabIndex = 0;
            this.name.Text = "name";
            // 
            // column1Label
            // 
            this.column1Label.AutoSize = true;
            this.column1Label.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.column1Label.ForeColor = System.Drawing.Color.White;
            this.column1Label.Location = new System.Drawing.Point(34, 407);
            this.column1Label.MaximumSize = new System.Drawing.Size(130, 0);
            this.column1Label.Name = "column1Label";
            this.column1Label.Size = new System.Drawing.Size(50, 28);
            this.column1Label.TabIndex = 8;
            this.column1Label.Text = "Info:";
            // 
            // column2Label
            // 
            this.column2Label.AutoSize = true;
            this.column2Label.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.column2Label.ForeColor = System.Drawing.Color.White;
            this.column2Label.Location = new System.Drawing.Point(34, 488);
            this.column2Label.MaximumSize = new System.Drawing.Size(130, 0);
            this.column2Label.Name = "column2Label";
            this.column2Label.Size = new System.Drawing.Size(50, 28);
            this.column2Label.TabIndex = 9;
            this.column2Label.Text = "Info:";
            // 
            // column3Label
            // 
            this.column3Label.AutoSize = true;
            this.column3Label.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.column3Label.ForeColor = System.Drawing.Color.White;
            this.column3Label.Location = new System.Drawing.Point(34, 569);
            this.column3Label.MaximumSize = new System.Drawing.Size(130, 0);
            this.column3Label.Name = "column3Label";
            this.column3Label.Size = new System.Drawing.Size(50, 28);
            this.column3Label.TabIndex = 10;
            this.column3Label.Text = "Info:";
            // 
            // column4Label
            // 
            this.column4Label.AutoSize = true;
            this.column4Label.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.column4Label.ForeColor = System.Drawing.Color.White;
            this.column4Label.Location = new System.Drawing.Point(34, 650);
            this.column4Label.MaximumSize = new System.Drawing.Size(130, 0);
            this.column4Label.Name = "column4Label";
            this.column4Label.Size = new System.Drawing.Size(50, 28);
            this.column4Label.TabIndex = 11;
            this.column4Label.Text = "Info:";
            // 
            // column1
            // 
            this.column1.AutoSize = true;
            this.column1.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.column1.ForeColor = System.Drawing.Color.White;
            this.column1.Location = new System.Drawing.Point(175, 407);
            this.column1.Name = "column1";
            this.column1.Size = new System.Drawing.Size(93, 28);
            this.column1.TabIndex = 12;
            this.column1.Text = "column 1";
            // 
            // column2
            // 
            this.column2.AutoSize = true;
            this.column2.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.column2.ForeColor = System.Drawing.Color.White;
            this.column2.Location = new System.Drawing.Point(175, 488);
            this.column2.Name = "column2";
            this.column2.Size = new System.Drawing.Size(93, 28);
            this.column2.TabIndex = 13;
            this.column2.Text = "column 2";
            // 
            // column3
            // 
            this.column3.AutoSize = true;
            this.column3.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.column3.ForeColor = System.Drawing.Color.White;
            this.column3.Location = new System.Drawing.Point(175, 569);
            this.column3.Name = "column3";
            this.column3.Size = new System.Drawing.Size(93, 28);
            this.column3.TabIndex = 14;
            this.column3.Text = "column 3";
            // 
            // column4
            // 
            this.column4.AutoSize = true;
            this.column4.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.column4.ForeColor = System.Drawing.Color.White;
            this.column4.Location = new System.Drawing.Point(175, 650);
            this.column4.Name = "column4";
            this.column4.Size = new System.Drawing.Size(93, 28);
            this.column4.TabIndex = 15;
            this.column4.Text = "column 4";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DarkRed;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(331, 24);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(59, 58);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "X";
            this.exitButton.UseCompatibleTextRendering = true;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.DarkGreen;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(34, 24);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(271, 58);
            this.updateButton.TabIndex = 17;
            this.updateButton.Text = "Update";
            this.updateButton.UseCompatibleTextRendering = true;
            this.updateButton.UseVisualStyleBackColor = false;
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1189, 649);
            this.Controls.Add(this.infoContainer);
            this.Controls.Add(this.burgasGMapControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Map";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App";
            this.infoContainer.ResumeLayout(false);
            this.infoContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl burgasGMapControl;
        private System.Windows.Forms.Panel infoContainer;
        private Label name;
        private Label longitude;
        private Label latitude;
        private Label latitudeLabel;
        private Label longitudeLabel;
        private Label column4;
        private Label column3;
        private Label column2;
        private Label column1;
        private Label column4Label;
        private Label column3Label;
        private Label column2Label;
        private Label column1Label;
        private Button updateButton;
        private Button exitButton;
    }
}

