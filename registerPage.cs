using System;
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
    public partial class registerPage : Form
    {
        public registerPage()
        {
            InitializeComponent();
        }

        private void showHeatmapButton_Click(object sender, EventArgs e)
        {
            heatmapPage form = new heatmapPage();
            form.Show();
            this.Hide();
        }

        private void findLocationButton_Click(object sender, EventArgs e)
        {
            locationPage form = new locationPage();
            form.Show();
            this.Hide();
        }

        private void userTraceButton_Click(object sender, EventArgs e)
        {
            trackingPage form = new trackingPage();
            form.Show();
            this.Hide();
        }

        private void currentLocationButton_Click(object sender, EventArgs e)
        {
            currentLocationPage form = new currentLocationPage();
            form.Show();
            this.Hide();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
