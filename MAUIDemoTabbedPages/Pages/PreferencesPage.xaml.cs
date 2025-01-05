using MAUIDemoTabbedPages.ViewModels;

namespace MAUIDemoTabbedPages.Pages;

public partial class PreferencesPage : ContentPage
{
    public PreferencesPage(PreferencesViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    private async void OnBackToDefaultPageClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//DefaultPage");
    }
}