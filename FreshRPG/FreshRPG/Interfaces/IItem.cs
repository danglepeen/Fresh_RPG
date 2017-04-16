using Enums;

namespace Interfaces
{
	public interface IItem
	{
		string Name { get; set; }
		string Description { get; set; }
		ItemAvailability ItemAvailability { get; set; }
		ItemEffect ItemEffect { get; set; }
		decimal ResaleValue { get; set; }
	}
}