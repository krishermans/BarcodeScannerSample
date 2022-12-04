using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeScannerSample.ViewModels
{
    internal class MainPageViewModel : BaseViewModel
    {
        private string _scannedMessage = "<<Scan the code>>";
        public string ScannedMessage
        { 
            get => _scannedMessage;
            set => SetProperty(ref _scannedMessage, value);
        }

        private string _codeType = string.Empty;
        public string CodeType
        {
            get => _codeType;
            set => SetProperty(ref _codeType, value);
        }

        public Command ScanCommand { get;  }

        public MainPageViewModel()
        {
            ScanCommand = new Command(PerformScan);
        }

        private void PerformScan(object args)
        {
            System.Diagnostics.Debug.WriteLine("Doing the scan!");
            if (args is ZXing.Net.Maui.BarcodeDetectionEventArgs)
            {
                var e = (ZXing.Net.Maui.BarcodeDetectionEventArgs)args;
                ScannedMessage = $"{e.Results[0].Value}";
                CodeType = $"{e.Results[0].Format}";
            }
        }
    }
}
