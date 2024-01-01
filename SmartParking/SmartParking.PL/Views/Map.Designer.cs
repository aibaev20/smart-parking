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
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 649);
            this.Controls.Add(this.burgasGMapControl);
            this.Name = "Map";
            this.Text = "App";
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl burgasGMapControl;
    }
}

