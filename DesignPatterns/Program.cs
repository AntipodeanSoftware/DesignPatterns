using System;
using System.Collections.Generic;
using DesignPatterns.StatePattern;
using DesignPatterns.AdapterPattern;


namespace DesignPatterns
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the world of design patterns...");

			bool isRunning = true;

			Dictionary<string, ICommand> commands = new Dictionary<string, ICommand>();

			commands.Add("A", new AdapterCommand());
			commands.Add("O", new ObserverCommand());
			commands.Add("S", new StateCommand());
			commands.Add("H", new HelpCommand());
			commands.Add("Q", new QuitCommand());

			var helpCommand = commands["H"];

			helpCommand.Run();

			while (isRunning) 
			{
				var inputKey = Console.ReadKey().KeyChar.ToString();

				if (commands.ContainsKey(inputKey))
				{
					var commandToRun = commands[inputKey];
					commandToRun.Run();
				}
			}
		}
	}
}
