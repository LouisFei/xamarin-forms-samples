using System;
using Xamarin.Forms;

namespace WorkingWithFiles
{
	public class App : Application // superclass new in 1.3
	{
		public App ()
		{
			var tabs = new TabbedPage ();

            //读取嵌入的文本资源
			tabs.Children.Add (new LoadResourceText {Title = "Resource", Icon = "txt.png" });
			tabs.Children.Add (new LoadResourceXml {Title = "Resource", Icon = "xml.png"});
			tabs.Children.Add(new LoadResourceJson { Title = "Resource", Icon = "json.png" });

            //读取本地资源
			tabs.Children.Add (new SaveAndLoadText {Title = "Save/Load", Icon = "saveload.png"});

			MainPage = tabs;
		}
	}
}

