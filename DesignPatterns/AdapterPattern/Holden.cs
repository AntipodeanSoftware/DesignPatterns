using System;

namespace DesignPatterns.AdapterPattern
{
	public class Holden : ICar
	{
		MessageProvider _messageProvider;
		
		public Holden (MessageProvider messageProvider)
		{
			_messageProvider = messageProvider;
		}
			
		public void Accelerate ()
		{
			_messageProvider.PublishMessage("Holden is Acclerating");
		}

		public void Brake ()
		{
			_messageProvider.PublishMessage("Holden is Braking");
		}

		public void ChangeGear ()
		{
			_messageProvider.PublishMessage("Holden is Changing gear");
		}
	}
}

