using Xamarin.Forms;
using InventoryApp.Objects;
using Xamarin.Forms.Xaml;
using InventoryApp.Persistance;
using System.Collections.ObjectModel;

namespace InventoryApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPrismMaster : MasterDetailPage
    {
        private DbManager _connection;
        private ObservableCollection<Inventory> _inventory;

        public MainPrismMaster()
        {
            InitializeComponent();

            _connection = new DbManager();
            _inventory = new ObservableCollection<Inventory>();
        }

        protected override async void OnAppearing()
        {
            await _connection.ConnectAsync();

            var categories = await _connection.LoadCategoriesAsync();

            foreach (Category category in categories)
            {
                _inventory.Add(new Inventory(category.Name, await _connection.LoadInventoyItemsAsync(category.Id)));
            }

            base.OnAppearing();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Inventory;

            if (item == null)
                return;

            Detail = new NavigationPage(new MainPrismDetail(item));
            IsPresented = false;
        }
    }
}