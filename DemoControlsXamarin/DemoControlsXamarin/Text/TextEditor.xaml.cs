using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoControlsXamarin.Text
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TextEditor : ContentPage
	{
		public TextEditor ()
		{
			InitializeComponent ();
		}
        void EditorCompleted(object sender, EventArgs e)
        {
            var text = ((Editor)sender).Text;
            textEditor.Text = text;
        }
    }
}