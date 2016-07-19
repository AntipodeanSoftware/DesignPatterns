using System;
using DesignPatterns;
using NUnit.Framework;

namespace DesignPatternTests
{
	[TestFixture()]
	public class BroadcastSingletonTests
	{
		public BroadcastSingletonTests()
		{
		}

		[Test()]
		public void BroadcastSingletonTest()
		{
			BroadcastSingleton broadcast = BroadcastSingleton.CreateBroadcastSingleton();

			Assert.IsNotNull(broadcast);

		}
	}
}

