﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
	interface IEvent
	{
		IEnumerable<ICharacter> Characters { get; set; }
		IEnumerable<string> Message { get; set; }
	}
}
