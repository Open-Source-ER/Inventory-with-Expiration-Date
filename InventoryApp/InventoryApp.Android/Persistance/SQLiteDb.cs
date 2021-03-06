﻿using System;
using System.IO;
using SQLite;
using Xamarin.Forms;
using InventoryApp.Persistance;
using InventoryApp.Droid.Persistance;

[assembly: Dependency(typeof(SQLiteDb))]

namespace InventoryApp.Droid.Persistance
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