using ExpensesMAUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesMAUI.Services.Interface
{
    public interface IExpensesService
    {
        Task<IEnumerable<Expense>> GetExpensesAsync();
        Task<Expense> GetExpenseById(int expenseID);
        Task AddExpenseAsync(Expense expense);
        Task RemoveExpenseAsync(int expenseID);
    }
}
