using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using prototype.Models;
using prototype.Services.Database;
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
        IDatabaseManager DatabaseManager;

        public DelegateCommand NavigateToItemCommand { get; set; }
        public string SelectedItem { get; set; }

        public MainPageViewModel(INavigationService navigationService, IDatabaseManager databaseManager)
            : base(navigationService)
        {
            DatabaseManager = databaseManager;
            Pages = new ObservableCollection<string>();
            Pages.Add("Dashboard");
            Pages.Add("Items");

            NavigateToItemCommand = new DelegateCommand(Navigate);
        }

        public override async void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            await DatabaseManager.Init();
            var a = await DatabaseManager.Connection.Table<InventoryItem>().ToListAsync();
            await DatabaseManager.Connection.InsertAsync(new InventoryItem() { Name = "asd" });
        }

        async void Navigate()
        {
            await NavigationService.NavigateAsync(nameof(NavigationPage) + "/" + SelectedItem + "Page");
        }


    }
}
