using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Steuerelemente
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // DisplayAlert("MessageBox", "Ich habe die ABG gelesen und verstanden", "Ja");
            // DisplayAlert("Ja/Nein - MessageBox", "Ich habe die ABG gelesen und verstanden", "Ja","Nein");
            
            // Wenn man mehr als 2 optionen braucht:
            DisplayActionSheet("Gibt es eine Frage?","Ok","Abbrechen", "Ja", "Nein", "Vielleicht", "Hab Angst");
        }
    }
}
