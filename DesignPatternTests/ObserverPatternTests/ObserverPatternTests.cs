using DesignPatterns;
using NUnit.Framework;
using System;

namespace DesignPatternTests
{
	[TestFixture ()]
	public class ObserverPatternTests
	{
		public ObserverPatternTests ()
		{
			
		}

		[Test()]
		public void ObserverPatternTest()
		{
			MessageProvider messageProvider = new MessageProvider ();
			MessageObserver messageObserver = new MessageObserver ();

			messageObserver.Subscribe (messageProvider);

			messageProvider.PublishMessage ("Hello");

			
		}


	}
}

