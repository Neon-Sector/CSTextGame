using System;
using System.Threading;
using System.Collections.Generic;
using CSTextGame.Objects;

namespace CSTextGame
{
	public class Game
	{
		Thread _thread;
		bool _running;

		private List<Item> _inventory = new List<Item>();
		private Location _currentLocation;

		public Game()
		{
		}

		public void Run()
		{
			while(_running)
			{
				Console.Out.Write("> ");
				string input = Console.In.ReadLine();
				string buffer = Command.ProcessCommand(input.Split(' '), this);
				Console.Out.WriteLine(buffer);
			}
		}

		public void Start()
		{
			if(_running)
				return;
			_running = true;
			_thread = new Thread(Run);
			_thread.Start();
		}

		public void Stop()
		{
			if(!_running)
				return;
			_running = false;
			_thread.Abort();
			_thread.Join();
		}
	}
}
