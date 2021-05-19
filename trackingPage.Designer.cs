
using System.Drawing;
using System.Windows.Forms;

namespace HeatmapApp
{
    partial class trackingPage 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trackingPage));
            this.showHeatmap = new System.Windows.Forms.Button();
            this.abovepanel = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rightpanel = new System.Windows.Forms.Panel();
            this.userTrace = new System.Windows.Forms.Button();
            this.findLocation = new System.Windows.Forms.Button();
            this.user_id_textBox = new System.Windows.Forms.TextBox();
            this.user_id_button = new System.Windows.Forms.Button();
            this.abovepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.rightpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // showHeatmap
            // 
            this.showHeatmap.Location = new System.Drawing.Point(17, 35);
            this.showHeatmap.Name = "showHeatmap";
            this.showHeatmap.Size = new System.Drawing.Size(140, 46);
            this.showHeatmap.TabIndex = 1;
            this.showHeatmap.Text = "Show Heatmap";
            this.showHeatmap.UseVisualStyleBackColor = true;
            this.showHeatmap.Click += new System.EventHandler(this.showHeatmap_Click);
            // 
            // abovepanel
            // 
            this.abovepanel.BackColor = System.Drawing.Color.SeaGreen;
            this.abovepanel.Controls.Add(this.label);
            this.abovepanel.Controls.Add(this.pictureBox2);
            this.abovepanel.Location = new System.Drawing.Point(-5, -1);
            this.abovepanel.Name = "abovepanel";
            this.abovepanel.Size = new System.Drawing.Size(2050, 110);
            this.abovepanel.TabIndex = 2;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label.Location = new System.Drawing.Point(1025, 45);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(346, 36);
            this.label.TabIndex = 1;
            this.label.Text = "LOCATION TRACKING";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // rightpanel
            // 
            this.rightpanel.BackColor = System.Drawing.Color.SeaGreen;
            this.rightpanel.Controls.Add(this.userTrace);
            this.rightpanel.Controls.Add(this.findLocation);
            this.rightpanel.Controls.Add(this.showHeatmap);
            this.rightpanel.Location = new System.Drawing.Point(-5, 104);
            this.rightpanel.Name = "rightpanel";
            this.rightpanel.Size = new System.Drawing.Size(175, 1060);
            this.rightpanel.TabIndex = 3;
            // 
            // userTrace
            // 
            this.userTrace.BackColor = System.Drawing.Color.Firebrick;
            this.userTrace.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userTrace.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userTrace.Location = new System.Drawing.Point(17, 166);
            this.userTrace.Name = "userTrace";
            this.userTrace.Size = new System.Drawing.Size(140, 46);
            this.userTrace.TabIndex = 4;
            this.userTrace.Text = "User Trace";
            this.userTrace.UseVisualStyleBackColor = false;
            // 
            // findLocation
            // 
            this.findLocation.BackColor = System.Drawing.Color.Transparent;
            this.findLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.findLocation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.findLocation.Location = new System.Drawing.Point(17, 101);
            this.findLocation.Name = "findLocation";
            this.findLocation.Size = new System.Drawing.Size(140, 46);
            this.findLocation.TabIndex = 0;
            this.findLocation.Text = "Find Location";
            this.findLocation.UseVisualStyleBackColor = false;
            this.findLocation.Click += new System.EventHandler(this.findLocation_Click);
            // 
            // user_id_textBox
            // 
            this.user_id_textBox.Location = new System.Drawing.Point(235, 159);
            this.user_id_textBox.Name = "user_id_textBox";
            this.user_id_textBox.Size = new System.Drawing.Size(100, 22);
            this.user_id_textBox.TabIndex = 4;
            this.user_id_textBox.Text = "User ID";
            // 
            // user_id_button
            // 
            this.user_id_button.Location = new System.Drawing.Point(246, 196);
            this.user_id_button.Name = "user_id_button";
            this.user_id_button.Size = new System.Drawing.Size(75, 23);
            this.user_id_button.TabIndex = 5;
            this.user_id_button.Text = "Enter";
            this.user_id_button.UseVisualStyleBackColor = true;
            this.user_id_button.Click += new System.EventHandler(this.user_id_button_Click);
            // 
            // trackingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1434, 711);
            this.Controls.Add(this.user_id_button);
            this.Controls.Add(this.user_id_textBox);
            this.Controls.Add(this.rightpanel);
            this.Controls.Add(this.abovepanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "trackingPage";
            this.Text = "Bluetooth Location Tracking";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.abovepanel.ResumeLayout(false);
            this.abovepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.rightpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button showHeatmap;
        private System.Windows.Forms.Panel abovepanel;
        private Panel rightpanel;
        private Button findLocation;
        private Button userTrace;
        private Label label;
        private PictureBox pictureBox2;
        private TextBox user_id_textBox;
        private Button user_id_button;
    }
}

