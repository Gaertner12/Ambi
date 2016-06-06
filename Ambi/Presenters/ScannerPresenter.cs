using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using ZXing.Mobile;
using ZXing;

namespace Ambi
{
	public class ScannerPresenter
	{
		private Activity activity{ get; set;}

		public ScannerPresenter (Activity myActivity)
		{
			this.activity = myActivity;
			scanForId ();
		}

		//Open Scanner and wait for it to deliver Barcode ID
		public async void scanForId(){
			var scanner = new MobileBarcodeScanner();
			var result = await scanner.Scan();

			createProductPage(result.Text);
		}

		public void createProductPage(string id){
			Intent intent = new Intent (activity, typeof(ProductPageActivity));
			intent.PutExtra ("ProductId", id);
			activity.StartActivity (typeof(ProductPageActivity));
		}
	}
}

