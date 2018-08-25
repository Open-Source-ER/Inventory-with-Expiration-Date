using InventoryApp.Generics;
using SQLite;

namespace InventoryApp.Objects
{
    public class Category : Table
    {
        [PrimaryKey, AutoIncrement]
        public override int Id { get; protected set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public Category()
        {
            Id = 0;
        }

        public Category(string name, string des)
        {
            Id = 0;
            Name = name;
            Description = des;
        }
    }
}
