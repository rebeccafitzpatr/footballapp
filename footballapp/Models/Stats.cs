namespace footballapp.Models
{
	public class Stats
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public List<PlayerStats>? PlayerStats { get; set; }
	}
}
