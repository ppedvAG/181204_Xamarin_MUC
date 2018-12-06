using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MalleView
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WebcamPage : ContentPage
	{
		public WebcamPage (WebcamItem item)
		{
			InitializeComponent ();
            this.item = item;
		}
        private readonly WebcamItem item;

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            labelName.Text = item.Name;
            labelLocation.Text = item.Location;
            webViewWebcam.Source = item.Url;
        }
    }
}