using System;
using System.ComponentModel; // using INotifyPropertyChagned
namespace Coupon.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public BaseViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        //OnPropertyChagned or NotifyPropertyChanged
        protected virtual void NotifyPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null){
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }    
        }    
    }
}
