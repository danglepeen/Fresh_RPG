using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Enums;
using Interfaces;

namespace PropertyBags
{
	public abstract class BasePropertyBag : IPropertyBag
	{
		public string Name { get; set; }
		public int Health { get; set; }
		public int Level { get; set; }
		public Alignments Alignment { get; set; }

		public string Serialize()
		{
			throw new NotImplementedException();
		}

		public object Deserialize(string value)
		{
			throw new NotImplementedException();
		}
	}
}