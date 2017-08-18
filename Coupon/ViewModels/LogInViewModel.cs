using System;
using System.Windows.Input;//Using ICommand
using Xamarin.Forms;//Using Command
using Coupon.Views;
using System.Threading.Tasks;//using Task

namespace Coupon.ViewModels
{
    public class LogInViewModel
    {
        INavigation Navigation;
        Page CurrentPage;
        public LogInViewModel(INavigation Nav, Page Current)
        {
            Navigation = Nav;
            CurrentPage = Current;

            NavigateToMainView_Command = new Command(async ()=> await NavigateToMainView_Function());
        }
        public ICommand NavigateToMainView_Command{get; set;}
        private async Task NavigateToMainView_Function()
        {
            App.LogInCheck = true;
            await Navigation.PushAsync(new MainView());
            //Navigation.InsertPageBefore(new MainView(), CurrentPage);
            await Navigation.PopAsync();
        }
    }
}
