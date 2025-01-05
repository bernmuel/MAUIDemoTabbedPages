using MAUIDemoTabbedPages.ViewModels;

namespace MAUIDemoTabbedPages.Pages;

public partial class AboutPage : ContentPage
{
    public AboutPage(AboutViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    private async void OnBackToDefaultPageClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//DefaultPage");
    }
}