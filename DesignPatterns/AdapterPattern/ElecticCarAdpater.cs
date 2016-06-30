using System;

namespace DesignPatterns.AdapterPattern
{
	public class ElecticCarAdpater : ICar
	{
		private IElectricCar _electricCar;

		public ElecticCarAdpater(IElectricCar electicCar)
		{
			_electricCar = electicCar;
		}


		public void Accelerate ()
		{
			_electricCar.Accelerate ();
		}

		public void Brake ()
		{
			_electricCar.Break ();
		}

		public void ChangeGear ()
		{
			_electricCar.Accelerate ();
		}
	}
}

