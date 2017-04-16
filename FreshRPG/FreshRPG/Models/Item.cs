using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enums;
using Interfaces;
using PropertyBags;
namespace Models
{
	class Item : IItem
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public ItemAvailabilities ItemAavailability { get; set; }
		public ItemEffects ItemEffect { get; set; }
	}
}
