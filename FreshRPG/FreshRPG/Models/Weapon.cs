using System;
using Enums;

namespace Models
{
	public class Weapon : Item
	{
		public Designation DesignatedFor { get; set; }
		public decimal AttackStat { get; set; }
	}
}