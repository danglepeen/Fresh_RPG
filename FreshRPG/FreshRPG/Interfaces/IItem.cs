using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enums;

namespace Interfaces
{
	public interface IItem
	{
		string Name { get; set; }
		string Description { get; set; }
		ItemAvailabilities ItemAavailability { get; set; }
		ItemEffects ItemEffect { get; set; }
	}
}