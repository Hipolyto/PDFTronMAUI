using System.Diagnostics;
using Android.Content;
using Android.Views;
using Android.Widget;
using AndroidX.CoordinatorLayout.Widget;
using AndroidX.Fragment.App;
using pdftron.PDF;
using pdftron.PDF.Config;
using pdftron.PDF.Tools;
using pdftron.PDF.Tools.Utils;
using pdftron.PDF.Widget.Preset.Component;
using pdftron.PDF.Widget.Toolbar.Component;

namespace PDFSample.Platforms.Android.Controls
{
    public class PdfDocumentViewer : CoordinatorLayout
    {
        Context _context;

        PDFViewCtrl mPdfViewCtrl;
        PDFDoc mPdfDoc;
        ToolManager mToolManager;
        AnnotationToolbarComponent mAnnotationToolbarComponent;
        PresetBarComponent mPresetBarComponent;
        FrameLayout mToolbarContainer;
        FrameLayout mPresetContainer;

        FragmentActivity mFragmentActivity;

        public PdfDocumentViewer(Context context) : base(context)
        {
            _context = context;

            try
            {
                SetupUserInterface();
                //SetupEventHandlers();


            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }
        void SetupUserInterface()
        {
            // Create a RelativeLayout for sizing the video
            RelativeLayout relativeLayout = new RelativeLayout(_context)
            {
                LayoutParameters = new CoordinatorLayout.LayoutParams(LayoutParams.MatchParent, LayoutParams.MatchParent)
                {
                    Gravity = (int)GravityFlags.Center
                }
            };
        }

    }
}
