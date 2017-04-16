using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enums;
using Interfaces;
using PropertyBags;
namespace Models
{
	class Minion : Character
	{
		public string Name { get; set; }
		public int Health { get; set; }
		public int Level { get; set; }
		public Alignments Alignment { get; set; }
		public Difficulties Difficulty { get; set; }

		public Minion()
		{
			this.Name = "Minion";
			this.Health = 25;
			this.Level = 1;
			this.Alignment = Alignments.Bad;
			this.Difficulty = Difficulties.VeryEasy;
		}
		public Minion(int level)
		{
			this.Name = "Pro Minion";
			this.Health = 50;
			this.Level = level;
			this.Alignment = Alignments.Bad;
			this.Difficulty = Difficulties.Easy;
		}
	}
}
