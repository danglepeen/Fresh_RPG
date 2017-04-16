using System;
using Enums;
using Interfaces;

namespace PropertyBags
{
	public abstract class BasePropertyBag : IPropertyBag
	{

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