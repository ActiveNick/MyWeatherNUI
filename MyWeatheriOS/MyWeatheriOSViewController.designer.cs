// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace MyWeatheriOS
{
	[Register ("MyWeatheriOSViewController")]
	partial class MyWeatheriOSViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnGetWeather { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblMessage { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtLocation { get; set; }

		[Action ("btnGetWeather_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnGetWeather_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnGetWeather != null) {
				btnGetWeather.Dispose ();
				btnGetWeather = null;
			}
			if (lblMessage != null) {
				lblMessage.Dispose ();
				lblMessage = null;
			}
			if (txtLocation != null) {
				txtLocation.Dispose ();
				txtLocation = null;
			}
		}
	}
}
