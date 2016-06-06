using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Ambi
{
	[Activity (Label = "Ambi", MainLauncher = true, Icon = "@mipmap/icon")]
	public class ScannerActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			var scannerPresenter = new ScannerPresenter (this);
		}
	}
}


