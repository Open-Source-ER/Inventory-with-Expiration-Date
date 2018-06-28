﻿using Prism.Commands;
using Prism.Navigation;
using prototype.Models;
using prototype.Services.Database;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace prototype.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ObservableCollection<string> Pages { get; set; }
        IDatabaseManager DatabaseManager;

        public DelegateCommand<object> NavigateToItemCommand { get; set; }
        public string SelectedItem { get; set; }

        public MainPageViewModel(INavigationService navigationService, IDatabaseManager databaseManager)
            : base(navigationService)
        {
            DatabaseManager = databaseManager;
            Pages = new ObservableCollection<string>();
            Pages.Add("Items");

            NavigateToItemCommand = new DelegateCommand<object>(Navigate);
        }

        public override async void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            await DatabaseManager.Init();
            var a = await DatabaseManager.Connection.Table<InventoryItem>().ToListAsync();
            await DatabaseManager.Connection.InsertAsync(new InventoryItem() { Name = "asd" });
        }

        async void Navigate(object parameter)
        {
            await NavigationService.NavigateAsync(nameof(NavigationPage) + "/" + parameter + "Page");
        }


    }
}
