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

[assembly: Xamarin.Forms.Dependency(typeof(DatenSpeichernUndLaden.Droid.AndroidSaveAndLoadText))]
namespace DatenSpeichernUndLaden.Droid
{
    public class AndroidSaveAndLoadText : ISaveAndLoadText
    {
        public string Load(string filename)
        {
            string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string fullPath = Path.Combine(folder, filename);

           return File.ReadAllText(fullPath);
        }

        public void Save(string filename, string content)
        {
            // Android: Ordner ?

            // Permissions:
            // READ_EXTERNAL_STORAGE
            // WRITE_EXTERNAL_STORAGE
            // Android.OS.Environment.DirectoryMusic

            // Zugriff IMMER möglich:
            // /data/data/[applikationsname]/files
            string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string fullPath = Path.Combine(folder, filename);

            File.WriteAllText(fullPath, content);
        }
    }
}