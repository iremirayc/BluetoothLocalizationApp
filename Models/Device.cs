using System;
using System.Collections.Generic;
using System.Text;

namespace BLE_DB.Models
{
    class Device
    {
        public int id { get; set; }
        public double posX { get; set; }
        public double posY { get; set; }
        public DateTime time { get; set; }
    }
}
