using ExpensesMAUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesMAUI.Services.Interface
{
    public interface ICategoriesService
    {
        Task<IEnumerable<Category>> GetCategoriesAsync();
        Task AddCategoryAsync(Category category);
        Task RemoveCategoryAsync(int categoryId);
        Task GetCategoriesExpensesAsPercentage(Category category);
    }
}
