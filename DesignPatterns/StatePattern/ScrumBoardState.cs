
using System;

namespace DesignPatterns.StatePattern
{
	public abstract class ScrumBoardState
	{
		public Task _task;

		protected MessageProvider _messageProvider;

		public ScrumBoardState(Task task, MessageProvider messageProvider)
		{
			_task = task;
			_messageProvider = messageProvider;
		}

		public abstract void SetToDo();
		public abstract void SetInProgress();
		public abstract void SetDone();
	}
}


