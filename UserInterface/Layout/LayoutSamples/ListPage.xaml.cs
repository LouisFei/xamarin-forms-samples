using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LayoutSamples
{
	public partial class ListPage : ContentPage
	{
		public ListPage ()
		{
			InitializeComponent ();

			List<Page> listOfPages = new List<Page> () {
				new StackLayoutDemo (),
				new StackLayoutDemoCode (),

				new AbsoluteLayoutExploration (),
				new AbsoluteLayoutExplorationCode (),

				new AbsoluteLayoutDemoXaml (),
				new AbsoluteLayoutDemoCode (),

				new RelativeLayoutExploration (),
				new RelativeLayoutExplorationCode (),

				new RelativeLayoutDemo (),
				new RelativeLayoutDemoCode (),

				new CalculatorGridXAML (),
				new CalculatorGridCode (),
				new MonkeyMoneyXaml (),
				new MonkeyMoneyCode (),
				new MonkeyMusic (),
				new MonkeyMusicCode (),
				new GridExploration (),
				new LabelGridXaml (),
				new LabelGridCode (),
				new ScrollingDemoXAML (),
				new ScrollingDemoCode ()
			};

			listPages.ItemsSource = listOfPages;
			listPages.ItemSelected += ListPages_ItemSelected;
		}

		void ListPages_ItemSelected (object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem != null) {
				this.Navigation.PushAsync ((Page)e.SelectedItem);
			}
			listPages.SelectedItem = null;
		}
	}
}