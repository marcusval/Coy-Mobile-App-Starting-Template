using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using test2.Data;
using Xamarin.Forms; 
using test2.Droid.Data;

[assembly: Xamarin.Forms.Dependency(typeof(SQLite_Android))]
namespace test2.Droid.Data
{
    class SQLite_Android : ISQLite
    {
        public SQLite_Android() { }
        public SQLite.SQLiteConnection GetConnection() {

            var sqliteFileName = "TestDB.db";
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentPath, sqliteFileName);
            var conn = new SQLite.SQLiteConnection(path);

            return conn; 
        }
    }
}