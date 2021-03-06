using BLE_DB.Database;
using BLE_DB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
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

        private List<HeatPoint> HeatPoints = new List<HeatPoint>();

        public struct HeatPoint
        {
            public double X;
            public double Y;
            public byte Intensity;
            public HeatPoint(double iX, double iY, byte bIntensity)
            {
                X = iX;
                Y = iY;
                Intensity = bIntensity;
            }
        }

        private Bitmap CreateIntensityMask(Bitmap bSurface, List<HeatPoint> aHeatPoints)
        {
            // Create new graphics surface from memory bitmap
            Graphics DrawSurface = Graphics.FromImage(bSurface);
            // Set background color to white so that pixels can be correctly colorized
            DrawSurface.Clear(Color.White);
            // Traverse heat point data and draw masks for each heat point
            foreach (HeatPoint DataPoint in aHeatPoints)
            {
                // Render current heat point on draw surface
                DrawHeatPoint(DrawSurface, DataPoint, 20);
            }
            return bSurface;
        }

        private void DrawHeatPoint(Graphics Canvas, HeatPoint HeatPoint, int Radius)
        {
            // Create points generic list of points to hold circumference points
            List<Point> CircumferencePointsList = new List<Point>();
            // Create an empty point to predefine the point struct used in the circumference loop
            Point CircumferencePoint;
            // Create an empty array that will be populated with points from the generic list
            Point[] CircumferencePointsArray;
            // Calculate ratio to scale byte intensity range from 0-255 to 0-1
            float fRatio = 1F / Byte.MaxValue;
            // Precalulate half of byte max value
            byte bHalf = Byte.MaxValue / 2;
            // Flip intensity on it's center value from low-high to high-low
            int iIntensity = (byte)(HeatPoint.Intensity - ((HeatPoint.Intensity - bHalf) * 2));
            // Store scaled and flipped intensity value for use with gradient center location
            float fIntensity = iIntensity * fRatio;
            // Loop through all angles of a circle
            // Define loop variable as a double to prevent casting in each iteration
            // Iterate through loop on 10 degree deltas, this can change to improve performance
            for (double i = 0; i <= 360; i += 1)
            {
                // Replace last iteration point with new empty point struct
                CircumferencePoint = new Point();
                // Plot new point on the circumference of a circle of the defined radius
                // Using the point coordinates, radius, and angle
                // Calculate the position of this iterations point on the circle
                CircumferencePoint.X = Convert.ToInt32(HeatPoint.X + Radius * Math.Cos(ConvertDegreesToRadians(i)));
                CircumferencePoint.Y = Convert.ToInt32(HeatPoint.Y + Radius * Math.Sin(ConvertDegreesToRadians(i)));
                // Add newly plotted circumference point to generic point list
                CircumferencePointsList.Add(CircumferencePoint);
            }
            // Populate empty points system array from generic points array list
            // Do this to satisfy the datatype of the PathGradientBrush and FillPolygon methods
            CircumferencePointsArray = CircumferencePointsList.ToArray();
            // Create new PathGradientBrush to create a radial gradient using the circumference points
            PathGradientBrush GradientShaper = new PathGradientBrush(CircumferencePointsArray);
            // Create new color blend to tell the PathGradientBrush what colors to use and where to put them
            ColorBlend GradientSpecifications = new ColorBlend(1);
            // Define positions of gradient colors, use intesity to adjust the middle color to
            // show more mask or less mask
            GradientSpecifications.Positions = new float[3] { 0, fIntensity, 1 };
            // Define gradient colors and their alpha values, adjust alpha of gradient colors to match intensity
            GradientSpecifications.Colors = new Color[3]
            {
        Color.FromArgb(0, Color.White),
        Color.FromArgb(HeatPoint.Intensity, Color.Black),
        Color.FromArgb(HeatPoint.Intensity, Color.Black)
            };
            // Pass off color blend to PathGradientBrush to instruct it how to generate the gradient
            GradientShaper.InterpolationColors = GradientSpecifications;
            // Draw polygon (circle) using our point array and gradient brush
            Canvas.FillPolygon(GradientShaper, CircumferencePointsArray);
        }

        private double ConvertDegreesToRadians(double degrees)
        {
            double radians = (Math.PI / 180) * degrees;
            return (radians);
        }

        public static Bitmap Colorize(Bitmap Mask, byte Alpha)
        {
            // Create new bitmap to act as a work surface for the colorization process
            Bitmap Output = new Bitmap(Mask.Width, Mask.Height, PixelFormat.Format32bppArgb);
            // Create a graphics object from our memory bitmap so we can draw on it and clear it's drawing surface
            Graphics Surface = Graphics.FromImage(Output);
            Surface.Clear(Color.Transparent);
            // Build an array of color mappings to remap our greyscale mask to full color
            // Accept an alpha byte to specify the transparancy of the output image
            ColorMap[] Colors = CreatePaletteIndex(Alpha);
            // Create new image attributes class to handle the color remappings
            // Inject our color map array to instruct the image attributes class how to do the colorization
            ImageAttributes Remapper = new ImageAttributes();
            Remapper.SetRemapTable(Colors);
            // Draw our mask onto our memory bitmap work surface using the new color mapping scheme
            Surface.DrawImage(Mask, new Rectangle(0, 0, Mask.Width, Mask.Height), 0, 0, Mask.Width, Mask.Height, GraphicsUnit.Pixel, Remapper);
            // Send back newly colorized memory bitmap
            return Output;
        }
        private static ColorMap[] CreatePaletteIndex(byte Alpha)
        {
            ColorMap[] OutputMap = new ColorMap[256];
            var len = OutputMap.Length;
            // Change this path to wherever you saved the palette image.
            Bitmap Palette = MixColorPalette(Color.Green, Color.Yellow, Color.Red, len, Color.LightGray); //(Bitmap)Bitmap.FromFile(@"..\..\palette.bmp");
                                                                                                          // Loop through each pixel and create a new color mapping
            for (int X = 0; X < len; X++)
            {
                OutputMap[X] = new ColorMap();
                OutputMap[X].OldColor = Color.FromArgb(X, X, X);
                OutputMap[X].NewColor = Color.FromArgb(Alpha, Palette.GetPixel(X, 0));
            }
            return OutputMap;
        }

        // <summary>
        /// Creates a mixed color Palette
        /// </summary>
        /// <param name="A">Start color (e.g. Color.Green)</param>
        /// <param name="B">Middle color (e.g. Color.Yellow)</param>
        /// <param name="C">End color (e.g. Color.Red)</param>
        /// <param name="num">Length of pallete</param>
        /// <param name="bgColor">Background color for zero values</param>
        /// <returns></returns>
        public static Bitmap MixColorPalette(Color A, Color B, Color C, int num, Color bgColor)
        {
            var blend = new ColorBlend(num)
            {
                Colors = new Color[3] { A, B, C },
                Positions = new float[3] { 0.0f, 0.5f, 1.0f }
            };
            var p1 = new Point(0, 0);
            var p2 = new Point(num, 0);
            var lgBrush = new LinearGradientBrush(p2,
            p1,
            A,
            B);
            lgBrush.InterpolationColors = blend;
            var pen = new Pen(lgBrush);
            var bmp = new Bitmap(num, 1);
            var gr = Graphics.FromImage(bmp);
            gr.DrawLine(pen, p1, p2);
            bmp.SetPixel(num - 1, 0, bgColor);
            return bmp;
        }

        public static Image SetImageOpacity(Image image, float opacity)
        {
            try
            {
                //create a Bitmap the size of the image provided  
                Bitmap bmp = new Bitmap(image.Width, image.Height);

                //create a graphics object from the image  
                using (Graphics gfx = Graphics.FromImage(bmp))
                {

                    //create a color matrix object  
                    ColorMatrix matrix = new ColorMatrix();

                    //set the opacity  
                    matrix.Matrix33 = opacity;

                    //create image attributes  
                    ImageAttributes attributes = new ImageAttributes();

                    //set the color(opacity) of the image  
                    attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                    //now draw the image  
                    gfx.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
                }
                return bmp;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                throw ex;
                //return null;
            }
        }


        public static Image Overlap(Image source1, Image source2)
        {
            var target = new Bitmap(source1.Width, source1.Height, PixelFormat.Format32bppArgb);
            var graphics = Graphics.FromImage(target);
            graphics.CompositingMode = CompositingMode.SourceOver; // this is the default, but just to be clear

            graphics.DrawImage(source1, 0, 0);
            graphics.DrawImage(source2, 0, 0);

            return target;
        }

        static FirebaseConneciton con = new FirebaseConneciton();
        private Device device = null;
        private async void readAccordingToTime(string id, string time)
        {
            con.client = new FireSharp.FirebaseClient(con.config);
            string addr = "Devices/" + id + "/" + time;
            con.response = await con.client.GetAsync(addr);
            device = con.response.ResultAs<Device>();
            int count = 0;
            while (device == null)
            {
                time = ControlTime(time);
                con.client = new FireSharp.FirebaseClient(con.config);
                addr = "Devices/" + id + "/" + time;
                con.response = await con.client.GetAsync(addr);
                device = con.response.ResultAs<Device>();
                count++;
                if (count > 5)
                {
                    MessageBox.Show("Could not Find!");
                    return;
                }

            }
            //createBitMap(device);
            this.Refresh();
            
            mapPictureBox2.Show();
        }

        private void createBitMap(Device device)
        {
            // Create new memory bitmap the same size as the picture box
            Bitmap bMap = new Bitmap(mapPictureBox2.Width, mapPictureBox2.Height);
            HeatPoints.Clear();
            HeatPoints.Add(new HeatPoint(device.posX, device.posY, 60));
            // Call CreateIntensityMask, give it the memory bitmap, and store the result back in the memory bitmap
            bMap = CreateIntensityMask(bMap, HeatPoints);
            // Colorize the memory bitmap and assign it as the picture boxes image
            mapPictureBox2.Image = Colorize(bMap, 255);
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
            if (minute >= 10 && second >= 10 && hour >= 10) // hiçbiri 
                time = hour.ToString() + ":" + minute.ToString() + ":" + second.ToString();
            else if (minute < 10 && second >= 10 && hour >= 10) // dakika
                time = hour.ToString() + ":0" + minute.ToString() + ":" + second.ToString();
            else if (minute >= 10 && second < 10 && hour >= 10) // saniye
                time = hour.ToString() + ":" + minute.ToString() + ":0" + second.ToString();
            else if (minute >= 10 && second >= 10 && hour < 10) // saat
                time = ":0" + hour.ToString() + ":" + minute.ToString() + ":" + second.ToString();
            else if (minute < 10 && second < 10 && hour >= 10) // dakika ve saniye
                time = hour.ToString() + ":0" + minute.ToString() + ":0" + second.ToString();
            else if (minute < 10 && second >= 10 && hour < 10) // saat ve dakika
                time = ":0" + hour.ToString() + ":0" + minute.ToString() + ":" + second.ToString();
            else if (minute >= 10 && second < 10 && hour < 10) // saat ve saniye
                time = ":0" + hour.ToString() + ":" + minute.ToString() + ":0" + second.ToString();
            else if (minute < 10 && second < 10 && hour < 10) // hepsi
                time = ":0" + hour.ToString() + ":0" + minute.ToString() + ":0" + second.ToString();

            return time;

        }

        private void currentLocationButton_Click(object sender, EventArgs e)
        {
            currentLocationPage form = new currentLocationPage();
            form.Show();
            this.Hide();
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

        private void backHomeButton_Click(object sender, EventArgs e)
        {
            mainPage form = new mainPage();
            form.Show();
            this.Hide();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            string userID = UserIDTextBox.Text;
            string time = timeTextBox.Text;
            readAccordingToTime(userID, time);
           
        }

        private void allCurrentLocButton_Click(object sender, EventArgs e)
        {
            allUsersLocPagecs form = new allUsersLocPagecs();
            form.Show();
            this.Hide();
        }
       
        
        private void locationpagepaint(object sender, PaintEventArgs e)
        {
            if (device != null )
            {
                
                  
                //mapPictureBox2.Image = Image.FromFile("C:\\Users\\pelsi\\source\\repos\\BluetoothLocalizationApp\\Images\\roomdesign.jpg");
                //  this.mapPictureBox2.Load(Image.FromFile("C:\\Users\\pelsi\\source\\repos\\BluetoothLocalizationApp\\Images\\roomdesign.jpg");                
                Icon icon = new Icon("C:\\Users\\pelsi\\source\\repos\\deneme1\\deneme1\\resim\\free-location.ico");
                
                e.Graphics.DrawIcon(icon, (int)device.posX, (int)device.posY);
               
            }
            
        }
    }
}
