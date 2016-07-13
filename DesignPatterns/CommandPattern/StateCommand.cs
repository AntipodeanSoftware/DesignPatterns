using System;
using DesignPatterns.StatePattern;

namespace DesignPatterns
{
	public class StateCommand : ICommand
	{
		public StateCommand()
		{
			
		}

		public void Run()
		{
			ScrumBoardClient.RunScrumBoardClient();
		}
	}
}

