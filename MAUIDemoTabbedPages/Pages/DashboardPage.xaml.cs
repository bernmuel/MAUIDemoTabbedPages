using MAUIDemoTabbedPages.ViewModels;

namespace MAUIDemoTabbedPages.Pages;

public partial class DashboardPage : ContentPage
{
    public DashboardPage(DashboardViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    private async void OnBackToDefaultPageClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//DefaultPage");
    }
}