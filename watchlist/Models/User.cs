namespace Watchlist.Models
{
	public class User
	{
		public string Name { get; set; }
		public string Email { get; set; }
	}

	public class Movie
	{
		public string Title { get; set; }
		public string Watched { get; set; }
		public string Image { get; set; }
		public string Grade { get; set; }
	}
}
