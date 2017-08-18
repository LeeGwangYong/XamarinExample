ing System;

using Xamarin.Forms;

namespace Coupon.Views
{
    public class LogInView : ContentPage
    {
        public LogInView()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

