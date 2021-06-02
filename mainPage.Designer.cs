
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
            this.homePageTitle = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rightpanel = new System.Windows.Forms.Panel();
            this.allCurrentLocButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.current_loc_button = new System.Windows.Forms.Button();
            this.userTrace = new System.Windows.Forms.Button();
            this.findLocation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.newMemberButton = new System.Windows.Forms.Button();
            this.abovepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.rightpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // showHeatmap
            // 
            this.showHeatmap.Location = new System.Drawing.Point(9, 31);
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
            this.abovepanel.Controls.Add(this.homePageTitle);
            this.abovepanel.Controls.Add(this.pictureBox2);
            this.abovepanel.Location = new System.Drawing.Point(-4, -1);
            this.abovepanel.Margin = new System.Windows.Forms.Padding(2);
            this.abovepanel.Name = "abovepanel";
            this.abovepanel.Size = new System.Drawing.Size(1538, 89);
            this.abovepanel.TabIndex = 2;
            // 
            // homePageTitle
            // 
            this.homePageTitle.AutoSize = true;
            this.homePageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.homePageTitle.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.homePageTitle.Location = new System.Drawing.Point(700, 30);
            this.homePageTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.homePageTitle.Name = "homePageTitle";
            this.homePageTitle.Size = new System.Drawing.Size(165, 29);
            this.homePageTitle.TabIndex = 1;
            this.homePageTitle.Text = "HOME PAGE";
            this.homePageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
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
            this.rightpanel.Controls.Add(this.button1);
            this.rightpanel.Controls.Add(this.current_loc_button);
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
            this.allCurrentLocButton.Location = new System.Drawing.Point(9, 278);
            this.allCurrentLocButton.Name = "allCurrentLocButton";
            this.allCurrentLocButton.Size = new System.Drawing.Size(111, 37);
            this.allCurrentLocButton.TabIndex = 8;
            this.allCurrentLocButton.Text = "All Current Location";
            this.allCurrentLocButton.UseVisualStyleBackColor = true;
            this.allCurrentLocButton.Click += new System.EventHandler(this.allCurrentLocButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(9, 226);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Home Page";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // current_loc_button
            // 
            this.current_loc_button.Location = new System.Drawing.Point(9, 177);
            this.current_loc_button.Name = "current_loc_button";
            this.current_loc_button.Size = new System.Drawing.Size(111, 37);
            this.current_loc_button.TabIndex = 5;
            this.current_loc_button.Text = "Current Location";
            this.current_loc_button.UseVisualStyleBackColor = true;
            this.current_loc_button.Click += new System.EventHandler(this.current_loc_button_Click);
            // 
            // userTrace
            // 
            this.userTrace.Location = new System.Drawing.Point(9, 128);
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
            this.findLocation.BackColor = System.Drawing.Color.Transparent;
            this.findLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.findLocation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.findLocation.Location = new System.Drawing.Point(9, 80);
            this.findLocation.Margin = new System.Windows.Forms.Padding(2);
            this.findLocation.Name = "findLocation";
            this.findLocation.Size = new System.Drawing.Size(111, 37);
            this.findLocation.TabIndex = 0;
            this.findLocation.Text = "Find Location";
            this.findLocation.UseVisualStyleBackColor = false;
            this.findLocation.Click += new System.EventHandler(this.findLocation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(394, 219);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(760, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "WELCOME TO THE OUR LOCATION TRACKING APPLICATION";
            // 
            // newMemberButton
            // 
            this.newMemberButton.Location = new System.Drawing.Point(698, 330);
            this.newMemberButton.Margin = new System.Windows.Forms.Padding(2);
            this.newMemberButton.Name = "newMemberButton";
            this.newMemberButton.Size = new System.Drawing.Size(200, 38);
            this.newMemberButton.TabIndex = 6;
            this.newMemberButton.Text = "New Member Registration";
            this.newMemberButton.UseVisualStyleBackColor = true;
            this.newMemberButton.Click += new System.EventHandler(this.newMemberButton_Click);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.newMemberButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rightpanel);
            this.Controls.Add(this.abovepanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainPage";
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
        private Label homePageTitle;
        private PictureBox pictureBox2;
        private Label label1;
        private Button current_loc_button;
        private Button newMemberButton;
        private Button button1;
        private Button allCurrentLocButton;
    }
}

