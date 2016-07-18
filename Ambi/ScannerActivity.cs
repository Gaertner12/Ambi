using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.IO;
using SQLite;


namespace Ambi
{
	[Activity (Label = "Ambi", MainLauncher = true, Icon = "@mipmap/icon")]
	public class ScannerActivity : Activity
	{
		protected ScannerPresenter scannerPresenter;
		protected override void OnCreate(Bundle savedInstanceState)
		{
<<<<<<< HEAD
			//Toast.MakeText (this, scannerPresenter.id, ToastLength.Long).Show ();
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.Main);

			scannerPresenter = new ScannerPresenter ();

			Button button = FindViewById<Button> (Resource.Id.myButton);			
			button.Click += delegate {
				scanForProduct();
			};
=======
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Main);

			scannerPresenter = new ScannerPresenter();

			scanForProduct();
>>>>>>> refs/remotes/origin/Design/Interface-Branch
		}

		protected async void scanForProduct(){
			await scannerPresenter.startScan();
			openProductView (scannerPresenter.id);
		}

		protected void openProductView(string id){
			Intent intent = new Intent (this, typeof(ProductPageActivity));
			intent.PutExtra ("ProductId", id.ToString());
			this.StartActivity (intent);
		}

		protected void onBackPressed()
		{
			new AlertDialog.Builder(this)
   			.SetMessage("hi")
   			.Show();
		}
	}
}


