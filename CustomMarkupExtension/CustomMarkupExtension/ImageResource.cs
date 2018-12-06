using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomMarkupExtension
{
    [ContentProperty(nameof(ID))]
    class ImageResource : IMarkupExtension
    {
        public string ID { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (string.IsNullOrWhiteSpace(ID))
                return null;

            var output = ImageSource.FromResource(ID);
            return output;
        }
    }
}
