namespace MAUIDemoTabbedPages.Pages;

public partial class DefaultPage : ContentPage
{
    public DefaultPage()
    {
        InitializeComponent();
    }

    private async void OnHomeButtonClicked(object sender, EventArgs e)
    {
        // Navigate to Home TabBar
        await Shell.Current.GoToAsync("//Home");
    }

    private async void OnSettingsButtonClicked(object sender, EventArgs e)
    {
        // Navigate to Settings TabBar
        await Shell.Current.GoToAsync("//Settings");
    }
}