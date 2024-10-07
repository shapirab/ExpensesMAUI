using ExpensesMAUI.Models;
using ExpensesMAUI.Services.Interface;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesMAUI.Services.Implementation
{
    public class ExpenseService : IExpensesService
    {
        private readonly SQLiteAsyncConnection _connection;
        public ExpenseService(ISqliteDb db)
        {
            _connection = db.GetConnection();
            _connection.CreateTableAsync<Expense>();
        }

        public async Task AddExpenseAsync(Expense expense)
        {
            await _connection.InsertAsync(expense);
        }

        public async Task<IEnumerable<Expense>> GetExpensesAsync()
        {
            return await _connection.Table<Expense>().ToListAsync();
        }

        public async Task<Expense> GetExpenseById(int expenseID)
        {
            return await _connection.Table<Expense>().Where(expense => expense.Id == expenseID).FirstOrDefaultAsync();
        }

        public async Task RemoveExpenseAsync(int expenseID)
        {
            await _connection.DeleteAsync(expenseID);
        }
    }
}
