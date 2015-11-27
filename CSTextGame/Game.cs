using System;
using System.Threading;
using System.Collections.Generic;

namespace CSTextGame
{
	public class Game
	{
		Thread _thread;
		bool _running;

		//private List<Item> _inventory = new List<Item>();
		//private Location _currentLocation;

		public Game()
		{
		}

		public void Run()
		{
			while(_running)
			{
				string buffer = Command.ProcessCommand(Console.In.ReadLine(), this);
			}
		}

		public void Start()
		{
			_thread = new Thread(Run);
		}

		public void Stop()
		{
			
		}
	}
}
