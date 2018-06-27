using System.Threading.Tasks;

namespace prototype.Services.Database
{
    public interface IDatabaseManager
    {
        SQLite.SQLiteAsyncConnection Connection { get; set; }
        Task Init();
    }
}
