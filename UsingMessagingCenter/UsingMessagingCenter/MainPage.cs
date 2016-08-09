using System;
using Xamarin.Forms;

namespace UsingMessagingCenter
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            BindingContext = new MainPageViewModel();

            //https://developer.xamarin.com/guides/xamarin-forms/messaging-center/
            // Send messages when buttons are pressed
            var button1 = new Button { Text = "Say Hi" };
            button1.Clicked += (sender, e) =>
            {
                //发送命名消息，但没有消息参数
                MessagingCenter.Send<MainPage>(this, "Hi");
            };

            var button2 = new Button { Text = "Say Hi to John" };
            button2.Clicked += (sender, e) =>
            {
                //发送命名消息，并附上指定消息参数
                MessagingCenter.Send<MainPage, string>(this, "Hi", "John");
            };

            var button3 = new Button { Text = "Unsubscribe from alert" };
            button3.Clicked += (sender, e) =>
            {
                //取消消息订阅
                MessagingCenter.Unsubscribe<MainPage, string>(this, "Hi");

                DisplayAlert("Unsubscribed",
                    "This page has stopped listening, so no more alerts; however the ViewModel is still receiving messages.",
                    "OK");
            };

            // 订阅消息
            // Subscribe to a message (which the ViewModel has also subscribed to) to pop up an Alert
            MessagingCenter.Subscribe<MainPage, string>(this, "Hi", (sender, arg) =>
            {
                DisplayAlert("Message Received", "arg=" + arg, "OK");
            });

            var listView = new ListView();
            listView.SetBinding(ListView.ItemsSourceProperty, "Greetings");

            Content = new StackLayout
            {
                Padding = new Thickness(0, 20, 0, 0),
                Children = {
                    button1,
                    button2,
                    button3,
                    listView }
            };
        }
    }
}

