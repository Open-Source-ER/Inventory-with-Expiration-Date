using InventoryApp.Generics;
using InventoryApp.Objects;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace InventoryApp.Persistance
{
    class DbManager
    {
        private SQLiteAsyncConnection _connection;

        public DbManager()
        {
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
        }

        public async Task ConnectAsync()
        {
            await _connection.CreateTableAsync<Category>();
            await _connection.CreateTableAsync<CategoryAlert>();
            await _connection.CreateTableAsync<InventoryItem>();
            await _connection.CreateTableAsync<Item>();
        }

        // SELECT (Categories)
        public async Task<List<Category>> LoadCategoriesAsync()
        {
            return await _connection.QueryAsync<Category>("SELECT * FROM Category");
        }

        // SELECT (Inventory items)
        public async Task<List<InventoryItem>> LoadInventoyItemsAsync(int categoryId)
        {
            var inventoryItems = new List<InventoryItem>();
            var items = await LoadItemsAsync(categoryId);
            
            foreach (InventoryItem item in items)
            {
                inventoryItems.AddRange(await _connection.QueryAsync<InventoryItem>("SELECT * FROM InventoryItem WHERE ItemId = ?", item.Id));
            }

            return inventoryItems;
        }

        // SELECT (Possible items)
        public async Task<List<InventoryItem>> LoadItemsAsync()
        {
            return await _connection.QueryAsync<InventoryItem>("SELECT * FROM Item");
        }

        public async Task<List<InventoryItem>> LoadItemsAsync(int categoryId)
        {
            return await _connection.QueryAsync<InventoryItem>("SELECT * FROM Item WHERE CategoryId = ?", categoryId);
        }

        // INSERT / UPDATE
        public async Task<bool> SaveAsync(Table tableItem)
        {
            if (tableItem.Id != 0)
            {
                await _connection.UpdateAsync(tableItem);
                return true;
            }
            else
            {
                await _connection.InsertAsync(tableItem);
                return false;
            }
        }

        // DELETE
        public async Task DeleteAsync(Table tableItem)
        {
            // tried to make dynamic, but could not get type in runtime.

            var tableName = tableItem.GetType().Name;

            if (tableItem is Category)
            {
                if (tableItem.Id != 0)
                    await _connection.QueryAsync<Category>("DELETE FROM ? WHERE Id = ?", tableName, tableItem.Id);
            }
            else if (tableItem is CategoryAlert)
            {
                if (tableItem.Id != 0)
                    await _connection.QueryAsync<CategoryAlert>("DELETE FROM ? WHERE Id = ?", tableName, tableItem.Id);
            }
            else if (tableItem is InventoryItem)
            {
                if (tableItem.Id != 0)
                    await _connection.QueryAsync<InventoryItem>("DELETE FROM ? WHERE Id = ?", tableName, tableItem.Id);
            }
            else if (tableItem is Item)
            {
                if (tableItem.Id != 0)
                    await _connection.QueryAsync<Item>("DELETE FROM ? WHERE Id = ?", tableName, tableItem.Id);
            }
        }
    }
}
