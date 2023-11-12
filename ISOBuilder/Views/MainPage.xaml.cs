using ISOBuilder.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace ISOBuilder.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }

    private void AppBarButton_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        this.Frame.Navigate(typeof(SettingsPage));
    }

    public async void OpenDialog()
    {
        WelcomeDialog dialog = new()
        {
            XamlRoot = this.XamlRoot
        };
        await dialog.ShowAsync();
    }
}
