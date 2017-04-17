using System;
using Enums;

namespace Models
{
	public class Armor : Item
	{
		public Designation DesignatedFor { get; set; }
		public decimal DefenseStat { get; set; }

		public Armor()
		{
			ItemEffect = ItemEffect.Helpful;
		}
	}
}