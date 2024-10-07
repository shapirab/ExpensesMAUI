using ExpensesMAUI.Services;
using ExpensesMAUI.Services.Implementation;
using ExpensesMAUI.Services.Implementation.Mock;
using ExpensesMAUI.Services.Interface;
using ExpensesMAUI.ViewModels;
using ExpensesMAUI.Views;
using Microsoft.Extensions.Logging;

namespace ExpensesMAUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            builder.Services.AddSingleton<CategoriesPage>();
            builder.Services.AddSingleton<AddCategoryPage>();
            builder.Services.AddSingleton<ExpensesPage>();
            builder.Services.AddSingleton<AddExpensePage>();

            builder.Services.AddSingleton<CategoriesViewModel>();
            builder.Services.AddSingleton<AddCategoryViewModel>();

            builder.Services.AddScoped<ICategoriesService, CategoryService>();
            builder.Services.AddScoped<IExpensesService, ExpenseService>();
            builder.Services.AddScoped<ISqliteDb, LocalDbService>();


#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
