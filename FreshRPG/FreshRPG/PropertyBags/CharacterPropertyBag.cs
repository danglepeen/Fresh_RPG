using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enums;
using Interfaces;

namespace PropertyBags
{
	public class CharacterPropertyBag : BasePropertyBag
	{
		public string Name { get; set; }
		public int Health { get; set; }
		public int Level { get; set; }
		public Alignments Alignment { get; set; }
		public Difficulties Difficulty { get; set; }

		public CharacterPropertyBag()
		{

		}
	}
}
