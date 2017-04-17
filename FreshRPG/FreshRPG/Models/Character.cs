using System;
using System.Collections.Generic;
using Enums;
using Interfaces;
using PropertyBags;

namespace Models
{
	public class Character : ICharacter
	{
		public string Name { get; set; }
		public decimal Health { get; set; }
		public int Level { get; set; }
		public Alignment Alignment { get; set; }
		public decimal TotalXP { get; set; }
		public decimal XPToNextLevel { get; set; }
		public bool EligibleForLevelUp { get; set; }
		public Weapon Weapon { get; set; }
		public Armor Armor { get; set; }
		public IEnumerable<IItem> Inventory { get; set; }

		public Character()
		{

		}

		/// <summary>
		/// Use this to create New Characters you can customize
		/// </summary>
		/// <param name="propertyBag"></param>
		public Character(CharacterPropertyBag propertyBag)
		{
			this.Name = propertyBag.Name;
			this.Health = propertyBag.Health;
			this.Level = propertyBag.Level;
			this.Alignment = propertyBag.Alignment;
			this.TotalXP = 0;
		}

		/// <summary>
		/// Use this to create a random friend/enemy
		/// </summary>
		/// <param name="Alignment">Good, Evil, or Nuetral</param>
		/// <param name="Difficulty">Very Easy, Easy, Medium, Hard, or Very Hard</param>
		public Character(Alignment Alignment, Difficulty Difficulty)
		{
			switch(Alignment)
			{
				case Alignment.Bad:
					switch(Difficulty)
					{
						case Difficulty.VeryEasy:
							new Minion();
							break;
						case Difficulty.Easy:
							new Minion(2);
							break;
						case Difficulty.Medium:
							new Villian();
							break;
						case Difficulty.Hard:
							new Boss();
							break;
						case Difficulty.VeryHard:
							new Boss(2);
							break;
						default:
							new Character();
							break;
					}
					break;
				case Alignment.Good:
					switch(Difficulty)
					{
						case Difficulty.VeryEasy:
							new Minion();
							break;
						case Difficulty.Easy:
							new Minion(2);
							break;
						case Difficulty.Medium:
							new Villian();
							break;
						case Difficulty.Hard:
							new Boss();
							break;
						case Difficulty.VeryHard:
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

		/// <summary>
		/// This method will return the amount XP points to character's next level.
		/// </summary>
		public decimal CalculateToNextLevel()
		{
			decimal result;
			if(Level > 1)
			{
				var x = TotalXP - (Level * 100);
				result = 100 - x;
			}
			else
			{
				result = 100 - TotalXP;
			}

			return result;
		}

		/// <summary>
		/// This method will return a bool and level up a character if true
		/// </summary>
		public bool LevelUp()
		{
			var result = false;
			var x = Math.Floor(TotalXP / 100);
			if(Level < x)
			{
				Level++;
				result = true;
			}
			return result;
		}
	}
}
