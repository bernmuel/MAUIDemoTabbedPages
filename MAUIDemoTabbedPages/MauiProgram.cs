using MAUIDemoTabbedPages.Pages;
using MAUIDemoTabbedPages.ViewModels;
using Microsoft.Extensions.Logging;

namespace MAUIDemoTabbedPages
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

            // Register DefaultPage
            builder.Services.AddTransient<DefaultPage>();

            // Register Tab Pages
            builder.Services.AddTransient<DashboardPage>();
            builder.Services.AddTransient<ReportsPage>();
            builder.Services.AddTransient<PreferencesPage>();
            builder.Services.AddTransient<AboutPage>();

            // Register ViewModels
            builder.Services.AddTransient<DashboardViewModel>();
            builder.Services.AddTransient<ReportsViewModel>();
            builder.Services.AddTransient<PreferencesViewModel>();
            builder.Services.AddTransient<AboutViewModel>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
