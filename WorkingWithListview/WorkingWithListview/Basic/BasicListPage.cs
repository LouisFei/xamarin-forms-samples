using System;
using Xamarin.Forms;
using System.Diagnostics;

namespace WorkingWithListview
{
	/// <summary>
	/// Very simple example of a ListView, demonstrating how to 'unselect'
	/// the row after tapping 
    /// 非常简单的一个ListView示例，演示如何在行被选中后，取消选中状态。
	/// </summary>
	public class BasicListPage : ContentPage
	{
		public BasicListPage ()
		{
			var listView = new ListView ();

			listView.ItemsSource = new [] { "a", "b", "c", "d" };

			// Using ItemTapped
			listView.ItemTapped += async (sender, e) => {
				await DisplayAlert("Tapped", e.Item + " row was tapped", "OK");
				Debug.WriteLine("Tapped: " + e.Item);
				//((ListView)sender).SelectedItem = null; // de-select the row
			};

            // If using ItemSelected
            listView.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null) return;
                await DisplayAlert("Selected", e.SelectedItem + " row was selected", "OK");
                Debug.WriteLine("Selected: " + e.SelectedItem);
                //((ListView)sender).SelectedItem = null; // de-select the row
            };

            // 发现ItemTapped事件和ItemSelected事件有以下几点区别：
            // 1、ItemTrapped事件会优先被触发。
            // 2、当选中一个当前已经被选中的Item时，不会触发ItemSelected事件，只会触发ItemTrapped事件。

            Padding = new Thickness (0,20,0,0);
			Content = listView;
		}
	}
}
