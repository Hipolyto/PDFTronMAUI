﻿using Microsoft.Extensions.Logging;
using PDFSample.Controls;
using PDFSample.Handlers;

namespace PDFSample;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureMauiHandlers((handlers) =>
			{
				handlers.AddHandler(typeof(PdfViewer), typeof(PdfViewerHandler));
                handlers.AddHandler(typeof(ViewerPage), typeof(ViewerPageHandler));
            })
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
