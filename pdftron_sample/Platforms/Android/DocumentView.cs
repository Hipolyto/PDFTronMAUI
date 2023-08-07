using Android.Content;
using Android.Util;
using Uri=Android.Net.Uri;
using AndroidX.Fragment.App;
using pdftron.PDF.Config;

namespace PDFSample.Platforms.Android
{
    public class DocumentView : pdftron.PDF.Controls.DocumentView2
    {
        private static string TAG = "DocumentView";
        public event System.EventHandler NavigationButtonPressed;
        public DocumentView(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            Initialize();
        }
        public DocumentView(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
            Initialize();
        }
        private void Initialize()
        {
        }
        public void OpenDocument(Uri documentUri, string password, ViewerConfig config, FragmentManager manager)
        {
            base.SetDocumentUri(documentUri);
            base.SetPassword(password);
            base.SetViewerConfig(config);
            base.SetSupportFragmentManager(manager);
        }
        public override void OnNavButtonPressed()
        {
            base.OnNavButtonPressed();

            NavigationButtonPressed?.Invoke(this, new System.EventArgs());
        }
        public override bool CanShowFileInFolder()
        {
            return false;
        }
        public override bool CanShowFileCloseSnackbar()
        {
            return false;
        }
        public override bool CanRecreateActivity()
        {
            return false;
        }
        public override void OnLastTabClosed()
        {
            base.OnLastTabClosed();

            NavigationButtonPressed?.Invoke(this, new System.EventArgs());
        }
    }
}
