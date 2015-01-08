using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Sensors;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace DemoAccelerometre
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Accelerometer _accelerometer;
        private uint _desiredReportInterval;
        public MainPage()
        {
            this.InitializeComponent();

            _accelerometer = Accelerometer.GetDefault();
            if (_accelerometer != null)
            {
                // Select a report interval that is both suitable for the purposes of the app and supported by the sensor.
                // This value will be used later to activate the sensor.
                uint minReportInterval = _accelerometer.MinimumReportInterval;
                _desiredReportInterval = minReportInterval > 16 ? minReportInterval : 16;

                _accelerometer.ReadingChanged += new TypedEventHandler<Accelerometer, AccelerometerReadingChangedEventArgs>(ReadingChanged);
            }
            else
            {
                new MessageDialog("No accelerometer !!").ShowAsync();
            }
        }

        async private void ReadingChanged(object sender, AccelerometerReadingChangedEventArgs e)
        {
            await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => {
                AccelerometerReading reading = e.Reading;
                XValue.Text = String.Format("{0,5:0.00}", reading.AccelerationX);
                YValue.Text = String.Format("{0,5:0.00}", reading.AccelerationY);
                ZValue.Text = String.Format("{0,5:0.00}", reading.AccelerationZ);
            });
        }
        private void accelerometer_CurrentValueChanged(Accelerometer sender, AccelerometerReadingChangedEventArgs args)
        {
                
        }
    }
}
