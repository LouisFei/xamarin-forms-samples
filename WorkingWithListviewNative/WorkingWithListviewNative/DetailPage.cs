using System;

using Xamarin.Forms;

namespace WorkingWithListviewNative
{
	public class DetailPage : ContentPage
	{
		public DetailPage (object detail)
		{
			var lblTitle = new Label { Text = "Xamarin.Forms Detail Page" }; 

			var lblContent = new Label ();

            if (detail is string)
            {
                lblContent.Text = (string)detail;
            }
            else if (detail is DataSource)
            {
                lblContent.Text = ((DataSource)detail).Name;
            }

			var btnDismiss = new Button { Text = "Dismiss 离开" };
			btnDismiss.Clicked += (sender, e) => Navigation.PopModalAsync();

            Content = new StackLayout
            {
                Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Children = {
                    lblTitle,
                    lblContent,
                    btnDismiss
                }
            };
		}
	}
}


