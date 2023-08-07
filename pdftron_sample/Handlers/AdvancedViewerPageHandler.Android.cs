using System;
using System.IO;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Handlers;
using Android.App;
using Android.Content;
using Android.Hardware;
using Android.Views;
using Android.Graphics;
using Android.Widget;
using pdftron.PDF.Tools;
using pdftron.PDF.Controls;
using pdftron.PDF.Tools.Utils;
using pdftron.PDF.Config;
using Android.Content.Res;
using FragmentActivity = AndroidX.Fragment.App.FragmentActivity;
using FragmentManager = AndroidX.Fragment.App.FragmentManager;
using static Android.Icu.Text.CaseMap;

namespace PDFSample.Droid
{
    /*
    public partial class AdvancedViewerPageHandler : PageHandler<AdvancedViewerPage, Android.Views.View>
    {
        private DocumentView mDocumentView;
        Activity activity;

        public AdvancedViewerPageHandler(DocumentView mDocumentView, Activity activity, IPropertyMapper mapper, CommandMapper commandMapper = null) : base(mapper, commandMapper)
        {
            this.mDocumentView = mDocumentView;
            this.activity = activity;
        }

        public AdvancedViewerPageHandler(DocumentView mDocumentView, Activity activity)
        {
            this.mDocumentView = mDocumentView;
            this.activity = activity;
        }

        async void DocumentView_OnNavButtonPressed(object sender, EventArgs e)
        {
            // ... aquí necesitarías una forma de realizar la navegación en Maui ...
        }

        private Android.Net.Uri GetFile()
        {
            //var file = Utils.CopyResourceToLocal(this.Context, Resource.Raw.sample, "sample", ".pdf");
            return Android.Net.Uri.FromFile(null);
        }

        private ViewerConfig GetConfig()
        {
            var toolmanagerBuilder = ToolManagerBuilder.From()
                .SetAutoSelect(true);
            var builder = new ViewerConfig.Builder();
            var config = builder
                .MultiTabEnabled(true)
                .FullscreenModeEnabled(false)
                .UseSupportActionBar(false)
                .ToolManagerBuilder(toolmanagerBuilder)
                //.SaveCopyExportPath(this.Context.FilesDir.AbsolutePath)
                .Build();
            return config;
        }

        protected override Android.Views.View CreatePlatformView()
        {
            activity = this.Context as Activity;

            var view = activity.LayoutInflater.Inflate(Resource.Layout.AdvancedViewerLayout, mDocumentView, false);
            mDocumentView = view.FindViewById<DocumentView>(Resource.Id.document_view);

            var context = this.Context;
            FragmentManager childManager = null;
            if (context is FragmentActivity)
            {
                var activity = context as FragmentActivity;
                var manager = activity.SupportFragmentManager;

                var fragments = manager.Fragments;
                if (fragments.Count > 0)
                {
                    childManager = fragments[0].ChildFragmentManager;
                }
                if (childManager != null)
                {
                    mDocumentView.OpenDocument(GetFile(), "", GetConfig(), childManager);
                }
            }

            mDocumentView.NavigationButtonPressed += DocumentView_OnNavButtonPressed;
            return view;
        }
    }
    */
}
