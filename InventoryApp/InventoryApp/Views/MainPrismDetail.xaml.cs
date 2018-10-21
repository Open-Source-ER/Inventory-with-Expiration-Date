using InventoryApp.Objects;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InventoryApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPrismDetail : ContentPage
    {
        public MainPrismDetail(Inventory inventory)
        {
            InitializeComponent();

            Title = inventory.CategoryName;
            _listView.ItemsSource = inventory.InventoryItems;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as InventoryItem;

            if (item == null)
                return;

            // do thing
        }
    }
}