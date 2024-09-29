using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExpensesMAUI.Models;
using ExpensesMAUI.Services.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesMAUI.ViewModels
{
    public partial class CategoriesViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Category> categories;
        private readonly ICategoriesService categoriesService;

        [RelayCommand]
        private async Task AddCategory()
        {
            await Shell.Current.GoToAsync("AddCategoryPage");
        }

        public CategoriesViewModel(ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService ?? throw new ArgumentNullException(nameof(categoriesService));
            Categories = new ObservableCollection<Category>();
            GetCategories();
        }

        public void OnAppearing()
        {
            GetCategories();
        }

        private async void GetCategories()
        {
           IEnumerable<Category> categories = await categoriesService.GetCategoriesAsync();
            Categories.Clear();
            foreach (var category in categories)
            {
                Categories.Add(category);
            }
        }
    }
}
