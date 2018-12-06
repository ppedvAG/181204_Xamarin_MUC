using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MalleView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ContentPage_Appearing(object sender, EventArgs e)
        {
            // Daten laden
            string json;
            using (HttpClient client = new HttpClient())
            {
                // json = client.GetStringAsync("asdasd").Result; // asynchrone logik synchron aufrufen-> blockierend
                json = await client.GetStringAsync("http://api.oceandrivers.com/v1.0/getWebCams/");
            }

            listViewWebcams.ItemsSource = JsonConvert.DeserializeObject<WebcamItem[]>(json);
        }

        private void ListViewWebcams_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            WebcamItem item = e.Item as WebcamItem;

            // Variante 1: Navigation zu einer neuen Page mit WebView
            Navigation.PushAsync(new WebcamPage(item));
            // Variante 2: Device.OpenURI -> Webbrowser auf dem Gerät
            // Device.OpenUri(item.Url);
        }
    }
}
