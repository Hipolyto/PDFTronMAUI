using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

namespace PDFSample.Handlers
{
    public class ViewerPageHandler : PageHandler
    {
        protected override ContentViewGroup CreatePlatformView()
        {
            return base.CreatePlatformView();
        }
        protected override void ConnectHandler(ContentViewGroup platformView)
        {
            base.ConnectHandler(platformView);
        }
    }
}
