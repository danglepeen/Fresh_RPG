using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enums;
using Interfaces;

namespace PropertyBags
{
	class PropertyBagFactory
	{
		// Constructor
		public static IPropertyBag CreateBag(PropertyTypes PropertyType)
		{
			switch(PropertyType)
			{
				case PropertyTypes.Character:
					return new CharacterPropertyBag();
				case PropertyTypes.Item:
					return new ItemPropertyBag();
				case PropertyTypes.Relic:
					return new RelicPropertyBag();
				default:
					return new ProbabilityPropertyBag();
			}
		}
	}
}
