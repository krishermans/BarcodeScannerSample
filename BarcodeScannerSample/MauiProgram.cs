using BarcodeScannerSample.Contracts;
using BarcodeScannerSample.Services;
using BarcodeScannerSample.ViewModels;
using BarcodeScannerSample.Views;
using CommunityToolkit.Maui;
using ZXing.Net.Maui;

namespace BarcodeScannerSample;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .UseBarcodeReader()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		RegisterDependencies(builder.Services);

		return builder.Build();
	}

    private static void RegisterDependencies(IServiceCollection services)
    {
		services.AddTransient<MainPage>();
		services.AddTransient<MainPageViewModel>();
		services.AddTransient<IQrScanner, QrScannerService>();
    }
}
