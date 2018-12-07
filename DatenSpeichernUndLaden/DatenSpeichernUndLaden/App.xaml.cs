using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DatenSpeichernUndLaden
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            // Application-Properties
            // Wird nur gespeichert, wenn man in den Background-Modus wechselt oder die App schließt
            this.Properties["Notifications"] = false;

            // Speichern erzwingen
            // Application.Current.SavePropertiesAsync();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
