using prototype.Enumerations;
using System;

namespace prototype.Models
{
    public class InventoryItem
    {
        public string Name { get; set; }
        public EInvenoryType ItemType { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int ExpirationDays { get; set; }
    }
}
