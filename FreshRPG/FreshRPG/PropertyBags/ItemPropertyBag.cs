using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enums;
using Interfaces;

namespace PropertyBags
{
	class ItemPropertyBag : BasePropertyBag
	{
		public PropertyTypes PropertyType { get; set; }
		public IEnumerable<IItem> Items { get; set; }

		public ItemPropertyBag()
		{

		}
	}
}
