using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellSample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VisualChallenge : ContentPage
	{
		public VisualChallenge ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            // Device.OpenUri(new Uri("https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/visual"));

            Shell.Current.GoToAsync("//Contacts2");
        }
    }
}