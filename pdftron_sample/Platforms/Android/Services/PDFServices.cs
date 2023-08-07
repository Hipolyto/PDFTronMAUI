using pdftron.PDF.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFSample.Services
{
    public partial class PDFServices
    {
        public partial void OpenDocument(string uri)
        {
            var _uri = Android.Net.Uri.Parse(uri);
            // intent builder
            var intent = DocumentActivity.IntentBuilder
                .FromActivityClass(Platform.CurrentActivity, Java.Lang.Class.FromType(typeof(DocumentActivity)))
                .WithUri(_uri)
                .Build();
            Platform.CurrentActivity.StartActivity(intent);
        }
    }
}
