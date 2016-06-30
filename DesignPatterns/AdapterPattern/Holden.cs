using System;

namespace DesignPatterns.AdapterPattern
{
	public class Holden : ICar
	{
		public Holden ()
		{
		}
			
		public void Accelerate ()
		{
			Console.WriteLine ("Holden is Acclerating");
		}

		public void Brake ()
		{
			Console.WriteLine ("Holden is Braking");
		}

		public void ChangeGear ()
		{
			Console.WriteLine ("Holden is Changing gear");
		}
	}
}

