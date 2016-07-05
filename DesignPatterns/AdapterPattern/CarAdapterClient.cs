using System;
using System.ComponentModel;

namespace DesignPatterns.AdapterPattern
{
	public class CarAdapterClient
	{
		AutoDriver driver;

		public CarAdapterClient ()
		{
			driver = new AutoDriver ();
		}
			
		public void TestDrive ()
		{
			Console.WriteLine ("Example of the Adapter Pattern.");
			Console.WriteLine ("Lets Test Drive some cars!");

			MessageProvider messageProvider = new MessageProvider ();
			MessageObserver messageObserver = new MessageObserver ();
			messageObserver.Subscribe (messageProvider);

			ICar holden = new Holden (messageProvider);

			driver.Drive (holden);

			IElectricCar tesla = new Tesla (messageProvider);
			ElecticCarAdpater electicCarAdapter = new ElecticCarAdpater (tesla);

			driver.Drive (electicCarAdapter);
		}
	}
}

