using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UserControlDemo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LabledEntry : ContentView
	{
		public LabledEntry ()
		{
			InitializeComponent ();
            this.BindingContext = this;
		}


        // propdp -> DependencyProperty aus WPF - Snippet
        // 1) propdp snippet erstellen
        // 2) Auf Xamarin.Forms "Umbauen"

        // Änderungen vom propdp - snippet:
        // DependencyProperty durch BindableProperty ersetzen
        // propertymetadata durch "standardwert" ersetzen (oder auslassen)
        // statt .Register .Create nutzen

        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Label.  This enables animation, styling, binding, etc...
        public static readonly BindableProperty LabelProperty =
            BindableProperty.Create("Label", typeof(string), typeof(LabledEntry),string.Empty);

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Label.  This enables animation, styling, binding, etc...
        public static readonly BindableProperty TextProperty =
            BindableProperty.Create("Text", typeof(string), typeof(LabledEntry), string.Empty);

        public string Placeholder
        {
            get { return (string)GetValue(PlaceholderProperty); }
            set { SetValue(PlaceholderProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Label.  This enables animation, styling, binding, etc...
        public static readonly BindableProperty PlaceholderProperty =
            BindableProperty.Create("Placeholder", typeof(string), typeof(LabledEntry), string.Empty);

    }
}