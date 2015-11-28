using System;
using System.Collections.Generic;

namespace CSTextGame.Objects
{
	public class Location
	{
		string _title;
		string _description;
		List<Exit> _exits;
		List<Item> _items;
		bool _alreadyVisited;

		public string Title { get; set; }

		public string Description { get; set; }

		public Exit GetExit(ExitDirection directionIndex)
		{
			foreach(Exit exit in _exits)
			{
				if(exit.Direction == directionIndex)
				{
					return exit;
				}
			}
			throw new Exception("There is no exit in that direction");
		}

		public void AddExit(Exit newExit)
		{
			foreach(Exit exit in _exits)
			{
				if(exit.Direction == newExit.Direction)
				{
					throw new Exception("There is already an exit in that direction");
				}
			}
		}

		public Location(string title, string description)
		{
			
		}
	}
}
