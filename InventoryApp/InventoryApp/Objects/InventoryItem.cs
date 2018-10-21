using InventoryApp.Generics;
using SQLite;
using System;

namespace InventoryApp.Objects
{
    public class InventoryItem : Table
    {
        [PrimaryKey, AutoIncrement]
        public override int Id { get; protected set; }

        public int  ItemId { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int Quantity { get; set; }

        public InventoryItem()
        {
            Id = 0;
        }

        public InventoryItem(int item, DateTime expDate, int qty)
        {
            Id = 0;
            ItemId = item;
            ExpirationDate = expDate;
            Quantity = qty;
        }
    }
}
