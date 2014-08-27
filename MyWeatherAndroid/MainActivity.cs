using System;
using System.Net.Http;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Newtonsoft.Json;

using MyWeather;

namespace MyWeatherAndroid
{
    [Activity(Label = "MyWeatherAndroid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        OpenWeatherMapService owms;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            owms = new OpenWeatherMapService();

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get controls from the layour resource
            EditText txtLocation = FindViewById<EditText>(Resource.Id.txtLocation);
            TextView lblMessage = FindViewById<TextView>(Resource.Id.lblMessage);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);
            button.Click += async delegate {

                string location = txtLocation.Text.Trim();

                var wr = await owms.GetWeather(location);
                if (wr != null)
                {
                    var weatherMessage = "The current temperature in {0} is {1}°F, with a high today of {2}°F and a low of {3}°F.";
                    lblMessage.Text = string.Format(weatherMessage, wr.Name, (int)wr.MainWeather.Temp, (int)wr.MainWeather.MaximumTemp, (int)wr.MainWeather.MinimumTemp);
                }
            };
        }
    }
}

