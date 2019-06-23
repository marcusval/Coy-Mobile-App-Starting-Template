using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using test2.Data;
using Android.Net;
using test2.Droid.Data;

[assembly : Xamarin.Forms.Dependency(typeof(NetworkConnection))]

namespace test2.Droid.Data
{
    public class NetworkConnection : INetworkConnection
    {
        public NetworkConnection() { }
        public bool IsConnected { get; set; }

    
        public void CheckNetworkConnection() {
            var ConnectivityManager = (ConnectivityManager)Application.Context.GetSystemService(Context.ConnectivityService);
            var ActiveNetworkInfo = ConnectivityManager.ActiveNetworkInfo;
            if (ActiveNetworkInfo != null && ActiveNetworkInfo.IsConnectedOrConnecting) {
                IsConnected = true; 
            }
            else
            {
                IsConnected = false; 
            }
        }
    }
}