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

                //线性布局（垂直/水平）
				new StackLayoutDemo (),
				new StackLayoutDemoCode (),

                //绝对定位布局
				new AbsoluteLayoutExploration (),
				new AbsoluteLayoutExplorationCode (),

				new AbsoluteLayoutDemoXaml (),
				new AbsoluteLayoutDemoCode (),

                //相对定位布局
				new RelativeLayoutExploration (),
				new RelativeLayoutExplorationCode (),

				new RelativeLayoutDemo (),
				new RelativeLayoutDemoCode (),

                //Grid网格布局
				new CalculatorGridXAML (),
				new CalculatorGridCode (),

                //混合布局（线性，网格，绝对）
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