using BLE_DB.Database;
using FireSharp.Response;
using HeatmapApp.Models;
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

        static FirebaseConneciton con = new FirebaseConneciton();
        private async void registerButton_Click(object sender, EventArgs e)
        {
            Visitor visitor = new Visitor();
            visitor.TC = TCnoTextBox.Text;
            visitor.Name = usernameTextBox.Text;
            visitor.deviceId = Int32.Parse(deviceIDTextBox.Text);
            if (InfoTextBox.Text != null)
                visitor.Info = InfoTextBox.Text;
            else visitor.Info = "";

            con.client = new FireSharp.FirebaseClient(con.config);
            con.response = await con.client.SetAsync("Visitor/" + visitor.deviceId, visitor);
            con.response = await con.client.SetAsync("Register/" + visitor.TC, visitor);
            MessageBox.Show(visitor.Name + " Registered!");
        }

        private async void findUserWithTC(string TC)
        {
            con.client = new FireSharp.FirebaseClient(con.config);
            string addr = "Register/" + TC;
            con.response = await con.client.GetAsync(addr);

            Visitor visitor = con.response.ResultAs<Visitor>();
            if (visitor == null)
            {
                MessageBox.Show("There is not visitor with this TC.");
            }
            else
            {
                userInfoLabel.Text = "Name : " + visitor.Name + "\nTC : " + visitor.TC +
                    "\nDevice ID : " + visitor.deviceId + "\nInfo : " + visitor.Info;
            }

        }

        private async void findUserWithDeviceId(int deviceId)
        {
            con.client = new FireSharp.FirebaseClient(con.config);
            string addr = "Visitor/" + deviceId;
            con.response = await con.client.GetAsync(addr);

            Visitor visitor = con.response.ResultAs<Visitor>();
            if (visitor == null)
            {
                MessageBox.Show("There is not visitor with this device.");
            }
            else
            {
                userInfoLabel.Text = "Name : " + visitor.Name + "\nTC : " + visitor.TC +
                    "\nDevice ID : " + visitor.deviceId + "\nInfo : " + visitor.Info;
            }
        }

        private void backHomeButton_Click(object sender, EventArgs e)
        {
            mainPage form = new mainPage();
            form.Show();
            this.Hide();
        }

        private void findVisitorButton_Click(object sender, EventArgs e)
        {
            if (TCnoTextBox.Text != "")
                findUserWithTC(TCnoTextBox.Text);
            else if (deviceIDTextBox.Text != "")
            {
                findUserWithDeviceId(Int32.Parse(deviceIDTextBox.Text));
            }
            else
            {
                MessageBox.Show("Please fill require field!");
            }
        }
    }
}
