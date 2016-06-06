using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Ambi
{
	public class ProductPagePresenter
	{
		private Activity activity{ get; set;}

		public ProductPagePresenter (Activity myActivity)
		{
			this.activity = myActivity;

			TextView productIdText = activity.FindViewById<TextView> (Resource.Id.productIdText);

			productIdText.Text = "whoop";	
		}
	}
}

