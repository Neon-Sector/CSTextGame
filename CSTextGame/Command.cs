using System;
using System.Collections;
using System.Collections.Generic;

namespace CSTextGame
{
	public abstract class Command
	{
		private static List<Command> commands = new List<Command>();

		static Command()
		{
		}

		private static void InitializeCommands()
		{
			commands.Add(new Command()
				{
				
				});
		}

		public static string ProcessCommand(string input, Game game)
		{
			foreach(Command command in commands)
			{
				foreach(string alias in command.Aliases())
				{
					if(alias.Equals(input, StringComparison.CurrentCultureIgnoreCase))
				}
			}
		}

		public Command()
		{
		}

		public abstract string[] Aliases();

		public abstract string Action(Game game);
	}
}
