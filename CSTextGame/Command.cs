using System;
using System.Collections.Generic;
using CSTextGame.Commands;

namespace CSTextGame
{
	public abstract class Command
	{
		public static List<Command> Commands = new List<Command>();

		static Command()
		{
			InitializeCommands();
		}

		static void InitializeCommands()
		{
			Commands.Add(new CommandTest());
			Commands.Add(new CommandMove());
		}

		public static string ProcessCommand(string[] input, Game game)
		{
			foreach(Command command in Commands)
			{
				foreach(string alias in command.Aliases())
				{
					if(alias.Equals(input[0], StringComparison.CurrentCultureIgnoreCase))
					{
						return command.Action(input, game);
					}
				}
			}
			return "Unknown command \"" + input[0] + "\"";
		}

		public abstract string[] Aliases();

		public abstract string Action(string[] input, Game game);
	}
}
