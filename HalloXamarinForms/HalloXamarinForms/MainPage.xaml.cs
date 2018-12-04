using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HalloXamarinForms
{
    // XAML wird mitkompiliert -> XAML-Fehler bekommen wir schon beim Builden mit !!!!
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonBildLaden_Clicked(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(entryHöhe.Text) || string.IsNullOrWhiteSpace(entryBreite.Text))
            {
                DisplayAlert("Warnung", "Bitte geben Sie eine gültige Höhe und Breite ein", "OK");
                return;
            }

            int höhe = Convert.ToInt32(entryHöhe.Text);
            int breite = Convert.ToInt32(entryBreite.Text);

            string url = $"http://placekitten.com/g/{höhe}/{breite}";

            //UriImageSource source = (UriImageSource)ImageSource.FromUri(new Uri(url));
            //source.CachingEnabled = true;                   // Standardfall : True
            //source.CacheValidity = TimeSpan.FromHours(2);   // Standardfall: 24h

            //image.Source = source;

            // Resource-Key -> Namespace.Ordnername.Dateiname
            image.Source = ImageSource.FromResource("HalloXamarinForms.Images.weihnachten.jpg");
        }
    }
}
