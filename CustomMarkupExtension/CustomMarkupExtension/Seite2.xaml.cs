using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomMarkupExtension
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Seite2 : ContentPage
	{
		public Seite2 ()
		{
			InitializeComponent ();
		}

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            // Publisher - Version
            MessagingCenter.Send<Slider, double>(sender as Slider, "ValueChanged", e.NewValue);
        }
    }
}