using ExpensesMAUI.ViewModels;

namespace ExpensesMAUI.Views;

public partial class ExpensesPage : ContentPage
{
    private readonly ExpensesViewModel vm;

    public ExpensesPage(ExpensesViewModel vm)
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