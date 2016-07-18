using System;
using System.Collections.Generic;
using System.Data;
using SQLite;
using System.IO;
using Android.Media;

namespace Ambi
{
	[Table("products")]
	public class Product
	{
		[PrimaryKey]
		public string id{get; set;}
		public string name{ get; set;}
		public UserImageCollection userImageCollection{ get; set;}
		public CommentCollection commentCollection{ get; set;}

		[Ignore]
		private SQLiteConnection db{ get; set; }

		public Product(){
		}

		public Product (string id)
		{
			this.id = id;
		}

		public bool fetch(){
			string dbPath = Path.Combine (Environment.GetFolderPath (Environment.SpecialFolder.Personal), "ambi.db3");

			this.db = new SQLiteConnection (dbPath);
			this.db.CreateTable<Product> ();

			var result = db.Query<Product> ("Select * from products WHERE id = " + this.id);
			if (result.Count > 0) {
				this.name = result [0].name;

				return true;
			} 

			return false;
		}

		public void toDatabase(){
		}
	}
}

