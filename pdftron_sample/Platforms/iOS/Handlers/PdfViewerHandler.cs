using Microsoft.Maui.Handlers;
using PDFSample.Controls;
using PDFSample.Platforms.iOS.Controls;

namespace PDFSample.Handlers
{
    public partial class PdfViewerHandler : ViewHandler<PdfViewer, PdfDocumentViewer>
    {
        protected override PdfDocumentViewer CreatePlatformView() => new PdfDocumentViewer();
        protected override void ConnectHandler(PdfDocumentViewer platformView)
        {
            base.ConnectHandler(platformView);
        }
        protected override void DisconnectHandler(PdfDocumentViewer platformView)
        {
            PlatformView?.Dispose();
            base.DisconnectHandler(platformView);
        }
        public static void MapSource(PdfViewerHandler handler, PdfDocumentViewer pdfDocumentViewer)
        {

        }
    }
}
