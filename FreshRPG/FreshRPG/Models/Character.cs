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
	public class Character : ICharacter
	{
		public string Name { get; set; }
		public int Health { get; set; }
		public int Level { get; set; }
		public Alignments Alignment { get; set; }

		public Character()
		{

		}

		// Playable Character
		public Character(IPropertyBag propertyBag)
		{
			this.Name = propertyBag.Name;
			this.Health = propertyBag.Health;
			this.Level = propertyBag.Level;
			this.Alignment = propertyBag.Alignment;
		}

		// Non-Playable Character
		public Character(Alignments align, Difficulties diff)
		{
			switch(align)
			{
				case Alignments.Bad:
					switch(diff)
					{
						case Difficulties.VeryEasy:
							new Minion();
							break;
						case Difficulties.Easy:
							new Minion(2);
							break;
						case Difficulties.Medium:
							new Villian();
							break;
						case Difficulties.Hard:
							new Boss();
							break;
						case Difficulties.VeryHard:
							new Boss(2);
							break;
						default:
							new Character();
							break;
					}
					break;
				case Alignments.Good:
					switch(diff)
					{
						case Difficulties.VeryEasy:
							new Minion();
							break;
						case Difficulties.Easy:
							new Minion(2);
							break;
						case Difficulties.Medium:
							new Villian();
							break;
						case Difficulties.Hard:
							new Boss();
							break;
						case Difficulties.VeryHard:
							new Boss(2);
							break;
						default:
							new Character();
							break;
					}
					break;
				default:
					break;
			}
		}
	}
}
