using System.Collections.Generic;

namespace InventoryApp.Objects
{
    public class Inventory
    {
        public string CategoryName { get; set; }
        public List<InventoryItem> InventoryItems { get; set; }

        public Inventory()
        {
            InventoryItems = new List<InventoryItem>();
        }

        public Inventory(string name, List<InventoryItem> inventoryList)
        {
            CategoryName = name;
            InventoryItems = inventoryList;
        }
    }
}
