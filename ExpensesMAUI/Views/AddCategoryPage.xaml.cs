using ExpensesMAUI.ViewModels;

namespace ExpensesMAUI.Views;

public partial class AddCategoryPage : ContentPage
{
	public AddCategoryPage(AddCategoryViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}