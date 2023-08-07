using Microsoft.Maui.Handlers;
using PDFSample.Controls;
using PDFSample.Platforms.Android.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFSample.Handlers
{
    public partial class PdfViewerHandler : ViewHandler<PdfViewer, PdfDocumentViewer>
    {
        protected override PdfDocumentViewer CreatePlatformView() => new PdfDocumentViewer(Context);
        protected override void ConnectHandler(PdfDocumentViewer platformView)
        {
            base.ConnectHandler(platformView);
        }
        protected override void DisconnectHandler(PdfDocumentViewer platformView)
        {
            PlatformView?.Dispose();
            base.DisconnectHandler(platformView);
        }
        public static void MapSource(PdfViewerHandler handler, PdfViewer pdfDocumentViewer)
        {
            
        }
    }
}
