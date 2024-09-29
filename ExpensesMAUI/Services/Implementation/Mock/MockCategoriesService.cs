using ExpensesMAUI.Models;
using ExpensesMAUI.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesMAUI.Services.Implementation.Mock
{
    public class MockCategoriesService : ICategoriesService
    {
        private List<Category> categories = new List<Category>
            {
                new Category { Id = 1, Name = "Housing", ExpensesPercentage = 0 },
                new Category { Id = 2, Name = "Debt",ExpensesPercentage = 0 },
                new Category { Id = 3, Name = "Health",ExpensesPercentage = 0 },
                new Category { Id = 4, Name = "Food",ExpensesPercentage = 0 },
                new Category { Id = 5, Name = "Personal",ExpensesPercentage = 0 },
                new Category { Id = 6, Name = "Travel",ExpensesPercentage = 0 },
                new Category { Id = 7, Name = "Other",ExpensesPercentage = 0 }
            };

        public Task AddCategoryAsync(Category category)
        {
            categories.Add(category);
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            await Task.Delay(100);
            return categories;
        }

        public Task GetCategoriesExpensesAsPercentage(Category category)
        {
            throw new NotImplementedException();
        }

        public async Task RemoveCategoryAsync(int categoryId)
        {
            List<Category>? categoriesList = await GetCategoriesAsync() as List<Category>;
            
            if(categoriesList != null)
            {
                categories = categoriesList;
                categories.Remove(categories[categoryId]);
            }
        }
    }
}
