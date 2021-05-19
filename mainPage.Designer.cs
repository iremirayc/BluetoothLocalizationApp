
using System.Drawing;
using System.Windows.Forms;

namespace HeatmapApp
{
    partial class mainPage 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPage));
            this.showHeatmap = new System.Windows.Forms.Button();
            this.abovepanel = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rightpanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.userID = new System.Windows.Forms.Label();
            this.userTrace = new System.Windows.Forms.Button();
            this.findLocation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.abovepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.rightpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // showHeatmap
            // 
            this.showHeatmap.Location = new System.Drawing.Point(17, 109);
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
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
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
            this.rightpanel.Controls.Add(this.textBox1);
            this.rightpanel.Controls.Add(this.userID);
            this.rightpanel.Controls.Add(this.userTrace);
            this.rightpanel.Controls.Add(this.findLocation);
            this.rightpanel.Controls.Add(this.showHeatmap);
            this.rightpanel.Location = new System.Drawing.Point(-5, 104);
            this.rightpanel.Name = "rightpanel";
            this.rightpanel.Size = new System.Drawing.Size(175, 1060);
            this.rightpanel.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 22);
            this.textBox1.TabIndex = 6;
            // 
            // userID
            // 
            this.userID.AutoSize = true;
            this.userID.ForeColor = System.Drawing.SystemColors.Control;
            this.userID.Location = new System.Drawing.Point(18, 35);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(63, 17);
            this.userID.TabIndex = 5;
            this.userID.Text = "User ID :";
            // 
            // userTrace
            // 
            this.userTrace.Location = new System.Drawing.Point(17, 236);
            this.userTrace.Name = "userTrace";
            this.userTrace.Size = new System.Drawing.Size(140, 46);
            this.userTrace.TabIndex = 4;
            this.userTrace.Text = "User Trace";
            this.userTrace.UseVisualStyleBackColor = true;
            this.userTrace.Click += new System.EventHandler(this.userTrace_Click);
            // 
            // findLocation
            // 
            this.findLocation.BackColor = System.Drawing.Color.Transparent;
            this.findLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.findLocation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.findLocation.Location = new System.Drawing.Point(17, 173);
            this.findLocation.Name = "findLocation";
            this.findLocation.Size = new System.Drawing.Size(140, 46);
            this.findLocation.TabIndex = 0;
            this.findLocation.Text = "Find Location";
            this.findLocation.UseVisualStyleBackColor = false;
            this.findLocation.Click += new System.EventHandler(this.findLocation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(685, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(934, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "WELCOME TO THE OUR LOCATION TRACKING APPLICATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(850, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(754, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "PLEASE ENTER YOUR USER ID AND SELECT THE BUTTONS YOU WANT";
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1434, 711);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rightpanel);
            this.Controls.Add(this.abovepanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainPage";
            this.Text = "Bluetooth Location Tracking";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.abovepanel.ResumeLayout(false);
            this.abovepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.rightpanel.ResumeLayout(false);
            this.rightpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button showHeatmap;
        private System.Windows.Forms.Panel abovepanel;
        private Panel rightpanel;
        private Button findLocation;
        private Button userTrace;
        private TextBox textBox1;
        private Label userID;
        private Label label;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
    }
}

