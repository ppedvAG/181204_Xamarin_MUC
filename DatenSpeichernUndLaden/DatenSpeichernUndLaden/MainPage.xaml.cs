using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DatenSpeichernUndLaden
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            con = DependencyService.Get<ISQLiteHelper>().GetConnection();
            con.CreateTable<Person>(); // Wenn die Tabelle bereits existiert, passiert nichts !
        }

        private readonly SQLiteConnection con;

        private void ButtonSpeichern_Clicked(object sender, EventArgs e)
        {
            var service = DependencyService.Get<ISaveAndLoadText>();
            // wichtig: liefert NULL wenn er nix findet
            service.Save("demo.txt", entryDaten.Text);
        }

        private void ButtonLaden_Clicked(object sender, EventArgs e)
        {
            var service = DependencyService.Get<ISaveAndLoadText>();
            // wichtig: liefert NULL wenn er nix findet
            DisplayAlert("Textdatei", service.Load("demo.txt"), "ok");
        }

        private void ListViewPersonen_Refreshing(object sender, EventArgs e)
        {
            listViewPersonen.ItemsSource = con.Table<Person>().Where(x => x.Kontostand > 0);
            listViewPersonen.EndRefresh();
        }

        private void ButtonInDBSpeichern_Clicked(object sender, EventArgs e)
        {
            Person p = new Person
            {
                Name = entryName.Text,
                Kontostand = 100
            };

            con.Insert(p);

            //  Application.Current.Properties["gespeichert"] = p;
        }
    }
}
