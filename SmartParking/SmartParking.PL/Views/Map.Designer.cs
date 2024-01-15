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
            this.column4TextBox = new System.Windows.Forms.TextBox();
            this.column3TextBox = new System.Windows.Forms.TextBox();
            this.column2TextBox = new System.Windows.Forms.TextBox();
            this.column1TextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.column4Label = new System.Windows.Forms.Label();
            this.column3Label = new System.Windows.Forms.Label();
            this.column2Label = new System.Windows.Forms.Label();
            this.column1Label = new System.Windows.Forms.Label();
            this.longitudeLabel = new System.Windows.Forms.Label();
            this.latitudeLabel = new System.Windows.Forms.Label();
            this.latitude = new System.Windows.Forms.Label();
            this.longitude = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
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
            this.burgasGMapControl.Margin = new System.Windows.Forms.Padding(1);
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
            this.burgasGMapControl.Size = new System.Drawing.Size(793, 433);
            this.burgasGMapControl.TabIndex = 0;
            this.burgasGMapControl.Zoom = 0D;
            this.burgasGMapControl.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.burgasGMapControl_OnMarkerClick);
            this.burgasGMapControl.Load += new System.EventHandler(this.burgasGMapControl_Load);
            // 
            // infoContainer
            // 
            this.infoContainer.BackColor = System.Drawing.Color.LightSlateGray;
            this.infoContainer.Controls.Add(this.column4TextBox);
            this.infoContainer.Controls.Add(this.column3TextBox);
            this.infoContainer.Controls.Add(this.column2TextBox);
            this.infoContainer.Controls.Add(this.column1TextBox);
            this.infoContainer.Controls.Add(this.updateButton);
            this.infoContainer.Controls.Add(this.exitButton);
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
            this.infoContainer.Location = new System.Drawing.Point(518, 0);
            this.infoContainer.Margin = new System.Windows.Forms.Padding(2);
            this.infoContainer.Name = "infoContainer";
            this.infoContainer.Size = new System.Drawing.Size(275, 433);
            this.infoContainer.TabIndex = 1;
            this.infoContainer.Visible = false;
            // 
            // column4TextBox
            // 
            this.column4TextBox.Enabled = false;
            this.column4TextBox.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.column4TextBox.Location = new System.Drawing.Point(117, 433);
            this.column4TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.column4TextBox.Name = "column4TextBox";
            this.column4TextBox.Size = new System.Drawing.Size(68, 25);
            this.column4TextBox.TabIndex = 21;
            this.column4TextBox.Text = "Column 4";
            // 
            // column3TextBox
            // 
            this.column3TextBox.Enabled = false;
            this.column3TextBox.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.column3TextBox.Location = new System.Drawing.Point(117, 379);
            this.column3TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.column3TextBox.Name = "column3TextBox";
            this.column3TextBox.Size = new System.Drawing.Size(68, 25);
            this.column3TextBox.TabIndex = 20;
            this.column3TextBox.Text = "Column 3";
            // 
            // column2TextBox
            // 
            this.column2TextBox.Enabled = false;
            this.column2TextBox.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.column2TextBox.Location = new System.Drawing.Point(117, 325);
            this.column2TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.column2TextBox.Name = "column2TextBox";
            this.column2TextBox.Size = new System.Drawing.Size(68, 25);
            this.column2TextBox.TabIndex = 19;
            this.column2TextBox.Text = "Column 2";
            // 
            // column1TextBox
            // 
            this.column1TextBox.Enabled = false;
            this.column1TextBox.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.column1TextBox.Location = new System.Drawing.Point(117, 271);
            this.column1TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.column1TextBox.Multiline = true;
            this.column1TextBox.Name = "column1TextBox";
            this.column1TextBox.Size = new System.Drawing.Size(68, 19);
            this.column1TextBox.TabIndex = 18;
            this.column1TextBox.Text = "Column 1";
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.DarkGreen;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(23, 16);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(181, 39);
            this.updateButton.TabIndex = 17;
            this.updateButton.Text = "Update";
            this.updateButton.UseCompatibleTextRendering = true;
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DarkRed;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(221, 16);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(39, 39);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "X";
            this.exitButton.UseCompatibleTextRendering = true;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // column4Label
            // 
            this.column4Label.AutoSize = true;
            this.column4Label.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.column4Label.ForeColor = System.Drawing.Color.White;
            this.column4Label.Location = new System.Drawing.Point(23, 433);
            this.column4Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.column4Label.MaximumSize = new System.Drawing.Size(87, 0);
            this.column4Label.Name = "column4Label";
            this.column4Label.Size = new System.Drawing.Size(36, 19);
            this.column4Label.TabIndex = 11;
            this.column4Label.Text = "Info:";
            // 
            // column3Label
            // 
            this.column3Label.AutoSize = true;
            this.column3Label.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.column3Label.ForeColor = System.Drawing.Color.White;
            this.column3Label.Location = new System.Drawing.Point(23, 379);
            this.column3Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.column3Label.MaximumSize = new System.Drawing.Size(87, 0);
            this.column3Label.Name = "column3Label";
            this.column3Label.Size = new System.Drawing.Size(36, 19);
            this.column3Label.TabIndex = 10;
            this.column3Label.Text = "Info:";
            // 
            // column2Label
            // 
            this.column2Label.AutoSize = true;
            this.column2Label.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.column2Label.ForeColor = System.Drawing.Color.White;
            this.column2Label.Location = new System.Drawing.Point(23, 325);
            this.column2Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.column2Label.MaximumSize = new System.Drawing.Size(87, 0);
            this.column2Label.Name = "column2Label";
            this.column2Label.Size = new System.Drawing.Size(36, 19);
            this.column2Label.TabIndex = 9;
            this.column2Label.Text = "Info:";
            // 
            // column1Label
            // 
            this.column1Label.AutoSize = true;
            this.column1Label.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.column1Label.ForeColor = System.Drawing.Color.White;
            this.column1Label.Location = new System.Drawing.Point(23, 271);
            this.column1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.column1Label.MaximumSize = new System.Drawing.Size(87, 0);
            this.column1Label.Name = "column1Label";
            this.column1Label.Size = new System.Drawing.Size(36, 19);
            this.column1Label.TabIndex = 8;
            this.column1Label.Text = "Info:";
            // 
            // longitudeLabel
            // 
            this.longitudeLabel.AutoSize = true;
            this.longitudeLabel.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.longitudeLabel.ForeColor = System.Drawing.Color.White;
            this.longitudeLabel.Location = new System.Drawing.Point(23, 217);
            this.longitudeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.longitudeLabel.Name = "longitudeLabel";
            this.longitudeLabel.Size = new System.Drawing.Size(74, 19);
            this.longitudeLabel.TabIndex = 7;
            this.longitudeLabel.Text = "Longitude:";
            // 
            // latitudeLabel
            // 
            this.latitudeLabel.AutoSize = true;
            this.latitudeLabel.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.latitudeLabel.ForeColor = System.Drawing.Color.White;
            this.latitudeLabel.Location = new System.Drawing.Point(23, 163);
            this.latitudeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.latitudeLabel.Name = "latitudeLabel";
            this.latitudeLabel.Size = new System.Drawing.Size(62, 19);
            this.latitudeLabel.TabIndex = 6;
            this.latitudeLabel.Text = "Latitude:";
            // 
            // latitude
            // 
            this.latitude.AutoSize = true;
            this.latitude.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.latitude.ForeColor = System.Drawing.Color.White;
            this.latitude.Location = new System.Drawing.Point(117, 163);
            this.latitude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.latitude.Name = "latitude";
            this.latitude.Size = new System.Drawing.Size(55, 19);
            this.latitude.TabIndex = 5;
            this.latitude.Text = "latitude";
            // 
            // longitude
            // 
            this.longitude.AutoSize = true;
            this.longitude.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.longitude.ForeColor = System.Drawing.Color.White;
            this.longitude.Location = new System.Drawing.Point(117, 217);
            this.longitude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.longitude.Name = "longitude";
            this.longitude.Size = new System.Drawing.Size(67, 19);
            this.longitude.TabIndex = 4;
            this.longitude.Text = "longitude";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(23, 100);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.MaximumSize = new System.Drawing.Size(200, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(48, 20);
            this.name.TabIndex = 0;
            this.name.Text = "name";
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(793, 433);
            this.Controls.Add(this.infoContainer);
            this.Controls.Add(this.burgasGMapControl);
            this.Margin = new System.Windows.Forms.Padding(1);
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
        private Label column4Label;
        private Label column3Label;
        private Label column2Label;
        private Label column1Label;
        private Button updateButton;
        private Button exitButton;
        private TextBox column1TextBox;
        private TextBox column4TextBox;
        private TextBox column3TextBox;
        private TextBox column2TextBox;
    }
}

