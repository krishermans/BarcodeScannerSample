using BarcodeScannerSample.Models;

namespace BarcodeScannerSample.Contracts;

public interface IQrScanner
{
    ScanResult Process(object data);
}
