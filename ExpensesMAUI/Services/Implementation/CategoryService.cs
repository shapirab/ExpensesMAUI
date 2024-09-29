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
    public class CategoryService : ICategoriesService
    {
        private readonly SQLiteAsyncConnection _connection;
        public CategoryService(ISqliteDb db)
        {
            _connection = db.GetConnection();
            _connection.CreateTableAsync<Category>();
        }

        public async Task AddCategoryAsync(Category category)
        {
            await _connection.InsertAsync(category);
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await _connection.Table<Category>().ToListAsync();
        }

        public Task GetCategoriesExpensesAsPercentage(Category category)
        {
            throw new NotImplementedException();
        }

        public async Task RemoveCategoryAsync(int categoryId)
        {
            await _connection.DeleteAsync(categoryId);
        }
    }
}
