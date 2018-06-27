using prototype.Enumerations;
using SQLite;
using System;

namespace prototype.Models
{
    [Table("InventoryItem")]
    public class InventoryItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public EInvenoryType ItemType { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int ExpirationDays { get; set; }
    }
}
