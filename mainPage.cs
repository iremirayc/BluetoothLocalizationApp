﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeatmapApp
{
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();
        }

        private void showHeatmap_Click(object sender, EventArgs e)
        {
            heatmapPage form = new heatmapPage();
            form.Show();
            this.Hide();
        }

        private void findLocation_Click(object sender, EventArgs e)
        {
            locationPage form = new locationPage();
            form.Show();
            this.Hide();
        }

        private void userTrace_Click(object sender, EventArgs e)
        {
            trackingPage form = new trackingPage();
            form.Show();
            this.Hide();
        }
    }
}
