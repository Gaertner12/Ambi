﻿
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

			//TextView productIdText = FindViewById<TextView> (Resource.Id.productIdText);
			//var id = Intent.GetStringExtra ("ProductId");

			//productIdText.Text = 'whoop';	
		}

	}
}

