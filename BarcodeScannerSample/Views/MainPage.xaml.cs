using BarcodeScannerSample.ViewModels;

namespace BarcodeScannerSample.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

        BindingContext = new MainPageViewModel();
	}

    private void CameraBarcodeReaderView_BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
    {
        Dispatcher.Dispatch(() =>
        {
            barcodeResult.Text = $"{e.Results[0].Value}";
            barcodeFormat.Text = $"{e.Results[0].Format}";
        });
    }
}

