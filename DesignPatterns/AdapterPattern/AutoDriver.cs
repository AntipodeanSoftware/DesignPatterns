using System;

namespace DesignPatterns.AdapterPattern
{
	public class AutoDriver
	{
		public AutoDriver ()
		{
			
		}

		public void Drive(ICar car)
		{
			car.Accelerate ();
			car.ChangeGear ();
			car.Brake ();
		}
	}
}

