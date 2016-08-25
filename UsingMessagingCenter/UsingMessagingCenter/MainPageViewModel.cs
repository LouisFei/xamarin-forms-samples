using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace UsingMessagingCenter
{
	public class MainPageViewModel
	{
        public ObservableCollection<string> Greetings { get; set; }
        //public List<string> Greetings { get; set; }

        public MainPageViewModel ()
		{
            Greetings = new ObservableCollection<string>();
            //Greetings = new List<string>();

            //https://developer.xamarin.com/guides/xamarin-forms/messaging-center/
            //订阅消息
            MessagingCenter.Subscribe<MainPage> (this, "Hi", (sender) => {
				Greetings.Add("Hi");
			});

            //订阅消息
			MessagingCenter.Subscribe<MainPage, string> (this, "Hi", (sender, arg) => {
				Greetings.Add("Hi " + arg);
			});
		}
	}
}

