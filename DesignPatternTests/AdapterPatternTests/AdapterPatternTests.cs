using DesignPatterns.AdapterPattern;
using NUnit.Framework;
using System;

namespace DesignPatternTests
{
	[TestFixture ()]
	public class AdapterPatternTests
	{
		public AdapterPatternTests ()
		{
			
		}

		[Test()]
		public void ElectricCarAdapterAccelerateTeslaTest()
		{
			IElectricCar tesla = null;;// = new Tesla ();

			ElecticCarAdpater electricCarAdapter = new ElecticCarAdpater (tesla);

			Assert.IsNotNull (electricCarAdapter);

			electricCarAdapter.Accelerate ();
		}

		[Test()]
		public void ElectricCarAdapterChangeGearTeslaTest()
		{
			IElectricCar tesla = null;;// = new Tesla ();

			ElecticCarAdpater electricCarAdapter = new ElecticCarAdpater (tesla);

			Assert.IsNotNull (electricCarAdapter);

			electricCarAdapter.ChangeGear ();
		}

		[Test()]
		public void ElectricCarAdapterBreakTeslaTest()
		{
			IElectricCar tesla = null;;// = new Tesla ();

			ElecticCarAdpater electricCarAdapter = new ElecticCarAdpater (tesla);

			Assert.IsNotNull (electricCarAdapter);

			electricCarAdapter.Brake ();
		}

		[Test()]
		public void AutoDriverBreakHoldenTest()
		{
			ICar holden = null;;// = new Holden ();

			AutoDriver driver = new AutoDriver ();

			driver.Drive (holden);
		}

		//Need to figure out how to use IObservable, IObserver to have
		//Instead of console.writeline("BLah"), have a message variable
	}
}

