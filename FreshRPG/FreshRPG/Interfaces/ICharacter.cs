using Enums;

namespace Interfaces
{
	public interface ICharacter
	{
		string Name { get; set; }
		decimal Health { get; set; }
		int Level { get; set; }
		Alignment Alignment { get; set; }
		decimal TotalXP { get; set; }
	}
}
