using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoControlsXamarin.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoControlsXamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DemoText : ContentPage
	{
		public DemoText ()
		{
			InitializeComponent ();
		}
        async void OnTextEntryButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new TextEntry()));
        }
        async void OnTextEditorButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new TextEditor()));
        }
    }
}