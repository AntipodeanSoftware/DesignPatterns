using System;
using System.Threading;

namespace DesignPatterns
{
	public class BroadcastSingleton
	{
		private volatile static BroadcastSingleton instance;

		private static object syncLock = new object();

		private BroadcastSingleton()
		{
		}

		public static BroadcastSingleton CreateBroadcastSingleton()
		{
			if (instance == null)
			{
				lock (syncLock)
				{
					if (instance == null)
					{
						instance = new BroadcastSingleton();
					}
				}
			}

			return instance;

		}
	}
}

