using AndroidX.Annotations;
using PDFSample.Services;

namespace PDFSample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}
    private async void OnOpenLinkButtonClicked(object sender, EventArgs e)
    {
        var filepath = await GetPackageFile("sample.pdf");
        PDFServices.Instance.OpenDocument(filepath);
    }
    private async void OnOpenViewerButtonClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new ViewerPage());
    }
    private async void OnOpenAdvancedViewerButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AdvancedViewerPage());
    }
    public async Task<string> GetPackageFile(string filename)
    {
        string targetFile = Path.Combine(FileSystem.Current.CacheDirectory, filename);
        if(!File.Exists(targetFile))
        {
            using Stream inputStream = await FileSystem.Current.OpenAppPackageFileAsync(filename);
            using FileStream outputStream = File.Create(targetFile);
            await inputStream.CopyToAsync(outputStream);
        }
        return targetFile;
    }
}

