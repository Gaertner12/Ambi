
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
	[Activity (Label = "NewProductActivity")]			
	public class NewProductActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.NewProduct);
			var id = Intent.GetStringExtra ("ProductId");

			TextView idInput = FindViewById<TextView> (Resource.Id.productIdInput);
			TextView nameInput = FindViewById<TextView> (Resource.Id.productNameInput);
			Button submit = FindViewById<Button> (Resource.Id.productSubmit);

			idInput.Text = id;

			submit.Click += delegate {
				if(nameInput.Text != ""){
					Product product = new Product(id);
					product.name = nameInput.Text;
					product.toDatabase();

					Intent intent = new Intent (this, typeof(ProductPageActivity));
					intent.PutExtra ("ProductId", id.ToString());
					this.StartActivity (intent);
				} else {
					Toast.MakeText (this, "Bitte alle Felder ausfüllen", ToastLength.Long).Show ();
				}
			};
		}
	}
}

