using BarcodeScannerSample.Contracts;
using BarcodeScannerSample.Models;
using ZXing.Net.Maui;

namespace BarcodeScannerSample.Services;

public class QrScannerService : IQrScanner
{
    public ScanResult Process(object data)
    {
        if (data is BarcodeDetectionEventArgs)
        {
            BarcodeDetectionEventArgs e = (BarcodeDetectionEventArgs)data;
            return new ScanResult
            {
                Value = $"{e.Results[0].Value}",
                Type = $"{e.Results[0].Format}"
            };
        };
        return new ScanResult
        {
            Value = "Nothing to process!",
            Type = ""
        };
    }
}
