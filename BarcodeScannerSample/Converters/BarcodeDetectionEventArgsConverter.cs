using BarcodeScannerSample.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing.Net.Maui;

namespace BarcodeScannerSample.Converters
{
    internal class BarcodeDetectionEventArgsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is null) return null;
            if (value is BarcodeDetectionEventArgs)
            {
                var eventArgs = value as BarcodeDetectionEventArgs;
                return new ScanResult
                {
                    Value = eventArgs.Results[0].Value,
                    Type = eventArgs.Results[0].Format.ToString()
                };
            }
            return null;
        }
    }
}
