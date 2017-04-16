using System;
using System.Collections.Generic;
using Enums;
using Interfaces;

namespace PropertyBags
{
	class ItemPropertyBag : BasePropertyBag
	{
		public BagType BagType { get; set; }
		public IEnumerable<IItem> Items { get; set; }

		public ItemPropertyBag()
		{

		}
	}
}
