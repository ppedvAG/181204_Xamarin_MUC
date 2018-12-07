using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;

[assembly: Xamarin.Forms.Dependency(typeof(DatenSpeichernUndLaden.Droid.AndroidSQLiteHelper))]
namespace DatenSpeichernUndLaden.Droid
{
    class AndroidSQLiteHelper : ISQLiteHelper
    {
        public SQLiteConnection GetConnection()
        {
            string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string fullPath = Path.Combine(folder, "db.sqlite");

            return new SQLiteConnection(fullPath);
        }
    }
}