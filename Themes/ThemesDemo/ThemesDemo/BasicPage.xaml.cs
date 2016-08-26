using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ThemesDemo
{
	public partial class BasicPage : ContentPage
	{
		public BasicPage ()
		{
			InitializeComponent ();
		}

        private void OnShowLabelStyleDemoPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LabelStyleClassDemoPage());
        }
        private void OnShowButtonStyleDemoPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ButtonStyleClassDemoPage());
        }

    }
}

