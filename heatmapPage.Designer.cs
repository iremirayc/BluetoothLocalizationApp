
using System.Drawing;
using System.Windows.Forms;

namespace HeatmapApp
{
    partial class heatmapPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(heatmapPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showHeatmap = new System.Windows.Forms.Button();
            this.abovepanel = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rightpanel = new System.Windows.Forms.Panel();
            this.backHomeButton = new System.Windows.Forms.Button();
            this.currentLocationButton = new System.Windows.Forms.Button();
            this.userTrace = new System.Windows.Forms.Button();
            this.findLocation = new System.Windows.Forms.Button();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.abovepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.rightpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(700, 160);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(900, 800);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // showHeatmap
            // 
            this.showHeatmap.BackColor = System.Drawing.Color.Firebrick;
            this.showHeatmap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.showHeatmap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showHeatmap.Location = new System.Drawing.Point(12, 38);
            this.showHeatmap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showHeatmap.Name = "showHeatmap";
            this.showHeatmap.Size = new System.Drawing.Size(148, 45);
            this.showHeatmap.TabIndex = 1;
            this.showHeatmap.Text = "Show Heatmap";
            this.showHeatmap.UseVisualStyleBackColor = false;
            // 
            // abovepanel
            // 
            this.abovepanel.BackColor = System.Drawing.Color.SeaGreen;
            this.abovepanel.Controls.Add(this.label);
            this.abovepanel.Controls.Add(this.pictureBox2);
            this.abovepanel.Location = new System.Drawing.Point(-5, -1);
            this.abovepanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.abovepanel.Name = "abovepanel";
            this.abovepanel.Size = new System.Drawing.Size(2051, 110);
            this.abovepanel.TabIndex = 2;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label.Location = new System.Drawing.Point(950, 45);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(273, 36);
            this.label.TabIndex = 1;
            this.label.Text = "SHOW HEATMAP";
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
            this.rightpanel.Controls.Add(this.userTrace);
            this.rightpanel.Controls.Add(this.findLocation);
            this.rightpanel.Controls.Add(this.showHeatmap);
            this.rightpanel.Location = new System.Drawing.Point(-5, 103);
            this.rightpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rightpanel.Name = "rightpanel";
            this.rightpanel.Size = new System.Drawing.Size(175, 1060);
            this.rightpanel.TabIndex = 3;
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
            this.currentLocationButton.Location = new System.Drawing.Point(12, 218);
            this.currentLocationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currentLocationButton.Name = "currentLocationButton";
            this.currentLocationButton.Size = new System.Drawing.Size(148, 45);
            this.currentLocationButton.TabIndex = 5;
            this.currentLocationButton.Text = "Current Location";
            this.currentLocationButton.UseVisualStyleBackColor = false;
            this.currentLocationButton.Click += new System.EventHandler(this.currentLocationButton_Click);
            // 
            // userTrace
            // 
            this.userTrace.Location = new System.Drawing.Point(12, 158);
            this.userTrace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userTrace.Name = "userTrace";
            this.userTrace.Size = new System.Drawing.Size(148, 45);
            this.userTrace.TabIndex = 4;
            this.userTrace.Text = "User Trace";
            this.userTrace.UseVisualStyleBackColor = true;
            this.userTrace.Click += new System.EventHandler(this.userTrace_Click);
            // 
            // findLocation
            // 
            this.findLocation.Location = new System.Drawing.Point(12, 98);
            this.findLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.findLocation.Name = "findLocation";
            this.findLocation.Size = new System.Drawing.Size(148, 45);
            this.findLocation.TabIndex = 0;
            this.findLocation.Text = "Find Location";
            this.findLocation.UseVisualStyleBackColor = true;
            this.findLocation.Click += new System.EventHandler(this.findLocation_Click);
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(310, 260);
            this.timeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(218, 22);
            this.timeTextBox.TabIndex = 4;
            this.timeTextBox.Text = "Starting Time";
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(380, 300);
            this.enterButton.Margin = new System.Windows.Forms.Padding(4);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(100, 30);
            this.enterButton.TabIndex = 5;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // heatmapPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1371, 711);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.rightpanel);
            this.Controls.Add(this.abovepanel);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "heatmapPage";
            this.Text = "Bluetooth Location Tracking";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.abovepanel.ResumeLayout(false);
            this.abovepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.rightpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button showHeatmap;
        private System.Windows.Forms.Panel abovepanel;
        private Panel rightpanel;
        private Button findLocation;
        private Button userTrace;
        private Label label;
        private PictureBox pictureBox2;
        private TextBox timeTextBox;
        private Button enterButton;
        private Button currentLocationButton;
        private Button backHomeButton;
    }
}

