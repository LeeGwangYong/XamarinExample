using Xamarin.Forms;
using Coupon.Views;

namespace Coupon
{
    public partial class App : Application
    {
        public static bool LogInCheck { get; set; }
        public App()
        {
            InitializeComponent();

            if (LogInCheck == false){
                MainPage = new NavigationPage(new LogInView());
			}
            else{
                MainPage = new NavigationPage(new Coupon.Views.MainView());
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
