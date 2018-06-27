using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace prototype.Models
{
        public class InventoryGroup : ObservableCollection<InventoryItem>
        {
            public string Title { get; set; }

            public InventoryGroup(string title, IList<InventoryItem> items) : base(items)
            {
                Title = title;
            }
    }
}
