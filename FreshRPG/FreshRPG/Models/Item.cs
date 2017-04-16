using Enums;
using Interfaces;
using PropertyBags;

namespace Models
{
	public class Item : IItem
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public ItemAvailability ItemAvailability { get; set; }
		public ItemEffect ItemEffect { get; set; }
		public decimal ResaleValue { get; set; }
	}
}
