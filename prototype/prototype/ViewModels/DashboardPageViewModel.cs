using Prism.Navigation;
using PropertyChanged;
using prototype.Services.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace prototype.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class DashboardPageViewModel : ViewModelBase
    {
        public string InventoryNews { get; set; }
        public string FunnyQuote { get; set; }
       

        public DashboardPageViewModel(INavigationService navigationService)
            :base(navigationService)
        {

        }
    }
}
