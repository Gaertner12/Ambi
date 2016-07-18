using System;

namespace Ambi
{
	public class Comment
	{
		public int id{ get; set;}
		public int productId{ get; set;}
		public string user{ get; set;}
		public string text{ get; set;}
		public bool upvote{ get; set;}

		public Comment ()
		{
		}
	}
}

