
using System.Drawing;
using System.Windows.Forms;

namespace HeatmapApp
{
    partial class locationPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(locationPage));
            this.showHeatmap = new System.Windows.Forms.Button();
            this.abovepanel = new System.Windows.Forms.Panel();
            this.findLocationTitle = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rightpanel = new System.Windows.Forms.Panel();
            this.allCurrentLocButton = new System.Windows.Forms.Button();
            this.backHomeButton = new System.Windows.Forms.Button();
            this.currentLocationButton = new System.Windows.Forms.Button();
            this.userTrace = new System.Windows.Forms.Button();
            this.findLocation = new System.Windows.Forms.Button();
            this.UserIDTextBox = new System.Windows.Forms.TextBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.mapPictureBox2 = new System.Windows.Forms.PictureBox();
            this.findButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.userIDLabel = new System.Windows.Forms.Label();
            this.abovepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.rightpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // showHeatmap
            // 
            this.showHeatmap.Location = new System.Drawing.Point(10, 30);
            this.showHeatmap.Margin = new System.Windows.Forms.Padding(2);
            this.showHeatmap.Name = "showHeatmap";
            this.showHeatmap.Size = new System.Drawing.Size(111, 37);
            this.showHeatmap.TabIndex = 1;
            this.showHeatmap.Text = "Show Heatmap";
            this.showHeatmap.UseVisualStyleBackColor = true;
            this.showHeatmap.Click += new System.EventHandler(this.showHeatmap_Click);
            // 
            // abovepanel
            // 
            this.abovepanel.BackColor = System.Drawing.Color.SeaGreen;
            this.abovepanel.Controls.Add(this.findLocationTitle);
            this.abovepanel.Controls.Add(this.pictureBox2);
            this.abovepanel.Location = new System.Drawing.Point(-4, -1);
            this.abovepanel.Margin = new System.Windows.Forms.Padding(2);
            this.abovepanel.Name = "abovepanel";
            this.abovepanel.Size = new System.Drawing.Size(1538, 89);
            this.abovepanel.TabIndex = 2;
            // 
            // findLocationTitle
            // 
            this.findLocationTitle.AutoSize = true;
            this.findLocationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.findLocationTitle.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.findLocationTitle.Location = new System.Drawing.Point(712, 37);
            this.findLocationTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.findLocationTitle.Name = "findLocationTitle";
            this.findLocationTitle.Size = new System.Drawing.Size(211, 29);
            this.findLocationTitle.TabIndex = 1;
            this.findLocationTitle.Text = "FIND LOCATION";
            this.findLocationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // rightpanel
            // 
            this.rightpanel.BackColor = System.Drawing.Color.SeaGreen;
            this.rightpanel.Controls.Add(this.allCurrentLocButton);
            this.rightpanel.Controls.Add(this.backHomeButton);
            this.rightpanel.Controls.Add(this.currentLocationButton);
            this.rightpanel.Controls.Add(this.userTrace);
            this.rightpanel.Controls.Add(this.findLocation);
            this.rightpanel.Controls.Add(this.showHeatmap);
            this.rightpanel.Location = new System.Drawing.Point(-4, 84);
            this.rightpanel.Margin = new System.Windows.Forms.Padding(2);
            this.rightpanel.Name = "rightpanel";
            this.rightpanel.Size = new System.Drawing.Size(131, 861);
            this.rightpanel.TabIndex = 3;
            // 
            // allCurrentLocButton
            // 
            this.allCurrentLocButton.Location = new System.Drawing.Point(10, 280);
            this.allCurrentLocButton.Name = "allCurrentLocButton";
            this.allCurrentLocButton.Size = new System.Drawing.Size(111, 37);
            this.allCurrentLocButton.TabIndex = 18;
            this.allCurrentLocButton.Text = "All Current Location";
            this.allCurrentLocButton.UseVisualStyleBackColor = true;
            this.allCurrentLocButton.Click += new System.EventHandler(this.allCurrentLocButton_Click);
            // 
            // backHomeButton
            // 
            this.backHomeButton.BackColor = System.Drawing.Color.Transparent;
            this.backHomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backHomeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.backHomeButton.Location = new System.Drawing.Point(10, 230);
            this.backHomeButton.Margin = new System.Windows.Forms.Padding(2);
            this.backHomeButton.Name = "backHomeButton";
            this.backHomeButton.Size = new System.Drawing.Size(111, 37);
            this.backHomeButton.TabIndex = 17;
            this.backHomeButton.Text = "Home Page";
            this.backHomeButton.UseVisualStyleBackColor = false;
            this.backHomeButton.Click += new System.EventHandler(this.backHomeButton_Click);
            // 
            // currentLocationButton
            // 
            this.currentLocationButton.BackColor = System.Drawing.Color.Transparent;
            this.currentLocationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.currentLocationButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.currentLocationButton.Location = new System.Drawing.Point(10, 180);
            this.currentLocationButton.Margin = new System.Windows.Forms.Padding(2);
            this.currentLocationButton.Name = "currentLocationButton";
            this.currentLocationButton.Size = new System.Drawing.Size(111, 37);
            this.currentLocationButton.TabIndex = 5;
            this.currentLocationButton.Text = "Current Location";
            this.currentLocationButton.UseVisualStyleBackColor = false;
            this.currentLocationButton.Click += new System.EventHandler(this.currentLocationButton_Click);
            // 
            // userTrace
            // 
            this.userTrace.Location = new System.Drawing.Point(10, 130);
            this.userTrace.Margin = new System.Windows.Forms.Padding(2);
            this.userTrace.Name = "userTrace";
            this.userTrace.Size = new System.Drawing.Size(111, 37);
            this.userTrace.TabIndex = 4;
            this.userTrace.Text = "User Trace";
            this.userTrace.UseVisualStyleBackColor = true;
            this.userTrace.Click += new System.EventHandler(this.userTrace_Click);
            // 
            // findLocation
            // 
            this.findLocation.BackColor = System.Drawing.Color.Firebrick;
            this.findLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.findLocation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.findLocation.Location = new System.Drawing.Point(10, 80);
            this.findLocation.Margin = new System.Windows.Forms.Padding(2);
            this.findLocation.Name = "findLocation";
            this.findLocation.Size = new System.Drawing.Size(111, 37);
            this.findLocation.TabIndex = 0;
            this.findLocation.Text = "Find Location";
            this.findLocation.UseVisualStyleBackColor = false;
            // 
            // UserIDTextBox
            // 
            this.UserIDTextBox.Location = new System.Drawing.Point(232, 211);
            this.UserIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.UserIDTextBox.Name = "UserIDTextBox";
            this.UserIDTextBox.Size = new System.Drawing.Size(173, 20);
            this.UserIDTextBox.TabIndex = 4;
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(232, 244);
            this.timeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(173, 20);
            this.timeTextBox.TabIndex = 6;
            // 
            // mapPictureBox2
            // 
            this.mapPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("mapPictureBox2.Image")));
            this.mapPictureBox2.Location = new System.Drawing.Point(612, 164);
            this.mapPictureBox2.Name = "mapPictureBox2";
            this.mapPictureBox2.Size = new System.Drawing.Size(617, 573);
            this.mapPictureBox2.TabIndex = 8;
            this.mapPictureBox2.TabStop = false;
            this.mapPictureBox2.Visible = false;
            this.mapPictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.locationpagepaint);
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(285, 276);
            this.findButton.Margin = new System.Windows.Forms.Padding(2);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 24);
            this.findButton.TabIndex = 14;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(188, 247);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(39, 13);
            this.timeLabel.TabIndex = 15;
            this.timeLabel.Text = "Time : ";
            // 
            // userIDLabel
            // 
            this.userIDLabel.AutoSize = true;
            this.userIDLabel.Location = new System.Drawing.Point(175, 214);
            this.userIDLabel.Name = "userIDLabel";
            this.userIDLabel.Size = new System.Drawing.Size(52, 13);
            this.userIDLabel.TabIndex = 16;
            this.userIDLabel.Text = "User ID : ";
            // 
            // locationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.userIDLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.mapPictureBox2);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.UserIDTextBox);
            this.Controls.Add(this.rightpanel);
            this.Controls.Add(this.abovepanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "locationPage";
            this.Text = "Bluetooth Location Tracking";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.abovepanel.ResumeLayout(false);
            this.abovepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.rightpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button showHeatmap;
        private System.Windows.Forms.Panel abovepanel;
        private Panel rightpanel;
        private Button findLocation;
        private Button userTrace;
        private Label findLocationTitle;
        private PictureBox pictureBox2;
        private TextBox UserIDTextBox;
        private TextBox timeTextBox;
        private PictureBox mapPictureBox2;
        private Button currentLocationButton;
        private Button findButton;
        private Button backHomeButton;
        private Label timeLabel;
        private Label userIDLabel;
        private Button allCurrentLocButton;
    }
}

