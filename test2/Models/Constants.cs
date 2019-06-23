using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace test2.Models
{
    public class Constants
    {
        public static bool IsDev = true;

        public static Color BackGroundColor = Color.FromRgb(226, 226, 226);
        public static Color MainTextColor = Color.FromRgb(105, 119, 117);
        public static int LogInIconHeight = 120;
        internal static object ActivitySpinner;

        public static string LoginUrl = "https://test.com/api/Auth/Login";

        public static string NoInternetText = "No Internet, please reconnect"; 


    }
}
