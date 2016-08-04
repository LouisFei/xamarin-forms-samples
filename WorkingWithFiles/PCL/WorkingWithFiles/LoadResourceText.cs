using System;
using Xamarin.Forms;
using System.Reflection;
using System.IO;

namespace WorkingWithFiles
{
	public class LoadResourceText : ContentPage 
	{
		public LoadResourceText ()
		{
			var editor = new Label { Text = "loading...", HeightRequest = 300};

			#region How to load a text file embedded resource  嵌入的txt文本资源
			var assembly = typeof(LoadResourceText).GetTypeInfo().Assembly;
			Stream stream = assembly.GetManifestResourceStream("WorkingWithFiles.PCLTextResource.txt");
            //注意文件名格式：程序集名称.目录名称.文件名称  （几部分以点号相连）。

			string text = "";
			using (var reader = new System.IO.StreamReader (stream)) {
				text = reader.ReadToEnd ();
			}
			#endregion

			editor.Text = text;

			Content = new StackLayout {
				Padding = new Thickness (0, 20, 0, 0),
				VerticalOptions = LayoutOptions.StartAndExpand,
				Children = {
					new Label { Text = "Embedded Resource Text File (PCL)", 
						FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
						FontAttributes = FontAttributes.Bold
					},
                    editor
				}
			};

			// NOTE: use for debugging, not in released app code!
			//foreach (var res in assembly.GetManifestResourceNames()) 
			//	System.Diagnostics.Debug.WriteLine("found resource: " + res);
		}
	}
}

