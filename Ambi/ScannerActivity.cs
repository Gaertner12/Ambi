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
		protected ScannerPresenter scannerPresenter;
		protected override void OnCreate (Bundle savedInstanceState)
		{
			//Toast.MakeText (this, scannerPresenter.id, ToastLength.Long).Show ();
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			scannerPresenter = new ScannerPresenter ();

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				scanForProduct();
			};
		}

		protected async void scanForProduct(){
			await scannerPresenter.startScan();
			openProductView (scannerPresenter.id);
		}

		protected void openProductView(string id){
			Intent intent = new Intent (this, typeof(ProductPageActivity));
			intent.PutExtra ("ProductId", id);
			this.StartActivity (typeof(ProductPageActivity));
		}
	}
}


