using ExpensesMAUI.Views;

namespace ExpensesMAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("CategoriesPage", typeof(CategoriesPage));
            Routing.RegisterRoute("ExpensesPage", typeof(ExpensesPage));
            Routing.RegisterRoute("AddCategoryPage", typeof(AddCategoryPage));
            Routing.RegisterRoute("AddExpensePage", typeof(AddExpensePage));
        }
    }
}
