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
                while (device == null)
                {
                    time = ControlTime(time);
                    con.client = new FireSharp.FirebaseClient(con.config);
                    addr = "Devices/" + id + "/" + time;
                    con.response = await con.client.GetAsync(addr); 
                    device = con.response.ResultAs<Device>();
                }
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

        private string ControlTime(string time)
        {
            string[] times = time.Split(':');
            int hour = Int32.Parse(times[0]);
            int minute = Int32.Parse(times[1]);
            int second = Int32.Parse(times[2]);

            if (second < 59)
                second++;
            else
            {
                if (minute < 59)
                {
                    minute++;
                    second = 0;
                }
                else
                {
                    if (hour < 23)
                    {
                        minute = 0;
                        second = 0;
                        hour++;
                    }
                    else
                    {
                        minute = 0;
                        second = 0;
                        hour = 0;
                    }

                }

            }
            if (minute > 10 && second > 10 && hour > 10) // hiçbiri 
                time = hour.ToString() + ":" + minute.ToString() + ":" + second.ToString();
            else if (minute < 10 && second > 10 && hour > 10) // dakika
                time = hour.ToString() + ":0" + minute.ToString() + second.ToString();
            else if (minute > 10 && second < 10 && hour > 10) // saniye
                time = hour.ToString() + minute.ToString() + ":0" + second.ToString();
            else if (minute > 10 && second > 10 && hour < 10) // saat
                time = ":0" + hour.ToString() + minute.ToString() + second.ToString();
            else if (minute < 10 && second < 10 && hour > 10) // dakika ve saniye
                time = hour.ToString() + ":0" + minute.ToString() + ":0" + second.ToString();
            else if (minute < 10 && second > 10 && hour < 10) // saat ve dakika
                time = ":0" + hour.ToString() + ":0" + minute.ToString() + second.ToString();
            else if (minute > 10 && second < 10 && hour < 10) // saat ve saniye
                time = ":0" + hour.ToString() + minute.ToString() + ":0" + second.ToString();
            else if (minute < 10 && second < 10 && hour < 10) // hepsi
                time = ":0" + hour.ToString() + ":0" + minute.ToString() + ":0" + second.ToString();

            return time;

        }
    }
}
