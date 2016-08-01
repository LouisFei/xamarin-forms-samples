using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TheBusinessTumble
{
	public partial class AbsoluteLayoutPage : ContentPage
	{
		public AbsoluteLayoutPage ()
		{
			InitializeComponent ();
		}

		public override string ToString(){
			return this.Title;
		}

        void OnMaroonButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("", "Maroon Button Clicked", "Cancel");
        }

        void OnRedButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("", "Red Button Clicked", "Cancel");
        }

    }
}

