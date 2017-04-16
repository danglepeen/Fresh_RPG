using System;
using Enums;
using Interfaces;

namespace PropertyBags
{
	public class CharacterPropertyBag : BasePropertyBag
	{
		public string Name { get; set; }
		public int Health { get; set; }
		public int Level { get; set; }
		public Alignment Alignment { get; set; }
		public Difficulty Difficulty { get; set; }

		public CharacterPropertyBag()
		{

		}
	}
}
