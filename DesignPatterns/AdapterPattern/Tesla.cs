using System;

namespace DesignPatterns.AdapterPattern
{
	public class Tesla : IElectricCar
	{
		MessageProvider _messageProvider;

		public Tesla (MessageProvider messageProvider)
		{
			_messageProvider = messageProvider;
		}

		public void Accelerate ()
		{
			_messageProvider.PublishMessage("Tesla is Accellllleraatting!!!!!");
		}

		public void Break ()
		{
			_messageProvider.PublishMessage("Tesla is Breaking");
		}
			

	}
}

