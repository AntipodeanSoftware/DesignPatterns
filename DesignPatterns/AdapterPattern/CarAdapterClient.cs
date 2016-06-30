using System;

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

			ICar holden = new Holden ();

			driver.Drive (holden);

			IElectricCar tesla = new Tesla ();
			ElecticCarAdpater electicCarAdapter = new ElecticCarAdpater (tesla);

			driver.Drive (electicCarAdapter);
		}
	}
}

