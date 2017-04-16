using System;
using Enums;
using Interfaces;

namespace PropertyBags
{
	class ProbabilityPropertyBag : BasePropertyBag
	{
		public int Success { get; set; }

		public ProbabilityPropertyBag()
		{

		}
	}
}
