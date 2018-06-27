using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace prototype.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ObservableCollection<string> Pages { get; set; }

        public DelegateCommand NavigateToItemCommand { get; set; }
        public string SelectedItem { get; set; }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Pages = new ObservableCollection<string>();
            Pages.Add("Dashboard");
            Pages.Add("Items");

            NavigateToItemCommand = new DelegateCommand(Navigate);
        }


        async void Navigate()
        {
            await NavigationService.NavigateAsync(nameof(NavigationPage) + "/" + SelectedItem + "Page");
        }


    }
}
