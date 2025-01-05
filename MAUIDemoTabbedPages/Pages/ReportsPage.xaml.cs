using MAUIDemoTabbedPages.ViewModels;

namespace MAUIDemoTabbedPages.Pages;

public partial class ReportsPage : ContentPage
{
    public ReportsPage(ReportsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    private async void OnBackToDefaultPageClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//DefaultPage");
    }
}