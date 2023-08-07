namespace PDFSample.Controls;

public class PdfViewer : View
{
    public static readonly BindableProperty SoureProperty =
            BindableProperty.Create(nameof(Source), typeof(string), typeof(PdfViewer), null);
    public string Source
    {
        get => (string)GetValue(SoureProperty);
        set => SetValue(SoureProperty, value);
    }
}