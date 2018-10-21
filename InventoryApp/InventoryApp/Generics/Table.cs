using SQLite;

namespace InventoryApp.Generics
{
    public abstract class Table
    {
        [PrimaryKey, AutoIncrement]
        public abstract int Id { get; protected set; }

        public Table()
        {
            Id = 0;
        }
    }
}
