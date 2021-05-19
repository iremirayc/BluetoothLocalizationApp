using System;
using System.Collections.Generic;
using System.Text;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace BLE_DB.Database
{
    class FirebaseConneciton
    {
        public IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "QqHfGBiMW2vuqlTXurJB5VfovEFb1WPPrThqLTkJ",
            BasePath = "https://ble-localization-84b97-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        public IFirebaseClient client;
        public FirebaseResponse response;

    }
}
