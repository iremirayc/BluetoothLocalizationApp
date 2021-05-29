﻿
namespace HeatmapApp
{
    partial class currentLocationPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(currentLocationPage));
            this.showHeatmapButton = new System.Windows.Forms.Button();
            this.abovepanel = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rightpanel = new System.Windows.Forms.Panel();
            this.backHomeButton = new System.Windows.Forms.Button();
            this.currentLocationButton = new System.Windows.Forms.Button();
            this.userTraceButton = new System.Windows.Forms.Button();
            this.findLocationButton = new System.Windows.Forms.Button();
            this.map_pictureBox = new System.Windows.Forms.PictureBox();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.abovepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.rightpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.map_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // showHeatmapButton
            // 
            this.showHeatmapButton.Location = new System.Drawing.Point(12, 38);
            this.showHeatmapButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showHeatmapButton.Name = "showHeatmapButton";
            this.showHeatmapButton.Size = new System.Drawing.Size(148, 45);
            this.showHeatmapButton.TabIndex = 1;
            this.showHeatmapButton.Text = "Show Heatmap";
            this.showHeatmapButton.UseVisualStyleBackColor = true;
            this.showHeatmapButton.Click += new System.EventHandler(this.showHeatmapButton_Click);
            // 
            // abovepanel
            // 
            this.abovepanel.BackColor = System.Drawing.Color.SeaGreen;
            this.abovepanel.Controls.Add(this.label);
            this.abovepanel.Controls.Add(this.pictureBox2);
            this.abovepanel.Location = new System.Drawing.Point(0, -1);
            this.abovepanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.abovepanel.Name = "abovepanel";
            this.abovepanel.Size = new System.Drawing.Size(2051, 110);
            this.abovepanel.TabIndex = 7;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label.Location = new System.Drawing.Point(950, 45);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(337, 36);
            this.label.TabIndex = 1;
            this.label.Text = "CURRENT LOCATION";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // rightpanel
            // 
            this.rightpanel.BackColor = System.Drawing.Color.SeaGreen;
            this.rightpanel.Controls.Add(this.backHomeButton);
            this.rightpanel.Controls.Add(this.currentLocationButton);
            this.rightpanel.Controls.Add(this.userTraceButton);
            this.rightpanel.Controls.Add(this.findLocationButton);
            this.rightpanel.Controls.Add(this.showHeatmapButton);
            this.rightpanel.Location = new System.Drawing.Point(0, 103);
            this.rightpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rightpanel.Name = "rightpanel";
            this.rightpanel.Size = new System.Drawing.Size(175, 1060);
            this.rightpanel.TabIndex = 8;
            // 
            // backHomeButton
            // 
            this.backHomeButton.BackColor = System.Drawing.Color.Transparent;
            this.backHomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backHomeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.backHomeButton.Location = new System.Drawing.Point(12, 278);
            this.backHomeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backHomeButton.Name = "backHomeButton";
            this.backHomeButton.Size = new System.Drawing.Size(148, 45);
            this.backHomeButton.TabIndex = 16;
            this.backHomeButton.Text = "Home Page";
            this.backHomeButton.UseVisualStyleBackColor = false;
            this.backHomeButton.Click += new System.EventHandler(this.backHomeButton_Click);
            // 
            // currentLocationButton
            // 
            this.currentLocationButton.BackColor = System.Drawing.Color.Firebrick;
            this.currentLocationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.currentLocationButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.currentLocationButton.Location = new System.Drawing.Point(12, 218);
            this.currentLocationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currentLocationButton.Name = "currentLocationButton";
            this.currentLocationButton.Size = new System.Drawing.Size(148, 45);
            this.currentLocationButton.TabIndex = 4;
            this.currentLocationButton.Text = "Current Location";
            this.currentLocationButton.UseVisualStyleBackColor = false;
            // 
            // userTraceButton
            // 
            this.userTraceButton.BackColor = System.Drawing.Color.Transparent;
            this.userTraceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userTraceButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userTraceButton.Location = new System.Drawing.Point(12, 158);
            this.userTraceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userTraceButton.Name = "userTraceButton";
            this.userTraceButton.Size = new System.Drawing.Size(148, 45);
            this.userTraceButton.TabIndex = 0;
            this.userTraceButton.Text = "User Trace";
            this.userTraceButton.UseVisualStyleBackColor = false;
            this.userTraceButton.Click += new System.EventHandler(this.userTraceButton_Click);
            // 
            // findLocationButton
            // 
            this.findLocationButton.BackColor = System.Drawing.Color.Transparent;
            this.findLocationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.findLocationButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.findLocationButton.Location = new System.Drawing.Point(12, 98);
            this.findLocationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.findLocationButton.Name = "findLocationButton";
            this.findLocationButton.Size = new System.Drawing.Size(148, 45);
            this.findLocationButton.TabIndex = 0;
            this.findLocationButton.Text = "Find Location";
            this.findLocationButton.UseVisualStyleBackColor = false;
            this.findLocationButton.Click += new System.EventHandler(this.findLocationButton_Click);
            // 
            // map_pictureBox
            // 
            this.map_pictureBox.Location = new System.Drawing.Point(700, 160);
            this.map_pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.map_pictureBox.Name = "map_pictureBox";
            this.map_pictureBox.Size = new System.Drawing.Size(900, 800);
            this.map_pictureBox.TabIndex = 11;
            this.map_pictureBox.TabStop = false;
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.Location = new System.Drawing.Point(310, 260);
            this.userIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(229, 22);
            this.userIDTextBox.TabIndex = 13;
            this.userIDTextBox.Text = "User ID";
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(380, 300);
            this.enterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(100, 30);
            this.enterButton.TabIndex = 15;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            // 
            // currentLocationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1827, 922);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.userIDTextBox);
            this.Controls.Add(this.abovepanel);
            this.Controls.Add(this.rightpanel);
            this.Controls.Add(this.map_pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "currentLocationPage";
            this.Text = "Bluetooth Location Tracking";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.abovepanel.ResumeLayout(false);
            this.abovepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.rightpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.map_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showHeatmapButton;
        private System.Windows.Forms.Panel abovepanel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel rightpanel;
        private System.Windows.Forms.Button currentLocationButton;
        private System.Windows.Forms.Button userTraceButton;
        private System.Windows.Forms.Button findLocationButton;
        private System.Windows.Forms.PictureBox map_pictureBox;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button backHomeButton;
    }
}