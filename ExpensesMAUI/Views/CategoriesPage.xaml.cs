using ExpensesMAUI.ViewModels;

namespace ExpensesMAUI.Views;

public partial class CategoriesPage : ContentPage
{
    private readonly CategoriesViewModel vm;

    public CategoriesPage(CategoriesViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
        this.vm = vm;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        vm.OnAppearing();
    }
}