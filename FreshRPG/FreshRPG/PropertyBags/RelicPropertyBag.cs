using System;
using Enums;
using Interfaces;

namespace PropertyBags
{
	class RelicPropertyBag : BasePropertyBag
	{
		public BagType BagType { get; set; }
		public string Name { get; set; }

		public RelicPropertyBag()
		{

		}
	}
}
