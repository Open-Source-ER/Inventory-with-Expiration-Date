using Prism.Navigation;
using PropertyChanged;
using prototype.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace prototype.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class ItemsPageViewModel : ViewModelBase
    {
        public ObservableCollection<InventoryGroup> _items;
        public ObservableCollection<InventoryGroup> Items
        {
            get => _items;
            set
            {
                _items = value;
                RaisePropertyChanged();
            }
        }
        private List<InventoryItem> data;
        public ItemsPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            data = new List<InventoryItem>();
            for (int i = 0; i < 10; i++)
                data.Add(new InventoryItem() { ItemType = Enumerations.EInvenoryType.Electricity, Name = "item" });
            for (int i = 0; i < 10; i++)
                data.Add(new InventoryItem() { ItemType = Enumerations.EInvenoryType.Food, Name = "item" });
            for (int i = 0; i < 10; i++)
                data.Add(new InventoryItem() { ItemType = Enumerations.EInvenoryType.Water, Name = "item" });
            GroupByType();
        }

        #region Load
        public void GroupByType()
        {
            Items = new ObservableCollection<InventoryGroup>();
            var a = data.GroupBy(x => x.ItemType).ToList();
            foreach (var item in a)
            {
                Items.Add(new InventoryGroup(item.Key.ToString(), new ObservableCollection<InventoryItem>(item.ToList())));
            }
        }
        #endregion
    }
}
