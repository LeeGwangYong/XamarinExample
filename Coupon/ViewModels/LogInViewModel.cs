using System;
using System.Windows.Input;//Using ICommand
using Xamarin.Forms;//Using Command
using Coupon.Views;
using System.Threading.Tasks;//using Task
using System.Diagnostics.Contracts;

namespace Coupon.ViewModels
{
    public class LogInViewModel : BaseViewModel
    {
        INavigation Navigation;
        Page CurrentPage;
        public LogInViewModel(INavigation Nav, Page Current)
        {
            Navigation = Nav;
            CurrentPage = Current;

            NavigateToMainView_Command = new Command(async () => await NavigateToMainView_Function());
        }

        #region Field
        private string userID { get; set; }
        public string UserID
        {
            get { return userID; }
            set
            {
                if (userID != value)
                {
                    userID = value;
                    NotifyPropertyChanged("userID");
                }
            }
        }
        private string userPW { get; set; }
        public string UserPW
        {
            get { return userPW; }
            set
            {
                if (userPW != value)
                {
                    userPW = value;
                    NotifyPropertyChanged("userPW");
                }
            }
        }
        #endregion

        #region Command
        public ICommand NavigateToMainView_Command { get; set; }
        private async Task NavigateToMainView_Function()
        {
            string temporal_ID = "Test@email.com";
            string temporal_PW = "test";
            if (string.IsNullOrWhiteSpace(userID) == false &&
               string.IsNullOrWhiteSpace(userPW) == false)
            {
				if (userID.Equals(temporal_ID) && userPW.Equals(temporal_PW))
				{
					App.LogInCheck = true;
                    Navigation.InsertPageBefore(new MainView(), CurrentPage);
					await Navigation.PopAsync();
				}
                else
				{
					await Application.Current.MainPage.DisplayAlert("Alert", "Incorrect User Information.\nPlease Retry", "OK");
                }

            }
            else
            {
				await Application.Current.MainPage.DisplayAlert("Alert", "You didn't input all of information.\nPlease Input ID or Password", "OK");
			}
        }
        #endregion

    }
}
