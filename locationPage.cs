using BLE_DB.Database;
using BLE_DB.Models;
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
    public partial class locationPage : Form
    {
        public locationPage()
        {
            InitializeComponent();
        }

        private void showHeatmap_Click(object sender, EventArgs e)
        {
            heatmapPage form = new heatmapPage();
            form.Show();
            this.Hide();
        }

        private void userTrace_Click(object sender, EventArgs e)
        {
            trackingPage form = new trackingPage();
            form.Show();
            this.Hide();
        }

        static FirebaseConneciton con = new FirebaseConneciton();
        private async void readAccordingToTime(string id, string time)
        {
            try
            {
                con.client = new FireSharp.FirebaseClient(con.config);
                string addr = "Devices/" + id + "/" + time;
                con.response = await con.client.GetAsync(addr); // bu kısmı elimle girdim ama bi insanın hangi saatlerde nerede olduğuna burdan bakabiliriz
                                                                //form üzerinden kişinin bilgileri girilecek ve device ıdsi de girilecek sonrasında hangi zaman aralığında nerde olduğunu kontorl etmek için burası kullanılacak
                                                                //2 saniyelik aralıklara bakarız, 133:55:30 da nerde dediyse bi kendinsine bi öncesine bakarız bi de sonrasına
                                                                //hangi zaman dilimnde databasede var ise onu alırız
                Device device = con.response.ResultAs<Device>();
                MessageBox.Show(device.posX + "\n" + device.posX);

            }
            catch (Exception)
            {
                MessageBox.Show("!!!!!!!!!");
            }
        }

        private void find_loc_button_Click(object sender, EventArgs e)
        {
            string userID = UserID_textBox.Text;
            string time = time_textBox.Text;
            readAccordingToTime(userID, time);
        }
    }
}
