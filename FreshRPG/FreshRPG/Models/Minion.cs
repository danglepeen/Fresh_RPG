using Enums;
using Interfaces;
using PropertyBags;

namespace Models
{
	public class Minion : Character
	{
		public Difficulty Difficulty { get; set; }

		public Minion()
		{
			this.Name = "Minion";
			this.Health = 25;
			this.Level = 1;
			this.Alignment = Alignment.Bad;
			this.Difficulty = Difficulty.VeryEasy;
		}
		public Minion(int level)
		{
			this.Name = "Pro Minion";
			this.Health = 50;
			this.Level = level;
			this.Alignment = Alignment.Bad;
			this.Difficulty = Difficulty.Easy;
		}
	}
}
