using Enums;
using Interfaces;
using PropertyBags;

namespace Models
{
	public class Boss : Character
	{
		public Difficulty Difficulty { get; set; }

		public Boss()
		{

		}

		public Boss(int level)
		{
			this.Level = level;
		}
	}
}
