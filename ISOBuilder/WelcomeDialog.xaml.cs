using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ISOBuilder;
/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class WelcomeDialog : ContentDialog
{
    public WelcomeDialog()
    {
        this.InitializeComponent();
    }
    private async void ButtonWhatsNew_Click(object sender, ContentDialogButtonClickEventArgs e)
    {
        this.Hide();
        await new WhatsNewDialog().ShowAsync();
    }

    private void ButtonStartUsing_Click(ContentDialog sender, ContentDialogButtonClickEventArgs args)
    {
        this.Hide();
    }
}
