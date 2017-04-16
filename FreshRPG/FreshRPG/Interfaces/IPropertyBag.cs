using Enums;

namespace Interfaces
{
	public interface IPropertyBag
	{
		// Properties

		// Methods 
		string Serialize();
		object Deserialize(string value);
	}
}
