using System;
using DesignPatterns.AdapterPattern;

namespace DesignPatterns
{
	public class AdapterCommand : ICommand
	{
		public AdapterCommand()
		{
		}

		public void Run()
		{
			CarAdapterClient client = new CarAdapterClient();
			client.TestDrive();
		}
	}
}

