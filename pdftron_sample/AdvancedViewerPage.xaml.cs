using System.Windows.Input;

namespace PDFSample;

public partial class AdvancedViewerPage : ContentPage
{
    public static readonly BindableProperty FileProperty =
            BindableProperty.Create(nameof(File), typeof(string), typeof(AdvancedViewerPage));

    public string File
    {
        get => (string)GetValue(FileProperty);
        set => SetValue(FileProperty, value);
    }

    public AdvancedViewerPage()
	{
        NavigationPage.SetHasNavigationBar(this, false);
        InitializeComponent();
	}
}