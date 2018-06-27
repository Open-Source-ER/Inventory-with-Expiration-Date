using prototype.Models;
using prototype.Services.FileProvider;
using System.Threading.Tasks;

namespace prototype.Services.Database
{
    public class DatabaseManager : IDatabaseManager
    {
        public SQLite.SQLiteAsyncConnection Connection { get; set; }
        IFileProvider FileProvider;

        public DatabaseManager(IFileProvider fileProvider)
        {
            FileProvider = fileProvider;
            Connection = new SQLite.SQLiteAsyncConnection(FileProvider.GetLocalFilePath("db.db"));
        }

        public async Task Init()
        {
            await Connection.CreateTableAsync<InventoryItem>();
        }

    }
}
