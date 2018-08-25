using System.IO;
using SQLite;
using Xamarin.Forms;
using InventoryApp.Windows.Persistance;
using Windows.Storage;
using InventoryApp.Persistance;

[assembly: Dependency(typeof(SQLiteDb))]

namespace InventoryApp.Windows.Persistance
{
    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = ApplicationData.Current.LocalFolder.Path;
            var path = Path.Combine(documentsPath, "MySQLite.db3");
            return new SQLiteAsyncConnection(path);
        }
    }
}