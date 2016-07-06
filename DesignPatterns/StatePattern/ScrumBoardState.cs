using System;

namespace DesignPatterns.StatePattern
{
	public abstract class ScrumBoardState
	{
		public Task task;

		//public MessageProvider messageProvider;

	    //string message;

		//public string Message { get { return message; } set { message = value; messageProvider.PublishMessage(message); } }

		public ScrumBoardState(Task task)
		{
			this.task = task;
			//this.messageProvider = new MessageProvider();
		}

		public abstract void SetToDo();
		public abstract void SetInProgress();
		public abstract void SetDone();


	}
}


