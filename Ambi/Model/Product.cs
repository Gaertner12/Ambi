using System;

namespace Ambi
{
	public class Product
	{
		public string id{get; set;}
		public string name{ get; set;}


		public Product (string id)
		{
			this.id = id;
		}

		public bool fetch(){
			if (false) {
				this.name = "Nutella";

				return true;
			} 

			return false;
		}

		public void toDatabase(){
		}
	}
}

