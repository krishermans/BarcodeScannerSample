using BarcodeScannerSample.Contracts;
using BarcodeScannerSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeScannerSample.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private IQrScanner _scannerService;

        public MainPageViewModel(IQrScanner scannerService)
        {
            this._scannerService = scannerService;
            ScanCommand = new Command(PerformScan);
        }
        
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

        private void PerformScan(object data)
        {
            System.Diagnostics.Debug.WriteLine("Doing the scan!");
            ScanResult result = _scannerService.Process(data);
            ScannedMessage = result.Value;
            CodeType = result.Type;
        }
    }
}
