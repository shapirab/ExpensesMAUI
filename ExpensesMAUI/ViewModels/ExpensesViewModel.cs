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
    public partial class ExpensesViewModel : ObservableObject
    {
        private readonly IExpensesService expensesService;
        [ObservableProperty]
        ObservableCollection<Expense> expenses;

        public ExpensesViewModel(IExpensesService expensesService)
        {
            this.expensesService = expensesService ?? throw new ArgumentNullException(nameof(expensesService));
            Expenses = new ObservableCollection<Expense>();
        }

        public void OnAppearing()
        {
            GetExpenses();
        }


        [RelayCommand]
        private async Task AddExpense()
        {
            await Shell.Current.GoToAsync("AddExpensePage");
        }
        [RelayCommand]
        private async Task Back()
        {
            await Shell.Current.GoToAsync("CategoriesPage");
        }

        private async void GetExpenses()
        {
            var expensesList = await expensesService.GetExpensesAsync();
            
            Expenses.Clear();
            foreach(var expense in expensesList)
            {
                Expenses.Add(expense);
            }
        }
    }
}
