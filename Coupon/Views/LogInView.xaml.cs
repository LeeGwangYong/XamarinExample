using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Coupon.ViewModels;
namespace Coupon.Views
{
    public partial class LogInView : ContentPage
    {
        LogInViewModel viewModel;   
        public LogInView()
        {
            InitializeComponent();
            viewModel = new LogInViewModel(Navigation, this);
            this.BindingContext = viewModel;
        }
    }
}
