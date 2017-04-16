using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enums;

namespace Interfaces
{
	public interface IPropertyBag
	{
		// Properties
		string Name { get; set; }
		int Health { get; set; }
		int Level { get; set; }
		Alignments Alignment { get; set; }

		// Methods 
		string Serialize();
		object Deserialize(string value);
	}
}
