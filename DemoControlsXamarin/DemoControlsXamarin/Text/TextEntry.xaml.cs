﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoControlsXamarin.Text
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TextEntry : ContentPage
	{
		public TextEntry ()
		{
			InitializeComponent ();
            password.Text = "password";
		}
	}
}