using Microsoft.Maui.Handlers;
using PDFSample.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFSample.Handlers
{
    public partial class PdfViewerHandler
    {
        public static PropertyMapper<PdfViewer, PdfViewerHandler> PropertyMapper = new(ViewHandler.ViewMapper)
        {
            [nameof(PdfViewer.Source)] = MapSource
        };
        public PdfViewerHandler() : base(PropertyMapper)
        {
        }
    }
}
