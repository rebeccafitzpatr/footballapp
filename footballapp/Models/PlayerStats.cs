namespace footballapp.Models
{
	public class PlayerStats
	{
		public int PlayerId { get; set; }
		public Player Player {  get; set; }

		public int StatsId { get; set; }

		public Stats Stats { get; set; }
 	}
}
