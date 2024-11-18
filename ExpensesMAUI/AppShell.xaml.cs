using ExpensesMAUI.Views;

namespace ExpensesMAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(CategoriesPage), typeof(CategoriesPage));
            Routing.RegisterRoute(nameof(ExpensesPage), typeof(ExpensesPage));
            Routing.RegisterRoute(nameof(AddCategoryPage), typeof(AddCategoryPage));
            Routing.RegisterRoute(nameof(AddExpensePage), typeof(AddExpensePage));
        }
    }
}
