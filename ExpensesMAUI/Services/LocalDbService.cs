using ExpensesMAUI.Models;
using ExpensesMAUI.Services.Interface;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesMAUI.Services
{
    public class LocalDbService : ISqliteDb
    {
        private const string DB_NAME = "expensesDB.db3";

        public LocalDbService()
        {

        }

        public SQLiteAsyncConnection GetConnection()
        {
            return new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DB_NAME));
        }
    }
}
