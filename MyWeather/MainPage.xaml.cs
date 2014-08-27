using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MyWeather.Resources;

namespace MyWeather
{
    public partial class MainPage : PhoneApplicationPage
    {
        OpenWeatherMapService owms;

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            owms = new OpenWeatherMapService();
        }

        private async void btnGetWeather_Click(object sender, RoutedEventArgs e)
        {
            string location = txtLocation.Text.Trim();  

            var wr = await owms.GetWeather(location);
            if (wr != null)
            {
                var weatherMessage = "The current temperature in {0} is {1}°F, with a high today of {2}°F and a low of {3}°F.";
                lblMessage.Text = string.Format(weatherMessage, wr.Name, (int)wr.MainWeather.Temp, (int)wr.MainWeather.MaximumTemp, (int)wr.MainWeather.MinimumTemp);
            }
        }
    }
}