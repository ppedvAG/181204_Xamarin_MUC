using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomMarkupExtension
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //Subscriber
            MessagingCenter.Subscribe<Slider, double>(this, "ValueChanged", MachWasWennSichDerSliderBewegt);
        }

        private void MachWasWennSichDerSliderBewegt(Slider arg1, double arg2)
        {
            labelWertAusSlider.Text = arg2.ToString();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Seite2());
        }
    }
}
