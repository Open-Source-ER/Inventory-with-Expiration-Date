using System;
using System.IO;
using SQLite;
using Xamarin.Forms;
using InventoryApp.iOS.Persistance;
using InventoryApp.Persistance;

[assembly: Dependency(typeof(SQLiteDb))]

namespace InventoryApp.iOS.Persistance
{
    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "MySQLite.db3");

            return new SQLiteAsyncConnection(path);
        }
    }
}