
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Ambi
{
	[Activity (Label = "ProductPageActivity")]			
	public class ProductPageActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.ProductPage);

			TextView productIdText = FindViewById<TextView> (Resource.Id.productIdText);
			TextView productNameText = FindViewById<TextView> (Resource.Id.productNameText);

			var id = Intent.GetStringExtra ("ProductId");
			Toast.MakeText (this, id, ToastLength.Long).Show ();

			var product = new Product (id);

			if (product.fetch ()) {
				productIdText.Text = product.id;
				productNameText.Text = product.name;
			} else {
				Intent intent = new Intent (this, typeof(NewProductActivity));
				intent.PutExtra ("ProductId", product.id);
				this.StartActivity (intent);
			}
		}
	}
}

