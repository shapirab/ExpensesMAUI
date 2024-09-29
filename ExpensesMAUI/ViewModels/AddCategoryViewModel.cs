using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExpensesMAUI.Models;
using ExpensesMAUI.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesMAUI.ViewModels
{
    public partial class AddCategoryViewModel : ObservableObject
    {
        [ObservableProperty]
        private Category category;
        private readonly ICategoriesService categoriesService;

        public AddCategoryViewModel(ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService ?? throw new ArgumentNullException(nameof(categoriesService));
            Category = new Category();
        }

        [RelayCommand]
        private async Task AddCategoryToDB()
        {
            await categoriesService.AddCategoryAsync(Category);
            //You cannot navigate to a page already in the stack by name, only by using ..
            //See https://stackoverflow.com/questions/73547988/maui-relative-routing-to-shell-elements-is-currently-not-supported
            await Shell.Current.GoToAsync("..");
        }
    }
}
