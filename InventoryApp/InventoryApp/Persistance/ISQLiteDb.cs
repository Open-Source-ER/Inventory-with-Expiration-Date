using SQLite;

namespace InventoryApp.Persistance
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}