using System;
namespace DesignPatterns
{
	public class HelpCommand : ICommand
	{
		public HelpCommand()
		{
		}

		public void Run()
		{
			Console.WriteLine("Type A for Adapter Patten, O for observer pattern, S for state pattern, H for help or Q to quit");
		}
	}
}

