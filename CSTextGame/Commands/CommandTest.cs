using System;

namespace CSTextGame.Commands
{
	public class CommandTest : Command
	{
		public override string[] Aliases()
		{
			return new string[] { "test" };
		}

		public override string Action(string[] input, Game game)
		{
			return "hello, world!";
		}
	}
}
