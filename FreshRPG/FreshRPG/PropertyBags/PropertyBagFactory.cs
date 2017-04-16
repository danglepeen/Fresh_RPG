using System;
using Enums;
using Interfaces;

namespace PropertyBags
{
	class PropertyBagFactory
	{
		// Constructor
		public static IPropertyBag CreateBag(BagType BagType)
		{
			switch(BagType)
			{
				case BagType.Character:
					return new CharacterPropertyBag();
				case BagType.Item:
					return new ItemPropertyBag();
				case BagType.Relic:
					return new RelicPropertyBag();
				default:
					return new ProbabilityPropertyBag();
			}
		}
	}
}
