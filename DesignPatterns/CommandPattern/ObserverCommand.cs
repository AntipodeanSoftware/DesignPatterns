using System;
namespace DesignPatterns
{
	public class ObserverCommand : ICommand
	{
		public ObserverCommand()
		{
		}

		public void Run()
		{
			MessageProvider messageProvider = new MessageProvider();
			MessageObserver messageObserver = new MessageObserver();

			messageObserver.Subscribe(messageProvider);

			messageProvider.PublishMessage("Hello");
		}
	}
}

