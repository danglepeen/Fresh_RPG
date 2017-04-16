using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enums;
using Interfaces;
using PropertyBags;
namespace PropertyBags
{
	class RelicPropertyBag : BasePropertyBag
	{
		public PropertyTypes PropertyType { get; set; }
		public string Name { get; set; }

		public RelicPropertyBag()
		{

		}
	}
}
