using System;

namespace CSTextGame.Commands
{
	public class CommandTest : Command
	{
		public override string[] Aliases()
		{
			return "test";
		}

		public override string Action(Game game)
		{
			return "hello, world!";
		}
	}
}
