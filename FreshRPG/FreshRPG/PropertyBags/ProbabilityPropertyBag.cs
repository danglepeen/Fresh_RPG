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
	class ProbabilityPropertyBag : BasePropertyBag
	{
		public int Success { get; set; }

		public ProbabilityPropertyBag()
		{

		}
	}
}
