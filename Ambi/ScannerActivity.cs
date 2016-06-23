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
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Main);

			scannerPresenter = new ScannerPresenter();

			scanForProduct();
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


