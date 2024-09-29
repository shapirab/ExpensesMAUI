using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesMAUI.Services.Interface
{
    public interface ISqliteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
