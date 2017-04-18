using System;
using System.Collections.Generic;
using Interfaces;

namespace Models
{
	public class Event : IEvent
	{
		public IEnumerable<ICharacter> Characters { get; set; }
		public IEnumerable<string> Message { get; set; }
	}
}