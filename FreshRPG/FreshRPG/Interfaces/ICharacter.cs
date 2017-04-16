using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enums;

namespace Interfaces
{

		public interface ICharacter
		{
			string Name { get; set; }
			int Health { get; set; }
			int Level { get; set; }
			Alignments Alignment { get; set; }
		}
	
}
