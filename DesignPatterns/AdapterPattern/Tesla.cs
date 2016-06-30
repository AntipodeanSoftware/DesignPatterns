using System;

namespace DesignPatterns.AdapterPattern
{
	public class Tesla : IElectricCar
	{
		public Tesla ()
		{
		}

		public void Accelerate ()
		{
			Console.WriteLine ("Tesla is Accellllleraatting!!!!!");
		}

		public void Break ()
		{
			Console.WriteLine ("Tesla is Breaking");
		}
			

	}
}

