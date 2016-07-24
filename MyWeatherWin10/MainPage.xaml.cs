using MyWeather;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MyWeatherWin10
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        OpenWeatherMapService owms;

        public MainPage()
        {
            this.InitializeComponent();

            owms = new OpenWeatherMapService();
        }

        private async void btnGetWeather_Click(object sender, RoutedEventArgs e)
        {
            string location = txtLocation.Text.Trim();

            var wr = await owms.GetWeather(location);
            if (wr != null)
            {
                var weatherMessage = "The current temperature in {0} is {1}°F, with a high today of {2}°F and a low of {3}°F.";
                lblMessage.Text = string.Format(weatherMessage, wr.name, (int)wr.main.temp, (int)wr.main.temp_max, (int)wr.main.temp_min);
            }
        }
    }
}
