using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using MyWeather;

namespace MyWeatheriOS
{
    public partial class MyWeatheriOSViewController : UIViewController
    {
        OpenWeatherMapService owms;

        public MyWeatheriOSViewController(IntPtr handle)
            : base(handle)
        {
            
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        #region View lifecycle

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
            owms = new OpenWeatherMapService();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

        #endregion

        async partial void btnGetWeather_TouchUpInside(UIButton sender)
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