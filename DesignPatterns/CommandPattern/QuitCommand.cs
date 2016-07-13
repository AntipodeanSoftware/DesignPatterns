using System;
namespace DesignPatterns
{
	public class QuitCommand : ICommand
	{
		private const int exitCodeSuccess = 0;

		public QuitCommand()
		{
		}

		public void Run()
		{
			Console.WriteLine("Goodbye");

			Environment.Exit(exitCodeSuccess);
		}
	}
}

