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

        private void current_loc_button_Click(object sender, EventArgs e)
        {
            currentLocationPage form = new currentLocationPage();
            form.Show();
            this.Hide();
        }

        private void newMemberButton_Click(object sender, EventArgs e)
        {
            registerPage form = new registerPage();
            form.Show();
            this.Hide();
        }

        private void allCurrentLocButton_Click(object sender, EventArgs e)
        {
            allUsersLocPagecs form = new allUsersLocPagecs();
            form.Show();
            this.Hide();
        }
    }
}
