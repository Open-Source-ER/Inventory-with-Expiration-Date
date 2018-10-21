using InventoryApp.Generics;
using SQLite;

namespace InventoryApp.Objects
{
    public class Item : Table
    {
        [PrimaryKey, AutoIncrement]
        public override int Id { get; protected set; }

        public int CategoryId { get; set; }
        // BARCODE to be added...
        public string Name { get; set; }
        public string Description { get; set; }

        public Item()
        {
            Id = 0;
        }

        public Item(int catId, string name, string des)
        {
            Id = 0;
            CategoryId = catId;
            Name = name;
            Description = des;
        }
    }
}
