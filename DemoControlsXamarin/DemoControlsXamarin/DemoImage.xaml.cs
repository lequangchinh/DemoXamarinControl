using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoControlsXamarin.DemoImageXamarin;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoControlsXamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DemoImage : ContentPage
	{
		public DemoImage ()
		{
			InitializeComponent ();
		}
        async void OnDemoLocalImageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ImageLocal());
        }
        async void OnDemoEmbeddedImageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EmbeddedImage());
        }

    }
}